using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pass_Data_View_To_Controller.Models;

namespace Pass_Data_View_To_Controller.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string UsingParameter(string firstName, string lastName)
        {
            return "Using Parameter :- First Name : " + firstName + " Last Name : " + lastName;
        }

        [HttpPost]
        public string UsingRequest()
        {
            string firstName = Request["firstName"];
            string lastName = Request["lastName"];
            return "Using Request :- First Name : " + firstName + " Last Name : " + lastName;
        }

        [HttpPost]
        public string UsingFormCollection( FormCollection form)
        {
            string firstName = form["firstName"];
            string lastName = form["lastName"];
            return "Using Form Collection :- First Name : " + firstName + " Last Name : " + lastName;
        }


        [HttpPost]
        public string UsingStronglyBind(clientModel client)
        {
            return "Using Strongly Bind :- First Name : " + client.firstName + " Last Name : " + client.lastName;
        }
    }
}