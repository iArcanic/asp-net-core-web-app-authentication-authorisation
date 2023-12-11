using Microsoft.EntityFrameworkCore;

namespace asp_net_core_web_app_authentication_authorisation.Services
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        { 
            
        }
    }
}
