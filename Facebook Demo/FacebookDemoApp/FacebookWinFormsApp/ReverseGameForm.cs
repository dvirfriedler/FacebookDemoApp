using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsApp
{
    public partial class ReverseGameForm : Form
    {
        private Game m_Game;

        public ReverseGameForm(UserFacade i_User)
        {
            m_Game = new Game(i_User);
            setUpGame();
            InitializeComponent();
        }

        private void setUpGame()
        {
            User[] friends = m_Game.chooseFourFriends();
            pictureBox1.LoadAsync(friends[0].PictureNormalURL);
            pictureBox2.LoadAsync(friends[1].PictureNormalURL);
            pictureBox3.LoadAsync(friends[2].PictureNormalURL);
            pictureBox4.LoadAsync(friends[3].PictureNormalURL);
            label1.Text = friends[m_Game.RightAnswer].Name;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            submitAnswer(0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            submitAnswer(1);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            submitAnswer(2);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
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
