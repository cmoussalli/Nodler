namespace Nodler.Components.Models;

public class ConnectorClickedEventArgs
{
    public WorkflowNode Node { get; set; } = default!;
    public NodeConnector Connector { get; set; } = default!;
}
