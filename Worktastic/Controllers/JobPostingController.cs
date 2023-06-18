using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Worktastic.Models;

namespace Worktastic.Controllers
{
    public class JobPostingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateEditJobPosting(int id)
        {
            return View();
        }
        public IActionResult CreateEditJob(JobPosting jobPosting, IFormFile file)
        {
            // TODO: write jobposting to db
            return RedirectToAction("Index");
        }
    }
}
