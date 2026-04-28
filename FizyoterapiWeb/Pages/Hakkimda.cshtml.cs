using FizyoterapiWeb.Models;
using FizyoterapiWeb.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FizyoterapiWeb.Pages;

public class HakkimdaModel : PageModel
{
    private readonly IApiService _apiService;

    public TherapistProfile? Therapist { get; set; }

    public HakkimdaModel(IApiService apiService)
    {
        _apiService = apiService;
    }

    public async Task OnGetAsync()
    {
        Therapist = await _apiService.GetTherapistProfileAsync();
    }
}