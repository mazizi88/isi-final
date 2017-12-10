using Final_isi.WcfService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final_isi.WcfService.Authenticate
{
    public class WebServiceAuthenticate
    {
        #region Instance

        public static readonly WebServiceAuthenticate Instance = new WebServiceAuthenticate();

        #endregion

        public void Authenticate(Model.Authenticate cnt)
        {
            if (cnt.UserId != "p")
                throw new BaseException(-3);
            if (cnt.Password != "1")
                throw new BaseException(-4);

        }
    }
}