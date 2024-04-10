using ThomasGregTest.API.Configuration;

var builder = WebApplication.CreateBuilder(args);

string corsName = "CorsName";
builder.Services.AddCors(options =>
{
    options.AddPolicy(corsName, policyBuilder => policyBuilder
        .WithOrigins("http://localhost", "https://localhost")
        .AllowAnyMethod()
        .AllowAnyHeader());
});

builder.Services.ResolveDependencies();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseCors(corsName);
app.ConfigRoutes();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.Run();