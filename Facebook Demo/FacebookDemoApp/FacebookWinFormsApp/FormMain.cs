using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsApp
{
    public partial class FormMain : Form
    {
        private readonly PictureBoxAdapter m_PictureBoxAdapter1;
        private readonly PictureBoxAdapter m_PictureBoxAdapter2;
        private readonly PictureBoxAdapter m_PictureBoxAdapter3;
        private readonly PictureBoxAdapter m_PictureBoxAdapter4;

        private readonly ObservableNextButton m_ObservableNextButton;
        private readonly ObservablePrevButton m_ObservablePrevButton;

        private UserFacade m_User;

        private int m_PictureIndex;

        private List<NamedSorterCommand<Photo>> m_comperatorsList;

        public delegate void m_PictureIndexChanged();

        public event m_PictureIndexChanged m_IndexChanged;

        private List<ILoadableControl> m_LoadableComponents = new List<ILoadableControl>();

        private List<PictureBoxAdapter> m_PictureBoxAdapters = new List<PictureBoxAdapter>();

        private List<Photo> m_CurretntAlbum;

        public FormMain(UserFacade i_User)
        {
            InitializeComponent();
            m_User = i_User;
            m_PictureIndex = 0;

            m_comperatorsList = new NamedSorterCommandsAggragate().GetComperators();

            m_PictureBoxAdapter1 = new PictureBoxAdapter(pictureBoxPictures1, m_PictureIndex, 0);
            m_PictureBoxAdapter2 = new PictureBoxAdapter(pictureBoxPictures2, m_PictureIndex, 1);
            m_PictureBoxAdapter3 = new PictureBoxAdapter(pictureBoxPictures3, m_PictureIndex, 2);
            m_PictureBoxAdapter4 = new PictureBoxAdapter(pictureBoxPictures4, m_PictureIndex, 3);

            m_PictureBoxAdapters.Add(m_PictureBoxAdapter1);
            m_PictureBoxAdapters.Add(m_PictureBoxAdapter2);
            m_PictureBoxAdapters.Add(m_PictureBoxAdapter3);
            m_PictureBoxAdapters.Add(m_PictureBoxAdapter4);

            this.m_IndexChanged += () => m_PictureBoxAdapter1.m_PictureIndexRefrence = m_PictureIndex;
            this.m_IndexChanged += () => m_PictureBoxAdapter2.m_PictureIndexRefrence = m_PictureIndex;
            this.m_IndexChanged += () => m_PictureBoxAdapter3.m_PictureIndexRefrence = m_PictureIndex;
            this.m_IndexChanged += () => m_PictureBoxAdapter4.m_PictureIndexRefrence = m_PictureIndex;

            m_PictureBoxAdapter1.PictureBoxClicked += () => PostComments(m_PictureBoxAdapter1.GetCurrentPhotoComents());
            m_PictureBoxAdapter2.PictureBoxClicked += () => PostComments(m_PictureBoxAdapter2.GetCurrentPhotoComents());
            m_PictureBoxAdapter3.PictureBoxClicked += () => PostComments(m_PictureBoxAdapter3.GetCurrentPhotoComents());
            m_PictureBoxAdapter4.PictureBoxClicked += () => PostComments(m_PictureBoxAdapter4.GetCurrentPhotoComents());

            m_ObservableNextButton = new ObservableNextButton(buttonNextPictures);
            m_ObservablePrevButton = new ObservablePrevButton(buttonPreviousPictures);

            this.m_IndexChanged += () => m_ObservableNextButton.UpdateDataMembers(m_PictureIndex, m_CurretntAlbum.Count);
            this.m_IndexChanged += () => m_ObservablePrevButton.UpdateDataMembers(m_PictureIndex);

            this.m_IndexChanged += () => m_ObservableNextButton.Update();
            this.m_IndexChanged += () => m_ObservablePrevButton.Update();

            m_LoadableComponents.Add(m_PictureBoxAdapter1);
            m_LoadableComponents.Add(m_PictureBoxAdapter2);
            m_LoadableComponents.Add(m_PictureBoxAdapter3);
            m_LoadableComponents.Add(m_PictureBoxAdapter4);
        }

        public void PostComments(FacebookObjectCollection<Comment> i_Comments)
        {
            listBoxPhotoComments.DisplayMember = "Message";
            listBoxPhotoComments.DataSource = i_Comments;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            buttonPreviousPictures.Enabled = false;

            listBoxFormOptions.Items.Add("Recent Friends Posts");
            listBoxFormOptions.Items.Add("Friends Game");
            listBoxFormOptions.Items.Add("Reverse Friends Game");

            postBindingSource.DataSource = m_User.GetPosts();

            fetchAlbums();
            fetchSortes();

            new Thread(loadComponnents).Start();
            new Thread(fetchUserInfo).Start();
        }

        private void loadComponnents()
        {
            foreach (ILoadableControl item in m_LoadableComponents)
            {
                item.Load();
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            this.Hide();
            AppSettings.Instance.AutoLogin = false;
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close();
        }

        private void fetchUserInfo()
        {
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
            pictureBoxProfile.LoadAsync(m_User.GetProfilePictureURL());
            new Thread(fetchBirthdays).Start();
            new Thread(fetchFriends).Start();
            new Thread(fetchPages).Start();
            new Thread(fetchEvents).Start();
            new Thread(fetchGroups).Start();
        }

        private void fetchGroups()
        {
            checkedListBoxGroups.Invoke(new Action(() => checkedListBoxGroups.Items.Clear()));
            checkedListBoxGroups.Invoke(new Action(() => checkedListBoxGroups.DisplayMember = "Name"));
            object groups = m_User.GetGroups();
            checkedListBoxGroups.Invoke(new Action(() => checkedListBoxGroups.DataSource = m_User.GetGroups()));
        }

        private void fetchEvents()
        {
            listBoxDateEvents.Invoke(new Action(() => listBoxDateEvents.Items.Clear()));
            foreach (Event dateEvent in m_User.GetEvents())
            {
                if (dateEvent.StartTime.Value.Date.Equals(dateTimePickerEvents.Value.Date))
                {
                    listBoxDateEvents.Invoke(new Action(() => listBoxDateEvents.Items.Add(dateEvent.Name)));
                }
            }
        }

        private void fetchPages()
        {
            listBoxPages.Invoke(new Action(() => listBoxPages.Items.Clear()));
            listBoxPages.Invoke(new Action(() => listBoxPages.DisplayMember = "Name"));
            object letLikedPages = m_User.GetLikedPages();
            listBoxPages.Invoke(new Action(() => listBoxPages.DataSource = m_User.GetLikedPages()));
        }

        private void fetchFriends()
        {
            listBoxFriends.Invoke(new Action(() => listBoxFriends.Items.Clear()));
            listBoxFriends.Invoke(new Action(() => listBoxFriends.DisplayMember = "Name"));
            object friends = m_User.GetFriends();
            listBoxFriends.Invoke(new Action(() => listBoxFriends.DataSource = friends));
        }

        private void fetchBirthdays()
        {
            m_User.GetFriends();
            listBoxBirthdays.Invoke(new Action(() => listBoxBirthdays.Items.Clear()));
            listBoxBirthdays.Invoke(new Action(() => listBoxBirthdays.DisplayMember = "Name"));
            object friendsBirthdays = m_User.GetFriendsBirthdays();
            listBoxBirthdays.Invoke(new Action(() => listBoxBirthdays.DataSource = friendsBirthdays));
        }

        private void fetchAlbums()
        {
            listBoxAlbums.Invoke(new Action(() => listBoxAlbums.Items.Clear()));
            listBoxAlbums.Invoke(new Action(() => listBoxAlbums.DisplayMember = "Name"));
            object albums = m_User.GetAlbums();
            listBoxAlbums.Invoke(new Action(() => listBoxAlbums.DataSource = albums));
            m_CurretntAlbum = m_User.GetPhotoList(listBoxAlbums);
        }

        private void fetchSortes()
        {
            sortByListBox.Invoke(new Action(() => sortByListBox.Items.Clear()));
            sortByListBox.Invoke(new Action(() => sortByListBox.DisplayMember = "CompereBy"));
            sortByListBox.Invoke(new Action(() => sortByListBox.DataSource = m_comperatorsList));
        }

        private void fetchMaxFourPhotosInOtherThread()
        {
            m_CurretntAlbum = m_User.GetPhotoList(listBoxAlbums);

            foreach (PictureBoxAdapter pictureBoxAdapter in m_PictureBoxAdapters)
            {
                pictureBoxAdapter.m_Photos = m_CurretntAlbum;
            }

            if(m_CurretntAlbum != null)
            {
                foreach (PictureBoxAdapter pictureBoxAdapter in m_PictureBoxAdapters)
                {
                    pictureBoxAdapter.Load();
                }
            }
        }

        private void buttonSetStatus_Click(object sender, EventArgs e)
        {
            try
            {
                Status postedStatus = m_User.PostStatus(textBoxStatus.Text);
                MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            fetchMaxFourPhotosInOtherThread();
            PictureIndex = 0;
        }

        private void buttonNextPictures_Click(object sender, EventArgs e)
        {
            PictureIndex++;
            fetchMaxFourPhotosInOtherThread();
        }

        private void buttonPreviousPictures_Click(object sender, EventArgs e)
        {
            PictureIndex--;
            fetchMaxFourPhotosInOtherThread();
        }

        private void dateTimePickerEvents_ValueChanged(object sender, EventArgs e)
        {
            fetchEvents();
        }

        private void buttonGroupsPost_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Group group in m_User.GetGroups())
                {
                    foreach (int chosenGroupIndex in checkedListBoxGroups.CheckedIndices)
                    {
                        if (group.Name.Equals(checkedListBoxGroups.GetItemText(checkedListBoxGroups.CheckedItems[chosenGroupIndex])))
                        {
                            Post postedStatus = group.PostToWall(textBoxGroupsPost.Text);
                            MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonLaunchForm_Click(object sender, EventArgs e)
        {
            if (listBoxFormOptions.SelectedItems.Count == 1)
            {
                Form form = FormFactory.CreateForm(listBoxFormOptions.SelectedIndex, m_User);

                if (form != null)
                {
                    this.Hide();
                    form.ShowDialog();
                    this.Show();
                }
            }
        }

        private int PictureIndex
        {
            get
            {
                return m_PictureIndex;
            }

            set
            {
                m_PictureIndex = value;
                m_IndexChanged?.Invoke();
            }
        }

        private class FormBuilder
        {
            private Form form;

            public FormBuilder()
            {
                form = new Form();
            }

            public FormBuilder WithTitle(string title)
            {
                form.Text = title;
                return this;
            }

            public FormBuilder WithSize(int width, int height)
            {
                form.Width = width;
                form.Height = height;
                return this;
            }

            public FormBuilder WithStartPosition(FormStartPosition startPosition)
            {
                form.StartPosition = startPosition;
                return this;
            }

            public Form Build()
            {
                return form;
            }
        }

        private void sortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sortByListBox.SelectedIndex != 0)
            {
                (sortByListBox.Items[sortByListBox.SelectedIndex] as ICommand<Photo>).Execute(m_CurretntAlbum);
            }

            fetchMaxFourPhotosInOtherThread();
            sortByListBox.SelectedIndex = 0;
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            messageListBox.DataSource = m_User.GetPosts()[listBoxPosts.SelectedIndex].Comments;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
