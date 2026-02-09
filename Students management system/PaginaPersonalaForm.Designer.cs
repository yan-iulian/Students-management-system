namespace PROIECT_REFACUT_PAW
{
    partial class PaginaPersonalaForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.titluLabel = new System.Windows.Forms.Label();
            this.numeStudentLabel = new System.Windows.Forms.Label();
            this.mediileDataGridView = new System.Windows.Forms.DataGridView();
            this.closeButton = new System.Windows.Forms.Button();
            this.genereazaDateleTxt = new System.Windows.Forms.Button();
            this.genAdeverintaButton = new System.Windows.Forms.Button();
            this.titlu2Label = new System.Windows.Forms.Label();
            this.raspunsLabel = new System.Windows.Forms.Label();
            this.afiseazaButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mediileDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // titluLabel
            // 
            this.titluLabel.AutoSize = true;
            this.titluLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.titluLabel.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titluLabel.Location = new System.Drawing.Point(39, 26);
            this.titluLabel.Name = "titluLabel";
            this.titluLabel.Size = new System.Drawing.Size(373, 22);
            this.titluLabel.TabIndex = 0;
            this.titluLabel.Text = "PAGINA PERSONALA A STUDENTULUI  : \r\n";
            // 
            // numeStudentLabel
            // 
            this.numeStudentLabel.AutoSize = true;
            this.numeStudentLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.numeStudentLabel.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeStudentLabel.Location = new System.Drawing.Point(576, 26);
            this.numeStudentLabel.Name = "numeStudentLabel";
            this.numeStudentLabel.Size = new System.Drawing.Size(81, 28);
            this.numeStudentLabel.TabIndex = 1;
            this.numeStudentLabel.Text = "label2";
            // 
            // mediileDataGridView
            // 
            this.mediileDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.mediileDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mediileDataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.mediileDataGridView.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.mediileDataGridView.Location = new System.Drawing.Point(29, 139);
            this.mediileDataGridView.Name = "mediileDataGridView";
            this.mediileDataGridView.RowHeadersWidth = 51;
            this.mediileDataGridView.RowTemplate.Height = 24;
            this.mediileDataGridView.Size = new System.Drawing.Size(340, 149);
            this.mediileDataGridView.TabIndex = 2;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.MistyRose;
            this.closeButton.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(771, 631);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(123, 44);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Terminat";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // genereazaDateleTxt
            // 
            this.genereazaDateleTxt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.genereazaDateleTxt.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genereazaDateleTxt.Location = new System.Drawing.Point(43, 482);
            this.genereazaDateleTxt.Name = "genereazaDateleTxt";
            this.genereazaDateleTxt.Size = new System.Drawing.Size(122, 61);
            this.genereazaDateleTxt.TabIndex = 4;
            this.genereazaDateleTxt.Text = "Genereaza .pdf ";
            this.genereazaDateleTxt.UseVisualStyleBackColor = false;
            this.genereazaDateleTxt.Click += new System.EventHandler(this.genereazaDateleTxt_Click);
            // 
            // genAdeverintaButton
            // 
            this.genAdeverintaButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.genAdeverintaButton.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genAdeverintaButton.Location = new System.Drawing.Point(43, 572);
            this.genAdeverintaButton.Name = "genAdeverintaButton";
            this.genAdeverintaButton.Size = new System.Drawing.Size(122, 60);
            this.genAdeverintaButton.TabIndex = 5;
            this.genAdeverintaButton.Text = "Genereaza adeverinta";
            this.genAdeverintaButton.UseVisualStyleBackColor = false;
            this.genAdeverintaButton.Click += new System.EventHandler(this.genAdeverintaButton_Click);
            // 
            // titlu2Label
            // 
            this.titlu2Label.AutoSize = true;
            this.titlu2Label.BackColor = System.Drawing.SystemColors.Control;
            this.titlu2Label.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlu2Label.Location = new System.Drawing.Point(26, 333);
            this.titlu2Label.Name = "titlu2Label";
            this.titlu2Label.Size = new System.Drawing.Size(278, 23);
            this.titlu2Label.TabIndex = 6;
            this.titlu2Label.Text = "Studentul doreste sa stea la camin?";
            // 
            // raspunsLabel
            // 
            this.raspunsLabel.AutoSize = true;
            this.raspunsLabel.BackColor = System.Drawing.SystemColors.Control;
            this.raspunsLabel.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raspunsLabel.Location = new System.Drawing.Point(367, 333);
            this.raspunsLabel.Name = "raspunsLabel";
            this.raspunsLabel.Size = new System.Drawing.Size(56, 23);
            this.raspunsLabel.TabIndex = 7;
            this.raspunsLabel.Text = "label1";
            // 
            // afiseazaButton
            // 
            this.afiseazaButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.afiseazaButton.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.afiseazaButton.Location = new System.Drawing.Point(43, 386);
            this.afiseazaButton.Name = "afiseazaButton";
            this.afiseazaButton.Size = new System.Drawing.Size(122, 60);
            this.afiseazaButton.TabIndex = 8;
            this.afiseazaButton.Text = "Afiseaza  \r\noptiunile  :\r\n";
            this.afiseazaButton.UseVisualStyleBackColor = false;
            this.afiseazaButton.Click += new System.EventHandler(this.afiseazaButton_Click);
            // 
            // PaginaPersonalaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImage = global::PROIECT_REFACUT_PAW.Properties.Resources.Cladirea_Ion_N_Angelescu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(932, 696);
            this.Controls.Add(this.afiseazaButton);
            this.Controls.Add(this.raspunsLabel);
            this.Controls.Add(this.titlu2Label);
            this.Controls.Add(this.genAdeverintaButton);
            this.Controls.Add(this.genereazaDateleTxt);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.mediileDataGridView);
            this.Controls.Add(this.numeStudentLabel);
            this.Controls.Add(this.titluLabel);
            this.Name = "PaginaPersonalaForm";
            this.Text = "Pagina persoanala ";
            ((System.ComponentModel.ISupportInitialize)(this.mediileDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titluLabel;
        private System.Windows.Forms.Label numeStudentLabel;
        private System.Windows.Forms.DataGridView mediileDataGridView;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button genereazaDateleTxt;
        private System.Windows.Forms.Button genAdeverintaButton;
        private System.Windows.Forms.Label titlu2Label;
        private System.Windows.Forms.Label raspunsLabel;
        private System.Windows.Forms.Button afiseazaButton;
    }
}