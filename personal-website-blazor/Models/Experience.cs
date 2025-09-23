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
        public required string Description { get; set; }
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

    public static class ExperienceTypeExtensions
    {
        public static string ToDisplayString(this ExperienceType type)
        {
            return type switch
            {
                ExperienceType.FullTimeEmployment => "Full Time",
                ExperienceType.PartTimeEmployment => "Part Time",
                ExperienceType.Degree => "Degree",
                ExperienceType.Certification => "Certification",
                ExperienceType.Internship => "Internship",
                _ => type.ToString()
            };
        }
    }
}