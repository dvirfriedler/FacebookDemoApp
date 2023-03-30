using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsApp
{
    public partial class GameForm : Form
    {
        private Game m_Game;

        public GameForm(UserFacade i_User)
        {
            m_Game = new Game(i_User);
            setUpGame();
            InitializeComponent();
        }

        private void setUpGame()
        {
            User[] friends = m_Game.chooseFourFriends();
            buttonAnswer1.Text = friends[0].Name;
            buttonAnswer2.Text = friends[1].Name;
            buttonAnswer3.Text = friends[2].Name;
            buttonAnswer4.Text = friends[3].Name;
            pictureBoxFriendProfile.LoadAsync(friends[m_Game.RightAnswer].PictureNormalURL);
        }

        private void buttonAnswer1_Click(object sender, EventArgs e)
        {
            submitAnswer(0);
        }

        private void buttonAnswer2_Click(object sender, EventArgs e)
        {
            submitAnswer(1);
        }

        private void buttonAnswer3_Click(object sender, EventArgs e)
        {
            submitAnswer(2);
        }

        private void buttonAnswer4_Click(object sender, EventArgs e)
        {
            submitAnswer(3);
        }

        private void submitAnswer(int i_ChosenAnswer)
        {
            if (m_Game.RightAnswer == i_ChosenAnswer)
            {
                MessageBox.Show("You answered correctly! :)");
                this.Close();
            }
            else
            {
                MessageBox.Show("You answered incorrectly :(");
                this.Close();
            }
        }
    }
}
