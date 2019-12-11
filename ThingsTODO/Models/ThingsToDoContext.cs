using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;

namespace ThingsTODO.Models
{
    public class ThingsToDoContext:DbContext
    {
       public DbSet<ToDoItem> toDoItem { get; set; }
    }
}
