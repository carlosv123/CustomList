using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;



namespace CustomListProject
{
    public class CustomList<T> : IEnumerable
    {

        public T[] item;
        private int count;
        private int capacity;
        public int Count { get { return count; } }
        public int Capacity { get { return capacity; } }
        public T this[int i]
        {
            get { return TempArray[i]; }
            set { TempArray[i] = value; }
        }
        private T[] TempArray { get; set; }

   
        public CustomList()
        {
            TempArray= new T[capacity];
            count = 0;
            capacity = 0;
        }

        public void Add(T item)
        { 
            if(count >= capacity)
            {
                T[] Nextarray = new T[capacity];
                for (int i = 0;i < count; i++)
                {
                    Nextarray[i] = TempArray[i];
                }
                TempArray = Nextarray;
                TempArray[count] = item;
                count++;
            }
            else
            {
                TempArray[count] = item;
                count++;
            }
            
            
        
        }
        public void Remove(T item)
        {                                                   
           for(int i = 0; i < count; i--)
            {
                if (TempArray[i].Equals(item))
                {
                    count--;
                    if(count == 0)
                    {
                        List = new T[0];
                    }
                }
            }

        }
       
       
       
    }

} 
