using Final_isi.Database.Table;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_isi.Database
{
    public class IsiContext
    {
        public IsiContext(): base()
        {

        }

        public DbSet<Member> Member { get; set; }
        public DbSet<Transaction> Transaction { get; set; }

      
    }
}
