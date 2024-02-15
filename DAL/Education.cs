namespace ChurchMI.DAL
{
    public class Education
    {
        public Guid EducationId { get; set; }
        public string Level { get; set; } = null!;
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
