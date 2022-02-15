var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers()
    .AddDapr(); // 注入Dapr service

var app = builder.Build();

app.UseAuthorization();

app.MapControllers();

app.Run();
