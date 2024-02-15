namespace ChurchMI.DAL
{
    public class Title
    {
        public Guid TitleId { get; set; }
        public string TitleName { get; set; } = null!;
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
