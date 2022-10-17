using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3
{
    internal class Stapel<T>
    {

        List<T> container = new List<T>();

        public void Toevoegen(T iets)
        {
            container.Add(iets);
        }

        public T Verwijderen()
        {
            if (container.Count == 0)
                throw new StackOverflowException();
            T delete = container[0];
            container.RemoveAt(0);

            return delete; 
        }

        public void Leegmaken()
        {
            container.Clear();
        }

        public bool isAanwezig(T iets)
        {
            if (container.Contains(iets))
            {
                return true;
            }
            else
            {
                return false; 
            }
        }

        public string ToString()
        {
            return String.Join(" , ", container.ToArray());
        }


        public Stapel<T> Copy()
        {
            return (Stapel<T>)MemberwiseClone();
        }

    }
}
