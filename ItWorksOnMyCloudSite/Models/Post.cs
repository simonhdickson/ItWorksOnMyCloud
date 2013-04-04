using System;
using System.Collections.Generic;

namespace ItWorksOnMyCloudSite.Models
{
    public class Post
    {
        public string Title { get; set; }

        public DateTime PostedDate { get; set; }

        public string Author { get; set; }

        public string Content { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}