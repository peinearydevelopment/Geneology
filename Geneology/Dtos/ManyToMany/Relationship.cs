namespace Geneology
{
    public class Relationship
    {
        public int Individual1Id { get; set; }
        public virtual Individual Individual1 { get; set; }
        public int Individual2Id { get; set; }
        public virtual Individual Individual2 { get; set; }
    }
}
