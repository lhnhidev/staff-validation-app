using StaffValidationApp.Controllers;
using StaffValidationApp.Views;

namespace StaffValidationApp;

class Program
{
    static void Main(string[] args)
    {
        StaffView view = new StaffView();
        StaffController controller = new StaffController(view);

        controller.ProcessStaffRegistration();

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("\n== ENTER ANY KEY TO EXIT ==");
        Console.ResetColor();
        Console.ReadKey();
    }
}