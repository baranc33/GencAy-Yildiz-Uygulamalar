var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    // 1. parametrede oluþturulan controller dýþý gidecek EndPoint yani istek þekli.
    // 2. parametrede istersek bir sýnýfa yönlendiririz istersek direk burda fonksyonnu yazabiliriz
    // bu örnekte fonksyonu uygun bir Task<delegate> alýr biz bunu lamda yardýmýyla bu delageti yazcaz
    endpoints.Map("example-route",async x=>
    {
        // burda yapýlcak iþlemleriz
        //https://localhost:5001/example-route controller gitmez burda iþlem yapar
    });
});

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
