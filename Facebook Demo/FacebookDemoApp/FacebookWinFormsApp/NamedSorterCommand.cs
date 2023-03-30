using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsApp
{
    public abstract class NamedSorterCommand<T> : IComparer<T>, ICommand<T>
    {
        public abstract string CompereBy { get; }

        public abstract int Compere(T x, T y);

        public void SortList(List<T> list, bool reverse = true)
        {
            bool needToSwap = false;

            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    needToSwap = this.Compere(list[i], list[j]) > 0;

                    if (reverse)
                    {
                        needToSwap = !needToSwap;
                    }

                    if (needToSwap)
                    {
                        T temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }
        }

        public void Execute(List<T> o_List)
        {
            SortList(o_List);
        }
    }

    public interface IComparer<T>
    {
        int Compere(T x, T y);
    }

    public interface ICommand<T>
    {
        void Execute(List<T> i_List);
    }
}
