namespace ChurchMI.DAL
{
    public partial class Member
    {
        public Guid MemberId { get; set; }
        public Guid RoledId { get; set; }
        public Guid TitleId { get; set; }
        public Guid GenderId { get; set; }
        public string FirstName { get; set; } = null!;
        public string? OtherName { get; set; }
        public string LastName { get; set; } = null!;
        public DateOnly? DateOfBirth { get; set; }
        public string PhoneNumber { get; set; } = null!;
        public string EmergencyContactName { get; set; } = null!;
        public string EmergencyContactNumber { get; set; } = null!;
        public string EmergencyContactRelationship { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string YearJoined { get; set; } = null!;
        public string Hometown { get; set; } = null!;
        public string Nationality { get; set; } = null!;
        public string ResidentialAddress { get; set; } = null!;
        public Guid MaritalStatusId { get; set; }
        
    }
}
