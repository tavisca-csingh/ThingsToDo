using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Timers;
using ThingsTODO.Models;
using ThingsTODO.Services;

namespace ThingsTODO
{
    class Program
    {
        static void Main(string[] args)
        {
 
            Console.WriteLine("Reading started\n");

            var lines = File.ReadAllLines(@"..\\..\\..\\..\\PointOfInterestCoordinatesList.txt");

            CreateDBEngine create = new CreateDBEngine();
            var context=create.CreateEngine(lines);

            Console.WriteLine("saved sucessfully");

            Console.WriteLine("you can do following operations\n 1.Delete\n 2.Update\n 3.Search\n select options");
            string choice=Console.ReadLine();

            SelectOperationEngine selectOperation = new SelectOperationEngine();
            selectOperation.doOperation(context,choice);


        }
    }

}
