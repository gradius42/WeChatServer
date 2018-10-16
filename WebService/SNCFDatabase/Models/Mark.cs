using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SNCFDatabase.Models
{
    public class Mark
    {
        public int ID { get; set; }
        public float Value { get; set; }
        public DateTime Date { get; set; }
        public int UserID { get; set; }
        private Comment Comment { get; set; }
        [ForeignKey("Comment")]
        public int CommentID { get; set; }
    }
}
