using Final_isi.WcfService.Interface;
using System;
using System.Runtime.Serialization;

namespace Final_isi.WcfService.Model
{
    [DataContract]
    public class Output : IOutput
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public String Message { get; set; }
    }
}