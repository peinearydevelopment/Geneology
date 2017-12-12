namespace Geneology
{
    public class SignificantEventLocation
    {
        public int SignificantEventId { get; set; }
        public virtual SignificantEvent SignificantEvent { get; set; }
        public int LocationId { get; set; }
        public virtual Location Location { get; set; }
    }
}
