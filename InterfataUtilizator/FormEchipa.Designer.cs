namespace DotNetOracle
{
    partial class FormEchipa
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
            this.dataGridEchipe = new System.Windows.Forms.DataGridView();
            this.btnAdaugareEchipa = new System.Windows.Forms.Button();
            this.lbl_NumeEchipa = new System.Windows.Forms.Label();
            this.txtNumeEchipa = new System.Windows.Forms.TextBox();
            this.btnActualizareEchipa = new System.Windows.Forms.Button();
            this.groupBoxActualizeazaEchipa = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAntrenorEdit1 = new System.Windows.Forms.ComboBox();
            this.lblActualizareEchipa = new System.Windows.Forms.Label();
            this.txtEditNumeEchipa = new System.Windows.Forms.TextBox();
            this.lblEditNumeEchipa = new System.Windows.Forms.Label();
            this.s = new System.Windows.Forms.Label();
            this.btnEchipaToStart = new System.Windows.Forms.Button();
            this.cmbAntrenor1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEchipe)).BeginInit();
            this.groupBoxActualizeazaEchipa.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridEchipe
            // 
            this.dataGridEchipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEchipe.Location = new System.Drawing.Point(21, 10);
            this.dataGridEchipe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridEchipe.Name = "dataGridEchipe";
            this.dataGridEchipe.RowHeadersWidth = 62;
            this.dataGridEchipe.RowTemplate.Height = 28;
            this.dataGridEchipe.Size = new System.Drawing.Size(415, 175);
            this.dataGridEchipe.TabIndex = 0;
            this.dataGridEchipe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEchipe_CellContentClick);
            this.dataGridEchipe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEchipe_CellContentClick);
            // 
            // btnAdaugareEchipa
            // 
            this.btnAdaugareEchipa.Location = new System.Drawing.Point(138, 403);
            this.btnAdaugareEchipa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdaugareEchipa.Name = "btnAdaugareEchipa";
            this.btnAdaugareEchipa.Size = new System.Drawing.Size(104, 25);
            this.btnAdaugareEchipa.TabIndex = 1;
            this.btnAdaugareEchipa.Text = "Adauga";
            this.btnAdaugareEchipa.UseVisualStyleBackColor = true;
            this.btnAdaugareEchipa.Click += new System.EventHandler(this.btnAdaugareEchipa_Click);
            // 
            // lbl_NumeEchipa
            // 
            this.lbl_NumeEchipa.AutoSize = true;
            this.lbl_NumeEchipa.Location = new System.Drawing.Point(18, 305);
            this.lbl_NumeEchipa.Name = "lbl_NumeEchipa";
            this.lbl_NumeEchipa.Size = new System.Drawing.Size(88, 16);
            this.lbl_NumeEchipa.TabIndex = 3;
            this.lbl_NumeEchipa.Text = "Nume Echipa";
            // 
            // txtNumeEchipa
            // 
            this.txtNumeEchipa.Location = new System.Drawing.Point(138, 305);
            this.txtNumeEchipa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumeEchipa.Name = "txtNumeEchipa";
            this.txtNumeEchipa.Size = new System.Drawing.Size(181, 22);
            this.txtNumeEchipa.TabIndex = 5;
            // 
            // btnActualizareEchipa
            // 
            this.btnActualizareEchipa.Location = new System.Drawing.Point(185, 177);
            this.btnActualizareEchipa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizareEchipa.Name = "btnActualizareEchipa";
            this.btnActualizareEchipa.Size = new System.Drawing.Size(104, 23);
            this.btnActualizareEchipa.TabIndex = 6;
            this.btnActualizareEchipa.Text = "Actualizare";
            this.btnActualizareEchipa.UseVisualStyleBackColor = true;
            this.btnActualizareEchipa.Click += new System.EventHandler(this.btnActualizareEchipa_Click);
            // 
            // groupBoxActualizeazaEchipa
            // 
            this.groupBoxActualizeazaEchipa.Controls.Add(this.label3);
            this.groupBoxActualizeazaEchipa.Controls.Add(this.label1);
            this.groupBoxActualizeazaEchipa.Controls.Add(this.cmbAntrenorEdit1);
            this.groupBoxActualizeazaEchipa.Controls.Add(this.lblActualizareEchipa);
            this.groupBoxActualizeazaEchipa.Controls.Add(this.txtEditNumeEchipa);
            this.groupBoxActualizeazaEchipa.Controls.Add(this.lblEditNumeEchipa);
            this.groupBoxActualizeazaEchipa.Controls.Add(this.btnActualizareEchipa);
            this.groupBoxActualizeazaEchipa.Location = new System.Drawing.Point(381, 226);
            this.groupBoxActualizeazaEchipa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxActualizeazaEchipa.Name = "groupBoxActualizeazaEchipa";
            this.groupBoxActualizeazaEchipa.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxActualizeazaEchipa.Size = new System.Drawing.Size(443, 253);
            this.groupBoxActualizeazaEchipa.TabIndex = 7;
            this.groupBoxActualizeazaEchipa.TabStop = false;
            this.groupBoxActualizeazaEchipa.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 58;
            this.label1.Text = "Antrenor";
            // 
            // cmbAntrenorEdit1
            // 
            this.cmbAntrenorEdit1.FormattingEnabled = true;
            this.cmbAntrenorEdit1.Location = new System.Drawing.Point(140, 120);
            this.cmbAntrenorEdit1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbAntrenorEdit1.Name = "cmbAntrenorEdit1";
            this.cmbAntrenorEdit1.Size = new System.Drawing.Size(201, 24);
            this.cmbAntrenorEdit1.TabIndex = 57;
            // 
            // lblActualizareEchipa
            // 
            this.lblActualizareEchipa.AutoSize = true;
            this.lblActualizareEchipa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualizareEchipa.Location = new System.Drawing.Point(89, 29);
            this.lblActualizareEchipa.Name = "lblActualizareEchipa";
            this.lblActualizareEchipa.Size = new System.Drawing.Size(149, 20);
            this.lblActualizareEchipa.TabIndex = 11;
            this.lblActualizareEchipa.Text = "Actualizare Echipa";
            // 
            // txtEditNumeEchipa
            // 
            this.txtEditNumeEchipa.Location = new System.Drawing.Point(140, 84);
            this.txtEditNumeEchipa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEditNumeEchipa.Name = "txtEditNumeEchipa";
            this.txtEditNumeEchipa.Size = new System.Drawing.Size(201, 22);
            this.txtEditNumeEchipa.TabIndex = 10;
            // 
            // lblEditNumeEchipa
            // 
            this.lblEditNumeEchipa.AutoSize = true;
            this.lblEditNumeEchipa.Location = new System.Drawing.Point(22, 84);
            this.lblEditNumeEchipa.Name = "lblEditNumeEchipa";
            this.lblEditNumeEchipa.Size = new System.Drawing.Size(88, 16);
            this.lblEditNumeEchipa.TabIndex = 8;
            this.lblEditNumeEchipa.Text = "Nume Echipa";
            // 
            // s
            // 
            this.s.AutoSize = true;
            this.s.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s.Location = new System.Drawing.Point(17, 246);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(121, 20);
            this.s.TabIndex = 8;
            this.s.Text = "Adauga Echipa";
            // 
            // btnEchipaToStart
            // 
            this.btnEchipaToStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEchipaToStart.Location = new System.Drawing.Point(474, 68);
            this.btnEchipaToStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEchipaToStart.Name = "btnEchipaToStart";
            this.btnEchipaToStart.Size = new System.Drawing.Size(141, 52);
            this.btnEchipaToStart.TabIndex = 10;
            this.btnEchipaToStart.Text = "Inapoi la Start";
            this.btnEchipaToStart.UseVisualStyleBackColor = true;
            this.btnEchipaToStart.Click += new System.EventHandler(this.btnEchipaToStart_Click);
            // 
            // cmbAntrenor1
            // 
            this.cmbAntrenor1.FormattingEnabled = true;
            this.cmbAntrenor1.Location = new System.Drawing.Point(138, 359);
            this.cmbAntrenor1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbAntrenor1.Name = "cmbAntrenor1";
            this.cmbAntrenor1.Size = new System.Drawing.Size(181, 24);
            this.cmbAntrenor1.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 59;
            this.label2.Text = "Antrenor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 16);
            this.label3.TabIndex = 59;
            this.label3.Text = "ID";
            // 
            // FormEchipa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 542);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbAntrenor1);
            this.Controls.Add(this.btnEchipaToStart);
            this.Controls.Add(this.s);
            this.Controls.Add(this.groupBoxActualizeazaEchipa);
            this.Controls.Add(this.txtNumeEchipa);
            this.Controls.Add(this.lbl_NumeEchipa);
            this.Controls.Add(this.btnAdaugareEchipa);
            this.Controls.Add(this.dataGridEchipe);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormEchipa";
            this.Text = "FormEchipa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEchipe)).EndInit();
            this.groupBoxActualizeazaEchipa.ResumeLayout(false);
            this.groupBoxActualizeazaEchipa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridEchipe;
        private System.Windows.Forms.Button btnAdaugareEchipa;
        private System.Windows.Forms.Label lbl_NumeEchipa;
        private System.Windows.Forms.TextBox txtNumeEchipa;
        private System.Windows.Forms.Button btnActualizareEchipa;
        private System.Windows.Forms.GroupBox groupBoxActualizeazaEchipa;
        private System.Windows.Forms.Label s;
        private System.Windows.Forms.TextBox txtEditNumeEchipa;
        private System.Windows.Forms.Label lblEditNumeEchipa;
        private System.Windows.Forms.Label lblActualizareEchipa;
        private System.Windows.Forms.Button btnEchipaToStart;
        private System.Windows.Forms.ComboBox cmbAntrenorEdit1;
        private System.Windows.Forms.ComboBox cmbAntrenor1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}