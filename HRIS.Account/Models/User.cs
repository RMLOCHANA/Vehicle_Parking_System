using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HRIS.Account.Models
{
    public class User
    {
        #region Data

        [Key]
        [Display(Name = "ID")]
        public string UserID { get; set; }

        [Required(ErrorMessage = "Username is required")]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is required")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Display name is required")]
        [Display(Name = "Display Name")]
        public string DisplayName { get; set; }

        [Display(Name = "Role Mode")]
        public string RoleMode { get; set; } = "R";

        [Required(ErrorMessage = "Status is required")]
        [Display(Name = "Status")]
        public string ActiveStatus { get; set; } = "A";

        #endregion


        #region Supporting

        public string ReturnURL { get; set; } = "/User/Index";

        #endregion


        #region Display

        
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

    public class UserSearchView
    {
        public string APIKey { get; set; }
        public string KeyW { get; set; } = "";
        public string CategoryID { get; set; } = "";
        public string ActiveStatus { get; set; } = "";

        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 15;

        public int RecordCount { get; set; } = 0;

        public List<int> PaginationList = new List<int>();
    }
}
