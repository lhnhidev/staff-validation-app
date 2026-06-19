using System.Reflection;
using System.Text.RegularExpressions;
using StaffValidationApp.Attributes;
using StaffValidationApp.Dto;
using StaffValidationApp.Models;

namespace StaffValidationApp.Validation;

public static class StaffValidator
{
    public static StaffValidatorDto Validate(Staff staff)
    {
        Type StaffType = staff.GetType();
        List<PropertyInfo> properties = StaffType.GetProperties().ToList();

        if (properties != null && properties.Count > 0)
        {
            foreach (PropertyInfo prop in properties)
            {
                var value = prop.GetValue(staff)?.ToString() ?? "";

                var emailAttr = prop.GetCustomAttribute<EmailCheckAttribute>();
                if (emailAttr != null && !Regex.IsMatch(value, emailAttr.RE))
                {
                    return new StaffValidatorDto(false, $"Field '{prop.Name}' ({value}) was not validated correctly.");
                }

                var phoneAttr = prop.GetCustomAttribute<PhoneCheckAttribute>();
                if (phoneAttr != null && !Regex.IsMatch(value, phoneAttr.RE))
                {
                    return new StaffValidatorDto(false, $"Field '{prop.Name}' ({value}) was not validated correctly.");
                }
            }
        }

        return new StaffValidatorDto(true, "Approved!");
    }
}