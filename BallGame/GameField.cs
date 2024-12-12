using System;
using System.Drawing;

public class GameField
{
    private BallFactory _ballFactory;
    private int _fieldSize;

    public GameField(int fieldSize)
    {
        _fieldSize = fieldSize;
        _ballFactory = new BallFactory();
    }

    public void Draw(Graphics graphics, int cellSize)
    {
        for (int i = 0; i < _fieldSize; i++)
        {
            for (int j = 0; j < _fieldSize; j++)
            {
                // Убедитесь, что при создании шарика передаёте оба аргумента:
                Ball ball = new Ball("Red", Color.Red);  // Пример: создаём красный шарик

                int x = i * cellSize;
                int y = j * cellSize;
                ball.Draw(graphics, x, y, cellSize);  // Вызов метода Draw
            }
        }
    }
}
