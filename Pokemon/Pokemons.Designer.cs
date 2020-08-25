namespace Pokemon
{
    partial class Pokemons
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnImportImages = new Syncfusion.WinForms.Controls.SfButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlPokemons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDeleteAll = new Syncfusion.WinForms.Controls.SfButton();
            this.btnReloadAll = new Syncfusion.WinForms.Controls.SfButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnReloadAll);
            this.panel1.Controls.Add(this.btnDeleteAll);
            this.panel1.Controls.Add(this.btnImportImages);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(796, 43);
            this.panel1.TabIndex = 0;
            // 
            // btnImportImages
            // 
            this.btnImportImages.AccessibleName = "Button";
            this.btnImportImages.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnImportImages.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnImportImages.Location = new System.Drawing.Point(3, 3);
            this.btnImportImages.Name = "btnImportImages";
            this.btnImportImages.Size = new System.Drawing.Size(96, 37);
            this.btnImportImages.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(170)))), ((int)(((byte)(85)))));
            this.btnImportImages.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(170)))), ((int)(((byte)(85)))));
            this.btnImportImages.Style.FocusedForeColor = System.Drawing.Color.White;
            this.btnImportImages.Style.ForeColor = System.Drawing.Color.White;
            this.btnImportImages.Style.HoverBackColor = System.Drawing.Color.Green;
            this.btnImportImages.Style.HoverForeColor = System.Drawing.Color.White;
            this.btnImportImages.TabIndex = 3;
            this.btnImportImages.Text = "Import Images";
            this.btnImportImages.Click += new System.EventHandler(this.btnImportImage_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlPokemons);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(2, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(796, 403);
            this.panel2.TabIndex = 1;
            // 
            // pnlPokemons
            // 
            this.pnlPokemons.AutoScroll = true;
            this.pnlPokemons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPokemons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPokemons.Location = new System.Drawing.Point(0, 0);
            this.pnlPokemons.Name = "pnlPokemons";
            this.pnlPokemons.Size = new System.Drawing.Size(796, 403);
            this.pnlPokemons.TabIndex = 0;
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.AccessibleName = "Button";
            this.btnDeleteAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDeleteAll.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnDeleteAll.Location = new System.Drawing.Point(99, 3);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Padding = new System.Windows.Forms.Padding(10);
            this.btnDeleteAll.Size = new System.Drawing.Size(96, 37);
            this.btnDeleteAll.Style.BackColor = System.Drawing.Color.Red;
            this.btnDeleteAll.Style.FocusedBackColor = System.Drawing.Color.Red;
            this.btnDeleteAll.Style.FocusedForeColor = System.Drawing.Color.White;
            this.btnDeleteAll.Style.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAll.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnDeleteAll.Style.HoverForeColor = System.Drawing.Color.White;
            this.btnDeleteAll.TabIndex = 4;
            this.btnDeleteAll.Text = "Delete All";
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnReloadAll
            // 
            this.btnReloadAll.AccessibleName = "Button";
            this.btnReloadAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnReloadAll.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnReloadAll.Location = new System.Drawing.Point(195, 3);
            this.btnReloadAll.Name = "btnReloadAll";
            this.btnReloadAll.Padding = new System.Windows.Forms.Padding(10);
            this.btnReloadAll.Size = new System.Drawing.Size(96, 37);
            this.btnReloadAll.Style.BackColor = System.Drawing.Color.Orange;
            this.btnReloadAll.Style.FocusedBackColor = System.Drawing.Color.Orange;
            this.btnReloadAll.Style.FocusedForeColor = System.Drawing.Color.White;
            this.btnReloadAll.Style.ForeColor = System.Drawing.Color.White;
            this.btnReloadAll.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(85)))));
            this.btnReloadAll.Style.HoverForeColor = System.Drawing.Color.White;
            this.btnReloadAll.TabIndex = 5;
            this.btnReloadAll.Text = "Reload All";
            this.btnReloadAll.Click += new System.EventHandler(this.btnReloadAll_Click);
            // 
            // Pokemons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Pokemons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pokemons";
            this.Load += new System.EventHandler(this.Pokemons_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel pnlPokemons;
        private Syncfusion.WinForms.Controls.SfButton btnImportImages;
        private Syncfusion.WinForms.Controls.SfButton btnDeleteAll;
        private Syncfusion.WinForms.Controls.SfButton btnReloadAll;
    }
}