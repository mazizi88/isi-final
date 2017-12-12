using Final_isi.WcfService.Authenticate;
using Final_isi.WcfService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Final_isi.WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RepService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select RepService.svc or RepService.svc.cs at the Solution Explorer and start debugging.
    public class RepService : IRepService
    {
        #region Transaction
        public TransactionOutput GetAllTransaction(Model.Authenticate authenticate)
        {
            TransactionOutput result = new TransactionOutput();
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

        public TransactionOutput GetTransactionByID(Model.Authenticate authenticate, int id)
        {
            TransactionOutput result = new TransactionOutput();
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

        public TransactionOutput GetTransactionByNationalID(Model.Authenticate authenticate, long nationalID)
        {
            TransactionOutput result = new TransactionOutput();
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

        public TransactionOutput GetTransactionByDate(Model.Authenticate authenticate, DateTime date1, DateTime date2)
        {
            TransactionOutput result = new TransactionOutput();
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

        public TransactionOutput GetTransactionCountNumber(Model.Authenticate authenticate, int id, int count)
        {
            TransactionOutput result = new TransactionOutput();
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


        #region member
        public MemberOutput GetAllMember(Model.Authenticate authenticate)
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

        public MemberOutput GetMemberByFullName(Model.Authenticate authenticate, int id)
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

        public MemberOutput GetMemberByNationalID(Model.Authenticate authenticate, long nationalID)
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

        public MemberOutput GetMemberByDate(Model.Authenticate authenticate, DateTime date1, DateTime date2)
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

        public MemberOutput GetMemberCountNumber(Model.Authenticate authenticate, int id, int count)
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

    }


}
