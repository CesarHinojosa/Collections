namespace CH.Collections.UI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddNewEntree = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddNewEntree
            // 
            this.btnAddNewEntree.Location = new System.Drawing.Point(491, 62);
            this.btnAddNewEntree.Name = "btnAddNewEntree";
            this.btnAddNewEntree.Size = new System.Drawing.Size(108, 55);
            this.btnAddNewEntree.TabIndex = 0;
            this.btnAddNewEntree.Text = "Add New Entree";
            this.btnAddNewEntree.UseVisualStyleBackColor = true;
            this.btnAddNewEntree.Click += new System.EventHandler(this.btnAddNewEntree_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddNewEntree);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAddNewEntree;
    }
}