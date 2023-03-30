using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsApp
{
    public class NoneSorterCommand : NamedSorterCommand<Photo>
    {
        public override string CompereBy => "None";

        public override int Compere(Photo x, Photo y)
        {
            return 0;
        }
    }
}
