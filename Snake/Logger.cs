using SnakeLogic;

namespace Tests {
    public class Logger {
        private Snake Snake;

        public Logger(Snake Snake) {
            this.Snake = Snake;
        }

        public void SegmentPosition() {
            Console.SetCursorPosition(0, 0);
            Console.BackgroundColor = ConsoleColor.Black;
            foreach (var seg in Snake.Segments) {
                Console.WriteLine($"({seg.X}, {seg.Y})");
            }
        }
    }

    public static class SnakeValidator {
        public static bool isValidateColor(ConsoleColor Color) {
            ConsoleColor[] BannedColors = {
                ConsoleColor.DarkBlue,      // 1 
                ConsoleColor.DarkGreen,     // 2
                ConsoleColor.DarkCyan,      // 3
                ConsoleColor.Blue,          // 9
                ConsoleColor.Green,         // 10
                ConsoleColor.Cyan           // 11
            };
            foreach (var bColor in BannedColors)
                if (Color == bColor) return false;
            return true;
        }
    }
}