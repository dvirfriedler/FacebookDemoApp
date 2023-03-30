using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsApp
{
    public class ProxyUser
    {
        private User m_LoggedInUser;
        private FacebookObjectCollection<Album> m_Albums = null;
        private FacebookObjectCollection<User> m_Friends = null;
        private FacebookObjectCollection<Group> m_Groups = null;
        private FacebookObjectCollection<Post> m_Posts = null;
        private FacebookObjectCollection<Event> m_Events = null;
        private FacebookObjectCollection<Page> m_LikedPages = null;
        private Dictionary<string, Photo[]> m_AlbumsPhotos = new Dictionary<string, Photo[]>();
        private string m_ProfilePictureURL = null;
        private List<string> m_PostsID = null;

        public ProxyUser(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
        }

        public FacebookObjectCollection<Album> Albums
        {
            get
            {
                if(m_Albums == null)
                {
                    m_Albums = m_LoggedInUser.Albums;
                }

                return m_Albums;
            }
        }

        public FacebookObjectCollection<User> Friends
        {
            get
            {
                if (m_Friends == null)
                {
                    m_Friends = m_LoggedInUser.Friends;

                    foreach (User friend in Friends)
                    {
                        foreach (Post post in friend.Posts)
                        {
                            if (post.UpdateTime >= DateTime.Today && post.Message != null)
                            {
                                m_PostsID.Add(post.Id);
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }

                return m_Friends;
            }
        }

        public FacebookObjectCollection<Group> Groups
        {
            get
            {
                if (m_Groups == null)
                {
                    m_Groups = m_LoggedInUser.Groups;
                }

                return m_Groups;
            }
        }

        public FacebookObjectCollection<Post> Posts
        {
            get
            {
                if (m_Posts == null)
                {
                    m_Posts = m_LoggedInUser.Posts;
                }

                return m_Posts;
            }
        }

        public FacebookObjectCollection<Event> Events
        {
            get
            {
                if (m_Events == null)
                {
                    m_Events = m_LoggedInUser.Events;
                }

                return m_Events;
            }
        }

        public FacebookObjectCollection<Page> LikedPages
        {
            get
            {
                if (m_LikedPages == null)
                {
                    m_LikedPages = m_LoggedInUser.LikedPages;
                }

                return m_LikedPages;
            }
        }

        public string ProfilePictureURL
        {
            get
            {
                if (m_ProfilePictureURL == null)
                {
                    m_ProfilePictureURL = m_LoggedInUser.PictureNormalURL;
                }

                return m_ProfilePictureURL;
            }
        }

        public Post GetSelectedPost(ListBox i_ListBoxPosts)
        {
            Post selected = null;

            if (i_ListBoxPosts.SelectedItems.Count == 1)
            {
                string postID = m_PostsID[i_ListBoxPosts.SelectedIndex];

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

            foreach (User friend in Friends)
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
            return m_LoggedInUser.PostStatus(i_StatusText);
        }

        public List<string> PostsID
        {
            get
            {
                if (m_PostsID == null)
                {
                    m_Friends = Friends;
                }

                return m_PostsID;
            }
        }
    }
}