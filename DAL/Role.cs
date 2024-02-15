namespace ChurchMI.DAL
{
    public class Role
    {
        public Guid RoleId { get; set; }
        public string RoleName { get; set; } = null!;
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
