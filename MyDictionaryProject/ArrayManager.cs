using System;

namespace MyDictionaryProject
{
    public static class ArrayManager<T>
    {
        public static void IncreaseSize(ref T[] array)
        {
            T[] tempArray = array;
            array = new T[tempArray.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                array[i] = tempArray[i];
            }
        }

        public static int Get(ref T[] array, T var)
        {
            return Array.IndexOf(array, var);
        }
    }
}