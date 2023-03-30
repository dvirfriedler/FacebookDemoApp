using System.Windows.Forms;

namespace FacebookWinFormsApp
{
    internal static class FormFactory
    {
        public static Form CreateForm(int i_FormType, UserFacade i_User)
        {
            Form form = null;

            switch (i_FormType)
            {
                case 0:
                    form = new FeedForm(i_User) as Form;
                    break;
                case 1:
                    if (i_User.GetFriends().Count >= 4)
                    {
                        form = new GameForm(i_User) as Form;
                    }
                    else
                    {
                        MessageBox.Show("Not enough friends :(");
                    }

                    break;
                case 2:
                    if (i_User.GetFriends().Count >= 4)
                    {
                        form = new ReverseGameForm(i_User) as Form;
                    }
                    else
                    {
                        MessageBox.Show("Not enough friends :(");
                    }

                    break;
            }

            return form;
        }
    }
}
