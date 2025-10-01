namespace DevQutstions.Domain.Tags;

public class Tag
{
    public Guid Id { get; set; }
    
    public required string Name { get; set; }
    
    public required string Descriptions { get; set; }
    
    
}