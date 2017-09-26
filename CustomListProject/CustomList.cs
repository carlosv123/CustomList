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

        T[] item;
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
            
            

            
            
        
        }
        public void Remove(T item)
        {                                                   
           

        }
       
       
       
    }

} 
