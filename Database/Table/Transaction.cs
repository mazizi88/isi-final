using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_isi.Database.Table
{
    public class Transaction
    {
        public Transaction()
        {

        }
        [Key]
        public int ID { set; get; }
        [Column("FK_MemberID")]
        [ForeignKey("NationalID")]
        public String FK_MemberID { set; get; }
        public String Date { set; get; }
        public DateTime RegistrationDate { set; get; }
        public Boolean IsActive { set; get; }
        public int Case { set; get; }
        public String Payment { set; get; }
        public String Comment { set; get; }

        public Member member { get; set; }
    }
}
