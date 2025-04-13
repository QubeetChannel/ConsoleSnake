using Tests;
using SnakeUtils;

namespace SnakeLogic {
    public class Snake {
        private List<Point> m_snake = new List<Point> {};

        public List<Point> Segments { get { return m_snake; }}
        public int Length { get { return m_snake.Count; }}
        
        private ConsoleColor m_head_color = ConsoleColor.DarkRed;
        private ConsoleColor m_body_color = ConsoleColor.Red;
        private ConsoleColor m_floor_color = ConsoleColor.DarkGreen;

        public ConsoleColor HeadColor { get { return m_head_color;} set { if (SnakeValidator.isValidateColor(value)) m_head_color = value; }}
        public ConsoleColor BodyColor { get { return m_body_color;} set { if (SnakeValidator.isValidateColor(value)) m_body_color = value; }}
        public ConsoleColor FloorColor { get { return m_floor_color;} set { if (SnakeValidator.isValidateColor(value)) m_floor_color = value; }}

        public Snake(Point Start) {
            int snakeLength = 20;

            for (int i = 0; i < snakeLength + 1; i++) // +1 для того чтобы был пиксель с полом
                m_snake.Add(new Point(Start.X, Start.Y + i));
        }
    }
}