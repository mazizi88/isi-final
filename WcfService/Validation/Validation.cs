using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final_isi.WcfService.Validation
{
    public static class Validation
    {
        public static void Validate(Model.WSMember T)
        {
            DateTime? birstdate = T.BirthDate;
            if (birstdate == null)
                throw new Model.BaseException(-126); //  تاريخ نادرست است
            
        }
    }
}