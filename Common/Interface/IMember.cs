using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interface
{
    public interface IMember
    {
        long NationalID { set; get; }
        String FullName { set; get; }
        String FatherName { set; get; }
        DateTime BirthDate { set; get; }
        String Comment { set; get; }
        Byte Image { set; get; }
        Boolean IsActive { set; get; }
    }
}
