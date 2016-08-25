using System;
using System.Collections.Generic;
using System.Linq;

namespace ValueTypeAndReferenceTypeExampleMain
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ChangeObjectOfCollectionWithValueType();
        }

        public static void ChangeObjectOfCollectionWithValueType()
        {
            var listInt = new List<int>() {1, 2, 3};
            foreach(var item in listInt)
            {
                Console.WriteLine(item);
            }
            var val = listInt.First(x => x == 2);
            val = 4;
            Console.WriteLine("After change value 2 to 4 into a variable");
            foreach(var item in listInt)
            {
                Console.WriteLine(item);
            }
        }
    }
}