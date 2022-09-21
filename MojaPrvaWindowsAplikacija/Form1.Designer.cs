namespace MojaPrvaWindowsAplikacija
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
            this.txtUnosBrojaA = new System.Windows.Forms.TextBox();
            this.txtUnosBrojaB = new System.Windows.Forms.TextBox();
            this.txtIznos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIzracun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUnosBrojaA
            // 
            this.txtUnosBrojaA.Location = new System.Drawing.Point(89, 58);
            this.txtUnosBrojaA.Name = "txtUnosBrojaA";
            this.txtUnosBrojaA.Size = new System.Drawing.Size(100, 20);
            this.txtUnosBrojaA.TabIndex = 0;
            this.txtUnosBrojaA.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtUnosBrojaB
            // 
            this.txtUnosBrojaB.Location = new System.Drawing.Point(384, 58);
            this.txtUnosBrojaB.Name = "txtUnosBrojaB";
            this.txtUnosBrojaB.Size = new System.Drawing.Size(100, 20);
            this.txtUnosBrojaB.TabIndex = 1;
            this.txtUnosBrojaB.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtIznos
            // 
            this.txtIznos.Location = new System.Drawing.Point(89, 224);
            this.txtIznos.Name = "txtIznos";
            this.txtIznos.ReadOnly = true;
            this.txtIznos.Size = new System.Drawing.Size(100, 20);
            this.txtIznos.TabIndex = 6;
            this.txtIznos.TabStop = false;
            this.txtIznos.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Broj A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Broj B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Zbroj";
            // 
            // btnIzracun
            // 
            this.btnIzracun.Location = new System.Drawing.Point(409, 224);
            this.btnIzracun.Name = "btnIzracun";
            this.btnIzracun.Size = new System.Drawing.Size(75, 23);
            this.btnIzracun.TabIndex = 2;
            this.btnIzracun.Text = "Izracunaj";
            this.btnIzracun.UseVisualStyleBackColor = true;
            this.btnIzracun.Click += new System.EventHandler(this.btnIzracun_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIzracun);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIznos);
            this.Controls.Add(this.txtUnosBrojaB);
            this.Controls.Add(this.txtUnosBrojaA);
            this.Name = "Form1";
            this.Text = "MojaPrvaWindowsAplikacija";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUnosBrojaA;
        private System.Windows.Forms.TextBox txtUnosBrojaB;
        private System.Windows.Forms.TextBox txtIznos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIzracun;
    }
}

