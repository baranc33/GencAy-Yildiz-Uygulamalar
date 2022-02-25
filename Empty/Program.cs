var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();// controller ve view kullanýlacak
//builder.Services.AddControllers();//sadece kontroller

var app = builder.Build();
app.UseRouting();// Gelen isteklerin Rotasýný bu middleware belirler. 

app.UseEndpoints(endpoints =>
{ 
// þimdilik defaulta ayarladýk
    endpoints.MapDefaultControllerRoute();
});// url  ile yapýlan isteðin Varýþ noktalarýný belirtmek için kullanýlýr

//app.MapGet("/", () => "Hello World!");


app.Run();
