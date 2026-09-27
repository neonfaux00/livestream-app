# Livestream App

An ASP.NET Core MVC starter web application for an original live-streaming platform design. It is not affiliated with or a copy of any third-party website.

## Run in Visual Studio

1. Install the .NET 8 SDK and Visual Studio with the **ASP.NET and web development** workload.
2. Clone this repository.
3. Open `LivestreamApp.csproj` in Visual Studio.
4. Press **Ctrl+F5** or run `dotnet run` from the project directory.

The app currently includes a responsive home page, browse/search page, stream cards, watch page, and mock chat. Sample thumbnails come from Unsplash; replace them with assets you own or have permission to use.

## Production work to add

- ASP.NET Core Identity and authorization
- EF Core with PostgreSQL or SQL Server
- An authorized HLS/MP4 streaming provider or your own media pipeline
- SignalR for real-time chat
- Moderation, reporting, rate limiting, and content policies
- Replace sample data in `HomeController.cs` with a database service
