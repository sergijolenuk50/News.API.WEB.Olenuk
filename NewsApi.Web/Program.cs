using NewsApi.Infrastructure;
using NewsApi.Core;

var builder = WebApplication.CreateBuilder(args);

// Crete connection string
string conStr = builder.Configuration.GetConnectionString("DefaultConnection");

// Add AppDbContext
builder.Services.AddDbContext(conStr);
// Add Repository
builder.Services.AddRepositoryes();
// Add Core Services
builder.Services.AddCoreServices(); 
// Add Mapper
builder.Services.AddMapping();
// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
