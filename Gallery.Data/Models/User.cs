using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallery.Data.Models
{
    public class User : IdentityUser
    {
        public User()
        {
            this.Picturies = new List<Picture>();
            this.Favorites = new List<int>();
        }

        [Required]
        [EmailAddress]
        [MaxLength(255)]
        public override string Email { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name {  get; set; }

        [Required]
        [MaxLength(10000)]
        public string Description { get; set; }
        public Image Image { get; set; }
        public ICollection<int> Favorites { get; set; }
        public ICollection<Picture> Picturies { get; set; }
    }
}
