using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace MySiteMVC.Models
{
    public partial class BlogPost
    {
        public int BlogPostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Summary { get; set; }
        public DateTime OriginalPostDate { get; set; }
        public DateTime UpdatedDate { get; set; }      
        public List<PostTagsJunction> PostTagsJunction { get; set; }

        public string OriginalPostDateForDisplay
        {
            get
            {
                return this.OriginalPostDate.ToShortDateString();
            }

        }
        public string UpdatedDateForDisplay
        {
            get
            {
                return this.UpdatedDate.ToShortDateString();
            }
        }
        public string BannerImgPath { get; set; }
    }
}
