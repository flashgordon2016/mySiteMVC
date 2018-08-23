using System;
using System.Collections.Generic;

namespace MySiteMVC.Models
{
    public partial class PostTagsJunction
    {
        public int TagId { get; set; }
        public Tag Tag { get; set; }

        public int BlogPostId { get; set; }
        public BlogPost BlogPost { get; set; }    
    }
}
