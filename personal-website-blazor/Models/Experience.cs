
namespace PersonalWebsiteBlazor.Models
{
    public class Experience
    {
        public required string ExperienceTitle { get; set; }
        public required ExperienceType Type { get; set; }
        public required List<string> Affiliations { get; set; }
        public required DateOnly FromDate { get; set; }
        public DateOnly? ToDate { get; set; }
        public required List<string> Keywords { get; set; }
        public required List<string> Highlights { get; set; }
        public string? LinkURL { get; set; }
        public string? Image { get; set; }
    }

    public enum ExperienceType
    {
        Degree,
        Certification,
        FullTimeEmployment,
        PartTimeEmployment,
        Internship
    }
}