var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();// controller ve view kullan�lacak
//builder.Services.AddControllers();//sadece kontroller

var app = builder.Build();
app.UseRouting();// Gelen isteklerin Rotas�n� bu middleware belirler. 

app.UseEndpoints(endpoints =>
{ 
// �imdilik defaulta ayarlad�k
    endpoints.MapDefaultControllerRoute();
});// url  ile yap�lan iste�in Var�� noktalar�n� belirtmek i�in kullan�l�r

//app.MapGet("/", () => "Hello World!");


app.Run();
