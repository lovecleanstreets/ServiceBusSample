using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace LCSShared.Domain
{
    [DataContract]
    class Report
    {

        [DataMember]
        public Guid ReportItemId { get; set; }

        [DataMember]
        public Guid ReportId { get; set; }

        [DataMember]
        public string ReportLocation { get; set; }

        [DataMember]
        public double Latitude { get; set; }

        [DataMember]
        public double Longitude { get; set; }

        [DataMember]
        public string AdditionalLocationInformation { get; set; }


        [DataMember]
        public string ReportUrl { get; set; }

        [DataMember]
        public string ImageUrl { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public string[] Tags { get; set; }

        [DataMember]
        public string Status { get; set; }

        [DataMember]
        public int StatusId { get; set; }


        [DataMember]
        public bool IsComplete { get; set; }

        [DataMember]
        public DateTime CompleteDate { get; set; }


        [DataMember]
        public string CreatedByEmail { get; set; }

        [DataMember]
        public DateTime CreatedDateTime { get; set; }

        [DataMember]
        public string CreatedByAdditionalData { get; set; }

        [DataMember]
        public bool Approved { get; set; }

        [DataMember]
        public string JobName { get; set; }

        [DataMember]
        public string LocalAuthority { get; set; }

        [DataMember]
        public int LocalAuthorityId { get; set; }

        [DataMember]
        public string WardName { get; set; }


        [DataMember]
        public string AssignedToEmail { get; set; }

        [DataMember]
        public DateTime AssignedToDate { get; set; }

        [DataMember]
        public string CategoryName { get; set; }

        [DataMember]
        public int CategoryId { get; set; }

        [DataMember]
        public string CategoryIntegrationCode { get; set; }

    }
}
