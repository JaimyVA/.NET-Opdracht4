using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht4
{
    internal class Rij<T>
    {
        private Queue<T> Queue = new Queue<T>();

        public void Toevoegen(T item)
        {
            Queue.Enqueue(item);
        }

        public T EersteElement()
        {
            return Queue.Peek();
        }
        public void LaatsteElement(T td)
        {
            Queue.Enqueue(td);
        }
        public T Toon(int i)
        {
            T result = Queue.ElementAt(i);
            return result;
        }

        public T Verwijderen()
        {
            return Queue.Dequeue();
        }
        public void Leegmaken()
        {
            Queue.Clear();
        }
        public override string ToString()
        {
            foreach (T element in Queue)
            {
                return element.ToString();
            }
            return "";
        }

        public bool isEmpty { get { return Queue.Count() == 0; } private set { } }
        public void RijCopy()
        {
            Rij<T> newRij = new Rij<T>();
            foreach (T item in Queue)
            {
                newRij.Toevoegen(item);
            }
        }
    }
}
