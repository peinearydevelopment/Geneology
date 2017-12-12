namespace Geneology
{
    public class LocationSupportingDocument
    {
        public int LocationId { get; set; }
        public virtual Location Location { get; set; }
        public int SupportingDocumentId { get; set; }
        public virtual SupportingDocument SupportingDocument { get; set; }
    }
}
