using System;

using System.Collections.Generic;

using System.Linq;

using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Mvc.RazorPages;

using PrimeNumberWebApp.Models;

using PrimeNumberWebApp.VmInterfaces;



namespace PrimeNumberWebApp.Pages.PrimeNumber

{

    public class DetailsModel : PageModel

    {

        private readonly IPrimeNumberVmService _service;



        public DetailsModel(IPrimeNumberVmService service)

        {

            _service = service;

        }



        public IActionResult OnGet()

        {

            return Page();

        }



        [BindProperty]

        public PrimeNumberWebApp.Models.PrimeNumber Item { get; set; }



        public async Task<IActionResult> OnPostAsync()

        {

            if (!ModelState.IsValid)

            {

                return Page();

            }

            await _service.AddPrimeNumber(Item);

            return RedirectToPage("./Index");

        }

    }

}

/*

        public async Task<IActionResult> OnGetAsync(long? nth)

        {

            if (nth == null)

            {

                return NotFound();

            }

            Item = await _service.GetPrimeNumber(nth.Value);

            if (Item == null)

            {

                return NotFound();

            }

            return RedirectToPage("./Index");

        }

*/
