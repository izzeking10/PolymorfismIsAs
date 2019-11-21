namespace PolymorfismIsAs
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
            this.rbA = new System.Windows.Forms.RadioButton();
            this.rbB = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rbA
            // 
            this.rbA.AutoSize = true;
            this.rbA.Location = new System.Drawing.Point(98, 61);
            this.rbA.Name = "rbA";
            this.rbA.Size = new System.Drawing.Size(100, 24);
            this.rbA.TabIndex = 0;
            this.rbA.TabStop = true;
            this.rbA.Text = "Välj typ A";
            this.rbA.UseVisualStyleBackColor = true;
            this.rbA.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbB
            // 
            this.rbB.AutoSize = true;
            this.rbB.Location = new System.Drawing.Point(98, 118);
            this.rbB.Name = "rbB";
            this.rbB.Size = new System.Drawing.Size(100, 24);
            this.rbB.TabIndex = 1;
            this.rbB.TabStop = true;
            this.rbB.Text = "Välj typ B";
            this.rbB.UseVisualStyleBackColor = true;
            this.rbB.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(583, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Skapa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(98, 286);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(407, 26);
            this.tbDescription.TabIndex = 3;
            this.tbDescription.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rbB);
            this.Controls.Add(this.rbA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbA;
        private System.Windows.Forms.RadioButton rbB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbDescription;
    }
}

