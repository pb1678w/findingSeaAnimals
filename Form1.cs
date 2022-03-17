using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FlyingPigGameFormApplication
{
    public partial class Form1 : Form
    {
        private int appleTimer = 0;
        int appleCount = 0;
        private Pig flyingPig;
        private List<Apple> apples;

        // Create a property to encapsulate the apples list
        public List<Apple> Apples { get => apples; set => apples = value; }

        public Form1()
        {
            
            InitializeComponent();

            // Instantiate the flyingPig and apples variables
            flyingPig = new Pig();
            apples = new List<Apple>();

            // Add the flyingPig to the panel called gameCanvas
            // Hint: panels have a 'Controls' collection to which you can add a control.
            // Note that the Pig object is a control since the Pig class inherits from PictureBox which is a control element
            gameCanvas.Controls.Add(flyingPig);

            // Set the Location property of flyingPig to x/y to 200/100
            flyingPig.Location = new Point(200, 100);

            // Start gameTimer
            // Hint: a Timer named gameTimer has been placed on the form (see Form1.cs[Design])
            gameTimer.Start();            
        }

        public void AddApple(Apple a)
        {
            // Add the apple to the list and the canvas
            this.apples.Add(a);
            gameCanvas.Controls.Add(a);
        }

        public void RemoveApple(Apple a)
        {
            // Remove the apple from the list and the canvas
            this.apples.Remove(a);
            gameCanvas.Controls.Remove(a);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the key pressed was right, left, up or down
            // If so, move the flyingPig in that direction
            if (e.KeyCode == Keys.Up)
                flyingPig.MoveGameEntity(Direction.Up);
            else if (e.KeyCode == Keys.Down)
                flyingPig.MoveGameEntity(Direction.Down);
            else if (e.KeyCode == Keys.Right)
                flyingPig.MoveGameEntity(Direction.Right);
            else if (e.KeyCode == Keys.Left)
                flyingPig.MoveGameEntity(Direction.Left);

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            // Increase the appleTimer by 1
            this.appleTimer++;
            // If the appleTimer is bigger than 20, add a new apple and set the timer to 0
            if(appleTimer > 20)
            {
                AddApple(new Apple());
                this.appleTimer = 0;
            }

            // Loop through the apples list and call the Update method for each apple
            foreach(var apple in apples)
            {
                apple.Update(gameCanvas);
            }

            // Loop through the apples list and for each check whether it collides with the flyingPig
            // If so, remove the apple, increase the appleCount by 1 and display the current count in countText as "Apples Eaten: appleCount"
            for (int indx = 0; indx < apples.Count; indx++)
            {
                if (DetectCollision(apples[indx], flyingPig))
                {
                    this.RemoveApple(apples[indx]);
                    this.appleCount++;
                    countText.Text = "Apples Eaten: " + this.appleCount;
                }
            }
        }

        public bool DetectCollision(PictureBox ctrl1, PictureBox ctrl2)
        {
            // Detect the collision between ctrl1 and ctrl2 by creating rectangles around them
            // and checking whether the intersection is empty or not
            Rectangle ctrl1Rect = new Rectangle(ctrl1.Left, ctrl1.Top, ctrl1.Width, ctrl1.Height);
            Rectangle ctrl2Rect = new Rectangle(ctrl2.Left, ctrl2.Top, ctrl2.Width, ctrl2.Height);
            return ctrl1Rect.IntersectsWith(ctrl2Rect);
            
        }
    }

 }

