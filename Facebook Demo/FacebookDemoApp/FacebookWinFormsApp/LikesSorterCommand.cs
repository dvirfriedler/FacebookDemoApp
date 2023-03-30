using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsApp
{
    public class LikesSorterCommand : NamedSorterCommand<Photo>
    {
        public override string CompereBy => "Likes";

        public override int Compere(Photo x, Photo y)
        {
            return x.LikedBy.Count.CompareTo(y.LikedBy.Count);
        }
    }
}
