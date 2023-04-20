using System;

namespace Stos
{
    public class StosWTablicy<T> : IStos<T>
    {
        private T[] tab;
        private int szczyt = -1;

        public StosWTablicy(int size = 10)
        {
            tab = new T[size];
            szczyt = -1;
        }

        public T Peek => IsEmpty ? throw new StosEmptyException() : tab[szczyt];

        public int Count => szczyt + 1;

        public bool IsEmpty => szczyt == -1;

        public void Clear() => szczyt = -1;

        public T Pop()
        {
            if (IsEmpty)
                throw new StosEmptyException();

            szczyt--;
            return tab[szczyt + 1];
        }

        public void Push(T value)
        {
            if (szczyt == tab.Length - 1)
            {
                Array.Resize(ref tab, tab.Length * 2);
            }

            szczyt++;
            tab[szczyt] = value;
        }

        public T[] ToArray()
        {
            //return tab;  //bardzo źle - reguły hermetyzacji

            //poprawnie:
            T[] temp = new T[szczyt + 1];
            for (int i = 0; i < temp.Length; i++)
                temp[i] = tab[i];
            return temp;
        }
    }
}
