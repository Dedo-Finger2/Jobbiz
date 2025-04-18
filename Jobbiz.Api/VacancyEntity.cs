namespace Jobbiz.Api
{
    public class VacancyEntity
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public Uri Url { get; set; }
        public string Platform { get; set; }
        public string Area { get; set; }
        public VacancyStatus Status { get; set; }
        public string Location { get; set; }
        public decimal? Salary { get; set; }
        public VacancyLevel Level { get; set; }
        public string CompanyName { get; set; }
        public EmploymentRegime Regime { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? AppliedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public VacancyEntity(long id, string title, string? description, Uri url, string platform, string area, VacancyStatus status, string location, decimal? salary, VacancyLevel level, string companyName, EmploymentRegime regime, DateTime createdAt, DateTime? appliedAt, DateTime? updatedAt)
        {
            Id = id;
            Title = title;
            Description = description;
            Url = url;
            Platform = platform;
            Area = area;
            Status = status;
            Location = location;
            Salary = salary;
            Level = level;
            CompanyName = companyName;
            Regime = regime;
            CreatedAt = createdAt;
            AppliedAt = appliedAt;
            UpdatedAt = updatedAt;
        }
    }
}
