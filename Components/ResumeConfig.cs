// ResumeConfig.cs

public class ResumeConfig
{
    public HeaderConfig Header { get; set; } = new();
    public DashboardConfig Dashboard { get; set; } = new();
    public SkillsConfig Skills { get; set; } = new();
    public List<Certification> Certifications { get; set; } = new();
    public List<Experience> Experiences { get; set; } = new();
    public List<Education> Education { get; set; } = new();
}

// A central place for UI/style settings
// ... (UiConfig class remains the same) ...

// --- MODIFIED DATA MODELS ---
public record HeaderConfig
{
    public string Name { get; set; } = "";
    public string Title { get; set; } = "";
    public string ProfileImageUrl { get; set; } = "";
}

public record DashboardConfig
{
    public string Bio { get; set; } = "";
    public List<ContactInfo> ContactDetails { get; set; } = new();
}

// In Properties/ResumeConfig.cs

public record ContactInfo
{
    public string Type { get; set; } = "";
    public string Value { get; set; } = "";
    public string? Url { get; set; } 

    public ContactInfo() { } 
    
    public ContactInfo(string type, string value, string? url = null) 
    { 
        Type = type; 
        Value = value; 
        Url = url; 
    }
}

public record SkillsConfig
{
    public List<string> TechSkills { get; set; } = new();
    public List<string> SoftSkills { get; set; } = new();
    public List<Language> Languages { get; set; } = new();
}

public class UiConfig
{
    // Font Sizes
    public string ItemCardFontSize { get; set; } = "1.1rem"; // 
    public string ItemTitleFontSize { get; set; } = "1.35rem"; // 1.15
    public string ItemSubtitleFontSize { get; set; } = "0.9rem"; // 0.9
}

public record Experience(string JobTitle, string Company, string DateRange, string[] Responsibilities);
public record Education(string Degree, string Institution, string Year);
public record Certification(string Name, string IssuingBody, string DateIssued, string ImageUrl);
public record Language(string Name, string Proficiency);