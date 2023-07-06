using System;
namespace PatronesEstructurales
{

	public abstract class Widget {
		public abstract void draw();
	}

    public class TextField : Widget
    {
        private int width, height;

        public TextField(int width, int height) {
            this.width = width;
            this.height = height;
        }


        public override void draw()
        {
            Console.WriteLine("TextField: " + width + ", " + height);
        }
    }

    public abstract class Decorator : Widget
	{
        protected Widget widget;

        public Decorator(Widget widget) {
            this.widget = widget;
        }

        public void SetWidget(Widget wdiget) {

            this.widget = wdiget;
        }

        public override void draw()
        {
            widget.draw();
        }
    }

    public class BorderDecorator : Decorator
    {
        public BorderDecorator(Widget widget) : base(widget)
        {
        }

        public void draw()
        {
            base.draw();
            Console.WriteLine("BorderDecorator");
        }
    }

    public class ScrollDecorator : Decorator
    {
        public ScrollDecorator(Widget widget) : base(widget)
        {
        }

        public void draw()
        {
            base.draw();
            Console.WriteLine("ScrollDecorator");
        }
    }

    public class DecoratorDemo
    {
        public void Demo()
        {
            // 8. Client has the responsibility to compose desired configurations
            Widget widget = new BorderDecorator(new BorderDecorator(new ScrollDecorator(new TextField(80, 24))));
            widget.draw();
        }
    }
}


