using StaffValidationApp.Attributes;

namespace StaffValidationApp.Models;

public class Staff
{
    public int StaffId { get; set; }
    public string StaffName { get; set; } = string.Empty;

    [EmailCheck(@"^\S+@\S+\.\S+$")]
    public string Email { get; set; } = string.Empty;

    [PhoneCheck(@"^(\+?\d{1,3})?[-.\s]?\(?\d{1,4}\)?[-.\s]?\d{3,4}[-.\s]?\d{3,4}$")]
    public string PhoneNumber { get; set; } = string.Empty;
}