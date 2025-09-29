namespace PROIECT_REFACUT_PAW
{
    partial class EditeazaStudentForm
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
            this.titluLabel2 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.grupaLabel = new System.Windows.Forms.Label();
            this.serieLabel = new System.Windows.Forms.Label();
            this.anStudiuLabel = new System.Windows.Forms.Label();
            this.prenumeLabel = new System.Windows.Forms.Label();
            this.numeLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.anDeStudiuNumeric = new System.Windows.Forms.NumericUpDown();
            this.grupaNumeric = new System.Windows.Forms.NumericUpDown();
            this.IdNumeric = new System.Windows.Forms.NumericUpDown();
            this.serieTextBox = new System.Windows.Forms.TextBox();
            this.prenumeTextBox = new System.Windows.Forms.TextBox();
            this.numeTextBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.anDeStudiuNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupaNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // titluLabel2
            // 
            this.titluLabel2.AutoSize = true;
            this.titluLabel2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.titluLabel2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titluLabel2.Location = new System.Drawing.Point(31, 10);
            this.titluLabel2.Name = "titluLabel2";
            this.titluLabel2.Size = new System.Drawing.Size(253, 25);
            this.titluLabel2.TabIndex = 36;
            this.titluLabel2.Text = "Editeaza datele studentului  :";
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.okButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.okButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.okButton.Location = new System.Drawing.Point(654, 424);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(138, 36);
            this.okButton.TabIndex = 35;
            this.okButton.Text = "Salveaza";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.closeButton.Location = new System.Drawing.Point(478, 424);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(141, 36);
            this.closeButton.TabIndex = 34;
            this.closeButton.Text = "Anuleaza";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // grupaLabel
            // 
            this.grupaLabel.AutoSize = true;
            this.grupaLabel.Location = new System.Drawing.Point(31, 346);
            this.grupaLabel.Name = "grupaLabel";
            this.grupaLabel.Size = new System.Drawing.Size(53, 16);
            this.grupaLabel.TabIndex = 33;
            this.grupaLabel.Text = "Grupa  :";
            // 
            // serieLabel
            // 
            this.serieLabel.AutoSize = true;
            this.serieLabel.Location = new System.Drawing.Point(31, 293);
            this.serieLabel.Name = "serieLabel";
            this.serieLabel.Size = new System.Drawing.Size(48, 16);
            this.serieLabel.TabIndex = 32;
            this.serieLabel.Text = "Serie  :";
            // 
            // anStudiuLabel
            // 
            this.anStudiuLabel.AutoSize = true;
            this.anStudiuLabel.Location = new System.Drawing.Point(31, 236);
            this.anStudiuLabel.Name = "anStudiuLabel";
            this.anStudiuLabel.Size = new System.Drawing.Size(89, 16);
            this.anStudiuLabel.TabIndex = 31;
            this.anStudiuLabel.Text = "An de studiu  :";
            // 
            // prenumeLabel
            // 
            this.prenumeLabel.AutoSize = true;
            this.prenumeLabel.Location = new System.Drawing.Point(31, 177);
            this.prenumeLabel.Name = "prenumeLabel";
            this.prenumeLabel.Size = new System.Drawing.Size(70, 16);
            this.prenumeLabel.TabIndex = 30;
            this.prenumeLabel.Text = "Prenume  :";
            // 
            // numeLabel
            // 
            this.numeLabel.AutoSize = true;
            this.numeLabel.Location = new System.Drawing.Point(31, 130);
            this.numeLabel.Name = "numeLabel";
            this.numeLabel.Size = new System.Drawing.Size(52, 16);
            this.numeLabel.TabIndex = 29;
            this.numeLabel.Text = "Nume  :";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(31, 82);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(29, 16);
            this.idLabel.TabIndex = 28;
            this.idLabel.Text = "ID  :";
            // 
            // anDeStudiuNumeric
            // 
            this.anDeStudiuNumeric.Location = new System.Drawing.Point(444, 230);
            this.anDeStudiuNumeric.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.anDeStudiuNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.anDeStudiuNumeric.Name = "anDeStudiuNumeric";
            this.anDeStudiuNumeric.Size = new System.Drawing.Size(132, 22);
            this.anDeStudiuNumeric.TabIndex = 27;
            this.anDeStudiuNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // grupaNumeric
            // 
            this.grupaNumeric.Location = new System.Drawing.Point(440, 340);
            this.grupaNumeric.Maximum = new decimal(new int[] {
            1105,
            0,
            0,
            0});
            this.grupaNumeric.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.grupaNumeric.Name = "grupaNumeric";
            this.grupaNumeric.Size = new System.Drawing.Size(132, 22);
            this.grupaNumeric.TabIndex = 26;
            this.grupaNumeric.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // IdNumeric
            // 
            this.IdNumeric.Location = new System.Drawing.Point(440, 76);
            this.IdNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.IdNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.IdNumeric.Name = "IdNumeric";
            this.IdNumeric.Size = new System.Drawing.Size(132, 22);
            this.IdNumeric.TabIndex = 25;
            this.IdNumeric.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // serieTextBox
            // 
            this.serieTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.serieTextBox.Location = new System.Drawing.Point(440, 287);
            this.serieTextBox.Name = "serieTextBox";
            this.serieTextBox.Size = new System.Drawing.Size(136, 22);
            this.serieTextBox.TabIndex = 24;
            // 
            // prenumeTextBox
            // 
            this.prenumeTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.prenumeTextBox.Location = new System.Drawing.Point(440, 171);
            this.prenumeTextBox.Name = "prenumeTextBox";
            this.prenumeTextBox.Size = new System.Drawing.Size(136, 22);
            this.prenumeTextBox.TabIndex = 23;
            // 
            // numeTextBox
            // 
            this.numeTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.numeTextBox.Location = new System.Drawing.Point(440, 124);
            this.numeTextBox.Name = "numeTextBox";
            this.numeTextBox.Size = new System.Drawing.Size(136, 22);
            this.numeTextBox.TabIndex = 22;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Gainsboro;
            this.deleteButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.deleteButton.ForeColor = System.Drawing.Color.Silver;
            this.deleteButton.Location = new System.Drawing.Point(12, 408);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(170, 47);
            this.deleteButton.TabIndex = 37;
            this.deleteButton.Text = "Sterge";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // EditeazaStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(819, 486);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.titluLabel2);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.grupaLabel);
            this.Controls.Add(this.serieLabel);
            this.Controls.Add(this.anStudiuLabel);
            this.Controls.Add(this.prenumeLabel);
            this.Controls.Add(this.numeLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.anDeStudiuNumeric);
            this.Controls.Add(this.grupaNumeric);
            this.Controls.Add(this.IdNumeric);
            this.Controls.Add(this.serieTextBox);
            this.Controls.Add(this.prenumeTextBox);
            this.Controls.Add(this.numeTextBox);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "EditeazaStudentForm";
            this.Text = "EditeazaStudentForm";
            ((System.ComponentModel.ISupportInitialize)(this.anDeStudiuNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupaNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titluLabel2;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label grupaLabel;
        private System.Windows.Forms.Label serieLabel;
        private System.Windows.Forms.Label anStudiuLabel;
        private System.Windows.Forms.Label prenumeLabel;
        private System.Windows.Forms.Label numeLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.NumericUpDown anDeStudiuNumeric;
        private System.Windows.Forms.NumericUpDown grupaNumeric;
        private System.Windows.Forms.NumericUpDown IdNumeric;
        private System.Windows.Forms.TextBox serieTextBox;
        private System.Windows.Forms.TextBox prenumeTextBox;
        private System.Windows.Forms.TextBox numeTextBox;
        private System.Windows.Forms.Button deleteButton;
    }
}