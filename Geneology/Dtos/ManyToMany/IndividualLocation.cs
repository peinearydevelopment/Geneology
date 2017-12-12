namespace Geneology
{
    public class IndividualLocation
    {
        public int IndividualId { get; set; }
        public virtual Individual Individual { get; set; }
        public int LocationId { get; set; }
        public virtual Location Location { get; set; }
    }
}
