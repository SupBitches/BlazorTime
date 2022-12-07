using BlazorShared;
using HelloBlazor.Services;
using Microsoft.AspNetCore.Components;

namespace HelloBlazor.Pages;

public partial class EmployeeOverview
{
    public IEnumerable<Employee> Employees { get; set; }

    [Inject]
    public IEmployeeDataService EmployeeDataService { get; set; }

    protected async override Task OnInitializedAsync()
    {
        Employees = (await EmployeeDataService.GetAllEmployees().ConfigureAwait(false)).ToList();

        await base.OnInitializedAsync().ConfigureAwait(false);
    }

}
