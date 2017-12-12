using System.Collections.Generic;

namespace Geneology
{
    public interface IDocumentableRecord
    {
        ICollection<SupportingDocument> SupportingDocuments { get; set; }
    }
}
