using System.Collections.Generic;

namespace PersonalWebsiteBlazor.Models
{
    public class Project
    {
        public required string ProjectTitle { get; set; }
        public required int Year { get; set; }
        public required List<string> Technologies { get; set; } = new List<string>();
        public required string ProjectEffortType { get; set; }
        public required string Description { get; set; }
        public string? CodeLink { get; set; }
        public string? Image { get; set; }
    }

    public enum ProjectEffortType
    {
        Solo,
        Team
    }
}