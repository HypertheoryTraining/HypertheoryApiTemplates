using Api.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.AddApiFeatureManagement();

builder.Services.AddApiServices();
builder.Services.AddApiOasGeneration();

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();