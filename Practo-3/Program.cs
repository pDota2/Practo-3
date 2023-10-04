using System;

namespace practo3
{
    class Default
    {
        static int[] WorkOctave = new int[] { 261, 277, 293, 311, 329, 349, 369, 392, 415, 440, 466, 493 };
        static void Main()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Piano! Use keys: |Q|W|E|R|T|Y|U|I|O|P|A|S|\nOctave: F1-F3.");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Press 'Escape' to exit");
                Music();
            }
        }

        static void Music()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.Q:
                        Console.Beep(WorkOctave[0], 500);
                        break;
                    case ConsoleKey.W:
                        Console.Beep(WorkOctave[1], 500);
                        break;
                    case ConsoleKey.E:
                        Console.Beep(WorkOctave[2], 500);
                        break;
                    case ConsoleKey.R:
                        Console.Beep(WorkOctave[3], 500);
                        break;
                    case ConsoleKey.T:
                        Console.Beep(WorkOctave[4], 500);
                        break;
                    case ConsoleKey.Y:
                        Console.Beep(WorkOctave[5], 500);
                        break;
                    case ConsoleKey.U:
                        Console.Beep(WorkOctave[6], 500);
                        break;
                    case ConsoleKey.I:
                        Console.Beep(WorkOctave[7], 500);
                        break;
                    case ConsoleKey.O:
                        Console.Beep(WorkOctave[8], 500);
                        break;
                    case ConsoleKey.P:
                        Console.Beep(WorkOctave[9], 500);
                        break;
                    case ConsoleKey.A:
                        Console.Beep(WorkOctave[10], 500);
                        break;
                    case ConsoleKey.S:
                        Console.Beep(WorkOctave[11], 500);
                        break;
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                    default:
                        WorkOctave = OctaveSwitch(key.Key);
                        break;
                }
            }
        }

        public static int[] OctaveSwitch(ConsoleKey key)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            switch (key)
            {
                case ConsoleKey.F1:
                    Console.WriteLine("Октава 1");
                    return new int[] { 261, 277, 293, 311, 329, 349, 369, 392, 415, 440, 466, 493 };
                case ConsoleKey.F2:
                    Console.WriteLine("Октава 2");
                    return new int[] { 523, 554, 587, 622, 659, 698, 739, 784, 830, 880, 932, 987 };
                case ConsoleKey.F3:
                    Console.WriteLine("Октава 3");
                    return new int[] { 1046, 1108, 1174, 1244, 1318, 1396, 1480, 1568, 1661, 1720, 1864, 1975 };
                default:
                    return WorkOctave;
            }
        }
    }
}