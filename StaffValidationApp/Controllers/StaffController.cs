using StaffValidationApp.Models;
using StaffValidationApp.Validation;
using StaffValidationApp.Views;

namespace StaffValidationApp.Controllers;

public class StaffController
{
    private readonly StaffView _view;

    public StaffController(StaffView view)
    {
        _view = view;
    }
    
    public void ProcessStaffRegistration()
    {
        var newStaff = _view.InputStaffDetails();

        var result = StaffValidator.Validate(newStaff);

        if (result.IsValid)
        {
            _view.DisplaySuccess(newStaff);
        }
        else
        {
            _view.DisplayValidationError(result.ErrorMessage);
        }
    }
}