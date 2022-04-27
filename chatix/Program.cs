namespace chatix {
    class Program {
        public static WebApplication app = WebApplication.CreateBuilder().Build();
        public static string? key;
        public static void Main(string[] args)
        {
            key = args[0];

            if (app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.UseStatusCodePagesWithRedirects("/errors/code{0}"); // Error Handilng

            app.Run();
        }
    }
}