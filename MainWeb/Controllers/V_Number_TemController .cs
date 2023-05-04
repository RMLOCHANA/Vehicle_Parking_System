using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Common;
using HRIS.Sample.Models;
using HRIS.Sample.Repository;

namespace MainWeb.Controllers
{
    public class V_Number_TemController : Controller
    {
        #region Construction

        private readonly IV_Number_TempData v_Number_TempData;

        public V_Number_TemController(IV_Number_TempData v_Number_TempData)
        {
            this.v_Number_TempData = v_Number_TempData;
        }

        #endregion


        public async Task<IActionResult> Index(string KeyW = "")
        {
            var obj = new V_Number_TempSearchView();
            obj.APIKey = AppData.GetAPIKey();
            obj.KeyW = KeyW;
            obj.RecordCount = await v_Number_TempData.GetCount
                                (
                                    APIKey: AppData.GetAPIKey(),
                                    KeyW: KeyW.ToBlank()
                                );
            obj.PaginationList = AppData.GetPaginationList(obj.RecordCount, obj.PageSize);

            return View(obj);
        }

        public IActionResult Add()
        {
            var obj = new V_Number_Temp();

            try
            {
                obj.ReturnURL = Request.Headers["Referer"].ToString();
            }
            catch { }

            return View(obj);
        }

        [HttpPost]
        public async Task<IActionResult> Add(V_Number_Temp obj)
        {

            try
            {
                obj.Id = "";
                obj.Id = await v_Number_TempData.Save
                                    (
                                       APIKey: AppData.GetAPIKey(),
                                       obj:obj, 
                                       LogUserID:""
                                    );

                return Redirect(obj.ReturnURL);
            }
            catch (Exception ex)
            {
                ViewData["ErrorMessage"] = "Unable to save record. " + ex.Message;
            }

            return View(obj);
        }

        public async Task<IActionResult> Edit(string id)
        {
            var obj = await v_Number_TempData.Get(AppData.GetAPIKey(), id);

            try
            {
                obj.ReturnURL = Request.Headers["Referer"].ToString();
            }
            catch { }

            return View(obj);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(V_Number_Temp obj)
        {
            try
            {
                obj.Id = await v_Number_TempData.Save
                                    (
                                       APIKey: AppData.GetAPIKey(),
                                       obj: obj,
                                       LogUserID: ""
                                    );

                return Redirect(obj.ReturnURL);
            }
            catch (Exception ex)
            {
                ViewData["ErrorMessage"] = "Unable to save record. " + ex.Message;
            }

            return View(obj);
        }



        // Partial

        public async Task<ActionResult> _MainList(string KeyW = "", int Page = 1, int PageSize = 99999)
        {
            Auth.CheckUserPartial();

            var objList = await v_Number_TempData.GetList
                            (
                                APIKey: AppData.GetAPIKey(),
                                KeyW: KeyW.ToBlank(),
                                Page: Page,
                                PageSize: PageSize
                            );

            return View(objList);
        }


        // JSon

        public async Task<JsonResult> Delete(string id)
        {
            try
            {
                if (id == null || id == "")
                {
                    return Json(new { success = false, responseText = "Invalid request or bad parameters" });
                }

                //var emp = (Employee)Session["Employee"];

                var RetValue = await v_Number_TempData.Delete
                                (
                                    APIKey: AppData.GetAPIKey(),
                                    ID: id,
                                    LogUserID: ""
                                );

                return Json(new { success = true, responseText = "Deleted successfully" });
            }
            catch (Exception ex)
            {
                while (ex.InnerException != null)
                {
                    ex = ex.InnerException;
                }
                return Json(new { success = false, responseText = "Unable to delete record. " + ex.Message });
            }
        }
    }
}
