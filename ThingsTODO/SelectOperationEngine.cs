using System;
using System.Collections.Generic;
using System.Text;
using ThingsTODO.Models;
using ThingsTODO.Services;

namespace ThingsTODO
{
    public class SelectOperationEngine
    {
        public void doOperation(ThingsToDoContext context,string choice)
        {
            switch (choice)
            {
                case "1":
                    DeleteEngine deleteEngine = new DeleteEngine();
                    Console.WriteLine("Enter Id For deletion");
                    string RegionId = Console.ReadLine();
                    deleteEngine.deleteEntry(context, RegionId);
                    break;
                case "2":
                    UpdateDBEngine updateDBEngine = new UpdateDBEngine();
                    Console.WriteLine("Enter Id For updation");
                    RegionId = Console.ReadLine();
                    updateDBEngine.updateEntry(context, RegionId);
                    break;
                case "3":
                    SearchEngine searchEngine = new SearchEngine();
                    Console.WriteLine("Enter Id For deletion");
                    RegionId = Console.ReadLine();
                    searchEngine.getEntry(context, RegionId);
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}
