namespace WindowsFormsApp2
{
    partial class PlayGame
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
            this.startbutton = new System.Windows.Forms.Button();
            this.counter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startbutton
            // 
            this.startbutton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.startbutton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.startbutton.FlatAppearance.BorderSize = 10;
            this.startbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.startbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.startbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startbutton.ForeColor = System.Drawing.Color.White;
            this.startbutton.Location = new System.Drawing.Point(245, 161);
            this.startbutton.Margin = new System.Windows.Forms.Padding(2);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(510, 202);
            this.startbutton.TabIndex = 0;
            this.startbutton.Text = "Start";
            this.startbutton.UseVisualStyleBackColor = false;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // counter
            // 
            this.counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counter.ForeColor = System.Drawing.Color.White;
            this.counter.Location = new System.Drawing.Point(371, 447);
            this.counter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(242, 150);
            this.counter.TabIndex = 1;
            this.counter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1000, 900);
            this.Controls.Add(this.counter);
            this.Controls.Add(this.startbutton);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PlayGame";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.Label counter;
    }
}

