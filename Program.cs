var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "FocusTrack API is running!");
app.MapGet("/status", () => Results.Ok(new
{
    status = "ok",
    service = "FocusTrack API",
    time = DateTime.UtcNow
}));

app.Run();