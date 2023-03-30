using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsApp
{
    public class NamedSorterCommandsAggragate
    {
        public List<NamedSorterCommand<Photo>> GetComperators()
        {
            List<NamedSorterCommand<Photo>> comperatorsList = new List<NamedSorterCommand<Photo>>();

            comperatorsList.Add(new NoneSorterCommand());

            comperatorsList.Add(new CommentsSorterCommand());

            comperatorsList.Add(new LikesSorterCommand());

            return comperatorsList;
        }
    }
}
