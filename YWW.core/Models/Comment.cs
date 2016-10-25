using SQLite.Net.Attributes;
using System;


namespace YWW.core.Models
{
    [Table("Comment")]
    public class Comment
    {
        [PrimaryKey, AutoIncrement]
        public int CommentID { get; set; }
        public int PostID { get; set; }
        public string Contents { get; set; }
        public string UserID { get; set; }
        public DateTime CommentDateTime { get; set; }
    }
}
