using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eUseControl.BusinessLogic.DBModel;
using eUseControl.BusinessLogic.Interfaces;
using eUseControl.Domain.Entites.User;
using eUseControl.Domain.Entities.User;
using eUseControl.Web.Extension;
using eUseControl.Web.Models;
using eUseControl.BusinessLogic;
using System.Data.Entity;
using System.Data;
using System.IO;

namespace eUseControl.Web.Controllers
{
     public class HomeController : BaseController
     {
          public ActionResult Index()
          {
               SessionStatus();
               if ((string)System.Web.HttpContext.Current.Session["LoginStatus"] == "login")
               {
                    //var players = db.New.Include(m=>m.Data);
                    return View();
               }
               return RedirectToAction("Index", "Login");
          }
          public ActionResult About()
          {
               return View();
          }

          public ActionResult Error404()
          {
               return View();
          }

          public ActionResult FAQ()
          {
               return View();
          }

          public ActionResult Top100()
          {
               using (TopuriContext dbModel = new TopuriContext())
               {
                    return View(dbModel.Topuri.ToList());
               }
          }
          
          public ActionResult Vizual(int id)
          {
               using (TopuriContext dbModel = new TopuriContext())
               {
                    return View(dbModel.Topuri.Where(x => x.Id == id).FirstOrDefault());
               }
          }
     }
}