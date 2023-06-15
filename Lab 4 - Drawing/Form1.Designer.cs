namespace Lab_4___Drawing
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
            this.grpColor = new System.Windows.Forms.GroupBox();
            this.rdoWhite = new System.Windows.Forms.RadioButton();
            this.rdoYellow = new System.Windows.Forms.RadioButton();
            this.rdoMagenta = new System.Windows.Forms.RadioButton();
            this.rdoRed = new System.Windows.Forms.RadioButton();
            this.rdoCyan = new System.Windows.Forms.RadioButton();
            this.rdoGreen = new System.Windows.Forms.RadioButton();
            this.rdoBlue = new System.Windows.Forms.RadioButton();
            this.rdoGray = new System.Windows.Forms.RadioButton();
            this.pnlBlackboard = new System.Windows.Forms.Panel();
            this.btnErase = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpColor
            // 
            this.grpColor.BackColor = System.Drawing.Color.DimGray;
            this.grpColor.Controls.Add(this.rdoWhite);
            this.grpColor.Controls.Add(this.rdoYellow);
            this.grpColor.Controls.Add(this.rdoMagenta);
            this.grpColor.Controls.Add(this.rdoRed);
            this.grpColor.Controls.Add(this.rdoCyan);
            this.grpColor.Controls.Add(this.rdoGreen);
            this.grpColor.Controls.Add(this.rdoBlue);
            this.grpColor.Controls.Add(this.rdoGray);
            this.grpColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpColor.Location = new System.Drawing.Point(588, 12);
            this.grpColor.Name = "grpColor";
            this.grpColor.Size = new System.Drawing.Size(200, 215);
            this.grpColor.TabIndex = 0;
            this.grpColor.TabStop = false;
            this.grpColor.Text = "Color";
            // 
            // rdoWhite
            // 
            this.rdoWhite.AutoSize = true;
            this.rdoWhite.Location = new System.Drawing.Point(7, 181);
            this.rdoWhite.Name = "rdoWhite";
            this.rdoWhite.Size = new System.Drawing.Size(58, 17);
            this.rdoWhite.TabIndex = 7;
            this.rdoWhite.TabStop = true;
            this.rdoWhite.Text = "White Color";
            this.rdoWhite.UseVisualStyleBackColor = true;
            this.rdoWhite.CheckedChanged += new System.EventHandler(this.rdoWhite_CheckedChanged);
            // 
            // rdoYellow
            // 
            this.rdoYellow.AutoSize = true;
            this.rdoYellow.Location = new System.Drawing.Point(7, 158);
            this.rdoYellow.Name = "rdoYellow";
            this.rdoYellow.Size = new System.Drawing.Size(62, 17);
            this.rdoYellow.TabIndex = 6;
            this.rdoYellow.TabStop = true;
            this.rdoYellow.Text = "Yellow";
            this.rdoYellow.UseVisualStyleBackColor = true;
            this.rdoYellow.CheckedChanged += new System.EventHandler(this.rdoYellow_CheckedChanged);
            // 
            // rdoMagenta
            // 
            this.rdoMagenta.AutoSize = true;
            this.rdoMagenta.Location = new System.Drawing.Point(7, 135);
            this.rdoMagenta.Name = "rdoMagenta";
            this.rdoMagenta.Size = new System.Drawing.Size(74, 17);
            this.rdoMagenta.TabIndex = 5;
            this.rdoMagenta.TabStop = true;
            this.rdoMagenta.Text = "Megenta";
            this.rdoMagenta.UseVisualStyleBackColor = true;
            this.rdoMagenta.CheckedChanged += new System.EventHandler(this.rdoMagenta_CheckedChanged);
            // 
            // rdoRed
            // 
            this.rdoRed.AutoSize = true;
            this.rdoRed.Location = new System.Drawing.Point(7, 112);
            this.rdoRed.Name = "rdoRed";
            this.rdoRed.Size = new System.Drawing.Size(48, 17);
            this.rdoRed.TabIndex = 4;
            this.rdoRed.TabStop = true;
            this.rdoRed.Text = "Red";
            this.rdoRed.UseVisualStyleBackColor = true;
            this.rdoRed.CheckedChanged += new System.EventHandler(this.rdoRed_CheckedChanged);
            // 
            // rdoCyan
            // 
            this.rdoCyan.AutoSize = true;
            this.rdoCyan.Location = new System.Drawing.Point(7, 89);
            this.rdoCyan.Name = "rdoCyan";
            this.rdoCyan.Size = new System.Drawing.Size(53, 17);
            this.rdoCyan.TabIndex = 3;
            this.rdoCyan.TabStop = true;
            this.rdoCyan.Text = "Cyan";
            this.rdoCyan.UseVisualStyleBackColor = true;
            this.rdoCyan.CheckedChanged += new System.EventHandler(this.rdoCyan_CheckedChanged);
            // 
            // rdoGreen
            // 
            this.rdoGreen.AutoSize = true;
            this.rdoGreen.Location = new System.Drawing.Point(7, 66);
            this.rdoGreen.Name = "rdoGreen";
            this.rdoGreen.Size = new System.Drawing.Size(59, 17);
            this.rdoGreen.TabIndex = 2;
            this.rdoGreen.TabStop = true;
            this.rdoGreen.Text = "Green";
            this.rdoGreen.UseVisualStyleBackColor = true;
            this.rdoGreen.CheckedChanged += new System.EventHandler(this.rdoGreen_CheckedChanged);
            // 
            // rdoBlue
            // 
            this.rdoBlue.AutoSize = true;
            this.rdoBlue.Location = new System.Drawing.Point(7, 43);
            this.rdoBlue.Name = "rdoBlue";
            this.rdoBlue.Size = new System.Drawing.Size(50, 17);
            this.rdoBlue.TabIndex = 1;
            this.rdoBlue.TabStop = true;
            this.rdoBlue.Text = "Blue";
            this.rdoBlue.UseVisualStyleBackColor = true;
            this.rdoBlue.CheckedChanged += new System.EventHandler(this.rdoBlue_CheckedChanged);
            // 
            // rdoGray
            // 
            this.rdoGray.AutoSize = true;
            this.rdoGray.Location = new System.Drawing.Point(7, 20);
            this.rdoGray.Name = "rdoGray";
            this.rdoGray.Size = new System.Drawing.Size(51, 17);
            this.rdoGray.TabIndex = 0;
            this.rdoGray.TabStop = true;
            this.rdoGray.Text = "Gray";
            this.rdoGray.UseVisualStyleBackColor = true;
            this.rdoGray.CheckedChanged += new System.EventHandler(this.rdoGray_CheckedChanged);
            // 
            // pnlBlackboard
            // 
            this.pnlBlackboard.BackColor = System.Drawing.Color.Black;
            this.pnlBlackboard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBlackboard.Location = new System.Drawing.Point(12, 12);
            this.pnlBlackboard.Name = "pnlBlackboard";
            this.pnlBlackboard.Size = new System.Drawing.Size(570, 330);
            this.pnlBlackboard.TabIndex = 0;
            // 
            // btnErase
            // 
            this.btnErase.Location = new System.Drawing.Point(605, 254);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(75, 23);
            this.btnErase.TabIndex = 1;
            this.btnErase.Text = "Erase";
            this.btnErase.UseVisualStyleBackColor = true;
            this.btnErase.Click += new System.EventHandler(this.btnErase_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(686, 254);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 364);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnErase);
            this.Controls.Add(this.pnlBlackboard);
            this.Controls.Add(this.grpColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blackboard Fun";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpColor.ResumeLayout(false);
            this.grpColor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpColor;
        private System.Windows.Forms.Panel pnlBlackboard;
        private System.Windows.Forms.RadioButton rdoWhite;
        private System.Windows.Forms.RadioButton rdoYellow;
        private System.Windows.Forms.RadioButton rdoMagenta;
        private System.Windows.Forms.RadioButton rdoRed;
        private System.Windows.Forms.RadioButton rdoCyan;
        private System.Windows.Forms.RadioButton rdoGreen;
        private System.Windows.Forms.RadioButton rdoBlue;
        private System.Windows.Forms.RadioButton rdoGray;
        private System.Windows.Forms.Button btnErase;
        private System.Windows.Forms.Button btnExit;
    }
}

