namespace SwissTransportGUI
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
            this.amountGroupBox = new System.Windows.Forms.GroupBox();
            this.resultNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.dateGroupBox = new System.Windows.Forms.GroupBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.timeGroupBox = new System.Windows.Forms.GroupBox();
            this.timeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.takeMeHomeGroupBox = new System.Windows.Forms.GroupBox();
            this.takeMeHomeButton = new System.Windows.Forms.Button();
            this.departureGroupBox = new System.Windows.Forms.GroupBox();
            this.connectionsDataGridView = new System.Windows.Forms.DataGridView();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.resultAmountGroupBox = new System.Windows.Forms.GroupBox();
            this.destinationComboBox = new System.Windows.Forms.ComboBox();
            this.startComboBox = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.departureBoardDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.departureBoardComboBox = new System.Windows.Forms.ComboBox();
            this.departureBoardSearchButton = new System.Windows.Forms.Button();
            this.stationSearchTab = new System.Windows.Forms.TabPage();
            this.closeSearchGroupBox = new System.Windows.Forms.GroupBox();
            this.distanceSearchButton = new System.Windows.Forms.Button();
            this.distanceComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.searchStationComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.stationDataGridView = new System.Windows.Forms.DataGridView();
            this.mapGroupBox = new System.Windows.Forms.GroupBox();
            this.mapShowButton = new System.Windows.Forms.Button();
            this.mainTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.amountGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultNumericUpDown)).BeginInit();
            this.dateGroupBox.SuspendLayout();
            this.timeGroupBox.SuspendLayout();
            this.takeMeHomeGroupBox.SuspendLayout();
            this.departureGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.connectionsDataGridView)).BeginInit();
            this.searchGroupBox.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departureBoardDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.stationSearchTab.SuspendLayout();
            this.closeSearchGroupBox.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stationDataGridView)).BeginInit();
            this.mapGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTabControl.Controls.Add(this.tabPage1);
            this.mainTabControl.Controls.Add(this.tabPage2);
            this.mainTabControl.Controls.Add(this.stationSearchTab);
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(2273, 1229);
            this.mainTabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.amountGroupBox);
            this.tabPage1.Controls.Add(this.dateGroupBox);
            this.tabPage1.Controls.Add(this.timeGroupBox);
            this.tabPage1.Controls.Add(this.takeMeHomeGroupBox);
            this.tabPage1.Controls.Add(this.departureGroupBox);
            this.tabPage1.Controls.Add(this.searchGroupBox);
            this.tabPage1.Location = new System.Drawing.Point(12, 69);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(2249, 1148);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Verbindungen";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // amountGroupBox
            // 
            this.amountGroupBox.Controls.Add(this.resultNumericUpDown);
            this.amountGroupBox.Location = new System.Drawing.Point(458, 271);
            this.amountGroupBox.Name = "amountGroupBox";
            this.amountGroupBox.Size = new System.Drawing.Size(610, 166);
            this.amountGroupBox.TabIndex = 9;
            this.amountGroupBox.TabStop = false;
            this.amountGroupBox.Text = "Anzahl Ergebnisse";
            // 
            // resultNumericUpDown
            // 
            this.resultNumericUpDown.Location = new System.Drawing.Point(138, 72);
            this.resultNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.resultNumericUpDown.Name = "resultNumericUpDown";
            this.resultNumericUpDown.Size = new System.Drawing.Size(303, 55);
            this.resultNumericUpDown.TabIndex = 0;
            this.resultNumericUpDown.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // dateGroupBox
            // 
            this.dateGroupBox.Controls.Add(this.dateTimePicker);
            this.dateGroupBox.Location = new System.Drawing.Point(1588, 628);
            this.dateGroupBox.Name = "dateGroupBox";
            this.dateGroupBox.Size = new System.Drawing.Size(634, 300);
            this.dateGroupBox.TabIndex = 8;
            this.dateGroupBox.TabStop = false;
            this.dateGroupBox.Text = "Datum eingeben";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(15, 117);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(588, 55);
            this.dateTimePicker.TabIndex = 0;
            // 
            // timeGroupBox
            // 
            this.timeGroupBox.Controls.Add(this.timeDateTimePicker);
            this.timeGroupBox.Location = new System.Drawing.Point(1588, 308);
            this.timeGroupBox.Name = "timeGroupBox";
            this.timeGroupBox.Size = new System.Drawing.Size(634, 290);
            this.timeGroupBox.TabIndex = 7;
            this.timeGroupBox.TabStop = false;
            this.timeGroupBox.Text = "Uhrzeit eingeben";
            // 
            // timeDateTimePicker
            // 
            this.timeDateTimePicker.Checked = false;
            this.timeDateTimePicker.CustomFormat = "HH:mm";
            this.timeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeDateTimePicker.Location = new System.Drawing.Point(26, 106);
            this.timeDateTimePicker.Name = "timeDateTimePicker";
            this.timeDateTimePicker.ShowUpDown = true;
            this.timeDateTimePicker.Size = new System.Drawing.Size(588, 55);
            this.timeDateTimePicker.TabIndex = 1;
            // 
            // takeMeHomeGroupBox
            // 
            this.takeMeHomeGroupBox.Controls.Add(this.takeMeHomeButton);
            this.takeMeHomeGroupBox.Location = new System.Drawing.Point(1588, 60);
            this.takeMeHomeGroupBox.Name = "takeMeHomeGroupBox";
            this.takeMeHomeGroupBox.Size = new System.Drawing.Size(351, 192);
            this.takeMeHomeGroupBox.TabIndex = 6;
            this.takeMeHomeGroupBox.TabStop = false;
            this.takeMeHomeGroupBox.Text = "TakeMeHome";
            // 
            // takeMeHomeButton
            // 
            this.takeMeHomeButton.Location = new System.Drawing.Point(25, 71);
            this.takeMeHomeButton.Name = "takeMeHomeButton";
            this.takeMeHomeButton.Size = new System.Drawing.Size(300, 72);
            this.takeMeHomeButton.TabIndex = 0;
            this.takeMeHomeButton.Text = "TakeMeHome";
            this.takeMeHomeButton.UseVisualStyleBackColor = true;
            this.takeMeHomeButton.Click += new System.EventHandler(this.TakeMeHomeButtonClick);
            // 
            // departureGroupBox
            // 
            this.departureGroupBox.Controls.Add(this.connectionsDataGridView);
            this.departureGroupBox.Location = new System.Drawing.Point(42, 460);
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
            this.searchGroupBox.Controls.Add(this.resultAmountGroupBox);
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
            // resultAmountGroupBox
            // 
            this.resultAmountGroupBox.Location = new System.Drawing.Point(225, 198);
            this.resultAmountGroupBox.Name = "resultAmountGroupBox";
            this.resultAmountGroupBox.Size = new System.Drawing.Size(1002, 64);
            this.resultAmountGroupBox.TabIndex = 8;
            this.resultAmountGroupBox.TabStop = false;
            this.resultAmountGroupBox.Text = "gewünschte Anzahl Verbindungen angeben";
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
            this.tabPage2.Controls.Add(this.mapGroupBox);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(12, 69);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(2249, 1148);
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
            this.departureBoardSearchButton.Click += new System.EventHandler(this.DepartureBoardSearchButtonClick);
            // 
            // stationSearchTab
            // 
            this.stationSearchTab.Controls.Add(this.closeSearchGroupBox);
            this.stationSearchTab.Controls.Add(this.groupBox4);
            this.stationSearchTab.Controls.Add(this.groupBox3);
            this.stationSearchTab.Location = new System.Drawing.Point(12, 69);
            this.stationSearchTab.Name = "stationSearchTab";
            this.stationSearchTab.Padding = new System.Windows.Forms.Padding(3);
            this.stationSearchTab.Size = new System.Drawing.Size(2249, 1148);
            this.stationSearchTab.TabIndex = 2;
            this.stationSearchTab.Text = "Stationssuche";
            this.stationSearchTab.UseVisualStyleBackColor = true;
            // 
            // closeSearchGroupBox
            // 
            this.closeSearchGroupBox.Controls.Add(this.distanceSearchButton);
            this.closeSearchGroupBox.Controls.Add(this.distanceComboBox);
            this.closeSearchGroupBox.Location = new System.Drawing.Point(1094, 60);
            this.closeSearchGroupBox.Name = "closeSearchGroupBox";
            this.closeSearchGroupBox.Size = new System.Drawing.Size(953, 188);
            this.closeSearchGroupBox.TabIndex = 9;
            this.closeSearchGroupBox.TabStop = false;
            this.closeSearchGroupBox.Text = "In Umgebung suchen";
            // 
            // distanceSearchButton
            // 
            this.distanceSearchButton.Location = new System.Drawing.Point(527, 71);
            this.distanceSearchButton.Name = "distanceSearchButton";
            this.distanceSearchButton.Size = new System.Drawing.Size(300, 72);
            this.distanceSearchButton.TabIndex = 8;
            this.distanceSearchButton.Text = "Suchen";
            this.distanceSearchButton.UseVisualStyleBackColor = true;
            this.distanceSearchButton.Click += new System.EventHandler(this.distanceSearchButtonClick);
            // 
            // distanceComboBox
            // 
            this.distanceComboBox.FormattingEnabled = true;
            this.distanceComboBox.Location = new System.Drawing.Point(25, 80);
            this.distanceComboBox.Name = "distanceComboBox";
            this.distanceComboBox.Size = new System.Drawing.Size(400, 56);
            this.distanceComboBox.TabIndex = 7;
            this.distanceComboBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ComboBoxKeyUp);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.searchStationComboBox);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Location = new System.Drawing.Point(19, 60);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(953, 188);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Station suchen";
            // 
            // searchStationComboBox
            // 
            this.searchStationComboBox.FormattingEnabled = true;
            this.searchStationComboBox.Location = new System.Drawing.Point(23, 80);
            this.searchStationComboBox.Name = "searchStationComboBox";
            this.searchStationComboBox.Size = new System.Drawing.Size(400, 56);
            this.searchStationComboBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(579, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 72);
            this.button1.TabIndex = 2;
            this.button1.Text = "Suchen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.stationSearchButtonClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.stationDataGridView);
            this.groupBox3.Location = new System.Drawing.Point(19, 315);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1500, 600);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Stationssuche";
            // 
            // stationDataGridView
            // 
            this.stationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stationDataGridView.Location = new System.Drawing.Point(55, 106);
            this.stationDataGridView.Name = "stationDataGridView";
            this.stationDataGridView.RowHeadersWidth = 123;
            this.stationDataGridView.RowTemplate.Height = 57;
            this.stationDataGridView.Size = new System.Drawing.Size(1400, 388);
            this.stationDataGridView.TabIndex = 4;
            // 
            // mapGroupBox
            // 
            this.mapGroupBox.Controls.Add(this.mapShowButton);
            this.mapGroupBox.Location = new System.Drawing.Point(1047, 60);
            this.mapGroupBox.Name = "mapGroupBox";
            this.mapGroupBox.Size = new System.Drawing.Size(472, 179);
            this.mapGroupBox.TabIndex = 7;
            this.mapGroupBox.TabStop = false;
            this.mapGroupBox.Text = "Karte ansehen";
            // 
            // mapShowButton
            // 
            this.mapShowButton.Location = new System.Drawing.Point(92, 71);
            this.mapShowButton.Name = "mapShowButton";
            this.mapShowButton.Size = new System.Drawing.Size(300, 72);
            this.mapShowButton.TabIndex = 0;
            this.mapShowButton.Text = "Karte ansehen";
            this.mapShowButton.UseVisualStyleBackColor = true;
            this.mapShowButton.Click += new System.EventHandler(this.mapShowButtonClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2285, 1241);
            this.Controls.Add(this.mainTabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mainTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.amountGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultNumericUpDown)).EndInit();
            this.dateGroupBox.ResumeLayout(false);
            this.timeGroupBox.ResumeLayout(false);
            this.takeMeHomeGroupBox.ResumeLayout(false);
            this.departureGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.connectionsDataGridView)).EndInit();
            this.searchGroupBox.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.departureBoardDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.stationSearchTab.ResumeLayout(false);
            this.closeSearchGroupBox.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stationDataGridView)).EndInit();
            this.mapGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl mainTabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button searchButton;
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
        private GroupBox takeMeHomeGroupBox;
        private Button takeMeHomeButton;
        private GroupBox timeGroupBox;
        private DateTimePicker dateTimePicker;
        private GroupBox dateGroupBox;
        private DateTimePicker timeDateTimePicker;
        private GroupBox amountGroupBox;
        private NumericUpDown resultNumericUpDown;
        private GroupBox resultAmountGroupBox;
        private TabPage stationSearchTab;
        private GroupBox groupBox3;
        private DataGridView stationDataGridView;
        private GroupBox groupBox4;
        private ComboBox searchStationComboBox;
        private Button button1;
        private GroupBox closeSearchGroupBox;
        private Button distanceSearchButton;
        private ComboBox distanceComboBox;
        private GroupBox mapGroupBox;
        private Button mapShowButton;
    }
}