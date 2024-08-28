namespace Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();


            var app = builder.Build();

            app.UseRouting();
            app.UseStaticFiles();

            //app.Use(async (context, next) =>

            //{

            //    Endpoint endpoint = context.GetEndpoint();

            //    if(endpoint is null)
            //        await context.Response.WriteAsync("Your Requested Page Not Found");

            //    await next();
            //});

            #region MyRegion

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/Home", async context =>
            //    {
            //        await context.Response.WriteAsync("You Are at Home Page");
            //    });


            //    endpoints.MapGet("/Products/{id:int?}", async context =>
            //    {
            //        var idData = context.Request.RouteValues["id"];

            //        if (idData is not null)
            //        {
            //            int id = Convert.ToInt32(idData);
            //            await context.Response.WriteAsync($"Your Request Product With Id => {id} ");
            //        }

            //        else
            //            await context.Response.WriteAsync("You Are at Products Page");


            //    });


            //    endpoints.MapGet("/Books/{id}/{auther:alpha:minlength(4):maxlength(6)}", async context =>
            //    {

            //        int id = Convert.ToInt32(context.Request.RouteValues["id"]);
            //        string auther = context.Request.RouteValues["auther"].ToString();

            //        await context.Response.WriteAsync($"Your Request Book With Id => {id} and Author => {auther} ");
            //    });




            //});

            //app.Run(async (HttpContext) =>
            //{

            //    await HttpContext.Response.WriteAsync("Your Requested Page Not Found");

            //}); 
            #endregion

            app.MapControllerRoute(

                name: "default",
                pattern: "/{Controller=Home}/{Action=Index}",
                defaults:new { Controller = "Home" , Action = "Index"}


                );

            app.Run();
        }
    }
}
