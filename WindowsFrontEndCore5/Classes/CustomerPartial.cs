namespace WindowsFrontEndCore5.Classes
{
    public class CustomerPartial
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString() => Name;
    }
}