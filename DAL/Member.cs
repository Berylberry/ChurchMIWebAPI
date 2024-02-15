namespace ChurchMI.DAL
{
    public partial class Member
    {
        public Guid MemberId { get; set; }
        public Guid RoledId { get; set; }
        public virtual Role Role { get; set; }
        public Guid TitleId { get; set; }
        public virtual Title Title { get; set; }
        public Guid GenderId { get; set; }
        public virtual Gender Gender { get; set; }
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
        public virtual MaritalStatus MaritalStatus { get; set; }
        public string? SpouseName { get; set; }
        public Guid? SpouseId { get; set; }
        public virtual Member? Spouse { get; set; }
        public DateOnly? WeddingDate { get; set; }
        public Guid? NumberOfChildren { get; set; }
        public bool FamilyRelations { get; set; }
        public Guid? FirstRelationId { get; set; }
        public virtual Member? FirstRelation { get; set; }
        public Guid? LastRelationId { get; set; }
        public virtual Member? LastRelation { get; set; }
        public string Occupation { get; set; } = null!;
        public string? Employer { get; set; }
        public Guid EducationslLevelId { get; set; }
        public virtual Education Education { get; set; }
        public bool Baptized { get; set; }
        public bool TithePayer { get; set; }
        public bool WelfareContributor { get; set; }
        public Guid DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        public Guid BranchId { get; set; }
        public virtual Branch Branch { get; set; }
        public string? ProfilePicture { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
