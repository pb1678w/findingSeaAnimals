using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace FlyingPigGameFormApplication
{
    public class Pig : PictureBox, IGameEntity
    {
        private int velocity = 10;
        
        public Pig()
        {
            this.Image = Image.FromFile("FlyingPig.png");
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            ((Bitmap)this.Image).MakeTransparent(((Bitmap)this.Image).GetPixel(1, 1));
            this.BackColor = Color.Transparent;
            this.Height = 58;
            this.Width = 80;
        }

        public void Update(Panel theCanvas)
        {
            // This method can stay empty
        }

        public void MoveGameEntity(Direction direction)
        {
            // Write code to move the Pig by value of velocity depending on the direction 
            // (e.g. if the direction is right, move the Pig to the right, etc.)
            // Hint: Use the Top attribute to move the Pig up and down and
            //           the Left attribute to move the Pig left and right
            if (direction == Direction.Up)
                this.Top -= velocity;
            else if (direction == Direction.Down)
                this.Top += velocity;           
            else if (direction == Direction.Right)
                this.Left += velocity;
            else if (direction == Direction.Left)
                this.Left -= velocity;
        }
    }
}

