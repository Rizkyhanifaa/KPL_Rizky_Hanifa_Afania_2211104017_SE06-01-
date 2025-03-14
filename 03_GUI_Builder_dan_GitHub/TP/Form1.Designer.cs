namespace tp_modul3
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
            this.submit_btn = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label_output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // submit_btn
            // 
            this.submit_btn.BackColor = System.Drawing.Color.ForestGreen;
            this.submit_btn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.submit_btn.Location = new System.Drawing.Point(539, 133);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(72, 36);
            this.submit_btn.TabIndex = 0;
            this.submit_btn.Text = "Submit";
            this.submit_btn.UseVisualStyleBackColor = false;
            this.submit_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.Color.OrangeRed;
            this.txtInput.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtInput.Location = new System.Drawing.Point(214, 133);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(272, 26);
            this.txtInput.TabIndex = 1;
            this.txtInput.Text = "Masukkan Nama Kamu";
            this.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // label_output
            // 
            this.label_output.AutoSize = true;
            this.label_output.BackColor = System.Drawing.Color.OrangeRed;
            this.label_output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_output.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_output.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_output.Location = new System.Drawing.Point(214, 175);
            this.label_output.Name = "label_output";
            this.label_output.Size = new System.Drawing.Size(53, 22);
            this.label_output.TabIndex = 2;
            this.label_output.Text = "Output";
            this.label_output.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_output);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.submit_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label_output;
    }
}

