using System.Runtime.Serialization;

namespace BasicDomainService.Directors.Models
{
    [DataContract(Name = "dateTime")]
    public class TimeViewModel
    {
        [DataMember(Name = "date")]
        public string FormattedDate { get; set; }

        [DataMember(Name = "time")]
        public string FormattedTime { get; set; }

        [DataMember(Name = "weekOfYear")]
        public int Week { get; set; }
    }
}