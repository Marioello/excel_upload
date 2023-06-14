using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string ValidationSummary = "")
        {
            if (Session["USER"] != null)
            {
                return RedirectToAction("Index", "Upload");
            }
            else
            {
                return RedirectToAction("Login", new { ValidationSummary = ValidationSummary });
            }
        }

        public ActionResult Login(string ValidationSummary = "")
        {
            ViewBag.ValidationSummaryStatus = string.IsNullOrEmpty(ValidationSummary);
            ViewBag.ValidationSummary = ValidationSummary;
            return View();
        }

        [HttpPost]
        public ActionResult Login(User usr)
        {
            SqlConnection dbConnection = new SqlConnection
            {
                ConnectionString = ConfigurationManager.ConnectionStrings["WebApplication"].ConnectionString
            };
            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = dbConnection,
                    CommandText = string.Format("SELECT * FROM [user] WHERE email = '{0}' AND password = '{1}'", usr.Email, usr.Password)
                };
                cmd.Connection.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                User user = null;
                if (dr.HasRows)
                {
                    user = new User();
                    while (dr.Read())
                    {
                        user.Email = dr["email"].ToString();
                        user.Password = dr["password"].ToString();
                    }
                }

                if (user != null)
                {
                    Session["USER"] = user;
                }
                else
                {
                    throw new Exception("User tidak ditemukan. Silahkan mendaftarkan diri");
                }
            }
            catch (Exception ex)
            {
                ViewBag.ValidationSummaryStatus = false;
                ViewBag.ValidationSummary = ex.Message.ToString();
                return View();
            }

            return RedirectToAction("Index");
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(User usr)
        {
            SqlConnection dbConnection = new SqlConnection
            {
                ConnectionString = ConfigurationManager.ConnectionStrings["WebApplication"].ConnectionString
            };
            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = dbConnection,
                    CommandText = string.Format("SELECT * FROM [user] WHERE email = '{0}' AND password = '{1}'", usr.Email, usr.Password)
                };
                cmd.Connection.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                User user = null;
                if (dr.HasRows)
                {
                    user = new User();
                    while (dr.Read())
                    {
                        user.Email = dr["email"].ToString();
                        user.Password = dr["password"].ToString();
                    }
                }

                if (user != null)
                {
                    Session["USER"] = user;
                }
                else
                {
                    throw new Exception("User tidak ditemukan. Silahkan mendaftarkan diri");
                }
            }
            catch (Exception ex)
            {
                ViewBag.ValidationSummaryStatus = false;
                ViewBag.ValidationSummary = ex.Message.ToString();
                return View();
            }

            return RedirectToAction("Index");
        }

        public ActionResult Logout()
        {
            Session.Remove("USER");
            return RedirectToAction("Index", new { ValidationSummary = "Anda berhasil logout" });
        }
    }
}