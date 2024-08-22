using Microsoft.EntityFrameworkCore;

namespace MovieTickets.Data
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options): base(options) 
        { 
        
        }
    }
}
