using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsApp
{
    public class UserFacade
    {
        private ProxyUser m_ProxyUser;

        private Dictionary<Album, List<Photo>> m_AlbumPhotos = new Dictionary<Album, List<Photo>>();

        public UserFacade(User i_LoggedInUser)
        {
            m_ProxyUser = new ProxyUser(i_LoggedInUser);
        }

        public FacebookObjectCollection<Album> GetAlbums()
        {
            return m_ProxyUser.Albums;
        }

        public FacebookObjectCollection<User> GetFriends()
        {
            return m_ProxyUser.Friends;
        }

        public FacebookObjectCollection<Group> GetGroups()
        {
            return m_ProxyUser.Groups;
        }

        public FacebookObjectCollection<Post> GetPosts()
        {
            return m_ProxyUser.Posts;
        }

        public FacebookObjectCollection<Event> GetEvents()
        {
            return m_ProxyUser.Events;
        }

        public FacebookObjectCollection<Page> GetLikedPages()
        {
            return m_ProxyUser.LikedPages;
        }

        public string GetProfilePictureURL()
        {
            return m_ProxyUser.ProfilePictureURL;
        }

        public FacebookObjectCollection<User> GetFriendsBirthdays()
        {
            FacebookObjectCollection<User> users = new FacebookObjectCollection<User>();

            foreach (User friend in GetFriends())
            {
                if (friend.Birthday != null)
                {
                    if (matchDates(friend.Birthday))
                    {
                        users.Add(friend);
                    }
                }
            }

            return users;
        }

        public List<Photo> GetPhotoList(ListBox i_ListBoxAlbums)
        {
            List<Photo> photos = new List<Photo>();

            Album selectedAlbum = null;

            if ((int)i_ListBoxAlbums.Invoke(new Func<int>(() => i_ListBoxAlbums.SelectedItems.Count)) == 1)
            {
                selectedAlbum = i_ListBoxAlbums.Invoke(new Func<Album>(() => i_ListBoxAlbums.SelectedItem as Album)) as Album;
            }

            if (!m_AlbumPhotos.ContainsKey(selectedAlbum))
            {
                int index = 0;

                for (int i = 0; i < selectedAlbum.Photos.Count; i++)
                {
                    photos.Add(selectedAlbum.Photos[i]);
                }

                m_AlbumPhotos.Add(selectedAlbum, photos);
            }

            return m_AlbumPhotos[selectedAlbum];
        }

        public Post GetSelectedPost(ListBox i_ListBoxPosts)
        {
            Post selected = null;

            if (i_ListBoxPosts.SelectedItems.Count == 1)
            {
                string postID = m_ProxyUser.PostsID[i_ListBoxPosts.SelectedIndex];

                foreach (Post post in GetFeedPosts())
                {
                    if (postID.Equals(post.Id))
                    {
                        selected = post;
                        break;
                    }
                }
            }

            return selected;
        }

        public FacebookObjectCollection<Post> GetFeedPosts()
        {
            FacebookObjectCollection<Post> posts = new FacebookObjectCollection<Post>();

            foreach (User friend in GetFriends())
            {
                foreach (Post post in friend.Posts)
                {
                    if (post.UpdateTime >= DateTime.Today && post.Message != null)
                    {
                        posts.Add(post);
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return posts;
        }

        public Status PostStatus(string i_StatusText)
        {
            return m_ProxyUser.PostStatus(i_StatusText);
        }

        private bool matchDates(string i_UserBirthday)
        {
            string todayDateDayAndMonthe = DateTime.Now.ToString("MM/dd");
            string userBirthDay = i_UserBirthday.Substring(0, 5);
            return todayDateDayAndMonthe.Equals(userBirthDay);
        }
    }
}