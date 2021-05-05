using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Agricultural_seedlingsProject.Models;
namespace Agricultural_seedlingsProject.Controllers
{
    public class HomeController : Controller
    {
        GreenEarthcontext Db;
        public HomeController()
        {
            Db = new GreenEarthcontext();
        }
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        #region sign up
        [HttpGet]
        public ActionResult signup()
        {

            return View();
        }
        [HttpPost]
        public ActionResult signup(User u)
        {
            if (ModelState.IsValid)
            {
                if (Db.Users.Any(w => w.Email == u.Email))
                {
                    u.LoginErrorMsg = "This Email Already Exists.";
                    return View("signup", u);

                }
                else
                {
                    Db.Users.Add(u);
                    Db.SaveChanges();
                    Session["log"] = "Log out";

                    var val = Db.Users.Where(ww => ww.Email == u.Email);
                    int id = val.Select(ww => ww.id).First();

                    Session["id"] = id;
                    return RedirectToAction("Products");

                }
            }
            else
            {
                return View("signup");
            }

        }
        #endregion

        #region Login
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User user)
        {
            var userDetails = Db.Users.Where(w => w.Email == user.Email && w.Password == user.Password).FirstOrDefault();
            if (userDetails == null)
            {
                Session["log"] = "Log In";

                Session["id"] = null;
                user.LoginErrorMsg = "Invalid Email or Password";
                return View("Login", user);
            }
            Session["log"] = "Log out";

            Session["id"] = userDetails.id;
            return RedirectToAction("Products");
        }
        #endregion

        #region Contact Us
        [HttpGet]
        public ActionResult ContactUs()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ContactUs(Contactus contactus)
        {

            if (ModelState.IsValid)
            {
                Db.GetContactus.Add(contactus);
                Db.SaveChanges();
                contactus.ContacterrorMsg = "Message delivered";
                return RedirectToAction("ContactUs", contactus);
            }
            else
            {
                contactus.ContacterrorMsg = "  The message has not been received";


                return View("ContactUs", contactus);
            }
        }

        #endregion

        #region Logout
        public ActionResult Logout()
        {
            Session["id"] = null;
            Session["log"] = null;
            /////
            return RedirectToAction("Index");
        }
        #endregion

        #region Aboutus
        public ActionResult IAboutus()
        {
            return View();
        }
        //
        #endregion

        #region  Products
        public ActionResult Products()
        {
            if (Session["id"] == null)
            {
                return View("Login");
            }
            else
            {
                return View();
            }
        }
        #endregion

        
        #region fruit
        public ActionResult fruit()
        {
            var fruits = Db.Fruits.ToList();
            return View(fruits);
        }
        #endregion

        #region green
        public ActionResult Green()
        {
            var greens = Db.Greens.ToList();
            return View(greens);
        }
        #endregion

        #region  ornamentals
        public ActionResult ornamentals()
        {
            var ornamentals = Db.Ornamentals.ToList();
            return View(ornamentals);
        }
        #endregion


        #region  forests
        public ActionResult forests()
        {
            var forest = Db.Forests.ToList();
            return View(forest);
        }

        #endregion

        #region  checkoutform
        [HttpGet]
        public ActionResult checkoutform(string n, int p, string t)
        {
            if (Session["id"] == null)
            {
                return View("Login");
            }
            else
            {

                var sales = new Sales();
                sales.ProductName = n;
                sales.Price = p;
                sales.nursaryName = t;

                return View(sales);
            }
        }
        [HttpPost]
        public ActionResult checkoutform(string n, int p, string t, int l = 1)

        {
            if (Session["id"] == null)
            {
                return View("Login");
            }
            else { 
            if (t == "fruit")
            {
                var prod = Db.Fruits.Where(ww => ww.FruitName == n).FirstOrDefault();
                prod.Quantity--;
                    var offer = Db.Offers.Where(ww => ww.ProductName == n).FirstOrDefault();
                    offer.Quantity--;

            }
            else if (t == "green")
            {
                var prod = Db.Greens.Where(ww => ww.GreenName == n).FirstOrDefault();
                prod.Quantity--;
                    var offer = Db.Offers.Where(ww => ww.ProductName == n).FirstOrDefault();
                    offer.Quantity--;

                }
            else if (t == "ornamentals")
            {
                var prod = Db.Ornamentals.Where(ww => ww.OrnamentalName == n).FirstOrDefault();
                prod.Quantity--;
                    var offer = Db.Offers.Where(ww => ww.ProductName == n).FirstOrDefault();
                    offer.Quantity--;

                }
            else if (t == "forests")
            {
                var prod = Db.Forests.Where(ww => ww.ForestName == n).FirstOrDefault();
                prod.Quantity--;
                    var offer = Db.Offers.Where(ww => ww.ProductName == n).FirstOrDefault();
                    offer.Quantity--;

                }
            
                //
                string userid = Session["id"].ToString();

            var sales = new Sales();
            sales.ProductName = n;
            sales.Price = p;
            sales.nursaryName = t;
            sales.Reservation_Date = DateTime.Now;
            sales.User_Id = int.Parse(userid);
            Db.GetSales.Add(sales);
            Db.SaveChanges();




            return RedirectToAction("Products");
        } }
        #endregion

        #region  volunteer

        [HttpGet]
        public ActionResult volunteer()
        {
            Volunter v = new Volunter();
            v.volunteerErrorMsg = "";
            return View(v);
        }
        [HttpPost]
        public ActionResult volunteer( Volunter volunter)
        {
            Volunter v = new Volunter();
            if (ModelState.IsValid)
            {
                Db.Volunters.Add(volunter);
                Db.SaveChanges();
                volunter.volunteerErrorMsg = "Done";
              
                v.volunteerErrorMsg = "Done";
                return View(v);

            }
            else
            {
                v.volunteerErrorMsg = "";
                return View("volunteer",v);
            }
           
        }

        #endregion

        #region offer
        public ActionResult offer()
        {
            if (Session["id"] == null)
            {
                return View("Login");
            }
            else
            {
                var offers = Db.Offers.ToList();
                return View(offers);
            }
        }
        #endregion
        //

    }
}