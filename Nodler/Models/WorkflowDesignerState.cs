using System.Text.Json;

namespace Nodler;

public class WorkflowDesignerState
{
    public List<WorkflowNode> Nodes { get; set; } = new();
    public List<Connection> Connections { get; set; } = new();
    public WorkflowNode? SelectedNode { get; set; }
    public string? SelectedConnectorNodeId { get; set; }
    public string? SelectedConnectorId { get; set; }

    public string ToJson(bool includePosition = true)
    {
        var options = new JsonSerializerOptions { WriteIndented = true };

        if (includePosition)
        {
            return JsonSerializer.Serialize(new { Nodes, Connections }, options);
        }

        var logicalNodes = Nodes.Select(n => new
        {
            n.Id,
            n.Title,
            n.Type,
            n.BackgroundColor,
            n.BorderColor,
            n.Template,
            n.Connectors,
            n.Properties
        });

        return JsonSerializer.Serialize(new { Nodes = logicalNodes, Connections }, options);
    }

    public static WorkflowDesignerState FromJson(string json)
    {
        var data = JsonSerializer.Deserialize<JsonElement>(json);
        var state = new WorkflowDesignerState();

        if (data.TryGetProperty("Nodes", out var nodes))
        {
            state.Nodes = JsonSerializer.Deserialize<List<WorkflowNode>>(nodes.GetRawText()) ?? new();
        }

        if (data.TryGetProperty("Connections", out var connections))
        {
            state.Connections = JsonSerializer.Deserialize<List<Connection>>(connections.GetRawText()) ?? new();
        }

        return state;
    }
}
