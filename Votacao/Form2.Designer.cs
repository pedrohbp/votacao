namespace Votacao
{
    partial class Form2
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
            this.labelchapa11 = new System.Windows.Forms.Label();
            this.labelchapa22 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelchapa11
            // 
            this.labelchapa11.AutoSize = true;
            this.labelchapa11.Font = new System.Drawing.Font("Microsoft Sans Serif", 200F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelchapa11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelchapa11.Location = new System.Drawing.Point(243, 253);
            this.labelchapa11.Name = "labelchapa11";
            this.labelchapa11.Size = new System.Drawing.Size(275, 302);
            this.labelchapa11.TabIndex = 213;
            this.labelchapa11.Text = "0";
            // 
            // labelchapa22
            // 
            this.labelchapa22.AutoSize = true;
            this.labelchapa22.Font = new System.Drawing.Font("Microsoft Sans Serif", 200F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelchapa22.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelchapa22.Location = new System.Drawing.Point(741, 253);
            this.labelchapa22.Name = "labelchapa22";
            this.labelchapa22.Size = new System.Drawing.Size(275, 302);
            this.labelchapa22.TabIndex = 214;
            this.labelchapa22.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 107);
            this.label1.TabIndex = 215;
            this.label1.Text = "Chapa 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(669, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(398, 107);
            this.label2.TabIndex = 216;
            this.label2.Text = "Chapa 2";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelchapa22);
            this.Controls.Add(this.labelchapa11);
            this.Name = "Form2";
            this.Text = "Placar";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label labelchapa11;
        public System.Windows.Forms.Label labelchapa22;
    }
}