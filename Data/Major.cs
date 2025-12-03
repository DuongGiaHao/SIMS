namespace SIMS.Data
{
    public class Major
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public string Name { get; set; } = string.Empty;
        public Department Department { get; set; }
    }
}
