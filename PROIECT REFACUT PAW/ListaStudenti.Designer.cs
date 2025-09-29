namespace PROIECT_REFACUT_PAW
{
    partial class ListaStudentiForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.studentGridView = new System.Windows.Forms.DataGridView();
            this.closeButton = new System.Windows.Forms.Button();
            this.adaugaStudentButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.serializareButton = new System.Windows.Forms.Button();
            this.deserializareButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // studentGridView
            // 
            this.studentGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.studentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.studentGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.studentGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.studentGridView.Location = new System.Drawing.Point(54, 47);
            this.studentGridView.Name = "studentGridView";
            this.studentGridView.RowHeadersWidth = 51;
            this.studentGridView.RowTemplate.Height = 24;
            this.studentGridView.Size = new System.Drawing.Size(1328, 526);
            this.studentGridView.TabIndex = 0;
            this.studentGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentGridView_CellContentClick);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.closeButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.closeButton.Location = new System.Drawing.Point(1257, 598);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(125, 45);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Inchide";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // adaugaStudentButton
            // 
            this.adaugaStudentButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.adaugaStudentButton.Location = new System.Drawing.Point(54, 598);
            this.adaugaStudentButton.Name = "adaugaStudentButton";
            this.adaugaStudentButton.Size = new System.Drawing.Size(151, 45);
            this.adaugaStudentButton.TabIndex = 2;
            this.adaugaStudentButton.Text = "Adauga student nou";
            this.adaugaStudentButton.UseVisualStyleBackColor = false;
            this.adaugaStudentButton.Click += new System.EventHandler(this.adaugaStudentButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.searchTextBox.Location = new System.Drawing.Point(158, 10);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(432, 22);
            this.searchTextBox.TabIndex = 3;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(51, 16);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(62, 16);
            this.searchLabel.TabIndex = 4;
            this.searchLabel.Text = "CAUTA  :";
            // 
            // serializareButton
            // 
            this.serializareButton.Location = new System.Drawing.Point(260, 598);
            this.serializareButton.Name = "serializareButton";
            this.serializareButton.Size = new System.Drawing.Size(109, 45);
            this.serializareButton.TabIndex = 5;
            this.serializareButton.Text = "Serializare";
            this.serializareButton.UseVisualStyleBackColor = true;
            this.serializareButton.Click += new System.EventHandler(this.serializareButton_Click);
            // 
            // deserializareButton
            // 
            this.deserializareButton.Location = new System.Drawing.Point(431, 598);
            this.deserializareButton.Name = "deserializareButton";
            this.deserializareButton.Size = new System.Drawing.Size(116, 45);
            this.deserializareButton.TabIndex = 6;
            this.deserializareButton.Text = "Deserializeaza";
            this.deserializareButton.UseVisualStyleBackColor = true;
            this.deserializareButton.Click += new System.EventHandler(this.deserializareButton_Click);
            // 
            // ListaStudentiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1425, 671);
            this.Controls.Add(this.deserializareButton);
            this.Controls.Add(this.serializareButton);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.adaugaStudentButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.studentGridView);
            this.Name = "ListaStudentiForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "LISTA STUDENTI";
            ((System.ComponentModel.ISupportInitialize)(this.studentGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView studentGridView;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button adaugaStudentButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Button serializareButton;
        private System.Windows.Forms.Button deserializareButton;
    }
}

