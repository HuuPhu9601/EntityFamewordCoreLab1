using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataCodeFirst.Context
{
    public class Lab1DbContextFatory : IDesignTimeDbContextFactory<Lab1DBContext>
    {
        public Lab1DBContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json").Build();

            var connectionString = configuration.GetConnectionString("lab1conections");

            var optionsBuilder = new DbContextOptionsBuilder<Lab1DBContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new Lab1DBContext(optionsBuilder.Options);
        }
    }
}
