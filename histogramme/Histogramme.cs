using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace histogramme
{
    public class Histogramme
    {
        public int[] x;
        public String[] y;
        public Color couleur;
        public int SizeLableText;
        public String Title;
        public int SizeTitle;
        Graphics Graphic;

        public Histogramme()
        {
            
        }
        public Histogramme(Graphics l)
        {
            this.Graphic = l;
        }
        public Histogramme(Graphics l,int[] x , String[] y)
        {
            this.Graphic = l;
            this.x = x;
            this.y = y;
        }

        public void addStringToScreen(String s, float x, float y , float width, float height,int size)
        {

            // Create string to draw.
            String drawString = s;

            // Create font and brush.
            Font drawFont = new Font("Arial", size);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            // Create rectangle for drawing.
            RectangleF drawRect = new RectangleF(x, y, width, height);

            // Draw rectangle to screen.
            Pen blackPen = new Pen(Color.Transparent);
            Graphic.DrawRectangle(blackPen, x, y, width, height);

            // Set format of string.
            StringFormat drawFormat = new StringFormat();
            drawFormat.Alignment = StringAlignment.Center;

            // Draw string to screen.
            Graphic.DrawString(drawString, drawFont, drawBrush, drawRect, drawFormat);
        }

        public void Show()
        {

            //Style  titre par default
            float PositionX = 490.0F;
            float PositionY = 100.0F;
            float width = 400.0F;
            float height = 50.0F;

            //Ajouter un titre par default
            addStringToScreen(this.Title, PositionX, PositionY, width, height,16);

            //chercher le max de tableau
            int max = x.Select((value, index) => new { value, index })
                 .OrderByDescending(vi => vi.value)
                 .First().value;

            

            //L'axe des x
            int Result = (800 / x.Length) * x.Length+400;
            Pen b = new Pen(Color.Black, 2);
            int x_de_p1 = 500;
            int y_de_p1_p2 = 620;
            int y_de_p3 = 200;
            Point p1 = new Point(x_de_p1, y_de_p1_p2);
            Point p2 = new Point(Result, y_de_p1_p2); 
            Graphic.DrawLine(b, p1, p2);

            //L'axe des y
            Point p3 = new Point(x_de_p1, y_de_p3);
            Graphic.DrawLine(b, p1, p3);

            //liste des rectangles de l'histogrammme
            int  z = 800 / x.Length;
            int xx = x_de_p1 - z;
            for (int i = 0; i < x.Length; i++)
            {
                xx = xx + z;
                Graphic.DrawRectangle(b, xx, y_de_p1_p2 - x[i], z, x[i]);
                addStringToScreen(y[i], xx, y_de_p1_p2 - x[i]-40,z, x[i], 7);
            }


        }

        public void setCouleur(string hex)
        {

            this.couleur = System.Drawing.ColorTranslator.FromHtml(hex);
            
        }

        public void setSizeLableText(int size)
        {
            this.SizeLableText = size;
        }

        public  void setTitle(String Title)
        {
            this.Title = Title;
       }
        public  void setSizeTitle(int size)
        {
            this.SizeTitle = size;
        }



    }
}
