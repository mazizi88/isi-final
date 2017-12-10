using Common.Interface;
using System;

namespace Common.DTO
{
    public class Member : IMember
    {
        public long NationalID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FullName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FatherName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime BirthDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Comment { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public byte Image { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsActive { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
