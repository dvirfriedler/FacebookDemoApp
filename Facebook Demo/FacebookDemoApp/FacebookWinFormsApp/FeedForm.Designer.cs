namespace FacebookWinFormsApp
{
    partial class FeedForm
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
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelPosts = new System.Windows.Forms.Label();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.buttonPostComment = new System.Windows.Forms.Button();
            this.buttonLike = new System.Windows.Forms.Button();
            this.buttonPostDetails = new System.Windows.Forms.Button();
            this.buttonCommentDetails = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.messageListBox = new System.Windows.Forms.ListBox();
            this.commentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            messageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.Location = new System.Drawing.Point(7, 19);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new System.Drawing.Size(74, 16);
            messageLabel.TabIndex = 0;
            messageLabel.Text = "Comments:";
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.DataSource = this.postBindingSource;
            this.listBoxPosts.DisplayMember = "Message";
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 16;
            this.listBoxPosts.Location = new System.Drawing.Point(26, 49);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(321, 372);
            this.listBoxPosts.TabIndex = 0;
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
            // 
            // labelPosts
            // 
            this.labelPosts.AutoSize = true;
            this.labelPosts.Location = new System.Drawing.Point(23, 20);
            this.labelPosts.Name = "labelPosts";
            this.labelPosts.Size = new System.Drawing.Size(47, 16);
            this.labelPosts.TabIndex = 3;
            this.labelPosts.Text = "Posts :";
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(379, 394);
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(255, 22);
            this.textBoxComment.TabIndex = 4;
            // 
            // buttonPostComment
            // 
            this.buttonPostComment.Location = new System.Drawing.Point(650, 393);
            this.buttonPostComment.Name = "buttonPostComment";
            this.buttonPostComment.Size = new System.Drawing.Size(118, 23);
            this.buttonPostComment.TabIndex = 5;
            this.buttonPostComment.Text = "Post Comment";
            this.buttonPostComment.UseVisualStyleBackColor = true;
            this.buttonPostComment.Click += new System.EventHandler(this.buttonPostComment_Click);
            // 
            // buttonLike
            // 
            this.buttonLike.Location = new System.Drawing.Point(650, 351);
            this.buttonLike.Name = "buttonLike";
            this.buttonLike.Size = new System.Drawing.Size(118, 23);
            this.buttonLike.TabIndex = 6;
            this.buttonLike.Text = "Like Post";
            this.buttonLike.UseVisualStyleBackColor = true;
            this.buttonLike.Click += new System.EventHandler(this.buttonLike_Click);
            // 
            // buttonPostDetails
            // 
            this.buttonPostDetails.Location = new System.Drawing.Point(379, 351);
            this.buttonPostDetails.Name = "buttonPostDetails";
            this.buttonPostDetails.Size = new System.Drawing.Size(111, 23);
            this.buttonPostDetails.TabIndex = 7;
            this.buttonPostDetails.Text = "Post Details";
            this.buttonPostDetails.UseVisualStyleBackColor = true;
            this.buttonPostDetails.Click += new System.EventHandler(this.buttonPostDetails_Click);
            // 
            // buttonCommentDetails
            // 
            this.buttonCommentDetails.Location = new System.Drawing.Point(505, 352);
            this.buttonCommentDetails.Name = "buttonCommentDetails";
            this.buttonCommentDetails.Size = new System.Drawing.Size(129, 23);
            this.buttonCommentDetails.TabIndex = 8;
            this.buttonCommentDetails.Text = "Comment Details";
            this.buttonCommentDetails.UseVisualStyleBackColor = true;
            this.buttonCommentDetails.Click += new System.EventHandler(this.buttonCommentDetails_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(messageLabel);
            this.panel1.Controls.Add(this.messageListBox);
            this.panel1.Location = new System.Drawing.Point(379, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 276);
            this.panel1.TabIndex = 9;
            // 
            // messageListBox
            // 
            this.messageListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.commentsBindingSource, "Message", true));
            this.messageListBox.FormattingEnabled = true;
            this.messageListBox.ItemHeight = 16;
            this.messageListBox.Location = new System.Drawing.Point(87, 19);
            this.messageListBox.Name = "messageListBox";
            this.messageListBox.Size = new System.Drawing.Size(301, 228);
            this.messageListBox.TabIndex = 1;
            // 
            // commentsBindingSource
            // 
            this.commentsBindingSource.DataMember = "Comments";
            this.commentsBindingSource.DataSource = this.postBindingSource;
            // 
            // FeedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 460);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonCommentDetails);
            this.Controls.Add(this.buttonPostDetails);
            this.Controls.Add(this.buttonLike);
            this.Controls.Add(this.buttonPostComment);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.labelPosts);
            this.Controls.Add(this.listBoxPosts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FeedForm";
            this.Text = "FeedForm";
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.Label labelPosts;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Button buttonPostComment;
        private System.Windows.Forms.Button buttonLike;
        private System.Windows.Forms.Button buttonPostDetails;
        private System.Windows.Forms.Button buttonCommentDetails;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox messageListBox;
        private System.Windows.Forms.BindingSource commentsBindingSource;
        private System.Windows.Forms.BindingSource postBindingSource;
    }
}