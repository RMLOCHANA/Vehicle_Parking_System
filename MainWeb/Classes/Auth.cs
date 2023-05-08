using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRIS.Account.Models;
using Microsoft.AspNetCore.Http;
using HRIS.Sample.Models;

public class Auth
{
    public static void CheckUser(string AccessCode = "")
    {
        IHttpContextAccessor _context = new HttpContextAccessor();
        if (_context.HttpContext.Session.GetObject<User>("User") == null)
        {
            var refUrl = _context.HttpContext.Request.GetTypedHeaders().Referer;
            string ReturnURL = refUrl != null ? refUrl.ToString() : "";
            string AbsoluteURL = _context.HttpContext.Request.Path.ToString();
            if (AbsoluteURL == null) ReturnURL = "";
            if (AbsoluteURL == "/") ReturnURL = "";
            if (AbsoluteURL.ToLower().Contains("add")) ReturnURL = "";
            if (AbsoluteURL.ToLower().Contains("edit")) ReturnURL = "";
            if (AbsoluteURL.ToLower().Contains("login")) ReturnURL = "";

            if (ReturnURL != "")
            {
                ReturnURL = ReturnURL.Replace("&", "(and)");
                _context.HttpContext.Response.Redirect("/Account/Login?ReturnURL=" + ReturnURL);
            }
            else
            {
                _context.HttpContext.Response.Redirect("/Account/Login");
            }

        }
    }

    public static void CheckUserPartial(string AccessCode = "")
    {
        IHttpContextAccessor _context = new HttpContextAccessor();
        if (_context.HttpContext.Session.GetObject<User>("User") == null)
        {
            _context.HttpContext.Response.Redirect("/Account/_Timeout");
        }
    }


    public static void Checkcus(string AccessCode = "")
    {
        IHttpContextAccessor _context = new HttpContextAccessor();
        if (_context.HttpContext.Session.GetObject<Customer>("Customer") == null)
        {
            var refUrl = _context.HttpContext.Request.GetTypedHeaders().Referer;
            string ReturnURL = refUrl != null ? refUrl.ToString() : "";
            string AbsoluteURL = _context.HttpContext.Request.Path.ToString();
            if (AbsoluteURL == null) ReturnURL = "";
            if (AbsoluteURL == "/") ReturnURL = "";
            if (AbsoluteURL.ToLower().Contains("add")) ReturnURL = "";
            if (AbsoluteURL.ToLower().Contains("edit")) ReturnURL = "";
            if (AbsoluteURL.ToLower().Contains("login")) ReturnURL = "";

            
          
                _context.HttpContext.Response.Redirect("/Account/LoginCustomer");
           

        }
    }

    public static void CheckUsercusPartial(string AccessCode = "")
    {
        IHttpContextAccessor _context = new HttpContextAccessor();
        if (_context.HttpContext.Session.GetObject<Customer>("Customer") == null)
        {
            _context.HttpContext.Response.Redirect("/Account/_Timeout");
        }
    }
}

