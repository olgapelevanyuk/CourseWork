using System;
using System.Collections.Generic;
using System.Text;

namespace OlympicFlights.DataAccess.ClientManagement
{
    /// <summary>
    /// Provides tools to work with entity sets of <see cref="Client"/>
    /// </summary>
    public class ClientContext : DomainContextBase<ApplicationDbContext>, IClientContext
    {
        /// <summary>
        /// Initializes a new instance of <see cref="ClientContext"/>
        /// </summary>
        /// <param name="dbContext">Root context, that contains <see cref="DbSet{TEntity}"/> of current <see cref="Client"/></param>
        public ClientContext(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public IEntitySet<Client> Clients => this.GetDbSet<Client>();
    }
}
