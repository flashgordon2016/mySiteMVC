using System;
using System.Collections.Generic;

namespace MySiteMVC.Models
{
    public partial class Tag
    {
        public int TagId { get; set; }
        public string Name { get; set; }

        public List<PostTagsJunction> PostTagsJunction { get; set; }
    }
}
