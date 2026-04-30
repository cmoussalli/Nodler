namespace Nodler;

public enum CanvasChangeType
{
    NodeAdded,
    NodeDeleted,
    NodeUpdated,
    NodeMoved,
    ConnectionAdded,
    ConnectionDeleted
}

public class CanvasChangedEventArgs
{
    public CanvasChangeType ChangeType { get; set; }
    public WorkflowNode? Node { get; set; }
    public Connection? Connection { get; set; }
}
