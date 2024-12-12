using System;
using System.Collections.Generic;
using System.Drawing;

public class BallFactory
{
    private Dictionary<string, Ball> _balls = new Dictionary<string, Ball>();

    public Ball GetBall(string type)
    {
        if (!_balls.ContainsKey(type))
        {
            Color color;

            if (type == "Red")
                color = Color.Red;
            else if (type == "Green")
                color = Color.Green;
            else if (type == "Blue")
                color = Color.Blue;
            else if (type == "Yellow")
                color = Color.Yellow;
            else if (type == "Purple")
                color = Color.Purple;
            else
                color = Color.Black;

            _balls[type] = new Ball(type, color); // Если такого шарика еще нет, создаем его
        }

        return _balls[type]; // Возвращаем уже существующий шарик
    }
}
