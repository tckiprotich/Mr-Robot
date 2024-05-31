global using Microsoft.EntityFrameworkCore;
global using Mr_Robot.Data;


var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.IncludeFields = true;
    });

//sqllite connection
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlite("Data Source=mrrobotapi.db");
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();

