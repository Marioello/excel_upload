using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly SqlCommand cmd = new SqlCommand();
        private readonly SqlConnection dbConnection = new SqlConnection();

        public ActionResult Index()
        {
            if (Session["USER"] != null)
            {
                return RedirectToAction("Index", "Upload");
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult Login()
        {
            return View();
        }

        // POST: Authentication/Create
        [HttpPost]
        public ActionResult Login(User user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    cmd.Connection = dbConnection;
                    cmd.Connection.Open();
                    cmd.CommandText = string.Format("SELECT 1 FROM user WHERE email = {0} AND password = {1}", user.Email, user.Password);

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (!dr.HasRows)
                    {
                        return RedirectToAction("Register");
                    }
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                return View();
            }

            return RedirectToAction("Index");
        }

        public ActionResult Register()
        {
            return View();
        }
    }
}