using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SNCFDatabase.Models
{
    public class Comment
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }
        public int UserID { get; set; }
        private Forum Forum { get; set; }
        [ForeignKey("Forum")]
        public int ForumID { get; set; }
    }
}
