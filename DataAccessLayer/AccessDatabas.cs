using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DataAccessLayer;

public class AccessDatabas
{
    public NorthwindContext GetDbContext()
    {
        var builder = new ConfigurationBuilder()
            .AddJsonFile($"appsettings.json", true, true);
        var config = builder.Build();

        var connectionString = config.GetConnectionString("DefaultConnection");

        var options = new DbContextOptionsBuilder<NorthwindContext>();
        options.UseSqlServer(connectionString);

        return new NorthwindContext(options.Options);
    }
}
