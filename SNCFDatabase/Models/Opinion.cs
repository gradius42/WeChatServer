using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SNCFDatabase.Models
{
    public class Opinion
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public float Mark { get; set; }
        public string Comment { get; set; }
        public string UserID { get; set; }
        private City City { get; set; }
        [ForeignKey("City")]
        public string CityID { get; set; }
    }
}
