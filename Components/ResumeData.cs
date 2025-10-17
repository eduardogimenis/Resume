// ResumeData.cs

public static class ResumeData
{
    public static ResumeConfig GetResumeData()
    {
        return new ResumeConfig
        {
            // Use object initializer syntax { Property = Value }
            Header = new() 
            {
                Name = "Jane 'Hex' Doe", 
                Title = "Principal Security Engineer", 
                ProfileImageUrl = "https://placehold.co/100x100/0891b2/ffffff?text=JD"
            },
            Dashboard = new()
            {
                Bio = "A results-oriented and strategic Principal Security Engineer with over 10 years of experience...",
                ContactDetails = new List<ContactInfo>
                {
                    new("Email", "jane.doe@securenet.dev"),
                    new("Phone", "(123) 456-7890"),
                    new("Location", "Aliso Viejo, CA"),
                    new("LinkedIn", "linkedin.com/in/janedoe-sec"),
                    new("GitHub", "github.com/JaneHexDoe"),
                    new("Blog", "janehexdoe.dev/blog")
                }
            },
            Skills = new()
            {
                TechSkills = new List<string> { "Penetration Testing", "SIEM (Splunk)", "Threat Modeling", "Cloud Security (AWS/Azure)", "IAM", "Cryptography", "Python/Bash Scripting", "Metasploit", "Burp Suite", "Nessus" },
                SoftSkills = new List<string> { "Risk Analysis", "Incident Response", "Secure SDLC", "DevSecOps", "Team Leadership", "Stakeholder Communication" },
                Languages = new List<Language> { new("English", "Native"), new("German", "Professional Working Proficiency") }
            },
            
            // --- SAMPLE DATA INITIALIZATION ---

            Certifications = new List<Certification> 
            {
                new("CompTIA A+ ce Certification", "CompTIA", "Nov 2025"),
                new("Microsoft Certified: C# Developer Associate", "Microsoft", "Aug 2025"),
                new("CompTIA Security+", "CompTIA", "May 2024")
            },
            Experiences = new List<Experience> 
            {
                new("Junior .NET Developer", "Tech Solutions Inc.", "Jan 2024 - Present", new[]
                {
                    "Developed and maintained features for a web-based inventory management system using C#, ASP.NET Core, and Blazor.",
                    "Collaborated with senior developers to troubleshoot and resolve software defects.",
                    "Wrote unit tests to ensure code quality and application stability."
                }),
                new("IT Support Intern", "Innovatech Corp", "Jun 2023 - Dec 2023", new[]
                {
                    "Provided technical support to employees for hardware, software, and network-related issues.",
                    "Assisted in the setup and configuration of new computer systems and peripherals.",
                    "Documented support tickets and resolutions in the company's knowledge base."
                })
            },
            Education = new List<Education> 
            {
                new("Associate of Science in Computer Science", "Irvine Valley College", "2024"),
                new("Bachelor of Science in Software Engineering", "University of California, Irvine", "In Progress")
            }
        };
    }
}