using Clase5.Models;
using Microsoft.EntityFrameworkCore;

namespace Clase5.Data;
public class CarContext : DbContext
{
    public CarContext(DbContextOptions<CarContext> options) : base(options)
    {

    }

    public DbSet<Car> Cars { get; set; }
}