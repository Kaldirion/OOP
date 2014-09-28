using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    public class GenericList<T> where T:IComparable<T>
    {
        //Fields and Constants
        const int DefaultCapacity = 16;

        private T[] elements;
        private int count = 0;

        //Constructor
        public GenericList(int capacity = DefaultCapacity)
        {
            elements = new T[capacity];
        }

        //Property
        public int Count
        {
            get { return this.count; }
        }

        public int Capacity
        {
            get { return this.elements.Length; }
        }

        //Methods 
        public void Add(T element)
        {
            if (count >= elements.Length)
            {
                throw new IndexOutOfRangeException(String.Format(
                    "The list capacity of {0} was exceeded.", elements.Length));
            }
            this.elements[count] = element;
            count++;
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= Count)
                {
                    throw new IndexOutOfRangeException(String.Format(
                        "Invalid index: {0}.", index));
                }
                T result = elements[index];
                return result;
            }
        }

        public bool Find(T element)
        {
            bool result = false;
            for (int i = 0; i < Count; i++)
            {
                if (Compare(this[i], element))
                {
                    result = true;
                    break;
                }
            }
            return result;
        }

        public  int FindIndex(T element)
        {
            if (this.Find(element))
            {
                int index = 0;
                for (int i = 0; i < Count; i++)
                {
                    if (Compare(this[i], element))
                    {
                        index = i;
                        break;
                    }
                }
                return index;
            }
            else
            {
                return -1;
            }
        }

        public void InsertAt(T element, int index)
        {
            if (index < 0 || index > this.count)
            {
                throw new ArgumentOutOfRangeException(String.Format(
                        "Invalid index: {0}.", index));
            }
            if (index >= this.Capacity)
            {
                this.Grow();
            }

            for (int i = this.count; i > index; i--)
            {
                this.elements[i] = this.elements[i - 1];
            }
            this.count++;
            this.elements[index] = element;
            
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index > this.count)
            {
                throw new ArgumentOutOfRangeException(String.Format("Invalid index : {0}", index));
            }

            for (int i = index; i < this.count - 1; i++)
            {
                this.elements[i] = this.elements[i + 1];
            }
            this.count--;
            this.elements[count] = default(T);
        }

        public void ClearAll()
        {
            for (int i = 0; i < this.count; i++)
            {
                this.elements[i] = default(T);
            }
        }

        public T Min(){
            if (this.count == 0)
            {
                throw new InvalidOperationException("The list is empty");
            }
            else
            {
                T minVal = this.elements[0];
                for (int i = 0; i < this.count; i++)
                {
                    if (this.elements[i].CompareTo(minVal) < 0)
                    {
                        minVal = this.elements[i];
                    }
                }
                return minVal;
            }
        }

        public T Max()
        {
            if (this.count == 0)
            {
                throw new InvalidOperationException("The list is empty");
            }
            else
            {
                T maxVal = this.elements[0];
                for (int i = 0; i < this.count; i++)
                {
                    if (this.elements[i].CompareTo(maxVal) > 0)
                    {
                        maxVal = this.elements[i];
                    }
                }
                return maxVal;
            }
        }

        private void Grow(){
            T[] expandedArray = new T[this.Capacity * 2];
            Array.Copy(this.elements, expandedArray, this.Capacity);
            this.elements = expandedArray;
        }

        bool Compare(T element1, T element2)
        {
            return element1.Equals(element2);
        }

        public override string ToString()
        {
            string result = "";
            Console.WriteLine("Number of elements: {0}", Count);
            for (int i = 0; i < Count; i++)
            {
                T element = this[i];
                result += "["+i+" -> "+element+"]\n";
            }
            return result;
        }
    }
}
