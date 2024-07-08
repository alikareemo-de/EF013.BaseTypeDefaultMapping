namespace EF013.BaseTypeDefaultMapping.Entities
{
    public class Individual : Particpant
    {
        public string University { get; set; }
        public int YearOfGreaduation { get; set; }
        public bool IsIntern { get; set; }

        public override string ToString()
        {
            return $"({Id}   |   {FName}  {LName}  Greaduad:{YearOfGreaduation}  from {University}" +
                $"(){(IsIntern ? "Inteternship" : "")}";
        }
    }


}
