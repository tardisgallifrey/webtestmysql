using Microsoft.EntityFrameworkCore;
using webtestmysql.Models;

namespace webtestmysql.Data
{
    public class Cars_DbContext : DbContext
    {
        public Cars_DbContext(DbContextOptions<Cars_DbContext> options)
        :base(options)
        { }

      //What this says:
      // Create a DbSet (database result set) that is public in scope
      //Use the model type of "Cars" and it has a public getter and setter
      //
      // Name it 'cars'
      // This name will be used in the PageModel class to reference
      // The result set from this database context.
      //
      // The name 'cars' must match exactly the tablename in our database, even for case.
      // In this example, our database vehicles has a table cars.  Cars will cause an error 
      // when you run the query/save.
        public DbSet<Cars> cars { get; set; }
    
    }
}