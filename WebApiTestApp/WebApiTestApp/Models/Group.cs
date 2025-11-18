namespace WebApiTestApp.Models
{
    public class Group
    {
        public int? GroupNumber { get; set; }
        public IEnumerable<Person>? Members { get; set; }
    }
}
