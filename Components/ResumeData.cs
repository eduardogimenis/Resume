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
                Name = "John", 
                Title = "Lead Global Sales & Assessments", 
                ProfileImageUrl = "https://github.com/eduardogimenis/Resume/blob/main/profile_pic.jpeg?raw=true"
            },
            Dashboard = new()
            {
                Bio = "A results-oriented and strategic Principal Security Engineer...",
                ContactDetails = new List<ContactInfo>
                {
                    // Add the full URL as the third parameter
                    new("Email", "johndoe@doe.com", "mailto:johndoe@doe.com"),
                    new("Phone", "(123) 425-1233"), // No URL needed
                    new("Location", "Aliso Viejo, CA"), // No URL needed
                    new("LinkedIn", "Linkedin Link", "https://linkedin.com/in/johndoe"),
                    new("GitHub", "Github Link", "https://github.com/joeoe"),
                    new("Website", "Web Cluster", "https://doejoe.pro")
                }
            },
            Skills = new()
            {
                TechSkills = new List<string> { "Penetration Testing", "SIEM (Splunk)", "Threat Modeling", "Cloud Security (AWS/Azure)", "IAM", "Cryptography", "Python/Bash Scripting", "Metasploit", "Burp Suite", "Nessus" },
                SoftSkills = new List<string> { "Risk Analysis", "Incident Response", "Secure SDLC", "DevSecOps", "Team Leadership", "Stakeholder Communication" },
                Languages = new List<Language> { new("English", "Native"), new("German", "Professional Working Proficiency") }
            },
            
            Certifications = new List<Certification> 
            {
                new("CompTIA A+", "CompTIA", "Nov 2025", "/Images/comp_a.png"),
                new("CompTIA Network+", "CompTIA", "Aug 2025", "/Images/comp_net.png"),
                new("CompTIA Security+", "CompTIA", "May 2024", "/Images/comp_sec.png"),
                new("C# Fundamentals", "Microsoft", "TBA", "/Images/csharp.png"),
                new("AZ-900", "Microsoft", "TBA", "/Images/az900.jpg"),
                new("SC-100", "Microsoft", "TBA", "/Images/sc100.png"),
                new("SC-200", "Microsoft", "TBA", "/Images/sc200.png")
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