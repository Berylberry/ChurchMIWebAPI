namespace ChurchMI.DAL
{
    public class MaritalStatus
    {
        public Guid MaritalStatusId { get; set; }
        public string Status { get; set; } = null!;
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
