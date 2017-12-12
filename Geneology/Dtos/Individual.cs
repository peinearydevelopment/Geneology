using System.Collections.Generic;

namespace Geneology
{
    public class Individual
    {
        public int Id { get; set; }
        public virtual ICollection<EnglishName> EnglishNames { get; set; }
        public virtual ICollection<HebrewName> HebrewNames { get; set; }
        public virtual ICollection<SignificantEventIndividual> SignificantEvents { get; set; }
        public virtual ICollection<IndividualSupportingDocument> SupportingDocuments { get; set; }
        public virtual ICollection<Relationship> Relationships1 { get; set; }
        public virtual ICollection<Relationship> Relationships2 { get; set; }
        public virtual ICollection<IndividualLocation> Locations { get; set; }
    }
}
