namespace Nodler;

public class Connection
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string SourceNodeId { get; set; } = string.Empty;
    public string SourceConnectorId { get; set; } = string.Empty;
    public string TargetNodeId { get; set; } = string.Empty;
    public string TargetConnectorId { get; set; } = string.Empty;
}
