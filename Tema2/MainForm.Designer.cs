namespace Tema2
{
    partial class MainForm
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
            this.textBoxIn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxStiva = new System.Windows.Forms.ListBox();
            this.listBoxIn = new System.Windows.Forms.ListBox();
            this.btnVerificare = new System.Windows.Forms.Button();
            this.btnIncarcare = new System.Windows.Forms.Button();
            this.listBoxOp = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBoxIn
            // 
            this.textBoxIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIn.Location = new System.Drawing.Point(118, 27);
            this.textBoxIn.Name = "textBoxIn";
            this.textBoxIn.Size = new System.Drawing.Size(152, 29);
            this.textBoxIn.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sir intrare";
            // 
            // listBoxStiva
            // 
            this.listBoxStiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxStiva.FormattingEnabled = true;
            this.listBoxStiva.ItemHeight = 24;
            this.listBoxStiva.Location = new System.Drawing.Point(291, 27);
            this.listBoxStiva.Name = "listBoxStiva";
            this.listBoxStiva.Size = new System.Drawing.Size(219, 388);
            this.listBoxStiva.TabIndex = 2;
            // 
            // listBoxIn
            // 
            this.listBoxIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxIn.FormattingEnabled = true;
            this.listBoxIn.ItemHeight = 24;
            this.listBoxIn.Location = new System.Drawing.Point(525, 27);
            this.listBoxIn.Name = "listBoxIn";
            this.listBoxIn.Size = new System.Drawing.Size(232, 388);
            this.listBoxIn.TabIndex = 3;
            // 
            // btnVerificare
            // 
            this.btnVerificare.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificare.Location = new System.Drawing.Point(27, 364);
            this.btnVerificare.Name = "btnVerificare";
            this.btnVerificare.Size = new System.Drawing.Size(108, 57);
            this.btnVerificare.TabIndex = 4;
            this.btnVerificare.Text = "Verifica";
            this.btnVerificare.UseVisualStyleBackColor = true;
            this.btnVerificare.Click += new System.EventHandler(this.btnVerificare_Click);
            // 
            // btnIncarcare
            // 
            this.btnIncarcare.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncarcare.Location = new System.Drawing.Point(27, 256);
            this.btnIncarcare.Name = "btnIncarcare";
            this.btnIncarcare.Size = new System.Drawing.Size(108, 58);
            this.btnIncarcare.TabIndex = 5;
            this.btnIncarcare.Text = "Incarca fisier";
            this.btnIncarcare.UseVisualStyleBackColor = true;
            this.btnIncarcare.Click += new System.EventHandler(this.btnIncarcare_Click);
            // 
            // listBoxOp
            // 
            this.listBoxOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxOp.FormattingEnabled = true;
            this.listBoxOp.ItemHeight = 24;
            this.listBoxOp.Location = new System.Drawing.Point(775, 27);
            this.listBoxOp.Name = "listBoxOp";
            this.listBoxOp.Size = new System.Drawing.Size(234, 388);
            this.listBoxOp.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 450);
            this.Controls.Add(this.listBoxOp);
            this.Controls.Add(this.btnIncarcare);
            this.Controls.Add(this.btnVerificare);
            this.Controls.Add(this.listBoxIn);
            this.Controls.Add(this.listBoxStiva);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxIn);
            this.Name = "MainForm";
            this.Text = "Automat Push Down";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxStiva;
        private System.Windows.Forms.ListBox listBoxIn;
        private System.Windows.Forms.Button btnVerificare;
        private System.Windows.Forms.Button btnIncarcare;
        private System.Windows.Forms.ListBox listBoxOp;
    }
}

