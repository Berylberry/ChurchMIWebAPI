namespace ChurchMI.DAL
{
    public class Announcement
    {
        public Guid AnnouncementId { get; set; }
        public string Body { get; set; }
        public string Title { get; set; }
        public bool BranchSpecific { get; set; }
        public Guid? BranchId { get; set; }
        public virtual Branch? Branch { get; set; }
        public string? AnnouncementImage { get; set; }
    }
}
