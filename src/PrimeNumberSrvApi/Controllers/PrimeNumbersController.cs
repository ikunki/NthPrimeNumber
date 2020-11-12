using System;

using System.Collections.Generic;

using System.Linq;

using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;

using Microsoft.AspNetCore.Mvc;

using Microsoft.EntityFrameworkCore;

using PrimeNumberSrvApi.Models;

using PrimeNumberSrvApi.Helpers;



namespace PrimeNumberSrvApi.Controllers

{

    [Route("api/[controller]")]

    [ApiController]

    public class PrimeNumbersController : ControllerBase

    {

        private readonly DataContext _context;



        public PrimeNumbersController(DataContext context)

        {

            _context = context;

        }



        // GET: api/PrimeNumbers

        [HttpGet]

        public async Task<ActionResult<IEnumerable<PrimeNumber>>> GetPrimeNumber()

        {

            return await _context.PrimeNumber.ToListAsync();

        }



        // GET: api/PrimeNumbers/5

        [HttpGet("{nth}")]

        public async Task<ActionResult<PrimeNumber>> GetPrimeNumber(long nth)

        {

            var primeNumber = await _context.PrimeNumber.FindAsync(nth);

            if (primeNumber == null)

            {

                PrimeNumber primeNumberItem = new PrimeNumber();

                primeNumberItem.Index = nth;

                return await SaveNthPrimeNumberItem(primeNumberItem);

            }

            return primeNumber;

        }



        // POST: api/PrimeNumbers

        // To protect from overposting attacks, enable the specific properties you want to bind to, for

        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.

        [HttpPost]

        public async Task<ActionResult<PrimeNumber>> PostPrimeNumber(PrimeNumber primeNumber)

        {

            PrimeNumber primeNumberItem = await SaveNthPrimeNumberItem(primeNumber);

            return primeNumberItem;

        }



        private async Task<PrimeNumber> SaveNthPrimeNumberItem(PrimeNumber primeNumber)

        {

            PrimeNumber primeNumberItem = await GetNthPrimeNumberItem(primeNumber.Index);

            if (primeNumberItem == null)

            {

                primeNumber.PrimeValue = NthPrime.GetPrime(primeNumber.Index);

                _context.PrimeNumber.Add(primeNumber);

                await _context.SaveChangesAsync();

                return primeNumber;

            }

            return primeNumberItem;

        }



        private async Task<PrimeNumber> GetNthPrimeNumberItem(long nth)

        {

            PrimeNumber primeNumberItem = await _context.PrimeNumber.FindAsync(nth);

            return primeNumberItem;

        }

    }

}

