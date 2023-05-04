using MainWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Common;
using HRIS.Sample.Models;
using HRIS.Sample.Repository;

namespace MainWeb.Controllers
{
    public class SampleDataController : Controller
    {
        #region Construction

        private readonly ISampleDataData SampleDatas;

        public SampleDataController(ISampleDataData SampleDatas)
        {
            this.SampleDatas = SampleDatas;
        }

        #endregion


        public async Task<IActionResult> Index(string KeyW = "", string CategoryID = "", string ActiveStatus = "")
        {

            var obj = new SampleDataSearchView();
            obj.APIKey = AppData.GetAPIKey();
            obj.KeyW = KeyW;
            obj.CategoryID = CategoryID;
            obj.ActiveStatus = ActiveStatus;
            obj.RecordCount = await SampleDatas.GetCount
                                (
                                    APIKey: AppData.GetAPIKey(),
                                    KeyW: KeyW,
                                    CategoryID: CategoryID,
                                    ActiveStatus: ActiveStatus
                                );
            obj.PaginationList = AppData.GetPaginationList(obj.RecordCount, obj.PageSize);

            return View(obj);
        }

        public async Task<IActionResult> Add()
        {
            var obj = new SampleData();

            try
            {
                obj.ReturnURL = Request.Headers["Referer"].ToString();
            }
            catch { }

            return View(obj);
        }

        [HttpPost]
        public async Task<IActionResult> Add(SampleData obj)
        {
            try
            {
                obj.DataID = "";

                obj.DataID = await SampleDatas.Save
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
            var obj = await SampleDatas.Get(AppData.GetAPIKey(), id);

            try
            {
                obj.ReturnURL = Request.Headers["Referer"].ToString();
            }
            catch { }

            return View(obj);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(SampleData obj)
        {
            try
            {
                obj.DataID = await SampleDatas.Save
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

        public async Task<IActionResult> _MainList(string KeyW = "", string CategoryID = "", string ActiveStatus = "", int Page = 1, int PageSize = 99999)
        {
            var objList = await SampleDatas.GetList
                            (
                                APIKey: AppData.GetAPIKey(),
                                KeyW: KeyW.ToBlank(),
                                CategoryID: CategoryID.ToBlank(),
                                ActiveStatus: ActiveStatus.ToBlank(),
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

                var RetValue = await SampleDatas.Delete
                                (
                                    APIKey: AppData.GetAPIKey(),
                                    ID: id,
                                    LogUserID: ""
                                );

                return Json( new { success = true, responseText = "Deleted successfully" });
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
