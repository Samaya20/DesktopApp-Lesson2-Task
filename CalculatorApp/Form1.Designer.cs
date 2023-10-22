namespace CalculatorApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            currentOpLabel = new Label();
            label1 = new Label();
            resultTextbox = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label20 = new Label();
            currentLabel = new Label();
            SuspendLayout();
            // 
            // currentOpLabel
            // 
            currentOpLabel.AutoSize = true;
            currentOpLabel.Location = new Point(0, 0);
            currentOpLabel.Name = "currentOpLabel";
            currentOpLabel.Size = new Size(0, 15);
            currentOpLabel.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 1F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Image = Resource1.dot;
            label1.Location = new Point(14, 549);
            label1.Name = "label1";
            label1.Padding = new Padding(30);
            label1.Size = new Size(62, 63);
            label1.TabIndex = 21;
            label1.Text = ".";
            label1.Click += button_click;
            // 
            // resultTextbox
            // 
            resultTextbox.AutoSize = true;
            resultTextbox.BackColor = Color.Transparent;
            resultTextbox.Font = new Font("Segoe UI", 45F, FontStyle.Regular, GraphicsUnit.Point);
            resultTextbox.ForeColor = SystemColors.ControlLight;
            resultTextbox.Location = new Point(4, 91);
            resultTextbox.Name = "resultTextbox";
            resultTextbox.Padding = new Padding(0, 30, 10, 30);
            resultTextbox.Size = new Size(77, 141);
            resultTextbox.TabIndex = 22;
            resultTextbox.Text = "0";
            resultTextbox.Click += resultTextbox_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 1F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Image = Resource1.EqBtn;
            label2.Location = new Point(165, 549);
            label2.Name = "label2";
            label2.Padding = new Padding(67, 30, 67, 30);
            label2.Size = new Size(137, 63);
            label2.TabIndex = 23;
            label2.Text = "=";
            label2.Click += equalBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 1F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Image = Resource1.dell;
            label3.Location = new Point(165, 254);
            label3.Name = "label3";
            label3.Padding = new Padding(30);
            label3.Size = new Size(63, 63);
            label3.TabIndex = 24;
            label3.Text = "2";
            label3.Click += deleteBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 1F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Image = Resource1.zero;
            label4.Location = new Point(90, 549);
            label4.Name = "label4";
            label4.Padding = new Padding(30);
            label4.Size = new Size(63, 63);
            label4.TabIndex = 25;
            label4.Text = "0";
            label4.Click += button_click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 1F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Image = Resource1._3;
            label5.Location = new Point(165, 475);
            label5.Name = "label5";
            label5.Padding = new Padding(30);
            label5.Size = new Size(63, 63);
            label5.TabIndex = 26;
            label5.Text = "3";
            label5.Click += button_click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 1F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Image = Resource1._2;
            label6.Location = new Point(90, 475);
            label6.Name = "label6";
            label6.Padding = new Padding(30);
            label6.Size = new Size(63, 63);
            label6.TabIndex = 27;
            label6.Text = "2";
            label6.Click += button_click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 1F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Image = Resource1._1;
            label7.Location = new Point(14, 475);
            label7.Name = "label7";
            label7.Padding = new Padding(30);
            label7.Size = new Size(63, 63);
            label7.TabIndex = 28;
            label7.Text = "1";
            label7.Click += button_click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 1F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Image = Resource1.plus;
            label8.Location = new Point(239, 475);
            label8.Name = "label8";
            label8.Padding = new Padding(30);
            label8.Size = new Size(63, 63);
            label8.TabIndex = 29;
            label8.Text = "+";
            label8.Click += operator_click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 1F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Image = Resource1._6;
            label9.Location = new Point(165, 401);
            label9.Name = "label9";
            label9.Padding = new Padding(30);
            label9.Size = new Size(63, 63);
            label9.TabIndex = 30;
            label9.Text = "6";
            label9.Click += button_click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 1F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Image = Resource1._5;
            label10.Location = new Point(90, 401);
            label10.Name = "label10";
            label10.Padding = new Padding(30);
            label10.Size = new Size(63, 63);
            label10.TabIndex = 31;
            label10.Text = "5";
            label10.Click += button_click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 1F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Image = Resource1._4;
            label11.Location = new Point(15, 401);
            label11.Name = "label11";
            label11.Padding = new Padding(30);
            label11.Size = new Size(63, 63);
            label11.TabIndex = 32;
            label11.Text = "4";
            label11.Click += button_click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 1F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Image = Resource1.minus;
            label12.Location = new Point(239, 401);
            label12.Name = "label12";
            label12.Padding = new Padding(30);
            label12.Size = new Size(63, 63);
            label12.TabIndex = 33;
            label12.Text = "-";
            label12.Click += operator_click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI", 1F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Image = Resource1._7;
            label13.Location = new Point(15, 327);
            label13.Name = "label13";
            label13.Padding = new Padding(30);
            label13.Size = new Size(63, 63);
            label13.TabIndex = 34;
            label13.Text = "7";
            label13.Click += button_click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Segoe UI", 1F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Image = Resource1._8;
            label14.Location = new Point(90, 327);
            label14.Name = "label14";
            label14.Padding = new Padding(30);
            label14.Size = new Size(63, 63);
            label14.TabIndex = 35;
            label14.Text = "8";
            label14.Click += button_click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Segoe UI", 1F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Image = Resource1._9;
            label15.Location = new Point(165, 327);
            label15.Name = "label15";
            label15.Padding = new Padding(30);
            label15.Size = new Size(63, 63);
            label15.TabIndex = 36;
            label15.Text = "9";
            label15.Click += button_click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Segoe UI", 1F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Image = Resource1.X;
            label16.Location = new Point(239, 327);
            label16.Name = "label16";
            label16.Padding = new Padding(30);
            label16.Size = new Size(63, 63);
            label16.TabIndex = 37;
            label16.Text = "X";
            label16.Click += operator_click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Segoe UI", 1F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Image = Resource1.CE;
            label17.Location = new Point(15, 254);
            label17.Name = "label17";
            label17.Padding = new Padding(30);
            label17.Size = new Size(64, 63);
            label17.TabIndex = 38;
            label17.Text = "CE";
            label17.Click += ceBtn_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.Font = new Font("Segoe UI", 1F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Image = Resource1.c;
            label18.Location = new Point(90, 254);
            label18.Name = "label18";
            label18.Padding = new Padding(30);
            label18.Size = new Size(63, 63);
            label18.TabIndex = 39;
            label18.Text = "C";
            label18.Click += cBtn_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.Transparent;
            label20.Font = new Font("Segoe UI", 1F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Image = Resource1.div;
            label20.Location = new Point(239, 254);
            label20.Name = "label20";
            label20.Padding = new Padding(30);
            label20.Size = new Size(63, 63);
            label20.TabIndex = 41;
            label20.Text = "/";
            label20.Click += operator_click;
            // 
            // currentLabel
            // 
            currentLabel.AutoSize = true;
            currentLabel.BackColor = Color.Transparent;
            currentLabel.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            currentLabel.ForeColor = SystemColors.ControlLight;
            currentLabel.Location = new Point(16, 44);
            currentLabel.Name = "currentLabel";
            currentLabel.Size = new Size(38, 46);
            currentLabel.TabIndex = 42;
            currentLabel.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Resource1.background_form;
            ClientSize = new Size(314, 643);
            Controls.Add(currentLabel);
            Controls.Add(label20);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(resultTextbox);
            Controls.Add(label1);
            Controls.Add(currentOpLabel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label currentOpLabel;
        private Label label1;
        private Label resultTextbox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label20;
        private Label currentLabel;
    }
}