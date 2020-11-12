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

    public class IndexModel : PageModel

    {

        private readonly IPrimeNumberVmService _service;



        public IndexModel(IPrimeNumberVmService service)

        {

            _service = service;

        }



        public IList<PrimeNumberWebApp.Models.PrimeNumber> Items { get; set; }



        public async Task OnGetAsync()

        {

            Items = (await _service.GetPrimeNumbers());

        }

    }

}

