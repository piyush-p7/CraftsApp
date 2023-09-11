using ContosoCrafts.WebSite.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddControllers();
builder.Services.AddTransient<JsonFileProductService>();

//a new instance of JsonFileProductService will be created every time it is requested

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();
app.MapControllers();
//app.MapGet("/products", (content) =>
//{
//    var productService = app.Services.GetRequiredService<JsonFileProductService>();

//    // Call the GetProducts method on the instance
//    var products = productService.GetProducts();
//    var json = JsonSerializer.Serialize<IEnumerable<Product>>(products);
//    return content.Response.WriteAsync(json);


//});

app.Run();
