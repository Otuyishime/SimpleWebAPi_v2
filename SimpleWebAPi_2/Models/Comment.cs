using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleWebAPi_2.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public String CommentDetails { get; set; }
        public int UserId { get; set; }
        public int PostId { get; set; }

    }
}