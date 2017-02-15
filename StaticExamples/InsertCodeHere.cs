using System;
using System.Collections.Generic;

namespace StaticExamples
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            List<int> aList = new List<int> {23, 86, 51, 11, 39};


            int smallest = ListMethods.FindSmallestNumber(aList);
            Console.WriteLine("Smallest number in the list is: {0}", smallest);

            int average = ListMethods.FindAverage(aList);
            Console.WriteLine("The average of the list is: {0}", average);

            Car minbil = new Car("abc123", 12000);
            Car minbil2 = new Car("dsf456", 40000);
            Car minbil3 = new Car ("asdk72", 130000);


            Console.WriteLine(minbil.LicensePlate);
            Console.WriteLine(Car.PlateTracker);
            Console.WriteLine(minbil.LicensePlate);
            Console.WriteLine(Car.PlateTracker);
            Console.WriteLine(minbil.LicensePlate);
            Console.WriteLine(Car.PlateTracker);
            Console.WriteLine(minbil.LicensePlate);
            Console.WriteLine(Car.PlateTracker);
            Console.WriteLine(minbil.LicensePlate);
            Console.WriteLine(Car.PlateTracker);
            Console.WriteLine(minbil.LicensePlate);
            Console.WriteLine(Car.PlateTracker);

            Console.WriteLine(minbil.Price);
            Console.WriteLine(Car.PriceTracker);
            Console.WriteLine(minbil.Price);
            Console.WriteLine(Car.PriceTracker);
            Console.WriteLine(minbil.Price);
            Console.WriteLine(Car.PriceTracker);
            Console.WriteLine(minbil.Price);
            Console.WriteLine(Car.PriceTracker);
            Console.WriteLine(minbil.Price);
            Console.WriteLine(Car.PriceTracker);
            Console.WriteLine(minbil.Price);
            Console.WriteLine(Car.PriceTracker);
            Console.WriteLine(minbil.Price);
            Console.WriteLine(Car.PriceTracker);




            //ListMethods listMethodsObject = new ListMethods();

            //int smallest = listMethodsObject.FindSmallestNumber(aList);
            //Console.WriteLine("The smallest number in the list is : {0}", smallest);

            //int average = listMethodsObject.FindAverage(aList);
            //Console.WriteLine("The average of the list is : {0}", average);

            // The LAST line of code should be ABOVE this line
        }
    }
}