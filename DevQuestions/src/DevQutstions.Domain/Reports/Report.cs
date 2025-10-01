using System.Diagnostics.CodeAnalysis;

namespace DevQutstions.Domain.Reports;

public class Report
{
    public Guid Id { get; set; }
    
    public required Guid UserId { get; set; }
    
    public required Guid ReportedUserId { get; set; }
    
    public required string Reason { get; set; }

    public Status Status { get; set; } = Status.Open;
    
    public DateTime CreatedAtTime { get; set; }
    
    public DateTime? UpdatedAtTime { get; set; }
    
    public Guid? ClosedByUserId { get; set; }
}

