namespace ZaverecnyProjekt
{
    partial class Form9
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
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.encodedTextBox = new System.Windows.Forms.TextBox();
            this.encodedTextBox2 = new System.Windows.Forms.TextBox();
            this.inputTextBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(244, 560);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(210, 45);
            this.button4.TabIndex = 15;
            this.button4.Text = "Zpět";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(730, 560);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 45);
            this.button1.TabIndex = 17;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(410, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 72);
            this.label1.TabIndex = 18;
            this.label1.Text = "Binární kódování";
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(488, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 45);
            this.button2.TabIndex = 19;
            this.button2.Text = "Encode";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputTextBox.Location = new System.Drawing.Point(244, 263);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(214, 45);
            this.inputTextBox.TabIndex = 20;
            this.inputTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // encodedTextBox
            // 
            this.encodedTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.encodedTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.encodedTextBox.Location = new System.Drawing.Point(726, 263);
            this.encodedTextBox.Multiline = true;
            this.encodedTextBox.Name = "encodedTextBox";
            this.encodedTextBox.ReadOnly = true;
            this.encodedTextBox.Size = new System.Drawing.Size(214, 45);
            this.encodedTextBox.TabIndex = 21;
            this.encodedTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // encodedTextBox2
            // 
            this.encodedTextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.encodedTextBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.encodedTextBox2.Location = new System.Drawing.Point(726, 381);
            this.encodedTextBox2.Multiline = true;
            this.encodedTextBox2.Name = "encodedTextBox2";
            this.encodedTextBox2.ReadOnly = true;
            this.encodedTextBox2.Size = new System.Drawing.Size(214, 45);
            this.encodedTextBox2.TabIndex = 24;
            // 
            // inputTextBox2
            // 
            this.inputTextBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputTextBox2.Location = new System.Drawing.Point(244, 381);
            this.inputTextBox2.Multiline = true;
            this.inputTextBox2.Name = "inputTextBox2";
            this.inputTextBox2.Size = new System.Drawing.Size(214, 45);
            this.inputTextBox2.TabIndex = 23;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(488, 381);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(210, 45);
            this.button3.TabIndex = 22;
            this.button3.Text = "Decode";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(488, 490);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(210, 45);
            this.button5.TabIndex = 25;
            this.button5.Text = "Clear";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 677);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.encodedTextBox2);
            this.Controls.Add(this.inputTextBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.encodedTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Name = "Form9";
            this.Text = "Form9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button4;
        private Button button1;
        private Label label1;
        private Button button2;
        private TextBox inputTextBox;
        private TextBox encodedTextBox;
        private TextBox encodedTextBox2;
        private TextBox inputTextBox2;
        private Button button3;
        private Button button5;
    }
}