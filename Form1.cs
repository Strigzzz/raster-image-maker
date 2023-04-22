using Svg;
using System.Drawing.Imaging;
using WinFormsApp1;
using Point = System.Drawing.Point;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Width = 900;
            this.Height = 700;
            bm = new Bitmap(pic.Width, pic.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pic.Image = bm;
        }
        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py;
        Pen p = new Pen(Color.Black, 1);
        SolidBrush b = new SolidBrush(Color.Black);
        Pen erase = new Pen(Color.White, 50);
        int x, y, aX, aY, bX, bY;
        int index;
        bool filled = false;
        ColorDialog cd = new ColorDialog();
        Color new_color;
        Stack<Bitmap> undoStack = new Stack<Bitmap>();
        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;

            aX = e.X; 
            aY = e.Y;

            if(index == 5) //the fill tool Can't fill with black, kept crashing when filled black on top of black
            {
                Point pt = new Point(aX, aY);
                Color old_color = bm.GetPixel(pt.X, pt.Y);
                Color new_color = cd.Color;
                if(old_color != Color.Black && new_color != Color.Black)
                {
                    FloodFill(bm, pt, cd.Color, old_color);
                }
            }    
        }
        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if(paint) 
            {
                if(index == 1)//the drawing tool
                {

                    px = e.Location;
                    g.DrawLine(p, px, py);
                    py = px;
                }
                if (index == 2)//the erase tool
                {
                    px = e.Location;
                    g.DrawLine(erase, px, py);
                    py = px;
                }
            }
            pic.Refresh();

            x = e.X;
            y = e.Y;
            bX = e.X - aX;
            bY = e.Y- aY;
        }
        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;

            bX = x - aX;
            bY = y - aY;

            if(index == 1)
            {
                ChangeMade();
            }
            if (index == 2)
            {
                ChangeMade();
            }
            if (index == 3)//rectangle tool
            {
                if (filled == true)
                {
                    g.FillEllipse(b, aX, aY, bX, bY);
                }
                g.DrawEllipse(p, aX, aY, bX, bY);
                ChangeMade();
            }
            if (index == 4)//elipse tool
            {
                if (filled == true)
                {
                    g.FillRectangle(b, aX, aY, bX, bY);
                }
                g.DrawRectangle(p, aX, aY, bX, bY);
                ChangeMade();
            }
        }
        private void pencil_btn_Click(object sender, EventArgs e)
        {
            index = 1;
        }
        private void erase_btn_Click(object sender, EventArgs e)
        {
            index = 2;
        }
        private void elipse_btn_Click(object sender, EventArgs e)
        {
            index = 3;
        }
        private void rectangle_btn_Click(object sender, EventArgs e)
        {
            index = 4;
        }
        private void fill_btn_Click(object sender, EventArgs e)
        {
            index = 5;
        }
        private void test_btn_Click(object sender, EventArgs e)
        {           
            for(int z = 0;z < 5; z++)
            {
                int i = pic.Width;
                int j = pic.Height;
                Random rnd = new Random();
                bX = rnd.Next(1,i);
                bY= rnd.Next(1,j);
                aX= rnd.Next(1,i);
                aY= rnd.Next(1,j);
                if(rnd.Next(1,3) == 1)
                {
                    g.DrawEllipse(p, aX, aY, bX, bY);
                }
                else
                {
                    g.DrawRectangle(p, aX, aY, bX, bY);
                }
            }
            ChangeMade();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)//toggles filled shapes
        {
            if(filled == true)
            {
                filled = false;
            }
            else
                filled= true;
        }
        private void color_btn_Click(object sender, EventArgs e) //felt there was no need to seperate outline and fill colors
        {
            cd.ShowDialog();
            new_color= cd.Color;
            p.Color = cd.Color;
            b = new SolidBrush(cd.Color);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)  // code for shortcut keys
        {
            if (e.Control && e.KeyCode.ToString() == "S")
            {
                save_btn_Click_1(sender, e);
            }
            if (e.Control && e.KeyCode.ToString() == "C")
            {
                clear_btn_Click(sender, e);
            }
        }
        private void ChangeMade()
        {
            
            undoStack.Push(bm);
        }
        private void undo_btn_Click(object sender, EventArgs e)   //does not work yet
        {
            if(undoStack.Count > 0)
            {
                bm = undoStack.Pop();
                pic.Image = bm;
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pic.Image = bm;
            index = 0;
        }
        private void size_bar_Scroll(object sender, EventArgs e)
        {
            p = new Pen(cd.Color, size_bar.Value);
        }
        private void validate(Bitmap bm, Stack<Point>sp, int x, int y, Color old_color, Color new_color)
        {
            Color cx = bm.GetPixel(x, y);
            if(cx == old_color)
            {
                sp.Push(new Point(x, y));
                bm.SetPixel(x, y, new_color);
            }
        }
        void FloodFill(Bitmap bm, Point pt, Color new_color, Color old_color)
        {
            Stack<(Point point, Color target)> pixels = new Stack<(Point, Color)>();
            pixels.Push((pt, old_color));
            while (pixels.Count > 0 && old_color != new_color)
            {
                var curr = pixels.Pop();
                var a = curr.point;
                Color targetColor = curr.target;

                if (a.X < bm.Width && a.X > 0 &&
                a.Y < bm.Height && a.Y > 0)//make sure we stay within bounds
                {
                    var tolerance = 10;
                    var green = Math.Abs(targetColor.G - bm.GetPixel(a.X, a.Y).G) < tolerance;
                    var red = Math.Abs(targetColor.R - bm.GetPixel(a.X, a.Y).R) < tolerance;
                    var blue = Math.Abs(targetColor.B - bm.GetPixel(a.X, a.Y).B) < tolerance;

                    if (red == true && blue == true && green == true)
                    {
                        var old = bm.GetPixel(a.X, a.Y);
                        bm.SetPixel(a.X, a.Y, new_color);
                        pixels.Push((new Point(a.X - 1, a.Y), old));
                        pixels.Push((new Point(a.X + 1, a.Y), old));
                        pixels.Push((new Point(a.X, a.Y - 1), old));
                        pixels.Push((new Point(a.X, a.Y + 1), old));
                    }
                }
            }
            //refresh our main picture box
            pic.Image = bm;
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            return;
        }
        private void pic_Paint(object sender, PaintEventArgs e)//outlines shape while mouse button is down
        {
            Graphics g = e.Graphics;
            if(paint)
            {
                if (index == 3)
                {
                    if(filled == true)
                    {
                        g.FillEllipse(b, aX, aY, bX, bY);
                    }
                    g.DrawEllipse(p, aX, aY, bX, bY);
                }
                if (index == 4)
                {
                    if (filled == true)
                    {
                        g.FillRectangle(b, aX, aY, bX, bY);
                    }
                    g.DrawRectangle(p, aX, aY, bX, bY);
                }
            }
        }
        private void save_btn_Click_1(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "image(*.jpg)|*.jpg|(*.*|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Bitmap btm = bm.Clone(new Rectangle(0, 0, pic.Width, pic.Height), bm.PixelFormat);
                btm.Save(sfd.FileName, ImageFormat.Jpeg);
            }
        }






    }
}