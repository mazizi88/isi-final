using Common.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interface
{
    public interface ITransaction : IDTOInt32
    {
        String FK_MemberID { set; get; }
        String Date { set; get; }
        DateTime RegistrationDate { set; get; }
        Boolean IsActive { set; get; }
        Status Case { set; get; }
        String Payment { set; get; }
        String Comment { set; get; }
    }
}
