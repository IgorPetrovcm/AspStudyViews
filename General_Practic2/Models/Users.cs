namespace Models 
{
    public record class Person(string name, int age);
    public class PersonStorage 
    {
        public List<Person> persons = new List<Person>();
    }
}