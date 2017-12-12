using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final_isi.WcfService1.Model
{
    public class BaseException : Exception
    {
        public int ErrorCode;

        public BaseException(int errorCode)
        {
            ErrorCode = errorCode;
        }
    }
}