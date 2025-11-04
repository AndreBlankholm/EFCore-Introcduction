
namespace EFCore_Introcduction
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }

        public List<Employee> Employees { get; set; }
    }
}