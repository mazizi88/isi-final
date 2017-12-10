using System.Runtime.Serialization;

namespace Final_isi.WcfService.Model
{
    [DataContract]
    public class Authenticate
    {
        [DataMember]
        public string UserId { get; set; }
        [DataMember]
        public string Password { get; set; }
    }
}