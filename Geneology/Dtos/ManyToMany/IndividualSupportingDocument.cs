namespace Geneology
{
    public class IndividualSupportingDocument
    {
        public int IndividualId { get; set; }
        public virtual Individual Individual { get; set; }
        public int SupportingDocumentId { get; set; }
        public virtual SupportingDocument SupportingDocument { get; set; }
    }
}
