﻿using MVCCodeFirst_TrainingAcademySln.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCodeFirst_TrainingAcademySln.Controllers
{
    public class TrainingController : Controller
    {
        ApplicationDbContext dbobj = new ApplicationDbContext();
        // GET: Training
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CreateTrainingAjax()
        {
            var Model = dbobj.Trainings.ToList();
            return View(Model);
        }
        public ActionResult TrainingAjaxFormExample(Training obj)
        {

            dbobj.Trainings.Add(obj);
            dbobj.SaveChanges();
            IEnumerable<Training> list = dbobj.Trainings.ToList();
            return PartialView(list);
        }
    }
}