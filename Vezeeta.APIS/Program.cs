

using MediatR;
using System.Reflection;
using Vezeeta.Application.Helper;
using Vezeeta.Core;
using Vezeeta.Infrastructure;

namespace Vezeeta.APIS
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            builder.Services.AddMediatR(Assembly.GetExecutingAssembly());

            builder.Services.AddAutoMapper(typeof(MappingProfiles));
            builder.Services.AddDbContext<VezeetaContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });
            builder.Services.AddIdentity<User, IdentityRole<long>>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<VezeetaContext>()
                .AddDefaultUI()
                .AddDefaultTokenProviders();
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
        }
    }
}