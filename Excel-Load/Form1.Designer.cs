namespace Excel_Load
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
            loadInput = new TextBox();
            loadBtn = new Button();
            groupBox1 = new GroupBox();
            saveBtn = new Button();
            label9 = new Label();
            radioButtonMale = new RadioButton();
            radioButtonFemale = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            label8 = new Label();
            numberInput = new TextBox();
            label7 = new Label();
            cityInput = new TextBox();
            label6 = new Label();
            countryInput = new TextBox();
            label5 = new Label();
            fathernameInput = new TextBox();
            label4 = new Label();
            surnameInput = new TextBox();
            label3 = new Label();
            nameInput = new TextBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // loadInput
            // 
            loadInput.Location = new Point(21, 13);
            loadInput.Name = "loadInput";
            loadInput.Size = new Size(169, 23);
            loadInput.TabIndex = 1;
            // 
            // loadBtn
            // 
            loadBtn.BackColor = Color.DarkSlateGray;
            loadBtn.FlatStyle = FlatStyle.Popup;
            loadBtn.ForeColor = SystemColors.Window;
            loadBtn.Location = new Point(214, 13);
            loadBtn.Name = "loadBtn";
            loadBtn.Size = new Size(87, 23);
            loadBtn.TabIndex = 2;
            loadBtn.Text = "Load";
            loadBtn.UseVisualStyleBackColor = false;
            loadBtn.Click += loadBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(saveBtn);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(radioButtonMale);
            groupBox1.Controls.Add(radioButtonFemale);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(numberInput);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cityInput);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(countryInput);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(fathernameInput);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(surnameInput);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(nameInput);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.DarkSlateGray;
            groupBox1.Location = new Point(21, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(280, 380);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Anket";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.DarkSlateGray;
            saveBtn.ForeColor = SystemColors.Window;
            saveBtn.Location = new Point(13, 324);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(256, 50);
            saveBtn.TabIndex = 17;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(13, 288);
            label9.Name = "label9";
            label9.Size = new Size(40, 17);
            label9.TabIndex = 16;
            label9.Text = "Cins :";
            // 
            // radioButtonMale
            // 
            radioButtonMale.AutoSize = true;
            radioButtonMale.Location = new Point(207, 286);
            radioButtonMale.Name = "radioButtonMale";
            radioButtonMale.Size = new Size(46, 21);
            radioButtonMale.TabIndex = 15;
            radioButtonMale.TabStop = true;
            radioButtonMale.Text = "Kişi";
            radioButtonMale.UseVisualStyleBackColor = true;
            radioButtonMale.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButtonFemale
            // 
            radioButtonFemale.AutoSize = true;
            radioButtonFemale.Location = new Point(125, 286);
            radioButtonFemale.Name = "radioButtonFemale";
            radioButtonFemale.Size = new Size(62, 21);
            radioButtonFemale.TabIndex = 14;
            radioButtonFemale.TabStop = true;
            radioButtonFemale.Text = "Qadın";
            radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(113, 247);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(156, 25);
            dateTimePicker1.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 250);
            label8.Name = "label8";
            label8.Size = new Size(95, 17);
            label8.TabIndex = 12;
            label8.Text = "Doğum Tarixi :";
            // 
            // numberInput
            // 
            numberInput.Location = new Point(72, 206);
            numberInput.Name = "numberInput";
            numberInput.Size = new Size(197, 25);
            numberInput.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 209);
            label7.Name = "label7";
            label7.Size = new Size(57, 17);
            label7.TabIndex = 10;
            label7.Text = "Nömrə :";
            label7.Click += label7_Click;
            // 
            // cityInput
            // 
            cityInput.Location = new Point(72, 175);
            cityInput.Name = "cityInput";
            cityInput.Size = new Size(197, 25);
            cityInput.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 178);
            label6.Name = "label6";
            label6.Size = new Size(49, 17);
            label6.TabIndex = 8;
            label6.Text = "Şəhər :";
            // 
            // countryInput
            // 
            countryInput.Location = new Point(72, 144);
            countryInput.Name = "countryInput";
            countryInput.Size = new Size(197, 25);
            countryInput.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 147);
            label5.Name = "label5";
            label5.Size = new Size(42, 17);
            label5.TabIndex = 6;
            label5.Text = "Ölkə :";
            // 
            // fathernameInput
            // 
            fathernameInput.Location = new Point(72, 94);
            fathernameInput.Name = "fathernameInput";
            fathernameInput.Size = new Size(196, 25);
            fathernameInput.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 97);
            label4.Name = "label4";
            label4.Size = new Size(58, 17);
            label4.TabIndex = 4;
            label4.Text = "Ata adı :";
            // 
            // surnameInput
            // 
            surnameInput.Location = new Point(72, 63);
            surnameInput.Name = "surnameInput";
            surnameInput.Size = new Size(196, 25);
            surnameInput.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 66);
            label3.Name = "label3";
            label3.Size = new Size(52, 17);
            label3.TabIndex = 2;
            label3.Text = "Soyad :";
            // 
            // nameInput
            // 
            nameInput.Location = new Point(72, 32);
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(196, 25);
            nameInput.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 35);
            label2.Name = "label2";
            label2.Size = new Size(32, 17);
            label2.TabIndex = 0;
            label2.Text = "Ad :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 450);
            Controls.Add(groupBox1);
            Controls.Add(loadBtn);
            Controls.Add(loadInput);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox loadInput;
        private Button loadBtn;
        private GroupBox groupBox1;
        private TextBox nameInput;
        private Label label2;
        private TextBox countryInput;
        private Label label5;
        private TextBox fathernameInput;
        private Label label4;
        private TextBox surnameInput;
        private Label label3;
        private TextBox numberInput;
        private Label label7;
        private TextBox cityInput;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private Label label8;
        private Label label9;
        private RadioButton radioButtonMale;
        private RadioButton radioButtonFemale;
        private Button saveBtn;
    }
}