namespace StaffValidationApp.Attributes;

[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = true)] 
public class EmailCheckAttribute : Attribute {     
    public string RE { get; set; } 
    public EmailCheckAttribute(string re) 
    { 
        this.RE = re; 
    } 
}