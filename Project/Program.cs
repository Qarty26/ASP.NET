using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Roads.Data;
using Roads.Helpers.Extensions;
using Roads.Helpers.Seeders;
using Roads.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;

var builder = WebApplication.CreateBuilder(args);
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins, policy =>
    {
        policy.WithOrigins("http://localhost:5173", "https://localhost:5173")
            .AllowAnyHeader()
            .AllowAnyMethod()
            .AllowCredentials();
    });
});


builder.Services.AddControllers();
builder.Services.AddDbContext<RoadsContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


builder.Services.AddIdentity<User, IdentityRole<Guid>>()
                .AddRoles<IdentityRole<Guid>>()
                .AddEntityFrameworkStores<RoadsContext>();

builder.Services.Configure<IdentityOptions>(opt =>
{
    opt.Password.RequireDigit = false;
    opt.Password.RequiredLength = 8;
    opt.User.RequireUniqueEmail = true;
    opt.SignIn.RequireConfirmedAccount = false;
    opt.SignIn.RequireConfirmedEmail = false;
    opt.SignIn.RequireConfirmedPhoneNumber = false;
});

FirebaseApp.Create(new AppOptions()
{
    Credential = GoogleCredential.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "roads-26-firebase-adminsdk-8y7lv-bab55fd584.json"))
});

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
app.UseCors(MyAllowSpecificOrigins);
app.UseAuthentication();
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

        var roleService = scope.ServiceProvider.GetService<RoleSeeder>();
        roleService.SeedInitialRoles();

        var userRoleService = scope.ServiceProvider.GetService<UserRoleSeeder>();
        userRoleService.SeedInitialUserRole();

        var carService = scope.ServiceProvider.GetService<CarSeeder>();
        carService.SeedInitialCars();

        var mapService = scope.ServiceProvider.GetService<MapSeeder>();
        mapService.SeedInitialMaps();

        var trackService = scope.ServiceProvider.GetService<TrackSeeder>();
        trackService.SeedInitialTracks();

        var hashtagService = scope.ServiceProvider.GetService<HashtagSeeder>();
        hashtagService.SeedInitialHashtags();

        var trackHashtagService = scope.ServiceProvider.GetService<TrackHashtagRelationSeeder>();
        trackHashtagService.SeedInitialTrackHashtags();

        var userTrackCarService = scope.ServiceProvider.GetService<UserTrackCarSeeder>();
        userTrackCarService.SeedInitialUTC();


    }
}