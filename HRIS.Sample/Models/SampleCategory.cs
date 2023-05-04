using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HRIS.Sample.Models
{
    public class SampleCategory
    {
        #region Data

        [Key]
        [Display(Name = "ID")]
        public string CategoryID { get; set; }

        [Required(ErrorMessage = "Category name is required")]
        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }

        #endregion


        #region Supporting

        [Display(Name = "Data")]
        public int DataCount { get; set; }

        public string ReturnURL { get; set; } = "/SampleCategory/Index";

        #endregion


        #region Display

        [Display(Name = "Data")]
        public string DataCountDisplay
        {
            get
            {
                var RetValue = "-";
                if (DataCount == 1) RetValue = "1 record";
                if (DataCount > 1) RetValue = DataCount.ToString() + " records";
                return RetValue;
            }
        }

        #endregion

    }

    public class SampleCategorySearchView
    {
        public string APIKey { get; set; }

        public string KeyW { get; set; } = "";

        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 15;

        public int RecordCount { get; set; } = 0;

        public List<SampleCategory> DataList = new List<SampleCategory>();
        public List<int> PaginationList = new List<int>();
    }
}
