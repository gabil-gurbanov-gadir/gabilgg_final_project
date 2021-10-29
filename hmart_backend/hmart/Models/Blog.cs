using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace hmart.Models
{
    public class Blog
    {
        public int Id { get; set; }

        [StringLength(maximumLength: 150)]
        public string Title { get; set; }

        [StringLength(maximumLength: 100)]
        public string Image { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }

        public DateTime Date { get; set; }

        [StringLength(maximumLength: 60)]
        public string Author { get; set; }

        [StringLength(maximumLength: 600)]
        public string Desc { get; set; }

        [StringLength(maximumLength: 6000)]
        public string Text { get; set; }

        [StringLength(maximumLength: 250)]
        public string Quote { get; set; }

        [StringLength(maximumLength: 60)]
        public string Quoter { get; set; }

        public List<BlogTagBlog> BlogTagBlogs { get; set; }
        public List<BlogComment> BlogComments { get; set; }
    }
}
