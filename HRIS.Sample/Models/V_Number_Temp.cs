using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HRIS.Sample.Models
{
    public class V_Number_Temp
    {
        #region Data

        [Key]
        [Display(Name = "ID")]
        public string Id { get; set; }

        [Required(ErrorMessage = "Vehicle No. is required")]
        [Display(Name = "Vehicle No. ")]
        public string V_Number { get; set; }

        [Required(ErrorMessage = "Allocate Slot. is required")]
        [Display(Name = "Allocate Slot ")]
        public string Slot { get; set; }

        [Required(ErrorMessage = "In Time is required")]
        [Display(Name = "In Time ")]
        public DateTime In_Time { get; set; }


        [Required(ErrorMessage = "Out Time is required")]
        [Display(Name = "Out Time")]
        public DateTime Out_Time { get; set; }

        [Required(ErrorMessage = "Status is required")]
        [Display(Name = "Status")]
        public string Status { get; set; }

        #endregion


        #region Supporting

         
        public string ReturnURL { get; set; } = "/SampleCategory/Index";

        #endregion


        #region Display
        [Display(Name = "Status")]
        public bool ActiveStatusBool
        {
            get
            {
                return Status == "A";
            }

            set
            {
                this.Status = value ? "A" : "I";
            }
        }

        [Display(Name = "Status")]
        public string ActiveStatusText
        {
            get
            {
                string retVal = "";
                switch (Status)
                {
                    case "P":
                        retVal = "Pending";
                        break;

                    case "SNA":
                        retVal = "Slot Not Available";
                        break;
                    case "C":
                        retVal = "Completed";
                        break;

                    default:
                        retVal = Status;
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
                switch (Status)
                {
                    case "P":
                        retVal = "info";
                        break;

                    case "SNA":
                        retVal = "warning";
                        break;
                    case "C":
                        retVal = "success";
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

    public class V_Number_TempSearchView
    {
        public string APIKey { get; set; }

        public string KeyW { get; set; } = "";

        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 15;

        public int RecordCount { get; set; } = 0;

        public List<V_Number_Temp> DataList = new List<V_Number_Temp>();
        public List<int> PaginationList = new List<int>();
    }
}
