using System;
using System.Globalization;
using System.Xml.Serialization;
namespace RemoveValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type array size: ");
            int size = Int32.Parse(Console.ReadLine());
            int[] array = new int[size];
            Console.WriteLine("Type your array: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Int32.Parse(Console.ReadLine());
            }
            Console.Write("Type your value you want to remove");
            int removeValue = Int32.Parse(Console.ReadLine());
            Console.Write("Array: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ", ");
            }
            remove(ref array, removeValue);
            Console.Write("New Array: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ", ");
            }


        }
        public static void remove(ref int[] array, int removevalue)
        {
            int index = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == removevalue)
                {
                    index = i;
                    break;
                }
            }
            if(index ==-1){
                Console.WriteLine("Not found");
            }else{
            for (int i = index; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[array.Length - 1] = 0;
            }


        }

    }
}

