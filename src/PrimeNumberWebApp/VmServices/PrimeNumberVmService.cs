using System;

using System.Collections.Generic;

using System.Linq;

using System.Threading.Tasks;

using PrimeNumberWebApp.ApiInterfaces;

using PrimeNumberWebApp.Models;

using PrimeNumberWebApp.VmInterfaces;



namespace PrimeNumberWebApp.VmServices

{

    public class PrimeNumberVmService: IPrimeNumberVmService

    {

        private readonly IPrimeNumberApiService _clientApiSrv;



        public PrimeNumberVmService(IPrimeNumberApiService clientApiSrv)

        {

            _clientApiSrv = clientApiSrv;

        }



        public async Task<List<PrimeNumber>> GetPrimeNumbers()

        {

            var items = await _clientApiSrv.GetPrimeNumbers();

            return items;

        }



        public async Task<PrimeNumber> GetPrimeNumber(long Id)

        {

            var item = await _clientApiSrv.GetPrimeNumber(Id);

            return item;

        }



        public async Task<string> AddPrimeNumber(PrimeNumber PrimeNumber)

        {

            var satus = await _clientApiSrv.AddPrimeNumber(PrimeNumber);

            return satus;

        }

    }

}

