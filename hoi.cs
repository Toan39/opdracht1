using System.Windows.Forms;
using System.Drawing;

class HalloForm : Form
{
    public HalloForm()
    {

        this.BackColor = Color.Yellow;
        this.Size = new Size(500, 500);
        this.Paint += this.tekenScherm;
    }
    void tekenScherm(object obj, PaintEventArgs pea)
    {
        this.Smiley(pea.Graphics, 240, 90, 50);
        this.Smiley(pea.Graphics, 350, 40, 75);
    }

    //Smiley-method//
    void Smiley(Graphics gr, int x1, int y1, int size)
    {
        //This are the coordinates that makes the smiley dynamic//
        int x2 =x1+20;
        int x3 =x1-12;
        int x5 = x1-30;     
        int y3 = y1 - 10;

        
        int r2 = size/10;
        int r3 = size*2;   
       

        //This determines the rectangular size and creates a pen with black color//
        Pen blackPen = new Pen(Color.Black, 3);
        Rectangle rect = new Rectangle(x3, y3, 50, 50);

        //This set of commands draws a basic smiley//
        gr.DrawEllipse(blackPen, x5, y3, r3, r3);
        gr.FillRectangle(Brushes.Black, x1, y1, r2, r2);
        gr.FillRectangle(Brushes.Black, x2, y1, r2, r2);
        gr.DrawArc(blackPen,rect, 50 ,100);
    }
}

class HalloWin3
{
    static void Main()
    {
        HalloForm scherm;
        scherm = new HalloForm();
        Application.Run(scherm);

    }
}