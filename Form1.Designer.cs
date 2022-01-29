namespace Convertio_Wave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.convertButton = new System.Windows.Forms.Button();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.inputBoxButton = new System.Windows.Forms.Button();
            this.outputBoxButton = new System.Windows.Forms.Button();
            this.fromBox = new System.Windows.Forms.ComboBox();
            this.toBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // convertButton
            // 
            this.convertButton.BackColor = System.Drawing.Color.Gray;
            this.convertButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.convertButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.convertButton.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertButton.ForeColor = System.Drawing.Color.Maroon;
            this.convertButton.Location = new System.Drawing.Point(224, 491);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(459, 102);
            this.convertButton.TabIndex = 0;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = false;
            this.convertButton.Click += new System.EventHandler(this.convertButtonClick);
            // 
            // inputBox
            // 
            this.inputBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.inputBox.ForeColor = System.Drawing.Color.Lime;
            this.inputBox.Location = new System.Drawing.Point(112, 344);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(680, 22);
            this.inputBox.TabIndex = 1;
            this.inputBox.Text = "Select File";
            // 
            // outputBox
            // 
            this.outputBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.outputBox.ForeColor = System.Drawing.Color.Lime;
            this.outputBox.Location = new System.Drawing.Point(112, 417);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(680, 22);
            this.outputBox.TabIndex = 2;
            this.outputBox.Text = "Select Path";
            // 
            // inputBoxButton
            // 
            this.inputBoxButton.BackColor = System.Drawing.Color.SlateGray;
            this.inputBoxButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inputBoxButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.inputBoxButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputBoxButton.ForeColor = System.Drawing.Color.DarkRed;
            this.inputBoxButton.Location = new System.Drawing.Point(812, 343);
            this.inputBoxButton.Name = "inputBoxButton";
            this.inputBoxButton.Size = new System.Drawing.Size(84, 23);
            this.inputBoxButton.TabIndex = 3;
            this.inputBoxButton.Text = "Browse";
            this.inputBoxButton.UseVisualStyleBackColor = false;
            this.inputBoxButton.Click += new System.EventHandler(this.inputBoxButtonClick);
            // 
            // outputBoxButton
            // 
            this.outputBoxButton.BackColor = System.Drawing.Color.SlateGray;
            this.outputBoxButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.outputBoxButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.outputBoxButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputBoxButton.ForeColor = System.Drawing.Color.DarkRed;
            this.outputBoxButton.Location = new System.Drawing.Point(812, 416);
            this.outputBoxButton.Name = "outputBoxButton";
            this.outputBoxButton.Size = new System.Drawing.Size(84, 23);
            this.outputBoxButton.TabIndex = 4;
            this.outputBoxButton.Text = "Browse";
            this.outputBoxButton.UseVisualStyleBackColor = false;
            this.outputBoxButton.Click += new System.EventHandler(this.outputBoxButtonClick);
            // 
            // fromBox
            // 
            this.fromBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.fromBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fromBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fromBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fromBox.ForeColor = System.Drawing.Color.Lime;
            this.fromBox.FormattingEnabled = true;
            this.fromBox.Location = new System.Drawing.Point(187, 219);
            this.fromBox.Name = "fromBox";
            this.fromBox.Size = new System.Drawing.Size(136, 24);
            this.fromBox.TabIndex = 5;
            // 
            // toBox
            // 
            this.toBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.toBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.toBox.ForeColor = System.Drawing.Color.Lime;
            this.toBox.FormattingEnabled = true;
            this.toBox.Location = new System.Drawing.Point(636, 219);
            this.toBox.Name = "toBox";
            this.toBox.Size = new System.Drawing.Size(136, 24);
            this.toBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Turquoise;
            this.label1.Location = new System.Drawing.Point(21, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Choose File:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Turquoise;
            this.label2.Location = new System.Drawing.Point(36, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Save To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LawnGreen;
            this.label3.Location = new System.Drawing.Point(11, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Convert From";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LawnGreen;
            this.label4.Location = new System.Drawing.Point(438, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 67);
            this.label4.TabIndex = 10;
            this.label4.Text = "To";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LawnGreen;
            this.label5.Location = new System.Drawing.Point(837, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Format";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe Script", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.OrangeRed;
            this.label6.Location = new System.Drawing.Point(124, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(681, 95);
            this.label6.TabIndex = 12;
            this.label6.Text = "Convertio Wave";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkOrange;
            this.label7.Location = new System.Drawing.Point(191, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(526, 41);
            this.label7.TabIndex = 13;
            this.label7.Text = "For An Easier Audio Conversion";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(922, 630);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toBox);
            this.Controls.Add(this.fromBox);
            this.Controls.Add(this.outputBoxButton);
            this.Controls.Add(this.inputBoxButton);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.convertButton);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convertio Wave";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Button inputBoxButton;
        private System.Windows.Forms.Button outputBoxButton;
        private System.Windows.Forms.ComboBox fromBox;
        private System.Windows.Forms.ComboBox toBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

