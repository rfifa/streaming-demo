var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
var realities = new[]
{
    "a fazenda", "big brother", "casa dos artistas", "no limite", "master chef", "the voice"
};
app.MapGet("/", () => "Hello World!");
app.MapGet("/api/realities", () => realities);
app.Run();