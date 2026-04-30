namespace Nodler;

public class WorkflowNode
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Title { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public string BackgroundColor { get; set; } = "#3b82f6";
    public string BorderColor { get; set; } = "transparent";
    public string? Template { get; set; }
    public double X { get; set; }
    public double Y { get; set; }
    public double Width { get; set; } = 200;
    public double Height { get; set; } = 100;
    public List<NodeConnector> Connectors { get; set; } = new();
    public Dictionary<string, object> Properties { get; set; } = new();
}
