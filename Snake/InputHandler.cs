namespace Input {
    public class InputHandler {
        public void Execute(ConsoleKeyInfo InputKey) {
            if (InputKey.Key == ConsoleKey.UpArrow ||
                InputKey.Key == ConsoleKey.DownArrow ||
                InputKey.Key == ConsoleKey.LeftArrow ||
                InputKey.Key == ConsoleKey.RightArrow) 
            {}
        }
    }
}