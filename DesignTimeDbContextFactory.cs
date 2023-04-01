using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using GranHotelApi.Data;

namespace GranHotelApi
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<GranHotelContext>
    {
        public GranHotelContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<GranHotelContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            builder.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 25)));

            return new GranHotelContext(builder.Options);
        }
    }
}
