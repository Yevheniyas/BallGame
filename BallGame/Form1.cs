using System;
using System.Drawing;
using System.Windows.Forms;

public partial class Form1 : Form
{
    private GameField _gameField;
    private int _fieldSize = 10; // Размер поля n x n
    private int _cellSize = 50;  // Размер клетки

    public Form1()
    {
        InitializeComponent();
        _gameField = new GameField(_fieldSize); // Инициализация игрового поля
        this.DoubleBuffered = true; // Для предотвращения мерцания
        this.Size = new Size(_fieldSize * _cellSize + 16, _fieldSize * _cellSize + 39); // Установка размера формы
    }

    private void InitializeComponent()
    {
        throw new NotImplementedException();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        _gameField.Draw(e.Graphics, _cellSize); // Рисуем игровое поле и шарики
    }
}
