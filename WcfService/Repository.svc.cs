using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Final_isi.WcfService.Model;
using Final_isi.WcfService.Authenticate;

using Final_isi.WcfService.Validation;

namespace Final_isi.WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Repository : IRepository
    {
        #region member
        public MemberOutput GetAllTransactiont(Model.Authenticate authenticate)
        {
            MemberOutput result = new MemberOutput();
            try
            {
               
                WebServiceAuthenticate.Instance.Authenticate(authenticate);
                //  Validation.Validate();
            }
            catch (BaseException ex)
            {
                result.Id = ex.ErrorCode;
            }
            catch (Exception ex)
            {
                result.Id = ex.HResult;
            }
            finally
            {
                //context.Dispose();
            }
            return result;
        }

        #endregion
        #region transaction


        #endregion

    }
}
