using Microsoft.AspNetCore.Mvc;

namespace LivestreamApp.Controllers;

public class StreamsController : Controller
{
    public IActionResult Index(string? search, string? category)
    {
        var streams = SampleStreams.All.AsEnumerable();
        if (!string.IsNullOrWhiteSpace(search))
            streams = streams.Where(s => s.Title.Contains(search, StringComparison.OrdinalIgnoreCase) || s.Creator.Contains(search, StringComparison.OrdinalIgnoreCase));
        if (!string.IsNullOrWhiteSpace(category))
            streams = streams.Where(s => s.Category.Equals(category, StringComparison.OrdinalIgnoreCase));
        ViewBag.Search = search;
        ViewBag.Category = category;
        return View(streams);
    }

    public IActionResult Watch(int id)
    {
        var stream = SampleStreams.All.FirstOrDefault(s => s.Id == id);
        return stream is null ? NotFound() : View(stream);
    }
}
