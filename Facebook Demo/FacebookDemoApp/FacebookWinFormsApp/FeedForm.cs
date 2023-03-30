using System;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsApp
{
    public partial class FeedForm : Form
    {
        private UserFacade m_User;

        public FeedForm(UserFacade i_User)
        {
            m_User = i_User;
            InitializeComponent();
            postBindingSource.DataSource = m_User.GetFeedPosts();
        }

        private void buttonPostComment_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxPosts.SelectedItems.Count == 1)
                {
                    string comment = textBoxComment.Text;
                    Post selected = m_User.GetSelectedPost(listBoxPosts);
                    Comment postedComment = (selected as PostedItem).Comment(textBoxComment.Text);
                    MessageBox.Show("Comment posted! ID : " + postedComment.Id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonLike_Click(object sender, EventArgs e)
        {
            try
            {
                if(listBoxPosts.SelectedItems.Count == 1)
                {
                    Post selected = m_User.GetSelectedPost(listBoxPosts);
                    (selected as PostedItem).Like();
                    MessageBox.Show("Post liked!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonCommentDetails_Click(object sender, EventArgs e)
        {
            int numOfLikes = 0;
            StringBuilder stringBuilder = new StringBuilder();

            if (postBindingSource.Count == 1)
            {
                PostedItem selected = m_User.GetSelectedPost(listBoxPosts).Comments[messageListBox.SelectedIndex] as PostedItem;

                stringBuilder.AppendLine("Created by " + selected.From.Name);
                stringBuilder.AppendLine("Created at " + selected.CreatedTime);

                foreach (User user in selected.LikedBy)
                {
                    numOfLikes++;
                }

                stringBuilder.AppendLine("Number of likes " + numOfLikes);

                MessageBox.Show(stringBuilder.ToString());
            }
        }

        private void buttonPostDetails_Click(object sender, EventArgs e)
        {
            int numOfComments = 0;
            int numOfLikes = 0;
            StringBuilder stringBuilder = new StringBuilder();

            if (listBoxPosts.SelectedItems.Count == 1)
            {
                PostedItem selected = m_User.GetSelectedPost(listBoxPosts) as PostedItem;

                stringBuilder.AppendLine("Created by " + selected.From.Name);
                stringBuilder.AppendLine("Created at " + selected.CreatedTime);

                foreach (Comment comment in selected.Comments)
                {
                    numOfComments++;
                }

                foreach (User user in selected.LikedBy)
                {
                    numOfLikes++;
                }

                stringBuilder.AppendLine("Number of likes " + numOfLikes);
                stringBuilder.AppendLine("Number of comments " + numOfComments);

                MessageBox.Show(stringBuilder.ToString());
            }
        }
    }
}
