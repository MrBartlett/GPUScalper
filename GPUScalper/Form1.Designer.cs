namespace GPUScalper
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
            this.btnNRun = new System.Windows.Forms.Button();
            this.txtNGPU = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNRun
            // 
            this.btnNRun.Location = new System.Drawing.Point(650, 120);
            this.btnNRun.Name = "btnNRun";
            this.btnNRun.Size = new System.Drawing.Size(104, 46);
            this.btnNRun.TabIndex = 0;
            this.btnNRun.Text = "btnNRun";
            this.btnNRun.UseVisualStyleBackColor = true;
            this.btnNRun.Click += new System.EventHandler(this.btnNRun_Click);
            // 
            // txtNGPU
            // 
            this.txtNGPU.Location = new System.Drawing.Point(12, 120);
            this.txtNGPU.Name = "txtNGPU";
            this.txtNGPU.Size = new System.Drawing.Size(170, 26);
            this.txtNGPU.TabIndex = 1;
            this.txtNGPU.Text = "txtNGPU";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(646, 334);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(73, 20);
            this.lblOutput.TabIndex = 2;
            this.lblOutput.Text = "lblOutput";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(650, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Price";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.txtNGPU);
            this.Controls.Add(this.btnNRun);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNRun;
        private System.Windows.Forms.TextBox txtNGPU;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label label1;
    }
}

