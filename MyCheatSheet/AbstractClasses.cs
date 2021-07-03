namespace MyCheatSheet
{
    public class AbstractClasses
    {
        // абстрактный класс фигуры
        abstract class Figure
        {
            // абстрактный метод для получения периметра
            public abstract float Perimeter();
            // абстрактный метод для получения площади
            public abstract float Area();
        }
// производный класс прямоугольника
        class Rectangle : Figure
        {
            public float Width { get; set; }
            public float Height { get; set; }
 
            public Rectangle(float width, float height)
            {
                this.Width = width;
                this.Height = height;
            }
            // переопределение получения периметра
            public override float Perimeter()
            {
                return Width * 2 + Height * 2;
            }
            // переопрелеление получения площади
            public override float Area()
            {
                return Width * Height;
            }
        }
    }
}