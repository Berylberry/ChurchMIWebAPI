namespace ChurchMI.DAL
{
    public class Branch
    {
        public int BranchId { get; set; }
        public string Name { get; set; } = null!;
        public string GeoLocation { get; set; } = null!;
        public string City { get; set; } = null!;
        public int RegionId { get; set; }
        public virtual Region Region { get; set; }
    }
}
