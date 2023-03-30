using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace FacebookWinFormsApp
{
    public partial class LoginForm : Form
    {
        private User m_LoggedInUser;
        private LoginResult m_LoginResult;

        public LoginForm()
        {
            InitializeComponent();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            AppSettings.Instance.LastWindowLocation = this.Location;
            AppSettings.Instance.AutoLogin = checkBoxRememberMe.Checked;
            AppSettings.Instance.SaveToFile();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (AppSettings.Instance.AutoLogin && AppSettings.Instance.AccessToken != null)
            {
                LoginResult result = FacebookService.Connect(AppSettings.Instance.AccessToken);

                if (string.IsNullOrEmpty(result.ErrorMessage))
                {
                    m_LoggedInUser = result.LoggedInUser;
                    fetchLoggedInUser();
                }
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.Location = AppSettings.Instance.LastWindowLocation;
            this.checkBoxRememberMe.Checked = AppSettings.Instance.AutoLogin;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            m_LoginResult = FacebookService.Login(
                    "695132158717351",
                    "email",
                    "public_profile",
                    "user_age_range",
                    "user_birthday",
                    "user_events",
                    "user_friends",
                    "user_gender",
                    "user_hometown",
                    "user_likes",
                    "user_link",
                    "user_location",
                    "user_photos",
                    "user_posts",
                    "user_videos");

            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser;
                AppSettings.Instance.AccessToken = m_LoginResult.AccessToken;
                fetchLoggedInUser();
            }
            else
            {
                MessageBox.Show(m_LoginResult.ErrorMessage, "Login Failed");
            }
        }

        private void fetchLoggedInUser()
        {
            FormMain formMain = new FormMain(new UserFacade(m_LoggedInUser));
            this.Hide();
            formMain.ShowDialog();
            this.Close();
        }
    }
}
