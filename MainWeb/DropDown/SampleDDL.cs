using Microsoft.AspNetCore.Mvc.Rendering;
using System.Threading.Tasks;
using HRIS.Sample.Repository;

// Helps to generate drop down lists (select lists)

namespace DropDown
{
    public class SampleDDL : ISampleDDL
    {
        #region Constructions

        private readonly ISampleCategoryData SampleCategories;
        
        public SampleDDL(ISampleCategoryData SampleCategories)
        {
            this.SampleCategories = SampleCategories;
        }

        #endregion

        public async Task<SelectList> SampleCategoryList()
        {
            var objList = await SampleCategories.GetList(AppData.GetAPIKey());
            return objList.ToSelectList("CategoryID", "CategoryName");
        }
    }
}

