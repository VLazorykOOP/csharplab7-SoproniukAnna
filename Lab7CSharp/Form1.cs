using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        private Random rand = new Random();
        private Graphics g;
        private Image originalImage;

        public Form1()
        {
            InitializeComponent();
            g = pictureBox.CreateGraphics();
            dataGridView.Columns.Add("Type", "Тип");
            dataGridView.Columns.Add("Size", "Розмір");
            dataGridView.Columns.Add("Color", "Колір");
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            textBoxInfo.Text = $"X: {Location.X}, Y: {Location.Y}";
        }

        private void buttonExit_MouseHover(object sender, EventArgs e)
        {
            int newX = rand.Next(0, this.ClientSize.Width - buttonExit.Width);
            int newY = rand.Next(0, this.ClientSize.Height - buttonExit.Height);

            buttonExit.Location = new Point(newX, newY);
            buttonExit.BringToFront();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            string shape = comboBoxShape.SelectedItem.ToString();
            switch (shape)
            {
                case "Коло":
                    Circle circle = new Circle(rand.Next(50, 600), rand.Next(5, 400), rand.Next(20, 150), Color.Red);
                    circle.Draw(g);
                    dataGridView.Rows.Add("Коло", circle.Width, circle.Color);
                    break;
                case "Квадрат":
                    Square square = new Square(rand.Next(50, 600), rand.Next(5, 400), rand.Next(20, 150), Color.Blue);
                    square.Draw(g);
                    dataGridView.Rows.Add("Квадрат", square.Width, square.Color);
                    break;
                case "Прямокутник":
                    RectangleWithText rect = new RectangleWithText(rand.Next(50, 600), rand.Next(5, 400), rand.Next(50, 200), rand.Next(50, 200), "Текст", Color.Green);
                    rect.Draw(g);
                    dataGridView.Rows.Add("Прямокутник", $"{rect.Width}x{rect.Height}", rect.Color);
                    break;
            }
        }

        private void buttonLoadImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                originalImage = Image.FromFile(openFileDialog.FileName);
                pictureBox.Image = originalImage;
            }
        }

        private void buttonSaveImage_Click(object sender, EventArgs e)
        {
            Image imageToSave = pictureBox.Image;
            if (imageToSave != null && saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                imageToSave.Save(saveFileDialog.FileName);
            }
        }

        private void buttonMirrorImage_Click(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
                Bitmap mirroredImage = new Bitmap(originalImage);
                mirroredImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
                pictureBox.Image = mirroredImage;
            }
        }

        abstract class Shape
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }
            public Color Color { get; set; }

            public Shape(int x, int y, int width, int height, Color color)
            {
                X = x;
                Y = y;
                Width = width;
                Height = height;
                Color = color;
            }

            public abstract void Draw(Graphics g);
        }

        class Circle : Shape
        {
            public Circle(int x, int y, int size, Color color) : base(x, y, size, size, color) { }

            public override void Draw(Graphics g)
            {
                g.FillEllipse(new SolidBrush(Color), X, Y, Width, Height);
            }
        }

        class Square : Shape
        {
            public Square(int x, int y, int size, Color color) : base(x, y, size, size, color) { }

            public override void Draw(Graphics g)
            {
                g.FillRectangle(new SolidBrush(Color), X, Y, Width, Height);
            }
        }

        class RectangleWithText : Shape
        {
            public string Text { get; set; }

            public RectangleWithText(int x, int y, int width, int height, string text, Color color) : base(x, y, width, height, color)
            {
                Text = text;
            }

            public override void Draw(Graphics g)
            {
                g.FillRectangle(new SolidBrush(Color), X, Y, Width, Height);
                g.DrawString(Text, new Font("Arial", 10), Brushes.White, X + (Width - Text.Length * 5) / 2, Y + Height / 2 - 5);
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxInfo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}