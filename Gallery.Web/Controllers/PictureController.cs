using AutoMapper;
using Couchbase.Management.Users;
using Gallery.Data.Models;
using Gallery.Services.Services.Contracts;
using Gallery.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Gallery.Web.Controllers
{
    public class PictureController : Controller
    {
        private IPictureService services;
        private IMapper mapper;
        private readonly UserManager<IdentityUser> userManager;

        public PictureController(IPictureService services,
            IMapper mapper,
            UserManager<IdentityUser> userManager)
        {
            this.services = services;
            this.mapper = mapper;
            this.userManager = userManager;
        }
            

        // GET: PictureController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PictureController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PictureController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PictureController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PictureInputModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            var userId = this.userManager.GetUserId(this.HttpContext.User);
            var pictureModel = this.mapper.Map<Picture>(model);
            pictureModel.UserId = userId;                //TODO: validate if userId is null
                                                         //TODO: create method arttype

            this.services.CreatePicture(pictureModel);

            return this.RedirectToAction("All", "Recipes");
        }

        // GET: PictureController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PictureController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PictureController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PictureController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
