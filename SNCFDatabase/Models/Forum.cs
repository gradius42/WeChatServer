using System.ComponentModel.DataAnnotations.Schema;

namespace SNCFDatabase.Models
{
    public class Forum
    {
        public int ID { get; set; }
        public string Name { get; set; }
        private City City { get; set; }
        [ForeignKey("City")]
        public string CityID { get; set; }
    }
}
