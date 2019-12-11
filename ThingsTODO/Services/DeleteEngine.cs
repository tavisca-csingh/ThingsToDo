
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using ThingsTODO.Models;

namespace ThingsTODO.Services
{
    public class DeleteEngine
    {
        public void deleteEntry(ThingsToDoContext context,string Id)
        {
            foreach (var item in context.toDoItem)
            {
                if(item.RegionId==Id)
                {
                    context.Entry(item).State = EntityState.Deleted;
                    context.SaveChanges();
                }
            }
        }
    }
}
