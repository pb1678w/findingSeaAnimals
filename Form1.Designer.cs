namespace FlyingPigGameFormApplication
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gameCanvas = new System.Windows.Forms.Panel();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.countText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameCanvas
            // 
            this.gameCanvas.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gameCanvas.Location = new System.Drawing.Point(58, 35);
            this.gameCanvas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gameCanvas.Name = "gameCanvas";
            this.gameCanvas.Size = new System.Drawing.Size(817, 462);
            this.gameCanvas.TabIndex = 0;
            // 
            // gameTimer
            // 
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // countText
            // 
            this.countText.AutoSize = true;
            this.countText.Location = new System.Drawing.Point(57, 557);
            this.countText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.countText.Name = "countText";
            this.countText.Size = new System.Drawing.Size(38, 15);
            this.countText.TabIndex = 1;
            this.countText.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 648);
            this.Controls.Add(this.countText);
            this.Controls.Add(this.gameCanvas);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel gameCanvas;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label countText;
    }
}

