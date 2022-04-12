﻿namespace SwissTransportGUI
{
    partial class Form1
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
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.departureGroupBox = new System.Windows.Forms.GroupBox();
            this.connectionsDataGridView = new System.Windows.Forms.DataGridView();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.destinationComboBox = new System.Windows.Forms.ComboBox();
            this.startComboBox = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.departureBoardDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.departureBoardComboBox = new System.Windows.Forms.ComboBox();
            this.departureBoardSearchButton = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.mainTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.departureGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.connectionsDataGridView)).BeginInit();
            this.searchGroupBox.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departureBoardDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTabControl.Controls.Add(this.tabPage1);
            this.mainTabControl.Controls.Add(this.tabPage2);
            this.mainTabControl.Controls.Add(this.tabPage3);
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(2016, 1054);
            this.mainTabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.departureGroupBox);
            this.tabPage1.Controls.Add(this.searchGroupBox);
            this.tabPage1.Location = new System.Drawing.Point(12, 69);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1992, 973);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Verbindungen";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // departureGroupBox
            // 
            this.departureGroupBox.Controls.Add(this.connectionsDataGridView);
            this.departureGroupBox.Location = new System.Drawing.Point(19, 315);
            this.departureGroupBox.Name = "departureGroupBox";
            this.departureGroupBox.Size = new System.Drawing.Size(1500, 600);
            this.departureGroupBox.TabIndex = 5;
            this.departureGroupBox.TabStop = false;
            this.departureGroupBox.Text = "Abfahrtstafel";
            // 
            // connectionsDataGridView
            // 
            this.connectionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.connectionsDataGridView.Location = new System.Drawing.Point(55, 106);
            this.connectionsDataGridView.Name = "connectionsDataGridView";
            this.connectionsDataGridView.RowHeadersWidth = 123;
            this.connectionsDataGridView.RowTemplate.Height = 57;
            this.connectionsDataGridView.Size = new System.Drawing.Size(1400, 388);
            this.connectionsDataGridView.TabIndex = 4;
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.destinationComboBox);
            this.searchGroupBox.Controls.Add(this.startComboBox);
            this.searchGroupBox.Controls.Add(this.searchButton);
            this.searchGroupBox.Location = new System.Drawing.Point(19, 60);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(1500, 192);
            this.searchGroupBox.TabIndex = 4;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Suche eingeben";
            // 
            // destinationComboBox
            // 
            this.destinationComboBox.FormattingEnabled = true;
            this.destinationComboBox.Location = new System.Drawing.Point(1055, 80);
            this.destinationComboBox.Name = "destinationComboBox";
            this.destinationComboBox.Size = new System.Drawing.Size(400, 56);
            this.destinationComboBox.TabIndex = 7;
            this.destinationComboBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ComboBoxKeyUp);
            // 
            // startComboBox
            // 
            this.startComboBox.FormattingEnabled = true;
            this.startComboBox.Location = new System.Drawing.Point(23, 80);
            this.startComboBox.Name = "startComboBox";
            this.startComboBox.Size = new System.Drawing.Size(400, 56);
            this.startComboBox.TabIndex = 6;
            this.startComboBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ComboBoxKeyUp);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(579, 71);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(300, 72);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Suchen";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButtonClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(12, 69);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1992, 973);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Abfahrtstafel";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.departureBoardDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(19, 315);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1500, 600);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Abfahrtstafel";
            // 
            // departureBoardDataGridView
            // 
            this.departureBoardDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.departureBoardDataGridView.Location = new System.Drawing.Point(55, 106);
            this.departureBoardDataGridView.Name = "departureBoardDataGridView";
            this.departureBoardDataGridView.RowHeadersWidth = 123;
            this.departureBoardDataGridView.RowTemplate.Height = 57;
            this.departureBoardDataGridView.Size = new System.Drawing.Size(1400, 388);
            this.departureBoardDataGridView.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.departureBoardComboBox);
            this.groupBox1.Controls.Add(this.departureBoardSearchButton);
            this.groupBox1.Location = new System.Drawing.Point(19, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(953, 188);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Suche eingeben";
            // 
            // departureBoardComboBox
            // 
            this.departureBoardComboBox.FormattingEnabled = true;
            this.departureBoardComboBox.Location = new System.Drawing.Point(23, 80);
            this.departureBoardComboBox.Name = "departureBoardComboBox";
            this.departureBoardComboBox.Size = new System.Drawing.Size(400, 56);
            this.departureBoardComboBox.TabIndex = 6;
            this.departureBoardComboBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ComboBoxKeyUp);
            // 
            // departureBoardSearchButton
            // 
            this.departureBoardSearchButton.Location = new System.Drawing.Point(579, 71);
            this.departureBoardSearchButton.Name = "departureBoardSearchButton";
            this.departureBoardSearchButton.Size = new System.Drawing.Size(300, 72);
            this.departureBoardSearchButton.TabIndex = 2;
            this.departureBoardSearchButton.Text = "Suchen";
            this.departureBoardSearchButton.UseVisualStyleBackColor = true;
            this.departureBoardSearchButton.Click += new System.EventHandler(this.departureBoardSearchButtonClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(12, 69);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1992, 973);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Stationenkarte";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2028, 1066);
            this.Controls.Add(this.mainTabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mainTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.departureGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.connectionsDataGridView)).EndInit();
            this.searchGroupBox.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.departureBoardDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl mainTabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button searchButton;
        private TabPage tabPage3;
        private GroupBox searchGroupBox;
        private GroupBox departureGroupBox;
        private DataGridView connectionsDataGridView;
        private ComboBox startComboBox;
        private ComboBox destinationComboBox;
        private GroupBox groupBox1;
        private ComboBox departureBoardComboBox;
        private Button departureBoardSearchButton;
        private GroupBox groupBox2;
        private DataGridView departureBoardDataGridView;
    }
}