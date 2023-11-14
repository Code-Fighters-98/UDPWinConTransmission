namespace UDP_Client
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            radioButton1 = new RadioButton();
            textBox3 = new TextBox();
            label9 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(459, 422);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(291, 125);
            button1.TabIndex = 2;
            button1.Text = "Execute";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 112);
            label1.Name = "label1";
            label1.Size = new Size(42, 31);
            label1.TabIndex = 3;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 202);
            label2.Name = "label2";
            label2.Size = new Size(86, 31);
            label2.TabIndex = 4;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 308);
            label3.Name = "label3";
            label3.Size = new Size(94, 31);
            label3.TabIndex = 5;
            label3.Text = "IsMale";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(148, 124);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(218, 30);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(148, 214);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(218, 30);
            textBox2.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(142, 58);
            label4.Name = "label4";
            label4.Size = new Size(55, 31);
            label4.TabIndex = 3;
            label4.Text = "Set";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(453, 58);
            label5.Name = "label5";
            label5.Size = new Size(58, 31);
            label5.TabIndex = 3;
            label5.Text = "Get";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(453, 125);
            label6.Name = "label6";
            label6.Size = new Size(86, 31);
            label6.TabIndex = 3;
            label6.Text = "IDGet";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(453, 204);
            label7.Name = "label7";
            label7.Size = new Size(130, 31);
            label7.TabIndex = 4;
            label7.Text = "NameGet";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(453, 300);
            label8.Name = "label8";
            label8.Size = new Size(138, 31);
            label8.TabIndex = 5;
            label8.Text = "IsMaleGet";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(148, 316);
            radioButton1.Margin = new Padding(3, 4, 3, 4);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(17, 16);
            radioButton1.TabIndex = 8;
            radioButton1.TabStop = true;
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(148, 479);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(218, 30);
            textBox3.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(12, 479);
            label9.Name = "label9";
            label9.Size = new Size(64, 31);
            label9.TabIndex = 3;
            label9.Text = "Port";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 562);
            Controls.Add(radioButton1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label9);
            Controls.Add(label1);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private RadioButton radioButton1;
        private TextBox textBox3;
        private Label label9;
    }
}
