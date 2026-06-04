namespace Nodler;

public class FilterButton
{
    /// <summary>Label shown on the tab button.</summary>
    public string Text { get; set; } = string.Empty;

    /// <summary>Tab color (any CSS color). Falls back to a hash color when empty.</summary>
    public string? Color { get; set; }

    /// <summary>Node categories mapped to this button. Selecting it shows nodes in any of these.</summary>
    public List<string> Categories { get; set; } = new();
}
