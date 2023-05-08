using HRIS.Sample.Models;
using HRIS.Sample.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MainWeb.Areas.CustomerBooking.Controllers
{
    [Area("CustomerBooking")]
    public class HomeController : Controller
    {
        #region Construction

        private readonly IV_Number_TempData v_Number_TempData;

        public HomeController(IV_Number_TempData v_Number_TempData)
        {
            this.v_Number_TempData = v_Number_TempData;
        }

        #endregion


        public async Task<IActionResult> Index()
        {
             Auth.Checkcus();
            var obj = new V_Number_Temp();
            obj.DataList  = await v_Number_TempData.GetList
                            (
                                APIKey: AppData.GetAPIKey(),
                                KeyW: "",
                                Page: 1,
                                PageSize: 999999
                            );




            return View(obj);
        }

        [HttpPost]
        public async Task<IActionResult> Add(V_Number_Temp obj)
        {

            try
            {
                obj.Id = "";
                obj.Status = "P";
                obj.Out_Time= new DateTime(2023, 1, 1, 9, 0, 0);
                obj.Id = await v_Number_TempData.Save
                                    (
                                       APIKey: AppData.GetAPIKey(),
                                       obj: obj,
                                       LogUserID: ""
                                    );

                TempData["SuccessMessage"] = "succussfully booked";
                return RedirectToAction("Index", "Home", new { area = "CustomerBooking" });

            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = "Unable to save record. " + ex.Message;
            }

            return RedirectToAction("Index", "Home", new { area = "CustomerBooking" });
        }
    }
}
