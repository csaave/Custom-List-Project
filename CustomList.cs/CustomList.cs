using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass 
{
    public class CustomList <T>
    {
        T[] arr;
        int capacity;
        public int count;

        public CustomList()
        {
            capacity = 5;
            arr = new T[capacity];
            count = 0;

        }
        public T this[int i]
        {
            get => arr[i];
            set => arr[i] = value;
        }
    
    public void Add(T value)    //add(9)
        {
            arr[count] = value;
            count += 1;
            
        }

        //check the count
        //arr[count]= value
        // count = count + 1
        // count ++
        // count += 1

            //int[] arr = { 2, 3, 4, };

        public void Remove(T value)
        {
            throw new NotImplementedException();
        }
        //research c# indexer

    }
}
