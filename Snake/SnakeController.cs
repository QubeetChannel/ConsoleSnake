using SnakeUtils;

namespace SnakeLogic {
    public class SnakeController {
        private Snake Snake;
        public Direction _lastDirection = Direction.Up;

        public SnakeController(Snake Snake) {
            this.Snake = Snake;
        }
        public void Move(ConsoleKeyInfo Key) {
            switch (Key.Key) {
                case ConsoleKey.UpArrow:
                    Move(Direction.Up);
                    break;
                case ConsoleKey.DownArrow:
                    Move(Direction.Down);
                    break;
                case ConsoleKey.LeftArrow:
                    Move(Direction.Left);
                    break;
                case ConsoleKey.RightArrow:
                    Move(Direction.Right);
                    break;
            }
        }
        public void Move(Direction dir) {

            if (dir == Direction.Up && _lastDirection == Direction.Down ||
                dir == Direction.Down && _lastDirection == Direction.Up ||
                dir == Direction.Left && _lastDirection == Direction.Right ||
                dir == Direction.Right && _lastDirection == Direction.Left)
            { return ; }

            for (int i = Snake.Length - 1; i > 0; i--) {
                Snake.Segments[i] = Snake.Segments[i-1];
            }
            
            Snake.Segments[0] = new Point(Snake.Segments[0].X, Snake.Segments[0].Y);

            switch (dir) {
                case Direction.Up:
                    Snake.Segments[0].Y -= 1;
                    break;
                case Direction.Down:
                    Snake.Segments[0].Y += 1;
                    break;
                case Direction.Left:
                    Snake.Segments[0].X -= 2;
                    break;
                case Direction.Right:
                    Snake.Segments[0].X += 2;
                    break;
            }
            // Body[0].X += offset.X; 
            // Body[0].Y += offset.Y
            // МОЖНО ВООБЩЕ ВСЁ ПРИВЯЗАТЬ К ОФФСЕТАМ, ЗМЕЙКА В ЛЮБОЙ МОМЕНТ ИГРЫ НЕ МОЖЕТ ИМЕТЬ НУЛЕВОЙ ОФФСЕТ
            // в базе этого метода можно указать что если оффсет при сложении с нажатой кнопкой получает 0.0 то ничего не делать
            // это проще чем проверять каждое направление
            _lastDirection = dir;
        }
    }
}