using DealDone.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealDone.Database
{
    public class DealDoneContext:DbContext
    {
        public DealDoneContext() : base("DealDoneConnection")
        {
            var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        public DbSet<Auction> Auctions { get; set; }
    }
}
