using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Geneology
{
    public class EnglishName
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
        [MaxLength(255)]
        public string FirstName { get; set; }
        [MaxLength(255)]
        public string MiddleName { get; set; }
        [MaxLength(255)]
        public string Surname { get; set; }
        [MaxLength(50)]
        public string Suffix { get; set; }
        [MaxLength(50)]
        public string ProfessionalTitle { get; set; }
        public virtual ICollection<EnglishNameSupportingDocument> SupportingDocuments { get; set; }

        public int IndividualId { get; set; }
        public virtual Individual Individual { get; set; }
    }
}
