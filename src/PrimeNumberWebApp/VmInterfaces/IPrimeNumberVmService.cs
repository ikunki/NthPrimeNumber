using PrimeNumberWebApp.Models;

using System;

using System.Collections.Generic;

using System.Linq;

using System.Threading.Tasks;



namespace PrimeNumberWebApp.VmInterfaces

{

    public interface IPrimeNumberVmService

    {

        Task<List<PrimeNumber>> GetPrimeNumbers();

        Task<PrimeNumber> GetPrimeNumber(long Id);

        Task<string> AddPrimeNumber(PrimeNumber PrimeNumber);

    }

}

