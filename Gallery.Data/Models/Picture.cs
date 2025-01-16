using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallery.Data.Models
{
    public class Picture
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(10000)]
        public string Url { get; set; }
        public bool IsDeleted { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [Required]
        [MaxLength(10000)]
        public string Description { get; set; } 

        public decimal Rating { get; set; }

        public ArtType ArtType { get; set; }
        public int ArtTypeId { get; set; }

        public User User { get; set; }
        public string UserId { get; set; }
    }
}
