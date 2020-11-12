using Microsoft.EntityFrameworkCore;



namespace PrimeNumberSrvApi.Models

{

    public class DataContext : DbContext

    {

        public DataContext()

            : base()

        { }



        public DataContext(DbContextOptions<DataContext> options)

            : base(options)

        { }



        public DbSet<PrimeNumber> PrimeNumber { get; set; }

    }

}

/*

"DefaultConnection": "Server=.\\SQLEXPRESS;Database=PrimeNumbers;Trusted_Connection=True;MultipleActiveResultSets=true",

"DefaultConnection": "Data Source=PrimeNumbers.db"

*/
