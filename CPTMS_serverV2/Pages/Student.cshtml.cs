using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CPTMS_serverV2.Pages
{
    [Authorize(Roles = "Student")]
    public class StudentModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
