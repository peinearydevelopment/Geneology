using System.Collections.Generic;

namespace Geneology
{
    public class Location
    {
        public int Id { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public virtual ICollection<LocationSupportingDocument> SupportingDocuments { get; set; }
        public virtual ICollection<SignificantEventLocation> SignificantEvents { get; set; }
        public virtual ICollection<IndividualLocation> Individuals { get; set; }
    }
}
