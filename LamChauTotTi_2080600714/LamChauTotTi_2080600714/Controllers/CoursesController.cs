using LamChauTotTi_2080600714.Models;
using LamChauTotTi_2080600714.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LamChauTotTi_2080600714.Controllers
{
    public class CoursesController : Controller
    {
        //
        private readonly ApplicationDbContext _dbContext;
        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        public ActionResult Create()
        {
            var viewModel = new CourseViewModel
            {
                Categories = _dbContext.Category.ToList()
            };
            return View(viewModel);
        }
    }
}