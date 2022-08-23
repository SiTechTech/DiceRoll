namespace RollingDiceGame
{
    partial class FormDice
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnRoll1 = new System.Windows.Forms.Button();
            this.picDice = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.btnRoll1;
            // 
            // btnRoll1
            // 
            this.btnRoll1.BackColor = System.Drawing.Color.Red;
            this.btnRoll1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoll1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoll1.ForeColor = System.Drawing.Color.White;
            this.btnRoll1.Location = new System.Drawing.Point(368, 350);
            this.btnRoll1.Name = "btnRoll1";
            this.btnRoll1.Size = new System.Drawing.Size(89, 36);
            this.btnRoll1.TabIndex = 1;
            this.btnRoll1.Text = "Roll Me ";
            this.btnRoll1.UseVisualStyleBackColor = false;
            this.btnRoll1.Click += new System.EventHandler(this.btnRoll1_Click);
            // 
            // picDice
            // 
            this.picDice.Image = global::RollingDiceGame.Properties.Resources.RollAway;
            this.picDice.Location = new System.Drawing.Point(301, 93);
            this.picDice.Name = "picDice";
            this.picDice.Size = new System.Drawing.Size(222, 222);
            this.picDice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDice.TabIndex = 0;
            this.picDice.TabStop = false;
            // 
            // picClose
            // 
            this.picClose.Image = global::RollingDiceGame.Properties.Resources._603px_Ps_x_button;
            this.picClose.Location = new System.Drawing.Point(729, 23);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(35, 35);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClose.TabIndex = 0;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            this.picClose.MouseHover += new System.EventHandler(this.picClose_MouseHover);
            // 
            // FormDice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRoll1);
            this.Controls.Add(this.picDice);
            this.Controls.Add(this.picClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SiTech DiceRoller";
            this.Load += new System.EventHandler(this.FormDice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox picClose;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.PictureBox picDice;
        private System.Windows.Forms.Button btnRoll1;
    }
}

