namespace IngredientMinery
{
    partial class frmVisualizarOwlFile
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
            this.txtOwlFileData = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtOwlFileData
            // 
            this.txtOwlFileData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOwlFileData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOwlFileData.Location = new System.Drawing.Point(0, 0);
            this.txtOwlFileData.Multiline = true;
            this.txtOwlFileData.Name = "txtOwlFileData";
            this.txtOwlFileData.Size = new System.Drawing.Size(1025, 575);
            this.txtOwlFileData.TabIndex = 0;
            // 
            // frmVisualizarOwlFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 575);
            this.Controls.Add(this.txtOwlFileData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmVisualizarOwlFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Owl File Data";
            this.Load += new System.EventHandler(this.frmVisualizarOwlFile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOwlFileData;
    }
}