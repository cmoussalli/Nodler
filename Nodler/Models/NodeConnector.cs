namespace Nodler;

public class NodeConnector
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Label { get; set; } = string.Empty;
    public ConnectorType Type { get; set; }
    public string? DataType { get; set; }

    // Maximum number of connections allowed on this connector. 0 means unlimited.
    public int MaxConnections { get; set; }
}
