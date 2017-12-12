namespace Geneology
{
    public class RelationshipEventSupportingDocument
    {
        public int RelationshipEventId { get; set; }
        public RelationshipEvent RelationshipEvent { get; set; }
        public int SupportingDocumentId { get; set; }
        public SupportingDocument SupportingDocument { get; set; }
    }
}
