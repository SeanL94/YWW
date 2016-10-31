using SQLite.Net.Attributes;
using System;

namespace YWW.core.Models
{
    [Table("Thought")]
    public class Thought
    {
        public Thought()
        {
            
        }
        public Thought(Thought thought)
        {
            AuthorID = thought.AuthorID;
            //Categories = thought.Categories;
            ThoughtDateTime = thought.ThoughtDateTime;
            Contents = thought.Contents;

        }
        [PrimaryKey, AutoIncrement]
        public int ThoughtID { get; set; }
        public string AuthorID { get; set; }
        public string Contents { get; set; }
        public DateTime ThoughtDateTime { get; set; }
    }
}
