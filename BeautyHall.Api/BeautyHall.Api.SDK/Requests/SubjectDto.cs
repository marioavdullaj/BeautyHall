namespace BeautyHall.Api.SDK.Requests
{
    public class SubjectDto
    {
        public int SubjectId { get; set; }

        public int Type { get; set; }
        public string? SubjectName { get; set; }
        public string? SubjectLastName { get; set; }
        public string? EMail { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime? RegistrationDate { get; set; }
    }
}
