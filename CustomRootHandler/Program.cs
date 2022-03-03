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
    // 1. parametrede olu�turulan controller d��� gidecek EndPoint yani istek �ekli.
    // 2. parametrede istersek bir s�n�fa y�nlendiririz istersek direk burda fonksyonnu yazabiliriz
    // bu �rnekte fonksyonu uygun bir Task<delegate> al�r biz bunu lamda yard�m�yla bu delageti yazcaz
    endpoints.Map("example-route",async x=>
    {
        // burda yap�lcak i�lemleriz
        //https://localhost:5001/example-route controller gitmez burda i�lem yapar
    });
});

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
