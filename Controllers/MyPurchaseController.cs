using CATeam5Solution.Method;
using CATeam5Solution.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CATeam5Solution.Controllers
{
    public class MyPurchaseController : Controller
    {
       private DBContext dbContext;
        public MyPurchaseController(DBContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {
            

            Session session = GetSession();
            if (session == null)
            {
                return RedirectToAction("Index", "Login");
            }

            Guid userid = session.UsersId;
          
            GetMyPurchaseData myPurchaseMaker = new GetMyPurchaseData(userid, dbContext);
            List<MyPurchaseViewModel> myPurchaseViewModels = myPurchaseMaker.MakeMyPurchaseView();
            ViewData["myPurchaseViewModel"] = myPurchaseViewModels;

            return View();
        }     
        
        private Session GetSession()
        {
            if (Request.Cookies["SessionId"] == null)
            {
                return null;
            }

            Guid sessionId = Guid.Parse(Request.Cookies["SessionId"]);
            Session session = dbContext.Session.FirstOrDefault(x =>
                x.Id == sessionId
            );

            return session;
        }
    }
}
