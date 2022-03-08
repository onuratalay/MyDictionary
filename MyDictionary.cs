using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionaries
{
    internal class MyDictionary<T1, T2>
    {
        T1[] numbers;
        T2[] names;
        T1[] tempNumbers;
        T2[] tempNames;

        public MyDictionary()
        {
            numbers = new T1[0];
            names = new T2[0];
        }
        public void Add(T1 number, T2 name)
        {
            tempNumbers = numbers;
            numbers = new T1[numbers.Length + 1];
            for (int i = 0; i < tempNumbers.Length; i++)
            {
                numbers[i] = tempNumbers[i];
            }

            tempNames = names;
            names = new T2[names.Length + 1];
            for (int i = 0; i < tempNames.Length; i++)
            {
                names[i] = tempNames[i];
            }
        }


        public int Count
        {
            get { return numbers.Length; }
        }
    }
}
