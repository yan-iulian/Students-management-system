namespace PROIECT_REFACUT_PAW
{
    partial class DisciplineViewForm
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
            this.DisciplineGridView = new System.Windows.Forms.DataGridView();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DisciplineGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DisciplineGridView
            // 
            this.DisciplineGridView.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.DisciplineGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DisciplineGridView.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DisciplineGridView.Location = new System.Drawing.Point(12, 25);
            this.DisciplineGridView.Name = "DisciplineGridView";
            this.DisciplineGridView.RowHeadersWidth = 51;
            this.DisciplineGridView.RowTemplate.Height = 24;
            this.DisciplineGridView.Size = new System.Drawing.Size(662, 443);
            this.DisciplineGridView.TabIndex = 0;
            this.DisciplineGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DisciplineGridView_CellContentClick);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(586, 491);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(88, 30);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Inchide";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // DisciplineViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(695, 533);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.DisciplineGridView);
            this.Name = "DisciplineViewForm";
            this.Text = "DisciplineViewForm";
            ((System.ComponentModel.ISupportInitialize)(this.DisciplineGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DisciplineGridView;
        private System.Windows.Forms.Button closeButton;
    }
}