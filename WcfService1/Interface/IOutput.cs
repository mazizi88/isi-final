using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_isi.WcfService1.Interface
{
    public interface IOutput
    {
        int Id { get; set; }
        String Message { get; set; }
    }
}
