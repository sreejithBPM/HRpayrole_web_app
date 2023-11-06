using HRPayrole.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HRPayrole.Pages
{
    public class PayroleModel : PageModel
    {
        public List<PayRoleRecord> PayRoleRecords { get; set; }
        public void OnGet(int payId)
        {
            PayRoleRecords = new GetPayRoleRecord().PayRoleRecord();
        }
        public PartialViewResult OnGetFetchPays(int payId)
        {
            PayRoleRecords = new GetPayRoleRecord().PayRoleRecord();
            return Partial("_PayRolePartial", PayRoleRecords.Where(x => x.PayId == payId).FirstOrDefault());
        }
    }
}
