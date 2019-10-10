using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_P_lb1
{
    public partial class HistoForm : Form
    {
        public HistoForm()
        {
            InitializeComponent();
        }
     
        public int[] val;
       public bool flag = false;
        
        private void picHisto_Resize(object sender, EventArgs e)
        {
            picHisto.Refresh();
        }
        private void DrawHistogram(Graphics gr, Color back_color,
    int[] values, int width, int height)
        {
            Color[] Colors = new Color[] {
        Color.Red, Color.LightGreen, Color.Blue,
        Color.Pink, Color.Green, Color.LightBlue,
        Color.Orange, Color.Yellow, Color.Purple
    };

            gr.Clear(back_color);

            // Сделаem преобразование в PictureBox.
            RectangleF data_bounds =
                new RectangleF(0, 0, values.Length, 200);
            PointF[] points =
            {
        new PointF(0, height),
        new PointF(width, height),
        new PointF(0, 0)
    };
            Matrix transformation = new Matrix(data_bounds, points);
            gr.Transform = transformation;

            // Нарисуем гистограмму.
            for (int i = 0; i < values.Length; i++)
                using (Pen thin_pen = new Pen(Colors[i % Colors.Length], 0))
            {
                
                {


                    RectangleF rect = new RectangleF(i, 0, 1, values[i]);
                    using (Brush the_brush =
                        new SolidBrush(Colors[i % Colors.Length]))


                    {
                        gr.FillRectangle(the_brush, rect);
                        gr.DrawRectangle(thin_pen, rect.X, rect.Y,
                            rect.Width, rect.Height);

                    }



                }
            }
        
            

            gr.ResetTransform();
            gr.DrawRectangle(Pens.Black, 0, 0, width - 1, height - 1);
        }
        private void picHisto_Paint(object sender, PaintEventArgs e)
        {
            
            
            DrawHistogram(e.Graphics, picHisto.BackColor, val,
       picHisto.ClientSize.Width, picHisto.ClientSize.Height);
            
        }

        private void HistoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flag == false)
            {
                e.Cancel = true;
                this.Hide();
            }
        }
    }
}
