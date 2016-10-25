using SQLite.Net.Attributes;
using System;

namespace YWW.core.Models
{
    [Table("Post")]
    public class Post
    {
        public Post() {
            AuthorID = "1";
            Type = "admin";
            Categories = "Advices";
            Privacy = "public";
            Contents = "Testing";
            SubjectTitle = "Testing Subject";
        }
        public Post(Post post)
        {
            AuthorID = post.AuthorID;
            Type = post.Type;
            Categories = post.Categories;
            Privacy = post.Privacy;
            Contents = post.Contents;
            PostDateTime = post.PostDateTime;
            SubjectTitle = post.SubjectTitle;

        }
        [PrimaryKey, AutoIncrement]
        public int PostID { get; set; }
        public string AuthorID { get; set; }
        public string Type { get; set; }
        public string Categories { get; set; }
        public string Privacy { get; set; }
        public string Contents { get; set; }
        public string SubjectTitle { get; set; }
        public DateTime PostDateTime { get; set; }
    }
}
