


namespace EFCore_Introcduction
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public DateTime HireDate { get; set; }
        public Department Department { get; set; }
    }
}