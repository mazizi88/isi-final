using System;
using System.Runtime.Serialization;
using Common.Enum;

namespace Final_isi.WcfService.Model
{
    [DataContract]
    public class WSTransaction : Common.Interface.ITransaction
    {
        [DataMember]
        public string FK_MemberID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [DataMember]
        public string Date { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [DataMember]
        public DateTime RegistrationDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //[DataMember]
        public bool IsActive { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [DataMember]
        public Status Case { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [DataMember]
        public string Payment { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [DataMember]
        public string Comment { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //[DataMember]
        public int ID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}