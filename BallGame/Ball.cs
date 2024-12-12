using System.Drawing;

public class Ball
{
    public string Type { get; }
    public Color Color { get; }

    // Конструктор класса Ball
    public Ball(string type, Color color)
    {
        Type = type;
        Color = color;
    }

    // Метод для отрисовки шарика
    public void Draw(Graphics graphics, int x, int y, int size)
    {
        // Рисуем шарик в виде круга
        using (Brush brush = new SolidBrush(Color))
        {
            graphics.FillEllipse(brush, x, y, size, size);
        }
    }
}
