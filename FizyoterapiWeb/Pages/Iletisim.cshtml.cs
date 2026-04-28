using FizyoterapiWeb.Models;
using FizyoterapiWeb.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FizyoterapiWeb.Pages;

public class IletisimModel : PageModel
{
    private readonly IApiService _apiService;

    public TherapistProfile? Therapist { get; set; }

    public IletisimModel(IApiService apiService)
    {
        _apiService = apiService;
    }

    public async Task OnGetAsync()
    {
        Therapist = await _apiService.GetTherapistProfileAsync();
    }
}