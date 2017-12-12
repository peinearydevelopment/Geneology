namespace Geneology
{
    public class EnglishNameSupportingDocument
    {
        public int EnglishNameId { get; set; }
        public virtual EnglishName EnglishName { get; set; }
        public int SupportingDocumentId { get; set; }
        public virtual SupportingDocument SupportingDocument { get; set; }
    }
}
