using System;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsApp
{
    internal class Game
    {
        private UserFacade m_User;
        private int m_RightAnswer;

        public int RightAnswer
        {
            get { return m_RightAnswer; }
        }

        public Game(UserFacade i_User)
        {
            m_User = i_User;
            m_RightAnswer = setUpGame();
        }

        public User[] chooseFourFriends()
        {
            User[] friends = new User[4];
            User firstFriend = chooseRandomFriend();
            friends[0] = firstFriend;
            User secondFriend = chooseRandomFriend();

            while (firstFriend.Name == secondFriend.Name)
            {
                secondFriend = chooseRandomFriend();
            }

            friends[1] = secondFriend;
            User thirdFriend = chooseRandomFriend();

            while (firstFriend.Name == thirdFriend.Name || secondFriend.Name == thirdFriend.Name)
            {
                thirdFriend = chooseRandomFriend();
            }

            friends[2] = thirdFriend;
            User forthFriend = chooseRandomFriend();

            while (firstFriend.Name == forthFriend.Name || secondFriend.Name == forthFriend.Name || thirdFriend.Name == forthFriend.Name)
            {
                forthFriend = chooseRandomFriend();
            }

            friends[3] = forthFriend;
            return friends;
        }

        private User chooseRandomFriend()
        {
            Random random = new Random();
            int numOfFriends = m_User.GetFriends().Count;
            User randomFriend = m_User.GetFriends()[random.Next(numOfFriends)];
            return randomFriend;
        }

        private int setUpGame()
        {
            Random random = new Random();
            int rightAnswer = random.Next(4);

            return rightAnswer;
        }
    }
}
