using System;
using System.Collections.Generic;
using System.Text;
using ThingsTODO.Models;

namespace ThingsTODO.Services
{
    public class CreateDBEngine
    {
        public ThingsToDoContext CreateEngine(string[] lines)
        {
            using (ThingsToDoContext context = new ThingsToDoContext())
            {
                List<ToDoItem> toDos = new List<ToDoItem>();
                foreach (var line in lines)
                {
                    char[] spearator = { '|', '|', '|', '|', '|', '|' };
                    String[] strlist = line.Split(spearator);
                    toDos.Add(new ToDoItem()
                    {
                        RegionId = strlist[0],
                        RegionName = strlist[1],
                        RegionNameLong = strlist[2],
                        Latitude = strlist[3],
                        Longitude = strlist[4],
                        SubClassification = strlist[5]
                    });
                }
                context.toDoItem.AddRange(toDos);

                context.SaveChanges();
                return context;
            }
        }
    }
}
