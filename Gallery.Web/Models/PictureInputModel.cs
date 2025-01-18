using Gallery.Data.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gallery.Web.Models
{
    public class PictureInputModel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(10000)]
        public string Url { get; set; }

        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile PictureFile { get; set; }

        [Required]
        [MaxLength(255)]
        [DisplayName("Picture Name")]
        public string Name { get; set; }

        [Required]
        [MaxLength(10000)]
        public string Description { get; set; }
        public int ArtTypeId { get; set; }
        public string UserId { get; set; }
    }
}
