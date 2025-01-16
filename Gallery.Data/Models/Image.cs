using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallery.Data.Models
{
    public class Image
    {
        [Required]
        [MaxLength(450)]
        public string Id { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Url { get; set; }
        public bool IsDeleted {  get; set; }

        public User User { get; set; }
    }
}
