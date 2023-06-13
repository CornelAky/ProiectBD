namespace DotNetOracle
{
    partial class FormStart
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
            this.btnStartEchipa = new System.Windows.Forms.Button();
            this.lblStartJucatori = new System.Windows.Forms.Button();
            this.btnStartAntrenor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStartEchipa
            // 
            this.btnStartEchipa.Location = new System.Drawing.Point(385, 46);
            this.btnStartEchipa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStartEchipa.Name = "btnStartEchipa";
            this.btnStartEchipa.Size = new System.Drawing.Size(245, 69);
            this.btnStartEchipa.TabIndex = 0;
            this.btnStartEchipa.Text = "Lista Echipe";
            this.btnStartEchipa.UseVisualStyleBackColor = true;
            this.btnStartEchipa.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblStartJucatori
            // 
            this.lblStartJucatori.Location = new System.Drawing.Point(385, 138);
            this.lblStartJucatori.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblStartJucatori.Name = "lblStartJucatori";
            this.lblStartJucatori.Size = new System.Drawing.Size(245, 69);
            this.lblStartJucatori.TabIndex = 1;
            this.lblStartJucatori.Text = "Lista Jucatori";
            this.lblStartJucatori.UseVisualStyleBackColor = true;
            this.lblStartJucatori.Click += new System.EventHandler(this.lblStartJucatori_Click);
            // 
            // btnStartAntrenor
            // 
            this.btnStartAntrenor.Location = new System.Drawing.Point(385, 242);
            this.btnStartAntrenor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStartAntrenor.Name = "btnStartAntrenor";
            this.btnStartAntrenor.Size = new System.Drawing.Size(245, 69);
            this.btnStartAntrenor.TabIndex = 2;
            this.btnStartAntrenor.Text = "Lista Antrenori";
            this.btnStartAntrenor.UseVisualStyleBackColor = true;
            this.btnStartAntrenor.Click += new System.EventHandler(this.btnStartTurneu_Click);
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnStartAntrenor);
            this.Controls.Add(this.lblStartJucatori);
            this.Controls.Add(this.btnStartEchipa);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormStart";
            this.Text = "FormStart";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStartEchipa;
        private System.Windows.Forms.Button lblStartJucatori;
        private System.Windows.Forms.Button btnStartAntrenor;
    }
}