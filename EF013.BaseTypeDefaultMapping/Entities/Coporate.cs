namespace EF013.BaseTypeDefaultMapping.Entities
{
    public class Coporate : Particpant
    {
        public string CompanyName { get; set; }
        public string JopTitle { get; set; }

        public override string ToString()
        {
            return $"({Id}   |   {FName}  {LName}   |{JopTitle} ) at {CompanyName}";
        }

    }


}
