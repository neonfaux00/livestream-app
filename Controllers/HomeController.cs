using LivestreamApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace LivestreamApp.Controllers;

public class HomeController : Controller
{
    public IActionResult Index() => View(SampleStreams.All.Take(4));

    public IActionResult Error() => View();
}

public static class SampleStreams
{
    public static readonly IReadOnlyList<StreamModel> All =
    [
        new() { Id = 1, Title = "Late Night Championship", Creator = "EpicArena", Category = "Esports", Viewers = 12400, IsLive = true, ThumbnailUrl = "https://images.unsplash.com/photo-1542751371-adc38448a05e?auto=format&fit=crop&w=900&q=80" },
        new() { Id = 2, Title = "Building a New World", Creator = "PixelSmith", Category = "Gaming", Viewers = 8300, IsLive = true, ThumbnailUrl = "https://images.unsplash.com/photo-1511512578047-dfb367046420?auto=format&fit=crop&w=900&q=80" },
        new() { Id = 3, Title = "Acoustic Sessions", Creator = "MayaMusic", Category = "Music", Viewers = 3900, IsLive = true, ThumbnailUrl = "https://images.unsplash.com/photo-1516280440614-37939bbacd81?auto=format&fit=crop&w=900&q=80" },
        new() { Id = 4, Title = "Designing for the Web", Creator = "CreateLab", Category = "Creative", Viewers = 2100, IsLive = true, ThumbnailUrl = "https://images.unsplash.com/photo-1558655146-d09347e92766?auto=format&fit=crop&w=900&q=80" },
        new() { Id = 5, Title = "Weekend Football Review", Creator = "ThePressBox", Category = "Sports", Viewers = 1700, IsLive = false, ThumbnailUrl = "https://images.unsplash.com/photo-1461896836934-ffe607ba8211?auto=format&fit=crop&w=900&q=80" }
    ];
}
