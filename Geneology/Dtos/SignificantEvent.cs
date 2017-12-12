using System;
using System.Collections.Generic;

namespace Geneology
{
    public class SignificantEvent
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime OccuredOn { get; set; }
        public virtual ICollection<SignificantEventSupportingDocument> SupportingDocuments { get; set; }
        public virtual ICollection<SignificantEventLocation> Locations { get; set; }
        public virtual ICollection<SignificantEventIndividual> Individuals { get; set; }
        public virtual ICollection<RelationshipEvent> Relationships { get; set; }
    }
}
