using System;
namespace PatronesEstructurales
{

	public interface Shape {
		void draw(int x, int y, int z, int j);
	}


	public class Line {

		public void draw(int x1, int y1, int x2, int y2) {
            Console.WriteLine("Line from point A(" + x1 + ";" + y1 + "), to point B(" + x2 + ";" + y2 + ")");
        }
	}

	public class Rectangle {
		public void draw(int x, int y , int width, int height) {

            Console.WriteLine("Rectangle with coordinate left-down point (" + x + ";" + y + "), width: " + width
                + ", height: " + height);
        }
	}


    public class LineAdapter : Shape
    {
        private Line adaptee;

        public LineAdapter(Line line)
        {
            this.adaptee = line;
        }

        public void draw(int x, int y, int z, int j)
        {
            adaptee.draw(x, y, z, j);
        }
    }

    public class RectangleAdapter : Shape
    {
        private Rectangle adaptee;

        public RectangleAdapter(Rectangle rectangle)
        {
            this.adaptee = rectangle;
        }

        public void draw(int x1, int y1, int x2, int y2)
        {
            int x = Math.Min(x1,x2);
            int y = Math.Min(y1, y2);
            int width = Math.Abs(x2 - x1);
            int height = Math.Abs(y2 - y1);
            adaptee.draw(x, y, width, height);
        }
    }
}

