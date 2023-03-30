using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsApp
{
    internal class ListBoxAdapter : ListBox
    {
        ListBox m_ListBox;

        public ListBoxAdapter(ListBox i_ListBox)
        {
            this.m_ListBox = i_ListBox;
        }

        public void AddItems(FacebookObjectCollection<Group> o_List)
        {
            foreach (FacebookObject facebookObject in o_List)
            {
                AddItem(facebookObject);
            }
        }

        public void AddItem(FacebookObject i_facebookObject)
        {
            m_ListBox.Invoke(new Action(() => m_ListBox.Items.Add(i_facebookObject.ToString())));
        }

        public void AddItems(FacebookObjectCollection<Photo> o_List)
        {
            foreach (FacebookObject facebookObject in o_List)
            {
                AddItem(facebookObject);
            }
        }

    }
}
