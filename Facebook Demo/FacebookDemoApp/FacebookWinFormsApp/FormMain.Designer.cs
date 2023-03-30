namespace FacebookWinFormsApp
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label messageLabel;
            this.buttonLogin = new System.Windows.Forms.Button();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelPosts = new System.Windows.Forms.Label();
            this.labelPostStatus = new System.Windows.Forms.Label();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.buttonSetStatus = new System.Windows.Forms.Button();
            this.pictureBoxPictures1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPictures3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPictures4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPictures2 = new System.Windows.Forms.PictureBox();
            this.buttonPreviousPictures = new System.Windows.Forms.Button();
            this.buttonNextPictures = new System.Windows.Forms.Button();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.labelAlbums = new System.Windows.Forms.Label();
            this.labelBirthdays = new System.Windows.Forms.Label();
            this.listBoxBirthdays = new System.Windows.Forms.ListBox();
            this.labelFriends = new System.Windows.Forms.Label();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxPages = new System.Windows.Forms.ListBox();
            this.listBoxDateEvents = new System.Windows.Forms.ListBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelEvents = new System.Windows.Forms.Label();
            this.dateTimePickerEvents = new System.Windows.Forms.DateTimePicker();
            this.labelGroups = new System.Windows.Forms.Label();
            this.checkedListBoxGroups = new System.Windows.Forms.CheckedListBox();
            this.labelGroupsPost = new System.Windows.Forms.Label();
            this.textBoxGroupsPost = new System.Windows.Forms.TextBox();
            this.buttonGroupsPost = new System.Windows.Forms.Button();
            this.listBoxPhotoComments = new System.Windows.Forms.ListBox();
            this.labelPhotoComments = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.messageListBox = new System.Windows.Forms.ListBox();
            this.commentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonLaunchForm = new System.Windows.Forms.Button();
            this.listBoxFormOptions = new System.Windows.Forms.ListBox();
            this.labelFormOptions = new System.Windows.Forms.Label();
            this.sortByListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            messageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPictures1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPictures3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPictures4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPictures2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.Location = new System.Drawing.Point(18, 14);
            messageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new System.Drawing.Size(120, 25);
            messageLabel.TabIndex = 0;
            messageLabel.Text = "Comments:";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(20, 30);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(6);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(318, 84);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login as diffrent user";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.BackColor = System.Drawing.Color.White;
            this.pictureBoxProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxProfile.Location = new System.Drawing.Point(18, 145);
            this.pictureBoxProfile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(317, 305);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProfile.TabIndex = 53;
            this.pictureBoxProfile.TabStop = false;
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.listBoxPosts.DataSource = this.postBindingSource;
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 25;
            this.listBoxPosts.Location = new System.Drawing.Point(18, 531);
            this.listBoxPosts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(630, 254);
            this.listBoxPosts.TabIndex = 54;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
            // 
            // labelPosts
            // 
            this.labelPosts.AutoSize = true;
            this.labelPosts.Location = new System.Drawing.Point(18, 488);
            this.labelPosts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPosts.Name = "labelPosts";
            this.labelPosts.Size = new System.Drawing.Size(78, 25);
            this.labelPosts.TabIndex = 55;
            this.labelPosts.Text = "Posts :";
            // 
            // labelPostStatus
            // 
            this.labelPostStatus.AutoSize = true;
            this.labelPostStatus.Location = new System.Drawing.Point(1004, 427);
            this.labelPostStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPostStatus.Name = "labelPostStatus";
            this.labelPostStatus.Size = new System.Drawing.Size(134, 25);
            this.labelPostStatus.TabIndex = 57;
            this.labelPostStatus.Text = "Post Status :";
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(1168, 417);
            this.textBoxStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(373, 31);
            this.textBoxStatus.TabIndex = 58;
            // 
            // buttonSetStatus
            // 
            this.buttonSetStatus.Location = new System.Drawing.Point(1562, 416);
            this.buttonSetStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSetStatus.Name = "buttonSetStatus";
            this.buttonSetStatus.Size = new System.Drawing.Size(112, 36);
            this.buttonSetStatus.TabIndex = 59;
            this.buttonSetStatus.Text = "Post";
            this.buttonSetStatus.UseVisualStyleBackColor = true;
            this.buttonSetStatus.Click += new System.EventHandler(this.buttonSetStatus_Click);
            // 
            // pictureBoxPictures1
            // 
            this.pictureBoxPictures1.BackColor = System.Drawing.Color.White;
            this.pictureBoxPictures1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPictures1.Location = new System.Drawing.Point(604, 77);
            this.pictureBoxPictures1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxPictures1.Name = "pictureBoxPictures1";
            this.pictureBoxPictures1.Size = new System.Drawing.Size(160, 141);
            this.pictureBoxPictures1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPictures1.TabIndex = 60;
            this.pictureBoxPictures1.TabStop = false;
            // 
            // pictureBoxPictures3
            // 
            this.pictureBoxPictures3.BackColor = System.Drawing.Color.White;
            this.pictureBoxPictures3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPictures3.Location = new System.Drawing.Point(604, 262);
            this.pictureBoxPictures3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxPictures3.Name = "pictureBoxPictures3";
            this.pictureBoxPictures3.Size = new System.Drawing.Size(160, 141);
            this.pictureBoxPictures3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPictures3.TabIndex = 63;
            this.pictureBoxPictures3.TabStop = false;
            // 
            // pictureBoxPictures4
            // 
            this.pictureBoxPictures4.BackColor = System.Drawing.Color.White;
            this.pictureBoxPictures4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPictures4.Location = new System.Drawing.Point(802, 262);
            this.pictureBoxPictures4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxPictures4.Name = "pictureBoxPictures4";
            this.pictureBoxPictures4.Size = new System.Drawing.Size(160, 141);
            this.pictureBoxPictures4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPictures4.TabIndex = 64;
            this.pictureBoxPictures4.TabStop = false;
            // 
            // pictureBoxPictures2
            // 
            this.pictureBoxPictures2.BackColor = System.Drawing.Color.White;
            this.pictureBoxPictures2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPictures2.Location = new System.Drawing.Point(802, 77);
            this.pictureBoxPictures2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxPictures2.Name = "pictureBoxPictures2";
            this.pictureBoxPictures2.Size = new System.Drawing.Size(160, 141);
            this.pictureBoxPictures2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPictures2.TabIndex = 65;
            this.pictureBoxPictures2.TabStop = false;
            // 
            // buttonPreviousPictures
            // 
            this.buttonPreviousPictures.Location = new System.Drawing.Point(1011, 345);
            this.buttonPreviousPictures.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPreviousPictures.Name = "buttonPreviousPictures";
            this.buttonPreviousPictures.Size = new System.Drawing.Size(112, 36);
            this.buttonPreviousPictures.TabIndex = 66;
            this.buttonPreviousPictures.Text = "<--";
            this.buttonPreviousPictures.UseVisualStyleBackColor = true;
            this.buttonPreviousPictures.Click += new System.EventHandler(this.buttonPreviousPictures_Click);
            // 
            // buttonNextPictures
            // 
            this.buttonNextPictures.Location = new System.Drawing.Point(1011, 275);
            this.buttonNextPictures.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonNextPictures.Name = "buttonNextPictures";
            this.buttonNextPictures.Size = new System.Drawing.Size(112, 36);
            this.buttonNextPictures.TabIndex = 67;
            this.buttonNextPictures.Text = "-->";
            this.buttonNextPictures.UseVisualStyleBackColor = true;
            this.buttonNextPictures.Click += new System.EventHandler(this.buttonNextPictures_Click);
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.ItemHeight = 25;
            this.listBoxAlbums.Location = new System.Drawing.Point(374, 77);
            this.listBoxAlbums.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(178, 379);
            this.listBoxAlbums.TabIndex = 68;
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // labelAlbums
            // 
            this.labelAlbums.AutoSize = true;
            this.labelAlbums.Location = new System.Drawing.Point(369, 30);
            this.labelAlbums.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAlbums.Name = "labelAlbums";
            this.labelAlbums.Size = new System.Drawing.Size(129, 25);
            this.labelAlbums.TabIndex = 69;
            this.labelAlbums.Text = "GetAlbums :";
            // 
            // labelBirthdays
            // 
            this.labelBirthdays.AutoSize = true;
            this.labelBirthdays.Location = new System.Drawing.Point(682, 686);
            this.labelBirthdays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBirthdays.Name = "labelBirthdays";
            this.labelBirthdays.Size = new System.Drawing.Size(301, 25);
            this.labelBirthdays.TabIndex = 70;
            this.labelBirthdays.Text = "Today\'s GetFriendsBirthdays :";
            // 
            // listBoxBirthdays
            // 
            this.listBoxBirthdays.FormattingEnabled = true;
            this.listBoxBirthdays.ItemHeight = 25;
            this.listBoxBirthdays.Location = new System.Drawing.Point(687, 730);
            this.listBoxBirthdays.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxBirthdays.Name = "listBoxBirthdays";
            this.listBoxBirthdays.Size = new System.Drawing.Size(274, 129);
            this.listBoxBirthdays.TabIndex = 71;
            // 
            // labelFriends
            // 
            this.labelFriends.AutoSize = true;
            this.labelFriends.Location = new System.Drawing.Point(682, 488);
            this.labelFriends.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFriends.Name = "labelFriends";
            this.labelFriends.Size = new System.Drawing.Size(170, 25);
            this.labelFriends.TabIndex = 72;
            this.labelFriends.Text = "GetFriends List :";
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 25;
            this.listBoxFriends.Location = new System.Drawing.Point(687, 531);
            this.listBoxFriends.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(274, 129);
            this.listBoxFriends.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(682, 881);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 74;
            this.label1.Text = "Liked Pages :";
            // 
            // listBoxPages
            // 
            this.listBoxPages.FormattingEnabled = true;
            this.listBoxPages.ItemHeight = 25;
            this.listBoxPages.Location = new System.Drawing.Point(687, 925);
            this.listBoxPages.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxPages.Name = "listBoxPages";
            this.listBoxPages.Size = new System.Drawing.Size(274, 129);
            this.listBoxPages.TabIndex = 75;
            // 
            // listBoxDateEvents
            // 
            this.listBoxDateEvents.FormattingEnabled = true;
            this.listBoxDateEvents.ItemHeight = 25;
            this.listBoxDateEvents.Location = new System.Drawing.Point(1168, 900);
            this.listBoxDateEvents.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxDateEvents.Name = "listBoxDateEvents";
            this.listBoxDateEvents.Size = new System.Drawing.Size(504, 154);
            this.listBoxDateEvents.TabIndex = 77;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(1004, 833);
            this.labelDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(146, 25);
            this.labelDate.TabIndex = 78;
            this.labelDate.Text = "Choose date :";
            // 
            // labelEvents
            // 
            this.labelEvents.AutoSize = true;
            this.labelEvents.Location = new System.Drawing.Point(1005, 900);
            this.labelEvents.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEvents.Name = "labelEvents";
            this.labelEvents.Size = new System.Drawing.Size(90, 25);
            this.labelEvents.TabIndex = 79;
            this.labelEvents.Text = "Events :";
            // 
            // dateTimePickerEvents
            // 
            this.dateTimePickerEvents.Location = new System.Drawing.Point(1168, 833);
            this.dateTimePickerEvents.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerEvents.Name = "dateTimePickerEvents";
            this.dateTimePickerEvents.Size = new System.Drawing.Size(504, 31);
            this.dateTimePickerEvents.TabIndex = 80;
            this.dateTimePickerEvents.ValueChanged += new System.EventHandler(this.dateTimePickerEvents_ValueChanged);
            // 
            // labelGroups
            // 
            this.labelGroups.AutoSize = true;
            this.labelGroups.Location = new System.Drawing.Point(1004, 488);
            this.labelGroups.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGroups.Name = "labelGroups";
            this.labelGroups.Size = new System.Drawing.Size(94, 25);
            this.labelGroups.TabIndex = 81;
            this.labelGroups.Text = "Groups :";
            // 
            // checkedListBoxGroups
            // 
            this.checkedListBoxGroups.FormattingEnabled = true;
            this.checkedListBoxGroups.Location = new System.Drawing.Point(1168, 488);
            this.checkedListBoxGroups.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkedListBoxGroups.Name = "checkedListBoxGroups";
            this.checkedListBoxGroups.Size = new System.Drawing.Size(504, 144);
            this.checkedListBoxGroups.TabIndex = 82;
            // 
            // labelGroupsPost
            // 
            this.labelGroupsPost.AutoSize = true;
            this.labelGroupsPost.Location = new System.Drawing.Point(1004, 758);
            this.labelGroupsPost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGroupsPost.Name = "labelGroupsPost";
            this.labelGroupsPost.Size = new System.Drawing.Size(167, 25);
            this.labelGroupsPost.TabIndex = 83;
            this.labelGroupsPost.Text = "Post to Groups :";
            // 
            // textBoxGroupsPost
            // 
            this.textBoxGroupsPost.Location = new System.Drawing.Point(1168, 753);
            this.textBoxGroupsPost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxGroupsPost.Name = "textBoxGroupsPost";
            this.textBoxGroupsPost.Size = new System.Drawing.Size(373, 31);
            this.textBoxGroupsPost.TabIndex = 84;
            // 
            // buttonGroupsPost
            // 
            this.buttonGroupsPost.Location = new System.Drawing.Point(1562, 753);
            this.buttonGroupsPost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonGroupsPost.Name = "buttonGroupsPost";
            this.buttonGroupsPost.Size = new System.Drawing.Size(112, 36);
            this.buttonGroupsPost.TabIndex = 85;
            this.buttonGroupsPost.Text = "Post";
            this.buttonGroupsPost.UseVisualStyleBackColor = true;
            this.buttonGroupsPost.Click += new System.EventHandler(this.buttonGroupsPost_Click);
            // 
            // listBoxPhotoComments
            // 
            this.listBoxPhotoComments.FormattingEnabled = true;
            this.listBoxPhotoComments.ItemHeight = 25;
            this.listBoxPhotoComments.Location = new System.Drawing.Point(1168, 30);
            this.listBoxPhotoComments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxPhotoComments.Name = "listBoxPhotoComments";
            this.listBoxPhotoComments.Size = new System.Drawing.Size(247, 329);
            this.listBoxPhotoComments.TabIndex = 88;
            // 
            // labelPhotoComments
            // 
            this.labelPhotoComments.AutoSize = true;
            this.labelPhotoComments.Location = new System.Drawing.Point(982, 45);
            this.labelPhotoComments.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPhotoComments.Name = "labelPhotoComments";
            this.labelPhotoComments.Size = new System.Drawing.Size(188, 25);
            this.labelPhotoComments.TabIndex = 89;
            this.labelPhotoComments.Text = "Photo Comments :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(messageLabel);
            this.panel1.Controls.Add(this.messageListBox);
            this.panel1.Location = new System.Drawing.Point(4, 805);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 266);
            this.panel1.TabIndex = 91;
            // 
            // messageListBox
            // 
            this.messageListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.commentsBindingSource, "Message", true));
            this.messageListBox.FormattingEnabled = true;
            this.messageListBox.ItemHeight = 25;
            this.messageListBox.Location = new System.Drawing.Point(16, 70);
            this.messageListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.messageListBox.Name = "messageListBox";
            this.messageListBox.Size = new System.Drawing.Size(638, 179);
            this.messageListBox.TabIndex = 1;
            // 
            // commentsBindingSource
            // 
            this.commentsBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Comment);
            // 
            // buttonLaunchForm
            // 
            this.buttonLaunchForm.Location = new System.Drawing.Point(1449, 275);
            this.buttonLaunchForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLaunchForm.Name = "buttonLaunchForm";
            this.buttonLaunchForm.Size = new System.Drawing.Size(225, 78);
            this.buttonLaunchForm.TabIndex = 93;
            this.buttonLaunchForm.Text = "Launch Form";
            this.buttonLaunchForm.UseVisualStyleBackColor = true;
            this.buttonLaunchForm.Click += new System.EventHandler(this.buttonLaunchForm_Click);
            // 
            // listBoxFormOptions
            // 
            this.listBoxFormOptions.FormattingEnabled = true;
            this.listBoxFormOptions.ItemHeight = 25;
            this.listBoxFormOptions.Location = new System.Drawing.Point(1449, 94);
            this.listBoxFormOptions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxFormOptions.Name = "listBoxFormOptions";
            this.listBoxFormOptions.Size = new System.Drawing.Size(223, 154);
            this.listBoxFormOptions.TabIndex = 94;
            // 
            // labelFormOptions
            // 
            this.labelFormOptions.AutoSize = true;
            this.labelFormOptions.Location = new System.Drawing.Point(1444, 41);
            this.labelFormOptions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFormOptions.Name = "labelFormOptions";
            this.labelFormOptions.Size = new System.Drawing.Size(153, 25);
            this.labelFormOptions.TabIndex = 95;
            this.labelFormOptions.Text = "Form Options :";
            // 
            // sortByListBox
            // 
            this.sortByListBox.FormattingEnabled = true;
            this.sortByListBox.ItemHeight = 25;
            this.sortByListBox.Location = new System.Drawing.Point(1010, 114);
            this.sortByListBox.Name = "sortByListBox";
            this.sortByListBox.Size = new System.Drawing.Size(120, 79);
            this.sortByListBox.TabIndex = 96;
            this.sortByListBox.SelectedIndexChanged += new System.EventHandler(this.sortBy_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1012, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 97;
            this.label2.Text = "SortBy:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1725, 1136);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sortByListBox);
            this.Controls.Add(this.labelFormOptions);
            this.Controls.Add(this.listBoxFormOptions);
            this.Controls.Add(this.buttonLaunchForm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelPhotoComments);
            this.Controls.Add(this.listBoxPhotoComments);
            this.Controls.Add(this.buttonGroupsPost);
            this.Controls.Add(this.textBoxGroupsPost);
            this.Controls.Add(this.labelGroupsPost);
            this.Controls.Add(this.checkedListBoxGroups);
            this.Controls.Add(this.labelGroups);
            this.Controls.Add(this.dateTimePickerEvents);
            this.Controls.Add(this.labelEvents);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.listBoxDateEvents);
            this.Controls.Add(this.listBoxPages);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxFriends);
            this.Controls.Add(this.labelFriends);
            this.Controls.Add(this.listBoxBirthdays);
            this.Controls.Add(this.labelBirthdays);
            this.Controls.Add(this.labelAlbums);
            this.Controls.Add(this.listBoxAlbums);
            this.Controls.Add(this.buttonNextPictures);
            this.Controls.Add(this.buttonPreviousPictures);
            this.Controls.Add(this.pictureBoxPictures2);
            this.Controls.Add(this.pictureBoxPictures4);
            this.Controls.Add(this.pictureBoxPictures3);
            this.Controls.Add(this.pictureBoxPictures1);
            this.Controls.Add(this.buttonSetStatus);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.labelPostStatus);
            this.Controls.Add(this.labelPosts);
            this.Controls.Add(this.listBoxPosts);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.buttonLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ido & Dvir Facebook App";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPictures1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPictures3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPictures4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPictures2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.Label labelPosts;
        private System.Windows.Forms.Label labelPostStatus;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Button buttonSetStatus;
        private System.Windows.Forms.PictureBox pictureBoxPictures1;
        private System.Windows.Forms.PictureBox pictureBoxPictures3;
        private System.Windows.Forms.PictureBox pictureBoxPictures4;
        private System.Windows.Forms.PictureBox pictureBoxPictures2;
        private System.Windows.Forms.Button buttonPreviousPictures;
        private System.Windows.Forms.Button buttonNextPictures;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.Label labelAlbums;
        private System.Windows.Forms.Label labelBirthdays;
        private System.Windows.Forms.ListBox listBoxBirthdays;
        private System.Windows.Forms.Label labelFriends;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxPages;
        private System.Windows.Forms.ListBox listBoxDateEvents;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelEvents;
        private System.Windows.Forms.DateTimePicker dateTimePickerEvents;
        private System.Windows.Forms.Label labelGroups;
        private System.Windows.Forms.CheckedListBox checkedListBoxGroups;
        private System.Windows.Forms.Label labelGroupsPost;
        private System.Windows.Forms.TextBox textBoxGroupsPost;
        private System.Windows.Forms.Button buttonGroupsPost;
        private System.Windows.Forms.ListBox listBoxPhotoComments;
        private System.Windows.Forms.Label labelPhotoComments;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox messageListBox;
        private System.Windows.Forms.BindingSource commentsBindingSource;
        private System.Windows.Forms.BindingSource postBindingSource;
        private System.Windows.Forms.Button buttonLaunchForm;
        private System.Windows.Forms.ListBox listBoxFormOptions;
        private System.Windows.Forms.Label labelFormOptions;
        private System.Windows.Forms.ListBox sortByListBox;
        private System.Windows.Forms.Label label2;
    }
}

