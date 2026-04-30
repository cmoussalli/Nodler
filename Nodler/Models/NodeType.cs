namespace Nodler;

public class NodeType
{
    public string Title { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public string Color { get; set; } = string.Empty;
    public List<NodeConnectorDefinition> Connectors { get; set; } = new();

    public string? Icon { get; set; }
    public string? IconUrl { get; set; }
    public string? Description { get; set; }
    public string? Category { get; set; }
    public string? Badge { get; set; }
    public string? TextColor { get; set; }
    public string? BorderColor { get; set; }
    public string? CssClass { get; set; }
    public string? Style { get; set; }
}
