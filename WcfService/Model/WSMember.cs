using System;
using System.Runtime.Serialization;

namespace Final_isi.WcfService.Model
{
    [DataContract]
    public class WSMember : Common.Interface.IMember
    {
        [DataMember]
        public long NationalID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [DataMember]
        public string FullName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [DataMember]
        public string FatherName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [DataMember]
        public DateTime BirthDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [DataMember]
        public string Comment { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [DataMember]
        public byte Image { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //[DataMember]
        public bool IsActive { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

}