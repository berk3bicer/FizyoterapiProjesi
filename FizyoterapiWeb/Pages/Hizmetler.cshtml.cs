using FizyoterapiWeb.Models;
using FizyoterapiWeb.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FizyoterapiWeb.Pages;

public class HizmetlerModel : PageModel
{
    private readonly IApiService _apiService;

    public List<Service> Services { get; set; } = new();

    public HizmetlerModel(IApiService apiService)
    {
        _apiService = apiService;
    }

    public async Task OnGetAsync()
    {
        Services = await _apiService.GetServicesAsync();
    }
}