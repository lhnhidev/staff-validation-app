namespace StaffValidationApp.Attributes;

[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = true)] 
public class PhoneCheckAttribute : Attribute {     
    public string RE { get; set; }

    public PhoneCheckAttribute(string re)
    {
        this.RE = re;
    }
}