using System.ComponentModel.DataAnnotations;

namespace ThingsTODO.Models
{
    public class ToDoItem
    {
        [Key]
        public string RegionId { get; set; }
        public string RegionName { get; set; }
        public string RegionNameLong { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string SubClassification { get; set; }
    }
}
