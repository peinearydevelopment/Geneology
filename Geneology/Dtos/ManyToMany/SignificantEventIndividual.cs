namespace Geneology
{
    public class SignificantEventIndividual
    {
        public int SignificantEventId { get; set; }
        public SignificantEvent SignificantEvent { get; set; }
        public int IndividualId { get; set; }
        public Individual Individual { get; set; }
    }
}
