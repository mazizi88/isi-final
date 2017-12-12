using Final_isi.WcfService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Final_isi.WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRepService" in both code and config file together.
    [ServiceContract]
    public interface IRepService
    {
        #region Transaction

        [OperationContract]
        TransactionOutput GetAllTransaction(Model.Authenticate authenticate);

        [OperationContract]
        TransactionOutput GetTransactionByID(Model.Authenticate authenticate, int id);

        [OperationContract]
        TransactionOutput GetTransactionByNationalID(Model.Authenticate authenticate, long nationalID);

        [OperationContract]
        TransactionOutput GetTransactionByDate(Model.Authenticate authenticate, DateTime date1, DateTime date2);

        [OperationContract]
        TransactionOutput GetTransactionCountNumber(Model.Authenticate authenticate, int id, int count);


        #endregion


        #region member

        [OperationContract]
        MemberOutput GetAllMember(Model.Authenticate authenticate);

        [OperationContract]
        MemberOutput GetMemberByFullName(Model.Authenticate authenticate, int id);

        [OperationContract]
        MemberOutput GetMemberByNationalID(Model.Authenticate authenticate, long nationalID);

        [OperationContract]
        MemberOutput GetMemberByDate(Model.Authenticate authenticate, DateTime date1, DateTime date2);

        [OperationContract]
        MemberOutput GetMemberCountNumber(Model.Authenticate authenticate, int id, int count);


        #endregion

    }
}
