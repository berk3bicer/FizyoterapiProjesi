using FizyoterapiWeb.Models;
using FizyoterapiWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FizyoterapiWeb.Pages;

public class RandevuModel : PageModel
{
    private readonly IApiService _apiService;

    [BindProperty]
    public Appointment Appointment { get; set; } = new();

    public List<Service> Services { get; set; } = new();
    public bool IsSuccess { get; set; }
    public bool HasError { get; set; }

    public RandevuModel(IApiService apiService)
    {
        _apiService = apiService;
    }

    public async Task OnGetAsync()
    {
        Services = await _apiService.GetServicesAsync();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        Services = await _apiService.GetServicesAsync();

        if (!ModelState.IsValid)
        {
            return Page();
        }

        var success = await _apiService.CreateAppointmentAsync(Appointment);

        if (success)
        {
            IsSuccess = true;
        }
        else
        {
            HasError = true;
        }

        return Page();
    }
}