using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookWinFormsApp
{
    internal interface IObserver
    {
       void Update();
    }

    public class ObservableNextButton : IObserver
    {
       private int m_CurrentPicturesIndex { get; set; }

       private int m_CurrentAlbumLength { get; set; }

       private Button m_Button;

       public ObservableNextButton(Button i_button)
       {
            m_Button = i_button;
            m_CurrentPicturesIndex = 0;
       }

       public void UpdateDataMembers(int i_CurrentPicturesIndex, int i_CurrentAlbumLength)
       {
            m_CurrentAlbumLength = i_CurrentAlbumLength;
            m_CurrentPicturesIndex = i_CurrentPicturesIndex;
       }

       public void Update()
       {
          this.m_Button.Enabled = (m_CurrentPicturesIndex + 1) * 4 < m_CurrentAlbumLength;
       }
    }

    public class ObservablePrevButton : IObserver
    {
        private int m_CurrentPicturesIndex { get; set; }

        private Button m_Button;

        public ObservablePrevButton(Button i_button)
        {
            m_Button = i_button;
            m_CurrentPicturesIndex = 0;
        }

        public void UpdateDataMembers(int i_CurrentPicturesIndex)
        {
            m_CurrentPicturesIndex = i_CurrentPicturesIndex;
        }

        public void Update()
        {
            this.m_Button.Enabled = m_CurrentPicturesIndex != 0;
        }
    }
}
