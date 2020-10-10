using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;   
using webtestmysql.Data;
using webtestmysql.Models;
using System.Threading.Tasks;

namespace webtestmysql.Pages.Index
{

    public class IndexModel : PageModel
    {

        private readonly Cars_DbContext _context;

        public IndexModel(Cars_DbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

       
        [BindProperty]
        public Cars Cars { get; set; }

                public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

           
            _context.cars.Add(Cars);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }

}