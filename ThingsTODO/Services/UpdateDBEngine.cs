using System;
using System.Collections.Generic;
using System.Text;
using ThingsTODO.Models;

namespace ThingsTODO.Services
{
    public class UpdateDBEngine
    {
        public void updateEntry(ThingsToDoContext context,string Id)
        {
            foreach (var item in context.toDoItem)
            {
                if(item.RegionId==Id)
                {
                    Console.WriteLine("enter update details : \n");
                    string input=Console.ReadLine();
                    char[] spearator = { '|', '|', '|', '|', '|', '|' };
                    String[] strlist = input.Split(spearator);
                    item.RegionId = strlist[0];
                    item.RegionName = strlist[1];
                    item.RegionNameLong = strlist[2];
                    item.Latitude= strlist[3];
                    item.Longitude = strlist[4];
                    item.SubClassification = strlist[5];
                    context.SaveChanges();
                    Console.WriteLine("updated");
                }

            }
            
        }
    }
}
