﻿namespace Pokemon
{
    partial class MainWindow
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
            Pokemon.Controls.PlayerContainer.GameStatus gameStatus1 = new Pokemon.Controls.PlayerContainer.GameStatus();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.playerContainer = new Pokemon.Controls.PlayerContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReloadPokemons = new Syncfusion.WinForms.Controls.SfButton();
            this.btnClear = new Syncfusion.WinForms.Controls.SfButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnConfirm = new Syncfusion.WinForms.Controls.SfButton();
            this.cbPokemon = new Syncfusion.WinForms.ListView.SfComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCurrentRound = new System.Windows.Forms.Label();
            this.lblCurrentPlayerName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBackground.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbPokemon)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBackground
            // 
            this.pnlBackground.Controls.Add(this.tableLayoutPanel1);
            this.pnlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackground.Location = new System.Drawing.Point(2, 2);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(901, 518);
            this.pnlBackground.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Controls.Add(this.playerContainer, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(901, 518);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // playerContainer
            // 
            this.playerContainer.BackColor = System.Drawing.Color.Transparent;
            this.playerContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            gameStatus1.CurrentOrder = Pokemon.Controls.PlayerContainer.Order.Increasing;
            gameStatus1.CurrentPlayer = 1;
            gameStatus1.CurrentRound = 0;
            gameStatus1.IsTurned = true;
            gameStatus1.Skip = false;
            this.playerContainer.CurrentGameStatus = gameStatus1;
            this.playerContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playerContainer.Location = new System.Drawing.Point(3, 3);
            this.playerContainer.Name = "playerContainer";
            this.playerContainer.Size = new System.Drawing.Size(579, 512);
            this.playerContainer.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnReloadPokemons);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(588, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 512);
            this.panel2.TabIndex = 1;
            // 
            // btnReloadPokemons
            // 
            this.btnReloadPokemons.AccessibleName = "Button";
            this.btnReloadPokemons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnReloadPokemons.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnReloadPokemons.Location = new System.Drawing.Point(0, 456);
            this.btnReloadPokemons.Name = "btnReloadPokemons";
            this.btnReloadPokemons.Size = new System.Drawing.Size(310, 28);
            this.btnReloadPokemons.Style.BackColor = System.Drawing.Color.Orange;
            this.btnReloadPokemons.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(109)))), ((int)(((byte)(0)))));
            this.btnReloadPokemons.Style.FocusedForeColor = System.Drawing.Color.White;
            this.btnReloadPokemons.Style.ForeColor = System.Drawing.Color.White;
            this.btnReloadPokemons.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(109)))), ((int)(((byte)(0)))));
            this.btnReloadPokemons.Style.HoverForeColor = System.Drawing.Color.White;
            this.btnReloadPokemons.TabIndex = 7;
            this.btnReloadPokemons.Text = "Reload Pokemons";
            this.btnReloadPokemons.Click += new System.EventHandler(this.btnReloadPokemons_Click);
            // 
            // btnClear
            // 
            this.btnClear.AccessibleName = "Button";
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnClear.Location = new System.Drawing.Point(0, 484);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(310, 28);
            this.btnClear.Style.BackColor = System.Drawing.Color.Red;
            this.btnClear.Style.FocusedBackColor = System.Drawing.Color.Red;
            this.btnClear.Style.FocusedForeColor = System.Drawing.Color.White;
            this.btnClear.Style.ForeColor = System.Drawing.Color.White;
            this.btnClear.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClear.Style.HoverForeColor = System.Drawing.Color.White;
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear All";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnConfirm);
            this.panel6.Controls.Add(this.cbPokemon);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 134);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(310, 105);
            this.panel6.TabIndex = 5;
            // 
            // btnConfirm
            // 
            this.btnConfirm.AccessibleName = "Button";
            this.btnConfirm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnConfirm.Location = new System.Drawing.Point(0, 77);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(310, 28);
            this.btnConfirm.Style.BackColor = System.Drawing.Color.Green;
            this.btnConfirm.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.btnConfirm.Style.FocusedForeColor = System.Drawing.Color.White;
            this.btnConfirm.Style.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.btnConfirm.Style.HoverForeColor = System.Drawing.Color.White;
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // cbPokemon
            // 
            this.cbPokemon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbPokemon.AutoCompleteSuggestMode = Syncfusion.WinForms.ListView.Enums.AutoCompleteSuggestMode.Contains;
            this.cbPokemon.BackColor = System.Drawing.Color.White;
            this.cbPokemon.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbPokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPokemon.Location = new System.Drawing.Point(0, 0);
            this.cbPokemon.Name = "cbPokemon";
            this.cbPokemon.Size = new System.Drawing.Size(310, 28);
            this.cbPokemon.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cbPokemon.Style.EditorStyle.BackColor = System.Drawing.Color.White;
            this.cbPokemon.Style.EditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPokemon.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPokemon.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbPokemon.Style.TokenStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPokemon.TabIndex = 1;
            this.cbPokemon.ThemeName = "";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 101);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(310, 33);
            this.panel5.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.lblCurrentRound);
            this.panel4.Controls.Add(this.lblCurrentPlayerName);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 33);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(310, 68);
            this.panel4.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Round";
            // 
            // lblCurrentRound
            // 
            this.lblCurrentRound.AutoSize = true;
            this.lblCurrentRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentRound.Location = new System.Drawing.Point(109, 37);
            this.lblCurrentRound.Name = "lblCurrentRound";
            this.lblCurrentRound.Size = new System.Drawing.Size(98, 20);
            this.lblCurrentRound.TabIndex = 0;
            this.lblCurrentRound.Text = "Player Name";
            // 
            // lblCurrentPlayerName
            // 
            this.lblCurrentPlayerName.AutoSize = true;
            this.lblCurrentPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPlayerName.Location = new System.Drawing.Point(109, 7);
            this.lblCurrentPlayerName.Name = "lblCurrentPlayerName";
            this.lblCurrentPlayerName.Size = new System.Drawing.Size(98, 20);
            this.lblCurrentPlayerName.TabIndex = 0;
            this.lblCurrentPlayerName.Text = "Player Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Player Name";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(310, 33);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Turn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 522);
            this.Controls.Add(this.pnlBackground);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Pokemon";
            this.pnlBackground.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbPokemon)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Controls.PlayerContainer playerContainer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCurrentRound;
        private System.Windows.Forms.Label lblCurrentPlayerName;
        private Syncfusion.WinForms.ListView.SfComboBox cbPokemon;
        private Syncfusion.WinForms.Controls.SfButton btnConfirm;
        private Syncfusion.WinForms.Controls.SfButton btnClear;
        private Syncfusion.WinForms.Controls.SfButton btnReloadPokemons;
    }
}

