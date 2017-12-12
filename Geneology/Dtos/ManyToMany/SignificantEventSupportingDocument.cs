namespace Geneology
{
    public class SignificantEventSupportingDocument
    {
        public int SignificantEventId { get; set; }
        public virtual SignificantEvent SignificantEvent { get; set; }
        public int SupportingDocumentId { get; set; }
        public virtual SupportingDocument SupportingDocument { get; set; }
    }
}
