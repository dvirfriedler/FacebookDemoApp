using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsApp
{
    public class CommentsSorterCommand : NamedSorterCommand<Photo>
    {
        public override string CompereBy => "Comments";

        public override int Compere(Photo x, Photo y)
        {
            try
            {
                return x.Comments.Count.CompareTo(y.Comments.Count);
            }
            catch (Exception e)
            {
                return 0;
            }
        }
    }
}
