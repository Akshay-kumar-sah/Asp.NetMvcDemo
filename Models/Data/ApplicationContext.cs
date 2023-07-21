using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Asp.NetMvcDemo.Models.Data
{
    public class ApplicationContext : DbContext
    {
        
      public ApplicationContext(DbContextOptions<ApplicationContext>options)
      :base(options)
      {
        
      }

      public DbSet<Employee>Employees{get;set;}

    }
}