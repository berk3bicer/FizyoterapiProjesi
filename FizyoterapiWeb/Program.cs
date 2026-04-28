using FizyoterapiWeb.Services;

var builder = WebApplication.CreateBuilder(args);

// Razor Pages
builder.Services.AddRazorPages();

// API'ye bağlanan HttpClient
builder.Services.AddHttpClient<IApiService, ApiService>(client =>
{
    var apiBaseUrl = builder.Configuration["ApiBaseUrl"] ?? "http://localhost:5114";
    client.BaseAddress = new Uri(apiBaseUrl);
});

var app = builder.Build();

// HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

app.MapRazorPages();

app.Run();