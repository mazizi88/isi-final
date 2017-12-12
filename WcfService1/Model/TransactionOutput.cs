using Final_isi.WcfService1.Interface;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Final_isi.WcfService1.Model
{
    [DataContract]
    public class TransactionOutput : IOutput
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public String Message { get; set; }
        [DataMember]
        public List<WSTransaction> transactions { get; set; }
    }
}