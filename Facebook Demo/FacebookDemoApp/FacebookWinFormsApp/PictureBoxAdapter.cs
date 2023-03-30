using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsApp
{
    public class PictureBoxAdapter : ILoadableControl
    {
        public List<Photo> m_Photos { get; set; }

        public delegate void m_PictureBoxClicked();

        public event m_PictureBoxClicked PictureBoxClicked;

        public int m_PictureIndexRefrence { get; set; }

        public string m_Url { get; set; }

        private int m_PictureNumber;

        private PictureBox m_PictureBox;

        private string m_ImageLocation { get; set; }

        private int m_indexCurrentPhoto;

        public PictureBoxAdapter(PictureBox i_PictureBox, int i_PictureIndexRefrence,  int i_PictureNumber)
        {
            m_PictureBox = i_PictureBox;
            m_PictureBox.Click += M_PictureBox_Click;
            m_ImageLocation = i_PictureBox.ImageLocation;
            m_PictureIndexRefrence = i_PictureIndexRefrence;
            m_PictureNumber = i_PictureNumber;
        }

        public void Load()
        {
            m_indexCurrentPhoto = (m_PictureIndexRefrence * 4) + m_PictureNumber;

            if (m_indexCurrentPhoto < m_Photos.Count)
            {
                m_Url = m_Photos[m_indexCurrentPhoto].PictureThumbURL;
                m_PictureBox.ImageLocation = m_ImageLocation;
                m_PictureBox.Invoke(new Action(() => m_PictureBox.LoadAsync(m_Url)));
            }
            else
            {
                m_PictureBox.ImageLocation = null;
            }
        }

        public string ImageLocation
        {
            get
            {
                return m_PictureBox.ImageLocation;
            }

            set
            {
                m_PictureBox.ImageLocation = value;
            }
        }

        public FacebookObjectCollection<Comment> GetCurrentPhotoComents()
        {
            return m_Photos[m_indexCurrentPhoto].Comments;
        }

        private void M_PictureBox_Click(object sender, EventArgs e)
        {
            PictureBoxClicked();
        }
    }
}
