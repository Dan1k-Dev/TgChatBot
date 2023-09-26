<<<<<<< HEAD
using Microsoft.AspNetCore.ResponseCompression;
=======
using Microsoft.EntityFrameworkCore;
>>>>>>> master
using TgChatBotTopYou.Hubs;

namespace TgChatBotTopYou
{
    public class Program
    {
        public string[] Message { get; private set; }
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddSignalR();

            var app = builder.Build();

<<<<<<< HEAD
=======
            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

>>>>>>> master
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();
            app.MapHub<ChatHub>("/chatHub");

            app.Run();
        }
    }
}