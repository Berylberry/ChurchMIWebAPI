namespace ChurchMI.DAL
{
    public class Gender
    {
        public Guid GenderId { get; set; }
        public string GenderLongName { get; set; } = null!;
        public string GenderShortName { get; set; } = null!;
    }
}
