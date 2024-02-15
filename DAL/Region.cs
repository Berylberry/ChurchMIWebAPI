namespace ChurchMI.DAL
{
    public class Region
    {
        public Guid RegionId { get; set; }
        public string Name { get; set; } = null!;
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
