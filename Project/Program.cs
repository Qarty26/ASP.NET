using Microsoft.EntityFrameworkCore;
using Roads.Data;
using Roads.Helpers.Extensions;
using Roads.Helpers.Seeders;
using Roads.Services.UserService;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddDbContext<RoadsContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddRepositories();
builder.Services.AddServices();
builder.Services.AddSeeder();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();
SeedData(app);


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
void SeedData(IHost app)
{
    var scopedFactory = app.Services.GetService<IServiceScopeFactory>();
    using (var scope = scopedFactory.CreateScope())
    {
        var userService = scope.ServiceProvider.GetService<UserSeeder>();
        userService.SeedInitialUsers();

        var carService = scope.ServiceProvider.GetService<CarSeeder>();
        carService.SeedInitialCars();

        var trackService = scope.ServiceProvider.GetService<TrackSeeder>();
        trackService.SeedInitialTracks();

        var hashtagService = scope.ServiceProvider.GetService<HashtagSeeder>();
        hashtagService.SeedInitialHashtags();
    }
}