ConsoleKeyInfo keyg;
int posg = 0;
ConsoleKeyInfo keyv;
int posv = 1;
Console.WriteLine("Начало - стрелка вправо");
do
{
    do
    {
        keyg = Console.ReadKey();
        if (keyg.Key == ConsoleKey.LeftArrow)
        {
            posg--;
            if (posg == 0)
                posg = 4;
        }
        else if (keyg.Key == ConsoleKey.RightArrow)
        {
            posg++;
            if (posg == 5)
                posg = 1;
        }
        if (keyg.Key != ConsoleKey.Escape)
        {
            switch (posg)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("  Ежедневник");
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("  23.10.23");
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("  24.10.23");
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("  25.10.23");
                    break;
            }
        }
    } while (!((keyg.Key == ConsoleKey.Enter) || (keyg.Key == ConsoleKey.Escape)));
    if (keyg.Key == ConsoleKey.Enter)
    {
        switch (posg)
        {

            case 1:
                Console.Clear();
                Console.WriteLine("Ежедневник");
                Console.WriteLine("Любая кнопка - назад");
                Console.WriteLine("Escape - выход");
                break;
            case 2:
                Console.Clear();
                Console.WriteLine("какое дело выберите?");
                Console.WriteLine("  1. дело");
                Console.WriteLine("  2. дело");
                do
                {
                    Console.SetCursorPosition(0, posv);
                    Console.WriteLine("->");

                    keyv = Console.ReadKey();
                    Console.SetCursorPosition(0, posv);
                    Console.WriteLine("  ");

                    if (keyv.Key == ConsoleKey.UpArrow)
                    {
                        posv--;
                        if (posv == 0)
                            posv = 2;
                    }
                    else if (keyv.Key == ConsoleKey.DownArrow)
                    {
                        posv++;
                        if (posv == 3)
                            posv = 1;
                    }
                } while (keyv.Key != ConsoleKey.Enter);

                Console.SetCursorPosition(0, 6);
                if (posv == 1)
                {
                    Console.Clear();
                    Console.WriteLine("1.Сыграть в доту");
                }
                if (posv == 2)
                {
                    Console.Clear();
                    Console.WriteLine("2.Сделать домашнее задание");
                }
                break;
            case 3:
                Console.Clear();
                Console.WriteLine("Дел нет на этот день");
                break;
            case 4:
                Console.Clear();
                Console.WriteLine("какое дело выберите?");
                Console.WriteLine("  1. дело");
                do
                {
                    Console.SetCursorPosition(0, posv);
                    Console.WriteLine("->");

                    keyv = Console.ReadKey();
                    Console.SetCursorPosition(0, posv);
                    Console.WriteLine("  ");

                    if (keyv.Key == ConsoleKey.UpArrow)
                    {
                        posv--;
                        if (posv == 0)
                            posv = 1;
                    }
                    else if (keyv.Key == ConsoleKey.DownArrow)
                    {
                        posv++;
                        if (posv == 2)
                            posv = 1;
                    }
                } while (keyv.Key != ConsoleKey.Enter);

                Console.SetCursorPosition(0, 6);
                if (posv == 1)
                {
                    Console.Clear();
                    Console.WriteLine("1.Ничего не делать");
                }
                break;
        }
    }
} while (keyg.Key != ConsoleKey.Escape);
