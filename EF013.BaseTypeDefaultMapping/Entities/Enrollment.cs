namespace EF013.BaseTypeDefaultMapping.Entities
{
    public class Enrollment
    {
        public int SectionId { get; set; }
        public int StudentId { get; set; }

        public Section Section { get; set; } = null!;
        public Particpant Particpant { get; set; } = null!;
    }
}
