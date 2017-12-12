using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Geneology
{
    public class AuditRecord
    {
        public int Id { get; set; }
        public int UserIdActionPerformedBy { get; set; }
        public DateTimeOffset ActionPerformedOn { get; set; }
        public int ObjectIdActionReference { get; set; }
        public string ObjectTypeActionReference { get; set; }
        public string ObjectStateBeforeAction { get; set; }
        [MaxLength(25)]
        public string AuditActionType { get; set; }
        [ForeignKey("UserIdActionPerformedBy")]
        public virtual User User { get; set; }
    }
}
