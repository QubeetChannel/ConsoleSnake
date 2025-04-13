using SnakeUtils;
using SnakeLogic;
using Tests;

public class Program {
    public static void Main(string[] args) {
        // MainMenu();
        Gameplay();
    }







    public static void CreateGameField() {
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.Clear();

        for (int y = 1; y < Console.WindowHeight - 1; y++) {
            for (int x = 2; x < Console.WindowWidth - 2; x++) {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.SetCursorPosition(x, y);
                Console.Write(' ');
                Console.BackgroundColor = ConsoleColor.DarkBlue;
            }
        }
    }

    public static void MainMenu() {
        Console.Title = "Qubeet's Console Snake!";

        while (true) {
            Console.Write(
                "\n" +
                "  ▄▀▀▀▄   █   █    ▄█▄    █   █   ▄▀▀▀▀   █\n" + 
                "  █       ██  █   █▀ ▀█   █  █    █       █\n" +
                "  ▀███▄   █ █ █   █▄▄▄█   ███     ████    █\n" +
                "      █   █  ██   █   █   █  █    █        \n" +
                "  ▀▄▄▄▀   █   █   █   █   █   █   ▀▄▄▄▄   █\n" +
                "\n" +
                $"    Play\n" +
                $"    Options"
            );
            
            Console.Read();
        }

    }

    public static void Gameplay() {
        CreateGameField();

        int start_x = Console.WindowWidth / 2;          // 60
        int start_y = Console.WindowHeight / 2 - 1;     // 14
        Point start_point = new Point(start_x, start_y);

        Snake Snake = new Snake(start_point);
        SnakeController Controller = new SnakeController(Snake);
        SnakeRenderer Renderer = new SnakeRenderer(Snake);
        
        Logger Logger = new Logger(Snake);

        while (true) {
            Logger.SegmentPosition();
            
            Renderer.Render();


            ConsoleKeyInfo Key = Console.ReadKey();
            Controller.Move(Key);
        }
    }
}