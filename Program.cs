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
            Console.WriteLine();
            ChangeObjectOfCollectionWithReferenceType();
        }

        public static void ChangeObjectOfCollectionWithValueType()
        {
            var intList = new List<int>() {1, 2, 3};
            foreach(var item in intList)
            {
                Console.WriteLine(item);
            }
            var val = intList.First(x => x == 2);
            val = 4;
            Console.WriteLine();
            Console.WriteLine("After change value 2 to 4 into a value variable");
            Console.WriteLine();
            foreach(var item in intList)
            {
                Console.WriteLine(item);
            }
        }

        public static void ChangeObjectOfCollectionWithReferenceType()
        {
            var carList = new List<Car>() {new Car{Year = 1999, Name = "focus"}, new Car{Year = 2010, Name = "Camaro"}, new Car{Year = 2016, Name = "Mustang"}};
            foreach(var item in carList)
            {
                Console.WriteLine($"{item.Name} - {item.Year}");
            }
            var val = carList.First(x => x.Year == 2010);
            val.Name = "Corvette";
            Console.WriteLine();
            Console.WriteLine("After change value Camaro to Corvette into a reference variable");
            Console.WriteLine();
            foreach(var item in carList)
            {
                Console.WriteLine($"{item.Name} - {item.Year}");
            }
        }

    }
}