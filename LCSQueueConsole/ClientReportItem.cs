using System;
using System.Runtime.Serialization;

// ReSharper disable CheckNamespace
namespace LoveCleanStreets.Contracts.ServiceBus
// ReSharper restore CheckNamespace
{
    [DataContract]
    public class ClientReportItem
    {

        string _imageUrl;

        [DataMember(Order = 5)]
        public string ImageUrl
        {
            get
            {
                return "/images/" + ReportItemId;

            }
            set
            {
                //setter is need for deserialization
                _imageUrl = value;
            }

        }

        [DataMember(Order = 6)]
        public double? Latitude { get; set; }

        [DataMember(Order = 7)]
        public double? Longitude { get; set; }

        [DataMember(Order = 3)]
        public decimal? URPN { get; set; }

        [DataMember(Order = 3)]
        public string Description { get; set; }

        [DataMember(Order = 14)]
        public string[] Tags { get; set; }


        [DataMember(Order = 11)]
        public bool? ResponseRequired { get; set; }

        [DataMember(Order = 2)]
        public DateTime? DateTimeRecorded { get; set; }

        [DataMember(Order = 4)]
        public byte[] ImageData { get; set; }

        [DataMember(Order = 12)]
        public int StatusId { get; set; }

        [DataMember(Order = 9)]
        public Guid ReportId { get; set; }

        [DataMember(Order = 10)]
        public Guid ReportItemId { get; set; }

        [DataMember(Order = 8)]
        public bool? NotifyEmail { get; set; }

        [DataMember(Order = 1)]
        public int CategoryId { get; set; }


        [DataMember(Order = 13)]
        public string AssignedTo { get; set; }

        [DataMember(Order = 15)]
        public bool? Completed { get; set; }

        [DataMember(Order = 16)]
        public DateTime? CompletedDate { get; set; }

        [DataMember(Order = 17)]
        public bool? Approved { get; set; }

        [DataMember(Order = 18)]
        public string JobName { get; set; }

        //    [DataMember(Order = 18)]
        public Guid AppKey { get; set; }
        [DataMember(Order = 21)]
        public string EmailAddress { get; set; }
        //  [DataMember(Order = 20)]
        public string DeviceUUId { get; set; }

        [DataMember(Order = 19)]
        public double Easting { get; set; }
        [DataMember(Order = 20)]
        public double Northing { get; set; }

        [DataMember(Order = 21)]
        public Guid? VideoId { get; set; }

        // Use the parent approval status if this is an update;
        public bool UseParentApproval { get; set; }


        // Used to create report item groups for multiple images.
        public Guid? ReportItemGroupId { get; set; }
        public int ReportItemGroupIndex { get; set; }


    }

}

