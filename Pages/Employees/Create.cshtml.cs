using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmployeesApp.Pages.Employees
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public string Name { get; set; }

        [BindProperty]
        public int Age { get; set; }

        [BindProperty]
        public string AccountNumber { get; set; }

        public void OnPost()
        {
            ViewData["Created"] = true;
        }
    }
}
