using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Geneology
{
    public class HebrewName
    {
        public int Id { get; set; }
        [MaxLength(25)]
        public string Title { get; set; }
        [MaxLength(255)]
        public string Name { get; set; }
        [MaxLength(25)]
        public string Descriptor { get; set; }
        [MaxLength(255)]
        public string ParentName { get; set; }
        public virtual ICollection<HebrewNameSupportingDocument> SupportingDocuments { get; set; }

        public int IndividualId { get; set; }
        public virtual Individual Individual { get; set; }
    }
}
