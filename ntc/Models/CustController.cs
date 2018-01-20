using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ntc.Models
{
    public class CustController : Controller
    {
        // GET: Cust
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult custdetails()
        {

            Customer c1 = new Customer();
            c1.custid = 1;
            c1.custname = "raj";
            c1.custsal = 1000;
            return View(c1);

        }
        public ActionResult razorpractice()
        {


            return View();
        }

        public ActionResult create()
        {
            return View();

        }
        [HttpPost]
        public ActionResult create(Customer c1)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    return RedirectToAction("Index");
                }
                return View();
            }
            catch
            {
                return View();
            }
        }
    }
}