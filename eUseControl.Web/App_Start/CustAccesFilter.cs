using eUseControl.BusinessLogic.Interfaces;
using eUseControl.Web.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eUseControl.Web.App_Start
{
     public class CustAccesFilter
     {
     }

     public class AdminModAttribute : ActionFilterAttribute
     {
          private readonly ISession _sessionBL;

          public AdminModAttribute()
          {
               var businessLogic = new BusinessLogic.InstanceBL();
               _sessionBL = businessLogic.GetSessionBL();
          }

          public override void OnActionExecuting(ActionExecutingContext filterContext)
          {
               var adminSession = HttpContext.Current.GetMySessionObject();
               if(adminSession == null)
               {
                    var cookie = HttpContext.Current.Request.Cookies["X-KEY"];
                    if(cookie!=null)
                    {
                         var profile = _sessionBL.GetUserByCookie(cookie.Value);
                         if(profile != null && profile.Level == Domain.Enums.URole.Admin)
                         {
                              HttpContext.Current.SetMySessionObject(profile);
                         }
                         else
                         {
                              filterContext.Result = new RedirectToRouteResult(new
                                   System.Web.Routing.RouteValueDictionary(new { controller = "Error", action = "Error404" }));
                         }
                    }
               }
               else
               {
                    if(adminSession.Level !=Domain.Enums.URole.Admin)
                    {
                         filterContext.Result = new RedirectToRouteResult(new
                                                            System.Web.Routing.RouteValueDictionary(new { controller = "Error", action = "Error404" }));
                    }
               }
          }
     }
}