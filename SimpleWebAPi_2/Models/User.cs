using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleWebAPi_2.Models
{
    public class User
    {
        public int Id { get; set; }
        public String UserName { get; set; }
        public String Email { get; set; }
        public String Address { get; set; }
        public String Website { get; set; }
        public List<Post> Posts { get; set; }
    }
}