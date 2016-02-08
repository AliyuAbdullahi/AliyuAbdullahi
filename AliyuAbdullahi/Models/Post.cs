using System;
using System.Collections;
using System.Collections.Generic;

namespace AliyuAbdullahi.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string  Title { get; set; }
        public DateTime Date { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}