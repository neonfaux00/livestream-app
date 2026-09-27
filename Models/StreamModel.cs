namespace LivestreamApp.Models;

public sealed class StreamModel
{
    public int Id { get; init; }
    public string Title { get; init; } = "";
    public string Creator { get; init; } = "";
    public string Category { get; init; } = "";
    public string ThumbnailUrl { get; init; } = "";
    public int Viewers { get; init; }
    public bool IsLive { get; init; }
}
