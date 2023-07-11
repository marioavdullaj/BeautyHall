using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace BeautyHall.Models.Dto.Requests
{
    public class SubjectDto : IValidatableObject
    {
        public List<int> ValidSubjectType = new() { 0, 1, 2 };
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int SubjectId { get; set; }

        public int Type { get; set; }

        [Required]
        [MaxLength(50)]
        public string? SubjectName { get; set; }

        [Required]
        [MaxLength(50)]
        public string? SubjectLastName { get; set; }

        [MaxLength(50)]
        public string? EMail { get; set; }

        [MaxLength(20)]
        public string? PhoneNumber { get; set; }
        public DateTime? RegistrationDate { get; set; }


        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> ret = new List<ValidationResult>();
            if (!ValidSubjectType.Contains(Type))
                ret.Add(new ValidationResult("Invalid Subject Type", new List<string>() { $"{nameof(SubjectDto.Type)}" }));
            return ret;
        }
    }
}
