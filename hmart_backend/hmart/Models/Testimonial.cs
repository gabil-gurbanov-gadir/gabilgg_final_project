using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace hmart.Models
{
    public class Testimonial
    {
        public int Id { get; set; }

        [StringLength(maximumLength: 50)]
        public string Author { get; set; }

        [StringLength(maximumLength: 50)]
        public string Position { get; set; }

        [StringLength(maximumLength: 500)]
        public string Text { get; set; }
    }
}
