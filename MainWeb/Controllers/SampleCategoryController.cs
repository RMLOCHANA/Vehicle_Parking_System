using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Common;
using HRIS.Sample.Models;
using HRIS.Sample.Repository;

namespace MainWeb.Controllers
{
    public class SampleCategoryController : Controller
    {
        #region Construction

        private readonly ISampleCategoryData SampleCategories;

        public SampleCategoryController(ISampleCategoryData SampleCategories)
        {
            this.SampleCategories = SampleCategories;
        }

        #endregion


        public async Task<IActionResult> Index(string KeyW = "")
        {
            var obj = new SampleCategorySearchView();
            obj.APIKey = AppData.GetAPIKey();
            obj.KeyW = KeyW;
            obj.RecordCount = await SampleCategories.GetCount
                                (
                                    APIKey: AppData.GetAPIKey(),
                                    KeyW: KeyW.ToBlank()
                                );
            obj.PaginationList = AppData.GetPaginationList(obj.RecordCount, obj.PageSize);

            return View(obj);
        }

        public IActionResult Add()
        {
            var obj = new SampleCategory();

            try
            {
                obj.ReturnURL = Request.Headers["Referer"].ToString();
            }
            catch { }

            return View(obj);
        }

        [HttpPost]
        public async Task<IActionResult> Add(SampleCategory obj)
        {

            try
            {
                obj.CategoryID = "";
                obj.CategoryID = await SampleCategories.Save
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
            var obj = await SampleCategories.Get(AppData.GetAPIKey(), id);

            try
            {
                obj.ReturnURL = Request.Headers["Referer"].ToString();
            }
            catch { }

            return View(obj);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(SampleCategory obj)
        {
            try
            {
                obj.CategoryID = await SampleCategories.Save
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

            var objList = await SampleCategories.GetList
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

                var RetValue = await SampleCategories.Delete
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
