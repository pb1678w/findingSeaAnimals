using System;
using System.Windows.Forms;
using System.Drawing;

namespace FlyingPigGameFormApplication
{
    public class Apple : PictureBox, IGameEntity
    {
        private int speed = 0;
        public Apple()
        {
            this.Image = Image.FromFile("apple.png");
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            ((Bitmap)this.Image).MakeTransparent(((Bitmap)this.Image).GetPixel(1, 1));
            this.BackColor = Color.Transparent;

            // Write code which sets the width (33), height (40) and left (680) properties
            // of the Apple.
            this.Width = 33;
            this.Height = 40;
            this.Left = 680;

            // Use the Random class to randomly generate a number between 50 and 250
            // and use this value to set the Top property.
            Random random = new Random();
            this.Top = random.Next(50, 250);
            // Also, set the speed variable to a random number between 5 and 15
            this.speed = random.Next(5, 15);
        }

        public void Update(Panel c)
        {
            // Call the method MoveGameEntity, passing left direction as an argument
            MoveGameEntity(Direction.Left);

            // If the current Left property of the apple is smaller than -50 remove it from the panel c
            // Hint: Panel has a Controls list from which this apple obhect needs to be removed from. 
            if(this.Left < -50)
            {
                c.Controls.Remove(this);
            }
            
        }
        public void MoveGameEntity(Direction direction)
        {
            // Decrease the Left property by the value of speed
            this.Left -= this.speed;
        }
    }

}

