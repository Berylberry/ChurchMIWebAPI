namespace ChurchMI.DAL
{
    public class Branch
    {
        public Guid BranchId { get; set; }
        public string Name { get; set; } = null!;
        public string GeoLocation { get; set; } = null!;
        public string City { get; set; } = null!;
        public Guid RegionId { get; set; }
        public virtual Region Region { get; set; }
        public DateTime DateCreated { get; set; }
        public Guid? CreatedById { get; set; }
        public virtual Member? CreatedBy { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
