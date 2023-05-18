using commander.Data;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddControllers().AddNewtonsoftJson(s => { 
    s.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
});
//builder.Services.AddScoped<ICommanderReop, MockCommanderRepo>();   ////Added  DEPENDENCY INJECTION
builder.Services.AddScoped<ICommanderRepo, SqlCommanderRepo>(); //Switched whole logic with one line
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies()); //Added Auto Mapper
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<CommanderContext>(options => options.UseSqlServer(   //Configure DbContext connection
    builder.Configuration.GetConnectionString("CommanderConnection")
    )) ;


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
