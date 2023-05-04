using HRIS.Sample.Repository;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Threading.Tasks;

namespace DropDown
{
    public interface ISampleDDL
    {
        Task<SelectList> SampleCategoryList();
    }
}