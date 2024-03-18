using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace dotnet_rpg_net7.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Character> Characters => Set<Character>();
        public DbSet<User> Users => Set<User>();
        
        public DataContext(DbContextOptions<DataContext> options)
            :base(options)
        {
            
        }
    }
}