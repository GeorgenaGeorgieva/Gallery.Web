using Gallery.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallery.Services.Services.Contracts
{
    public interface IPictureService
    {
        void CreatePicture(Picture model);
        ICollection<Picture> Listing();
    }
}
