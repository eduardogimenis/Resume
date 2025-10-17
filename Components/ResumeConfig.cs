// ResumeConfig.cs

// A central place for all resume content
public class ResumeConfig
{
    // These initializations are now valid because the records below will have parameterless constructors
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

public record ContactInfo
{
    public string Type { get; set; } = "";
    public string Value { get; set; } = "";
    // Adding a parameterless constructor for consistency
    public ContactInfo() { } 
    // Keep the constructor for easy initialization in ResumeData.cs
    public ContactInfo(string type, string value) { Type = type; Value = value; }
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
    public string ItemCardFontSize { get; set; } = "0.85rem"; // Changed from 0.75rem
    public string ItemTitleFontSize { get; set; } = "1.15rem"; // Changed from 1.25rem
    public string ItemSubtitleFontSize { get; set; } = "0.9rem";
}

// The rest of your records can remain as they are, but for consistency, 
// it's good practice to define them with properties too.
public record Experience(string JobTitle, string Company, string DateRange, string[] Responsibilities);
public record Education(string Degree, string Institution, string Year);
public record Certification(string Name, string IssuingBody, string DateIssued);
public record Language(string Name, string Proficiency);