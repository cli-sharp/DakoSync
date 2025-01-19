using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers().AddJsonOptions(options => options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}

public record Account
{
    public string AccountUId { get; set; }
    public string Name { get; set; }
    public bool Blocked { get; set; }
    public bool Active { get; set; }
}

public record WfsObject
{
    public string WfsObjectUId { get; set; }
    public string Vin { get; set; }
    public bool Active { get; set; }
    public FeatureType Feature { get; set; }
    public DateOnly Termination { get; set; }
}

public record DakoOnlyVehicle
{
    public string Vin { get; set; }
    public bool Active { get; set; }
}

public record DakoOnlyDriver
{
    public string CardNumber { get; set; }
    public bool Active { get; set; }
}

public record WfsDriver
{
    public string DriverUId{ get; set; }
    public string Name { get; set; }
    public string CardNumber { get; set; }
    public bool Active { get; set; }
}

public enum FeatureType
{
    REMOTE_TACHO,
    REMOTE_TACHO_PLUS
}