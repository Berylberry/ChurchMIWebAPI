namespace ChurchMI.DAL
{
    public class Department
    {
        public Guid DepartmentId { get; set; }
        public string Name { get; set; } = null!;
        public DateTime DateCreated { get; set; }
        public Guid? CreatedById { get; set; }
        public virtual Member? CreatedBy { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
