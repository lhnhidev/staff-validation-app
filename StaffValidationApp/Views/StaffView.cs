using StaffValidationApp.Models;

namespace StaffValidationApp.Views;

public class StaffView
{
    public Staff InputStaffDetails()
    {
        Staff staff = new Staff();
        Console.WriteLine("=== PROGRAM ENTER INFORMATION OF STAFF ===");
            
        Console.Write("Id staff (please enter number): ");
        staff.StaffId = int.Parse(Console.ReadLine());

        Console.Write("Name: ");
        staff.StaffName = Console.ReadLine();

        Console.Write("Email: ");
        staff.Email = Console.ReadLine();

        Console.Write("Number phone: ");
        staff.PhoneNumber = Console.ReadLine();

        return staff;
    }

    public void DisplaySuccess(Staff staff)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\n[Success] Staff '{staff.StaffName}' have added!");
        Console.ResetColor();
    }

    public void DisplayValidationError(string error)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"\n[Bad request] {error}");
        Console.ResetColor();
    }
}