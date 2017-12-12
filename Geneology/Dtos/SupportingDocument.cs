using System.Collections.Generic;

namespace Geneology
{
    public class SupportingDocument
    {
        public int Id { get; set; }
        public string Uri { get; set; }
        public virtual ICollection<EnglishNameSupportingDocument> EnglishNames { get; set; }
        public virtual ICollection<HebrewNameSupportingDocument> HebrewNames { get; set; }
        public virtual ICollection<IndividualSupportingDocument> Individuals { get; set; }
        public virtual ICollection<LocationSupportingDocument> Locations { get; set; }
        public virtual ICollection<SignificantEventSupportingDocument> SignificantEvents { get; set; }
        public virtual ICollection<RelationshipEventSupportingDocument> RelationshipEvents { get; set; }
    }
}
