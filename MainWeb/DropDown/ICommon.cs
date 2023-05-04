using Microsoft.AspNetCore.Mvc.Rendering;

namespace DropDown
{
    public interface ICommon
    {
        SelectList ActiveStatusList();

        SelectList StatusList();
        SelectList SlotList();
    }
}