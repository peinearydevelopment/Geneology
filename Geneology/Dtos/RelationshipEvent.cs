using System.Collections.Generic;

namespace Geneology
{
    public class RelationshipEvent
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public virtual Relationship Relationship { get; set; }
        public virtual ICollection<SignificantEvent> SignificantEvents { get; set; }
    }
}
