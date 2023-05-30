
namespace proekt
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.DrawingArea = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.StartPainting = new System.Windows.Forms.Button();
            this.A_x_coords = new System.Windows.Forms.NumericUpDown();
            this.A_y_coords = new System.Windows.Forms.NumericUpDown();
            this.B_x_coords = new System.Windows.Forms.NumericUpDown();
            this.B_y_coords = new System.Windows.Forms.NumericUpDown();
            this.C_x_coords = new System.Windows.Forms.NumericUpDown();
            this.C_y_coords = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.DrawingArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A_x_coords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A_y_coords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_x_coords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_y_coords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C_x_coords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C_y_coords)).BeginInit();
            this.SuspendLayout();
            // 
            // DrawingArea
            // 
            this.DrawingArea.Location = new System.Drawing.Point(139, 33);
            this.DrawingArea.Name = "DrawingArea";
            this.DrawingArea.Size = new System.Drawing.Size(1000, 560);
            this.DrawingArea.TabIndex = 0;
            this.DrawingArea.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 641);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Координаты точки A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 663);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "x";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 692);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(483, 641);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Координаты точки B";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(484, 663);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "x";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(483, 692);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(779, 641);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Координаты точки C";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(779, 663);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "x";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(778, 691);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "y";
            // 
            // StartPainting
            // 
            this.StartPainting.Location = new System.Drawing.Point(989, 641);
            this.StartPainting.Name = "StartPainting";
            this.StartPainting.Size = new System.Drawing.Size(150, 70);
            this.StartPainting.TabIndex = 16;
            this.StartPainting.Text = "Раскраска треугольника";
            this.StartPainting.UseVisualStyleBackColor = true;
            this.StartPainting.Click += new System.EventHandler(this.button1_Click);
            // 
            // A_x_coords
            // 
            this.A_x_coords.Location = new System.Drawing.Point(215, 661);
            this.A_x_coords.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.A_x_coords.Name = "A_x_coords";
            this.A_x_coords.Size = new System.Drawing.Size(120, 22);
            this.A_x_coords.TabIndex = 17;
            this.A_x_coords.Value = new decimal(new int[] {
            350,
            0,
            0,
            0});
            // 
            // A_y_coords
            // 
            this.A_y_coords.Location = new System.Drawing.Point(216, 689);
            this.A_y_coords.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.A_y_coords.Name = "A_y_coords";
            this.A_y_coords.Size = new System.Drawing.Size(120, 22);
            this.A_y_coords.TabIndex = 18;
            // 
            // B_x_coords
            // 
            this.B_x_coords.Location = new System.Drawing.Point(503, 660);
            this.B_x_coords.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.B_x_coords.Name = "B_x_coords";
            this.B_x_coords.Size = new System.Drawing.Size(120, 22);
            this.B_x_coords.TabIndex = 19;
            // 
            // B_y_coords
            // 
            this.B_y_coords.Location = new System.Drawing.Point(503, 688);
            this.B_y_coords.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.B_y_coords.Name = "B_y_coords";
            this.B_y_coords.Size = new System.Drawing.Size(120, 22);
            this.B_y_coords.TabIndex = 20;
            this.B_y_coords.Value = new decimal(new int[] {
            430,
            0,
            0,
            0});
            // 
            // C_x_coords
            // 
            this.C_x_coords.Location = new System.Drawing.Point(798, 661);
            this.C_x_coords.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.C_x_coords.Name = "C_x_coords";
            this.C_x_coords.Size = new System.Drawing.Size(120, 22);
            this.C_x_coords.TabIndex = 21;
            this.C_x_coords.Value = new decimal(new int[] {
            700,
            0,
            0,
            0});
            // 
            // C_y_coords
            // 
            this.C_y_coords.Location = new System.Drawing.Point(798, 691);
            this.C_y_coords.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.C_y_coords.Name = "C_y_coords";
            this.C_y_coords.Size = new System.Drawing.Size(120, 22);
            this.C_y_coords.TabIndex = 22;
            this.C_y_coords.Value = new decimal(new int[] {
            430,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1213, 738);
            this.Controls.Add(this.C_y_coords);
            this.Controls.Add(this.C_x_coords);
            this.Controls.Add(this.B_y_coords);
            this.Controls.Add(this.B_x_coords);
            this.Controls.Add(this.A_y_coords);
            this.Controls.Add(this.A_x_coords);
            this.Controls.Add(this.StartPainting);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DrawingArea);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DrawingArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A_x_coords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A_y_coords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_x_coords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_y_coords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C_x_coords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C_y_coords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox DrawingArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button StartPainting;
        private System.Windows.Forms.NumericUpDown A_x_coords;
        private System.Windows.Forms.NumericUpDown A_y_coords;
        private System.Windows.Forms.NumericUpDown B_x_coords;
        private System.Windows.Forms.NumericUpDown B_y_coords;
        private System.Windows.Forms.NumericUpDown C_x_coords;
        private System.Windows.Forms.NumericUpDown C_y_coords;
    }
}

