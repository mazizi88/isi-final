using Common.Enum;
using Common.Interface;
using System;

namespace Common.DTO
{
    public class Transaction : ITransaction
    {
        public string FK_MemberID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Date { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime RegistrationDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsActive { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Status Case { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Payment { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Comment { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int ID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
