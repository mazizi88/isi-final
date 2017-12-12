using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_isi.Database.Table
{
    public class Member
    {
        public Member()
        {
        }
        public long NationalID { set; get; }
        public String FullName { set; get; }
        public String FatherName { set; get; }
        public DateTime BirthDate { set; get; }
        public String Comment { set; get; }
        public Byte Image { set; get; }
        public Boolean IsActive { set; get; }

        public ICollection<Transaction> transaction { get; set; }
    }
}
