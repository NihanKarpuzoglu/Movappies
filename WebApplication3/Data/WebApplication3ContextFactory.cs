using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Data
{
    public class WebApplication3ContextFactory: IDesignTimeDbContextFactory<WebApplication3Context>
    {
        public WebApplication3Context CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<WebApplication3Context>();
            optionsBuilder.UseSqlServer("Data Source=WebApplication3Context.db");

            return new WebApplication3Context(optionsBuilder.Options);
        }
    }
}
