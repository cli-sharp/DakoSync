using System.Text.Json.Serialization;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options => options.OperationFilter<OperationFilter>());
builder.Services.AddControllers().AddJsonOptions(options =>
    options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.Run();

public class OperationFilter : IOperationFilter
{
    public void Apply(OpenApiOperation operation, OperationFilterContext context)
    {
        operation.Responses.Add("400", new OpenApiResponse() { Description = "Model invalid" });
        operation.Responses.Add("401", new OpenApiResponse() { Description = "Unauthorized" });
        operation.Responses.Add("404", new OpenApiResponse() { Description = "UID not found" });
        operation.Responses.Add("409", new OpenApiResponse() { Description = "UID already exists" });
        operation.Responses.Add("500", new OpenApiResponse() { Description = "Internal server error" });
    }
}