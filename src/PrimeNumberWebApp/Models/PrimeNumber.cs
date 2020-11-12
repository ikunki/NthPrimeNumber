using System.ComponentModel.DataAnnotations;



namespace PrimeNumberWebApp.Models

{

    public class PrimeNumber

    {

        public long Id { get; set; }

        [Required]

        [Range(1, 100)]

        public long Index { get; set; }

        public long PrimeValue { get; set; }

    }

}

