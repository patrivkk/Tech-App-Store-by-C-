using System;
using BL;
namespace ConsolePL;
using Persistence;


public class Program
{

    static void Main(string[] arvg)
    {

        Console.Clear();
        AppBL abl = new AppBL();
        AppsTrialBL atbl = new AppsTrialBL();
        CustomerBL cbl = new CustomerBL();
        CustomerTrialBL ctbl = new CustomerTrialBL();



        string line = @"================================================";
        string icon = @"■ ";
        string logo = @"================================================
    ╔╦╗┌─┐┌─┐┬ ┬  ╔═╗┌─┐┌─┐ ╔═╗┌┬┐┌─┐┬─┐┌─┐
     ║ ├┤ │  ├─┤  ╠=╣├─┘├─┘ ╚═╗ │ │ │├┬┘├┤                                                  
     ╩ └─┘└─┘┴ ┴  ╨ ╨┴  ┴   ╚═╝ ┴ └─┘┴└─└─┘";
        string title = "Tech App Store";
        string[] selection_list ={
 "\r1.Show all app",
    "\r2.Application management(Admin)",
    "\r3.Paid Apps and Free Apps",
    "\r4.Trial mode(Test)",
    "\r5.Supporter",
    "\r6.Rate App",
    // "\r7.Back to main menu",
    "\r8.Exit"};
        string[] selection_list_for_mainmenu1 = { "\r1.Show now", "\r2.Search app(id)", "\r3.Back to main menu" };
        string[] selection_list_for_mainmenu2 = { "\r1.Add Apps", "\r2.Update App(price)", "\r3.Delete App out of the program", "\r4.Rater", "\r5.Back to main menu" };
        string[] selection_list_for_mainmenu3 = { "\r1.Paid Apps", "\r2.Free Apps", "\r3.Back to main menu" };
        string[] selection_list_for_mainmenu3_console_paid_apps = { "\r1.Show all paids apps", "\r2.Buy app", "\r3.Back to main menu" };
        string[] selection_list_for_mainmenu3_console_free_apps = { "\r1.Show all free apps", "\r2.Down app for free", "\r3.Back to main menu" };
        string[] selection_list_for_mainmenu4 = { };///////////
        string[] selection_list_for_mainmenu5 = { "\r1.Contact with BOT support", "\r2.Chat with Supporter", "\r3.Back to main menu" };
        string[] selection_list_for_mainmenu6 = { "\r1.♥ ≈ Too bad ", "\r2.♥ ♥ ≈ so so", "\r3.♥ ♥ ♥ ≈ Fine", "\r4.♥ ♥ ♥ ♥ ≈ Good", "\r5.♥ ♥ ♥ ♥ ♥ ≈ Nicee!", "\r6.Back to main menu" };
        string[] selection_list_for_mainmenu6_console1 = { "\r1.The system is not stable", "\r2.The function is malfunctioning", "\r3.Loading time is too long", "\r4.Slow system authentication", "\r►Add your comments:" };
        string[] selection_list_for_mainmenu6_console2 = { "\r1.Need to edit a few details.", "\r2.Not optimized for how it works", "\r►Add your comments:" };
        string[] selection_list_for_mainmenu6_console3 = { "\r1.It's okay to use", "\r2.There is still an error but it is not significant", "\r3.Need to develop more on the interface part", "\r►Add your comments:" };
        string[] selection_list_for_mainmenu6_console4 = { "\r1.Good app", "\r2.I like this app", "\r3.The app to look forward to in the future", "\r►Add your comments:" };
        string[] selection_list_for_mainmenu6_console5 = { "\r1.Very good", "\r2.The publisher idea is great", "\r3.Not a single mistake, very meticulous design", "\r►Add your comments:" };
        ConsoleColor[] colors ={ConsoleColor.Black,ConsoleColor.Green,
            ConsoleColor.Yellow,ConsoleColor.Black,ConsoleColor.White,ConsoleColor.Black};
        Console.CursorVisible = false;

        ConsoleAll.Header(logo, title, colors);
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.ForegroundColor = colors[3];
        for (int i = 1; i <= 20; i++)
        {
            Console.Write(icon);
            Thread.Sleep(100);
        }
        Console.ResetColor();
        Console.Clear();
        ConsoleAll.Header(logo, title, colors);
        int choice;
        do
        {
            string result;

            switch (ConsoleAll.OneColumnMenu(selection_list, colors, 0))
            {

                case 0:
                    Console.Clear();
                    try
                    {
                        List<App> listapp = abl.GetAllApps();
                        if (listapp == null || listapp.Count == 0)
                        {
                            Console.WriteLine("...");
                        }
                        else
                            foreach (App item in listapp)
                            {
                                Console.WriteLine(item.AppId);
                                Console.WriteLine(item.AppName);
                                Console.WriteLine(item.AppPrice);
                                Console.WriteLine(item.AppType);
                                Console.WriteLine(item.AppVersion);
                                Console.WriteLine(item.AppDateDebut);
                            }

                        Console.WriteLine();

                        string titlee = "Show All App";
                        ConsoleAll.Header(logo, titlee, colors);
                        switch (ConsoleAll.OneColumnMenu(selection_list_for_mainmenu1, colors, 0))
                        {
                            case 0:

                                Console.Clear();
                                break;
                            case 1:
                                Console.Clear();
                                break;
                            case 2:
                                Console.Clear();
                                break;

                        }
                    }
                    catch { }
                    break;
                case 1:

                    Console.Clear();
                    Console.WriteLine();
                    string titleee = "Application management(Admin)";
                    ConsoleAll.HeaderWithTitleLong(logo, titleee, colors);
                    string pass = "thanhvip6d";
                    string dataa;
                    do
                    {
                        Console.Write("Enter password:");
                        dataa = ConsoleAll.Input();
                        Console.WriteLine();
                        if (pass != dataa)
                        {
                            Console.WriteLine("PASSWORD INCORRECTLY, RE-ENTER:");
                        }

                    } while (pass != dataa);

                    Console.Clear();
                    ConsoleAll.HeaderWithTitleLong(logo, titleee, colors);
                    switch (ConsoleAll.OneColumnMenu(selection_list_for_mainmenu2, colors, 0))
                    {
                        case 0:
                            Console.Clear();
                            break;
                        case 1:
                            Console.Clear();
                            break;
                        case 2:
                            Console.Clear();
                            break;

                        case 3:
                            Console.Clear();
                            ConsoleAll.Header(logo, titleee, colors);
                            Console.WriteLine("You want see rater about star?");
                            Console.WriteLine("1.1 star");
                            Console.WriteLine("1.2 star");
                            Console.WriteLine("1.3 star");
                            Console.WriteLine("1.4 star");
                            Console.WriteLine("1.4 star");
                            Console.Write("#Your Choice:");
                            int.TryParse(Console.ReadLine(), out choice);
                            break;
                        case 4:
                            Console.Clear();
                            break;
                    }
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine();
                    string titleeee = "Paid Apps and Free Apps";
                    ConsoleAll.HeaderWithTitleLong(logo, titleeee, colors);

                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine();
                    string title4 = "Trial mode(Test)";
                    ConsoleAll.Header(logo, title4, colors);
                    switch (ConsoleAll.OneColumnMenu(selection_list_for_mainmenu4, colors, 0))
                    {
                        case 0:
                            break;
                    }
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine();
                    string title5 = "Supporter";
                    ConsoleAll.HeaderWithTitleShort(logo, title5, colors);
                    switch (ConsoleAll.OneColumnMenu(selection_list_for_mainmenu5, colors, 0))
                    {
                        case 0:
                            break;
                    }
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine();
                    string title6 = "Rate App";
                    ConsoleAll.HeaderWithTitleShort(logo, title6, colors);
                    switch (ConsoleAll.OneColumnMenu(selection_list_for_mainmenu6, colors, 0))
                    {
                        case 0:
                            Console.Clear();
                            ConsoleAll.HeaderWithTitleShort(logo, title6, colors);
                            switch (ConsoleAll.OneColumnMenu(selection_list_for_mainmenu6_console1, colors, 0))
                            {
                                case 0:
                                    Console.Clear();
                                    Console.WriteLine(line);
                                    Console.WriteLine("Thank you for your note, we will fix it later.");
                                    Console.WriteLine("Press ramdom key to back menu...");
                                    Console.WriteLine(line);
                                    break;
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine(line);
                                    Console.WriteLine("Thank you for your note, we will fix it later.");
                                    Console.WriteLine("Press ramdom key to back menu...");
                                    Console.WriteLine(line);
                                    break;
                                case 2:
                                    Console.Clear();
                                    Console.WriteLine(line);
                                    Console.WriteLine("Thank you for your note, we will fix it later.");
                                    Console.WriteLine("Press ramdom key to back menu...");
                                    Console.WriteLine(line);
                                    break;
                                case 3:
                                    Console.Clear();
                                    Console.WriteLine(line);
                                    Console.WriteLine("Thank you for your note, we will fix it later.");
                                    Console.WriteLine("Press ramdom key to back menu...");
                                    Console.WriteLine(line);
                                    break;
                                case 4:
                                    Console.Clear();
                                    ConsoleAll.HeaderWithTitleShort(logo, title6, colors);
                                    string writeCmt;
                                    Console.Write("►Add your comments:");
                                    writeCmt = Console.ReadLine();
                                    string addcmt = "♥:";
                                    File.AppendAllText("Comments.txt", addcmt + writeCmt + "\n");
                                    break;
                            }
                            break;
                        case 1:
                            Console.Clear();
                            ConsoleAll.HeaderWithTitleShort(logo, title6, colors);
                            switch (ConsoleAll.OneColumnMenu(selection_list_for_mainmenu6_console2, colors, 0))
                            {
                                case 0:
                                    Console.WriteLine(line);
                                    Console.WriteLine("Thank you for your note, we will fix it later.");
                                    Console.WriteLine("Press ramdom key to back menu...");
                                    Console.WriteLine(line);
                                    break;
                                case 1:
                                    Console.WriteLine(line);
                                    Console.WriteLine("Thank you for your note, we will fix it later.");
                                    Console.WriteLine("Press ramdom key to back menu...");
                                    Console.WriteLine(line);
                                    break;
                                case 2:
                                    Console.Clear();
                                    Console.Clear();
                                    ConsoleAll.HeaderWithTitleShort(logo, title6, colors);
                                    string writeCmt;
                                    Console.Write("►Add your comments:");
                                    writeCmt = Console.ReadLine();
                                    string addcmt = "♥ ♥:";
                                    File.AppendAllText("Comments.txt", addcmt + writeCmt + "\n");
                                    break;


                            }
                            break;
                        case 2:
                            Console.Clear();
                            ConsoleAll.HeaderWithTitleShort(logo, title6, colors);
                            switch (ConsoleAll.OneColumnMenu(selection_list_for_mainmenu6_console3, colors, 0))
                            {
                                case 0:
                                    Console.Clear();
                                    Console.WriteLine(line);
                                    Console.WriteLine("Thank you for your note");
                                    Console.WriteLine("Press ramdom key to back menu...");
                                    Console.WriteLine(line);
                                    break;

                                case 1:
                                    Console.Clear();
                                    Console.WriteLine(line);
                                    Console.WriteLine("Thank you for your note");
                                    Console.WriteLine("Press ramdom key to back menu...");
                                    Console.WriteLine(line);
                                    break;
                                case 2:
                                    Console.Clear();
                                    Console.WriteLine(line);
                                    Console.WriteLine("Thank you for your note");
                                    Console.WriteLine("Press ramdom key to back menu...");
                                    Console.WriteLine(line);
                                    break;
                                case 3:
                                    Console.Clear();
                                    ConsoleAll.HeaderWithTitleShort(logo, title6, colors);
                                    string writeCmt;
                                    Console.Write("►Add your comments:");
                                    writeCmt = Console.ReadLine();
                                    string addcmt = "♥ ♥ ♥:";
                                    File.AppendAllText("Comments.txt", addcmt + writeCmt + "\n");
                                    break;
                            }
                            break;

                        case 3:

                            Console.Clear();
                            ConsoleAll.HeaderWithTitleShort(logo, title6, colors);
                            switch (ConsoleAll.OneColumnMenu(selection_list_for_mainmenu6_console4, colors, 0))
                            {
                                case 0:
                                    Console.Clear();
                                    Console.WriteLine(line);
                                    Console.WriteLine("Thank you for using the app");
                                    Console.WriteLine("Press ramdom key to back menu...");
                                    Console.WriteLine(line);
                                    break;
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine(line);
                                    Console.WriteLine("Thank you for using the app");
                                    Console.WriteLine("Press ramdom key to back menu...");
                                    Console.WriteLine(line);
                                    break;
                                case 2:
                                    Console.Clear();
                                    Console.WriteLine(line);
                                    Console.WriteLine("Thank you for using the app");
                                    Console.WriteLine("Press ramdom key to back menu...");
                                    Console.WriteLine(line);
                                    break;
                                case 3:
                                    Console.Clear();
                                    string writeCmt;
                                    ConsoleAll.HeaderWithTitleShort(logo, title6, colors);
                                    Console.Write("►Add your comments:");
                                    writeCmt = Console.ReadLine();
                                    string addcmt = "♥ ♥ ♥ ♥:";
                                    File.AppendAllText("Comments.txt", addcmt + writeCmt + "\n");


                                    break;
                            }
                            break;
                        case 4:
                            Console.Clear();
                            ConsoleAll.HeaderWithTitleShort(logo, title6, colors);
                            switch (ConsoleAll.OneColumnMenu(selection_list_for_mainmenu6_console5, colors, 0))
                            {
                                case 0:
                                    Console.Clear();
                                    Console.WriteLine(line);
                                    Console.WriteLine("Thank you for using the app");
                                    Console.WriteLine("Press ramdom key to back menu...");
                                    Console.WriteLine(line);
                                    break;
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine(line);
                                    Console.WriteLine("Thank you for using the app");
                                    Console.WriteLine("Press ramdom key to back menu...");
                                    Console.WriteLine(line);
                                    break;
                                case 2:
                                    Console.Clear();
                                    Console.WriteLine(line);
                                    Console.WriteLine("Thank you for using the app");
                                    Console.WriteLine("Press ramdom key to back menu...");
                                    Console.WriteLine(line);
                                    break;
                                case 3:
                                    string writeCmt;
                                    ConsoleAll.HeaderWithTitleShort(logo, title6, colors);
                                    Console.Write("►Add your comments:");
                                    writeCmt = Console.ReadLine();
                                    string addcmt = "♥ ♥ ♥ ♥ ♥:";
                                    File.AppendAllText("Comments.txt", addcmt + writeCmt + "\n");
                                    break;
                            }
                            break;

                    }
                    break;
            }
            // Console.Clear();
            ConsoleAll.Header(logo, title, colors);
            // Console.Clear();
        } while (true);

    }
}
