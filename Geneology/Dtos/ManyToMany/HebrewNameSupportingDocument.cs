namespace Geneology
{
    public class HebrewNameSupportingDocument
    {
        public int HebrewNameId { get; set; }
        public virtual HebrewName HebrewName { get; set; }
        public int SupportingDocumentId { get; set; }
        public virtual SupportingDocument SupportingDocument { get; set; }
    }
}
