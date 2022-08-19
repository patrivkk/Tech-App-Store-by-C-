namespace ConsolePL;
 public class ConsoleAll{
   public static string Input()
    {
        string data = string.Empty;
        ConsoleKeyInfo key;
        while (true)
        {
            key = Console.ReadKey(true);
            
            if (key.Key == ConsoleKey.Backspace && data.Length > 0)
            {
            
                Console.Write("\b \b");
               
                data = data[0..^1];
            }
          
            else if (key.Key == ConsoleKey.Enter)
                return data;
          
            else if (!char.IsControl(key.KeyChar))
            {
                data += key.KeyChar;
                Console.Write("*");
            }
        }
    }
   public  static void Header(string header, string title, ConsoleColor[] colors)
            {
                Console.Title = title;
                // Console.WriteLine();

                Console.BackgroundColor = colors[0];
                Console.ForegroundColor = colors[1];
                Console.WriteLine(header);

                Console.ResetColor();
                Console.Write("");
                Console.BackgroundColor = colors[2];
                Console.ForegroundColor = colors[3];
                int alignment = (32 - title.Length) / 2;
                for (int i = 0; i < alignment; i++)
                    Console.Write("  ");
                Console.Write(title);
                for (int i = 0; i < alignment - 1; i++)
                    Console.Write("  ");
                Console.WriteLine("\n");
                Console.ResetColor();

            }
         public   static void HeaderWithTitleLong(string header, string title, ConsoleColor[] colors)
            {
                Console.Title = title;
                // Console.WriteLine();

                Console.BackgroundColor = colors[0];
                Console.ForegroundColor = colors[1];
                Console.WriteLine(header);

                Console.ResetColor();
                Console.Write("");
                Console.BackgroundColor = colors[2];
                Console.ForegroundColor = colors[3];
                int alignment = (39 - title.Length) / 2;
                for (int i = 0; i < alignment; i++)
                    Console.Write("  ");
                Console.Write(title);
                for (int i = 0; i < alignment - 1; i++)
                    Console.Write("  ");
                Console.WriteLine("\n");
                Console.ResetColor();

            }
          public  static void HeaderWithTitleShort(string header, string title, ConsoleColor[] colors)
            {
                Console.Title = title;
                // Console.WriteLine();

                Console.BackgroundColor = colors[0];
                Console.ForegroundColor = colors[1];
                Console.WriteLine(header);

                Console.ResetColor();
                Console.Write("");
                Console.BackgroundColor = colors[2];
                Console.ForegroundColor = colors[3];
                int alignment = (30 - title.Length) / 2;
                for (int i = 0; i < alignment; i++)
                    Console.Write("  ");
                Console.Write(title);
                for (int i = 0; i < alignment - 1; i++)
                    Console.Write("  ");
                Console.WriteLine("\n");
                Console.ResetColor();

            }

          public  static int OneColumnMenu(string[] selection_list, ConsoleColor[] colors, int index)
            {
                ConsoleKeyInfo key;
                bool isLoop = false;
                while (true)
                {
                    if (index < 0)
                        index = 0;
                    else if (index > selection_list.Length - 1)
                        index = selection_list.Length - 1;
                    if (isLoop)
                        Console.CursorTop -= selection_list.Length;
                    for (int i = 0; i < selection_list.Length; i++)
                    {
                        Console.Write($"{" ",5}");
                        if (i == index)
                        {
                            Console.BackgroundColor = colors[4];
                            Console.ForegroundColor = colors[5];
                        }
                        Console.Write($"{selection_list[i],43}");
                        if (i == index)
                        {
                            Console.ResetColor();

                        }
                        Console.WriteLine();
                    }
                    key = Console.ReadKey(true);
                    if (char.IsDigit(key.KeyChar))
                        index = Convert.ToInt32(key.KeyChar.ToString());
                    else switch (key.Key)
                        {
                            case ConsoleKey.UpArrow:
                                if (--index < 0)
                                    index = selection_list.Length - 1;
                                break;
                            case ConsoleKey.DownArrow:
                                if (++index > selection_list.Length - 1)
                                    index = 0;
                                break;
                            case ConsoleKey.Escape:
                                return -1;
                            case ConsoleKey.Enter:
                                return index;
                        }
                    isLoop = true;
                }

            }
 }