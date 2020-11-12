using System;

using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;

using System.Linq;

using System.Threading.Tasks;



namespace PrimeNumberSrvApi.Models

{

    public class PrimeNumber

    {

        [Key]

        [Required]

        public long Id { get; set; }

        [Required]

        public long Index { get; set; }

        [Required]

        public long PrimeValue { get; set; }

    }

}

