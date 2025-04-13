namespace SnakeUtils {

    public enum Direction {
        Up, Right, Down, Left
    }

    public class Point {
        private int m_x;
        private int m_y;

        public int X {
            get { return m_x; }
            set { if (value >= 0 && value < 120) m_x = value; }
        }

        public int Y {
            get { return m_y; }
            set { if (value >= 0 && value < 30) m_y = value; }
        }

        public Point(int X, int Y) {
            this.X = X;
            this.Y = Y;
        }
    }
}