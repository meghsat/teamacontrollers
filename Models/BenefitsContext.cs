using TeamA.Models;
using Microsoft.EntityFrameworkCore;


namespace TeamA.Models

{

public class BenefitsContext :DbContext

    {

            public BenefitsContext(DbContextOptions<BenefitsContext> options) : base(options)

            {

            }



            public DbSet<Groups> groups { get; set; }
            public DbSet<Admin> admin { get; set; }
            public DbSet<Policy> policies { get; set; }
            public DbSet<BenefitsList> benefitsList { get; set; }
            public DbSet<Benefits> benefits { get; set; }
        }

    }