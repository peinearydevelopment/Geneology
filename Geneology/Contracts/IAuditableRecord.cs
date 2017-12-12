using System.Collections.Generic;

namespace Geneology
{
    public interface IAuditableRecord
    {
        ICollection<AuditRecord> AuditRecords { get; set; }
    }
}
