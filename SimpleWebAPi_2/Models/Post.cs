using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleWebAPi_2.Models
{
    public class Post
    {
        public int Id { get; set; }
        public String PostDetails { get; set; }
        public DateTime PostDate { get; set; }

        public List<Comment> Comments { get; set; }
    }
}