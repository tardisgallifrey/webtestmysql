using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;   
using System.Collections.Generic;           //Needed for IList<T> type
using Microsoft.EntityFrameworkCore;        //Needed for ToLIstAsync() Method


namespace webtestmysql.Pages.Another.Different
{
    public class DifferentModel : PageModel
    {

        //Remember, a simple OnGet() to return this page is an IActionResult type
        public IActionResult OnGet()
        {
            return Page();
        }
    }
}