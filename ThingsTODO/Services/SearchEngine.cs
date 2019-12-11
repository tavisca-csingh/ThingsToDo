using System;
using System.Collections.Generic;
using System.Text;
using ThingsTODO.Models;

namespace ThingsTODO.Services
{
    public class SearchEngine
    {
        public void getEntry(ThingsToDoContext context,string ID)
        {
            foreach (var item in context.toDoItem)
            {
                if(item.RegionId==ID)
                {
                    Console.WriteLine(item.RegionId+item.RegionName+"|"+item.RegionNameLong + "|" + item.Longitude + "|" + item.Latitude + "|" + item.SubClassification);
                }
            }
        }
    }
}
