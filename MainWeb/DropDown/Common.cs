using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRIS.Sample.Models;
using HRIS.Sample.Repository;

// Helps to generate drop down lists (select lists)

namespace DropDown
{
    public class Common : ICommon
    {
        public SelectList ActiveStatusList()
        {
            var objList = new List<_DDLItem>();

            objList.Add(new _DDLItem("A", "Active"));
            objList.Add(new _DDLItem("I", "Inactive"));

            return new SelectList(objList, "Value", "Text");
        }

        public SelectList StatusList()
        {
            var objList = new List<_DDLItem>();

            objList.Add(new _DDLItem("P", "Pending"));
            objList.Add(new _DDLItem("SNA", "slot not available"));
            objList.Add(new _DDLItem("SA", "Slot allocated"));
            objList.Add(new _DDLItem("C", "Completed"));

            return new SelectList(objList, "Value", "Text");
        }

        public SelectList SlotList()
        {
            var objList = new List<_DDLItem>();

            objList.Add(new _DDLItem("P", "ST01"));
            objList.Add(new _DDLItem("SNA", "ST02"));
            objList.Add(new _DDLItem("SA", "ST03"));
            objList.Add(new _DDLItem("C", "ST04"));

            return new SelectList(objList, "Value", "Text");
        }
    }
}

