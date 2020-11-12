using System;

using System.Collections.Generic;

using System.Linq;

using System.Threading.Tasks;

using PrimeNumberWebApp.Models;

using PrimeNumberWebApp.VmInterfaces;

using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Mvc.RazorPages;



namespace PrimeNumberWebApp.Pages.PrimeNumber

{

    public class CreateModel : PageModel

    {

        private readonly IPrimeNumberVmService _service;



        public CreateModel(IPrimeNumberVmService service)

        {

            _service = service;

        }



        public IActionResult OnGet()

        {

            return Page();

        }



        [BindProperty]

        public PrimeNumberWebApp.Models.PrimeNumber Item { get; set; }



        // To protect from overposting attacks, please enable the specific properties you want to bind to, for

        // more details see https://aka.ms/RazorPagesCRUD.

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

