namespace SnakeLogic {
    public class SnakeRenderer {
        private Snake m_snake;

        public SnakeRenderer(Snake Snake) {
            m_snake = Snake;
        }

        public void Render() {
            DrawPixel(m_snake.Segments[0].X, m_snake.Segments[0].Y, m_snake.HeadColor);

            for (int i = 1; i < m_snake.Length - 1; i++)
                DrawPixel(m_snake.Segments[i].X, m_snake.Segments[i].Y, m_snake.BodyColor);

            DrawPixel(m_snake.Segments[m_snake.Length - 1].X, m_snake.Segments[m_snake.Length - 1].Y, m_snake.FloorColor);
            
            Console.SetCursorPosition(2, 28);
        }

        public void DrawPixel(int X, int Y, ConsoleColor Color) {
            Console.SetCursorPosition(X, Y);
            Console.BackgroundColor = Color;
            Console.Write("  ");
        }
    }
}