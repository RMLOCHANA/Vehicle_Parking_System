using MainWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using HRIS.Account.Models;
using HRIS.Account.Repository;
using HRIS.Sample.Models;
using HRIS.Sample.Repository;

namespace MainWeb.Controllers
{
    public class AccountController : Controller
    {
        #region Construction

        private readonly IUserData Users;
        private readonly ICustomerData customerData;
        public AccountController(IUserData Users, ICustomerData customerData)
        {
            this.Users = Users;
            this.customerData = customerData;
        }

        #endregion

        public IActionResult Login(string ReturnURL)
        {
            var obj = new LoginView();
            if (ReturnURL != null)
            {
                obj.ReturnURL = ReturnURL.Replace("(and)", "&");
                ViewData["ErrorMessage"] = "Please login to continue";
            }

            var usr = HttpContext.Session.GetObject<User>("User");

            return View(obj);
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginView obj)
        {
            try
            {
                var usr = await Users.Login(AppData.GetAPIKey(), obj.Username);
                if (usr != null)
                {
                    if (Crypto.Encrypt(obj.Password) != usr.Password)
                    {
                        ViewData["ErrorMessage"] = "Invalid password. Please try again.";
                    }
                    else if (usr.ActiveStatus != "A")
                    {
                        ViewData["ErrorMessage"] = "This user us not active.";
                    }
                    else
                    {
                        HttpContext.Session.SetObject("User", usr);

                        if (obj.ReturnURL != null && obj.ReturnURL != "")
                        {
                            return Redirect(obj.ReturnURL);
                        }
                        else
                        {
                            return RedirectToAction("Index", "Home");
                        }
                    }
                }
                else
                {
                    ViewData["ErrorMessage"] = "Invalid username. Please try again.";
                }
            }
            catch (Exception ex)
            {
                ViewData["ErrorMessage"] = "Unable to login. " + ex.Message;
            }

            return View(obj);
        }

        public IActionResult _Timeout(string ReturnURL)
        {
            ViewData["ReturnURL"] = ReturnURL;
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Account");
        }

        public IActionResult LogoutCus()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("LoginCustomer", "Account");
        }

        public IActionResult LoginCustomer(string ReturnURL)
        {
            var obj = new LoginView();
             

            return View(obj);
        }

        [HttpPost]
        public async Task<IActionResult> LoginCustomer(LoginView obj)
        {
            try
            {
                var usr = await customerData.Login(AppData.GetAPIKey(), obj.Email);
                if (usr != null)
                {
                    if (obj.Password != usr.Cus_password)
                    {
                        ViewData["ErrorMessage"] = "Invalid password. Please try again.";
                        return View(obj);
                    }
                
                    else
                    {
                        HttpContext.Session.SetObject("Customer", usr);

                      
                        return RedirectToAction("Index", "Home", new { area = "CustomerBooking" });
                        
                    }
                }
                else
                {
                    ViewData["ErrorMessage"] = "Invalid username. Please try again.";
                }
            }
            catch (Exception ex)
            {
                ViewData["ErrorMessage"] = "Unable to login. " + ex.Message;
            }

            return View(obj);
        }

        public IActionResult Register(string ReturnURL)
        {
            var obj = new Customer();


            return View(obj);
        }

        [HttpPost]
        public async Task<IActionResult> Register(Customer obj)
        {
            try
            {
                obj.Cus_id = "";
                obj.Cus_id = await customerData.Save
                                    (
                                       APIKey: AppData.GetAPIKey(),
                                       obj: obj,
                                       LogUserID: ""
                                    );
                return RedirectToAction("Index", "Home", new { area = "CustomerBooking" });
            }
            catch (Exception ex)
            {
                ViewData["ErrorMessage"] = "Unable to login. " + ex.Message;
            }

            return View(obj);
        }

    }
}
