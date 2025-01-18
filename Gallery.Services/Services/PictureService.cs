using Gallery.Data;
using Gallery.Data.Models;
using Gallery.Services.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallery.Services.Services
{
    public class PictureServices : IPictureService
    {
        private GalleryDbContext context;

        public PictureServices(GalleryDbContext context)
            => this.context = context;

        public void CreatePicture(Picture model)
        {
            this.context.Pictures.Add(model);
            this.context.SaveChanges();
        }

        public ICollection<Picture> Listing()
        {
            throw new NotImplementedException();
        }
    }
}
