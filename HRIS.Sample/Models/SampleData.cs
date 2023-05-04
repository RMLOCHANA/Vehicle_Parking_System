using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Common;

namespace HRIS.Sample.Models
{
    public class SampleData
    {
        #region Data

        [Key]
        [Display(Name = "ID")]
        public string DataID { get; set; }

        [Required(ErrorMessage = "Category is required")]
        [Display(Name = "Category")]
        public string CategoryID { get; set; }

        [Required(ErrorMessage = "Data name is required")]
        [Display(Name = "Data Name")]
        public string DataName { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [Required(ErrorMessage = "Joined date is required")]
        [Display(Name = "Joined Date")]
        public DateTime? JoinedDate { get; set; }

        [Required(ErrorMessage = "Cost is required")]
        [Display(Name = "Cost")]
        public double? DataCost { get; set; }

        [Display(Name = "Description")]
        public string DataDescription { get; set; } = "";

        [Required(ErrorMessage = "Status is required")]
        [Display(Name = "Status")]
        public string ActiveStatus { get; set; } = "A";

        #endregion


        #region Supporting

        [Display(Name = "Category")]
        public string CategoryName { get; set; }

        public string ReturnURL { get; set; } = "/SampleCategory/Index";

        #endregion


        #region Display

        [Display(Name = "Joined Date")]
        public string JoinedDateDisplay
        {
            get
            {
                return JoinedDate.Value.ToShortDateString();
            }
        }

        [Display(Name = "Cost")]
        public string DataCostDisplay 
        { 
            get 
            {
                return DataCost.Value.ToCurrency();
            }
        }

        [Display(Name = "Status")]
        public bool ActiveStatusBool
        {
            get
            {
                return ActiveStatus == "A";
            }

            set
            {
                this.ActiveStatus = value ? "A" : "I";
            }
        }

        [Display(Name = "Status")]
        public string ActiveStatusText
        {
            get
            {
                string retVal = "";
                switch (ActiveStatus)
                {
                    case "A":
                        retVal = "Active";
                        break;

                    case "I":
                        retVal = "Inactive";
                        break;

                    default:
                        retVal = ActiveStatus;
                        break;
                }
                return retVal;
            }
        }

        public string ActiveStatusClass
        {
            get
            {
                string retVal = "";
                switch (ActiveStatus)
                {
                    case "A":
                        retVal = "success";
                        break;

                    case "I":
                        retVal = "danger";
                        break;

                    default:
                        retVal = "";
                        break;
                }
                return retVal;
            }
        }

        #endregion

    }

    public class SampleDataSearchView
    {
        public string APIKey { get; set; }
        public string KeyW { get; set; } = "";
        public string CategoryID { get; set; } = "";
        public string ActiveStatus { get; set; } = "";

        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 15;

        public int RecordCount { get; set; } = 0;

        public List<SampleCategory> DataList = new List<SampleCategory>();
        public List<int> PaginationList = new List<int>();
    }
}
