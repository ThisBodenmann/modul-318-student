namespace SwissTransportGUI
{
    partial class SwissTransport
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
            this.destinationGroupBox = new System.Windows.Forms.GroupBox();
            this.destinationComboBox = new System.Windows.Forms.ComboBox();
            this.startGroupBox = new System.Windows.Forms.GroupBox();
            this.startComboBox = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.mapGroupBox = new System.Windows.Forms.GroupBox();
            this.mapShowButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.departureBoardDataGridView = new System.Windows.Forms.DataGridView();
            this.departureSearchGroupBox = new System.Windows.Forms.GroupBox();
            this.departureEnterGroupBox = new System.Windows.Forms.GroupBox();
            this.departureBoardComboBox = new System.Windows.Forms.ComboBox();
            this.departureBoardSearchButton = new System.Windows.Forms.Button();
            this.stationSearchTab = new System.Windows.Forms.TabPage();
            this.stationSearchGroupBox = new System.Windows.Forms.GroupBox();
            this.stationSearchEnterGroupBox = new System.Windows.Forms.GroupBox();
            this.searchStationComboBox = new System.Windows.Forms.ComboBox();
            this.stationSearchButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.stationDataGridView = new System.Windows.Forms.DataGridView();
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
            this.destinationGroupBox.SuspendLayout();
            this.startGroupBox.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.mapGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departureBoardDataGridView)).BeginInit();
            this.departureSearchGroupBox.SuspendLayout();
            this.departureEnterGroupBox.SuspendLayout();
            this.stationSearchTab.SuspendLayout();
            this.stationSearchGroupBox.SuspendLayout();
            this.stationSearchEnterGroupBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stationDataGridView)).BeginInit();
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
            this.mainTabControl.SelectedIndexChanged += new System.EventHandler(this.mainTabControlSelectedIndexChanged);
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
            this.amountGroupBox.Location = new System.Drawing.Point(477, 258);
            this.amountGroupBox.Name = "amountGroupBox";
            this.amountGroupBox.Size = new System.Drawing.Size(610, 166);
            this.amountGroupBox.TabIndex = 4;
            this.amountGroupBox.TabStop = false;
            this.amountGroupBox.Text = "Anzahl Ergebnisse";
            // 
            // resultNumericUpDown
            // 
            this.resultNumericUpDown.Location = new System.Drawing.Point(143, 64);
            this.resultNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.resultNumericUpDown.Name = "resultNumericUpDown";
            this.resultNumericUpDown.Size = new System.Drawing.Size(300, 55);
            this.resultNumericUpDown.TabIndex = 4;
            this.resultNumericUpDown.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // dateGroupBox
            // 
            this.dateGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dateGroupBox.Controls.Add(this.dateTimePicker);
            this.dateGroupBox.Location = new System.Drawing.Point(1588, 628);
            this.dateGroupBox.Name = "dateGroupBox";
            this.dateGroupBox.Size = new System.Drawing.Size(634, 300);
            this.dateGroupBox.TabIndex = 6;
            this.dateGroupBox.TabStop = false;
            this.dateGroupBox.Text = "Datum eingeben";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(15, 117);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(588, 55);
            this.dateTimePicker.TabIndex = 6;
            // 
            // timeGroupBox
            // 
            this.timeGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.timeGroupBox.Controls.Add(this.timeDateTimePicker);
            this.timeGroupBox.Location = new System.Drawing.Point(1588, 308);
            this.timeGroupBox.Name = "timeGroupBox";
            this.timeGroupBox.Size = new System.Drawing.Size(634, 290);
            this.timeGroupBox.TabIndex = 5;
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
            this.timeDateTimePicker.TabIndex = 5;
            // 
            // takeMeHomeGroupBox
            // 
            this.takeMeHomeGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.takeMeHomeGroupBox.Controls.Add(this.takeMeHomeButton);
            this.takeMeHomeGroupBox.Location = new System.Drawing.Point(1588, 60);
            this.takeMeHomeGroupBox.Name = "takeMeHomeGroupBox";
            this.takeMeHomeGroupBox.Size = new System.Drawing.Size(351, 192);
            this.takeMeHomeGroupBox.TabIndex = 3;
            this.takeMeHomeGroupBox.TabStop = false;
            this.takeMeHomeGroupBox.Text = "TakeMeHome";
            // 
            // takeMeHomeButton
            // 
            this.takeMeHomeButton.Location = new System.Drawing.Point(25, 71);
            this.takeMeHomeButton.Name = "takeMeHomeButton";
            this.takeMeHomeButton.Size = new System.Drawing.Size(300, 72);
            this.takeMeHomeButton.TabIndex = 3;
            this.takeMeHomeButton.Text = "TakeMeHome";
            this.takeMeHomeButton.UseVisualStyleBackColor = true;
            this.takeMeHomeButton.Click += new System.EventHandler(this.TakeMeHomeButtonClick);
            // 
            // departureGroupBox
            // 
            this.departureGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.connectionsDataGridView.TabIndex = 10;
            this.connectionsDataGridView.TabStop = false;
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.destinationGroupBox);
            this.searchGroupBox.Controls.Add(this.startGroupBox);
            this.searchGroupBox.Controls.Add(this.searchButton);
            this.searchGroupBox.Location = new System.Drawing.Point(19, 6);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(1500, 246);
            this.searchGroupBox.TabIndex = 1;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Suche";
            // 
            // destinationGroupBox
            // 
            this.destinationGroupBox.Controls.Add(this.destinationComboBox);
            this.destinationGroupBox.Location = new System.Drawing.Point(978, 71);
            this.destinationGroupBox.Name = "destinationGroupBox";
            this.destinationGroupBox.Size = new System.Drawing.Size(500, 125);
            this.destinationGroupBox.TabIndex = 2;
            this.destinationGroupBox.TabStop = false;
            this.destinationGroupBox.Text = "Ziel eingeben";
            // 
            // destinationComboBox
            // 
            this.destinationComboBox.FormattingEnabled = true;
            this.destinationComboBox.Location = new System.Drawing.Point(30, 55);
            this.destinationComboBox.Name = "destinationComboBox";
            this.destinationComboBox.Size = new System.Drawing.Size(400, 56);
            this.destinationComboBox.TabIndex = 2;
            this.destinationComboBox.TextChanged += new System.EventHandler(this.updateComboBox);
            this.destinationComboBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ComboBoxKeyUp);
            // 
            // startGroupBox
            // 
            this.startGroupBox.Controls.Add(this.startComboBox);
            this.startGroupBox.Location = new System.Drawing.Point(6, 71);
            this.startGroupBox.Name = "startGroupBox";
            this.startGroupBox.Size = new System.Drawing.Size(500, 125);
            this.startGroupBox.TabIndex = 1;
            this.startGroupBox.TabStop = false;
            this.startGroupBox.Text = "Start eingeben";
            // 
            // startComboBox
            // 
            this.startComboBox.FormattingEnabled = true;
            this.startComboBox.Location = new System.Drawing.Point(30, 55);
            this.startComboBox.Name = "startComboBox";
            this.startComboBox.Size = new System.Drawing.Size(400, 56);
            this.startComboBox.TabIndex = 1;
            this.startComboBox.TextChanged += new System.EventHandler(this.updateComboBox);
            this.startComboBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ComboBoxKeyUp);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(601, 71);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(300, 72);
            this.searchButton.TabIndex = 10;
            this.searchButton.TabStop = false;
            this.searchButton.Text = "Suchen";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButtonClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.mapGroupBox);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.departureSearchGroupBox);
            this.tabPage2.Location = new System.Drawing.Point(12, 69);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(2249, 1148);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Abfahrtstafel";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // mapGroupBox
            // 
            this.mapGroupBox.Controls.Add(this.mapShowButton);
            this.mapGroupBox.Location = new System.Drawing.Point(1047, 73);
            this.mapGroupBox.Name = "mapGroupBox";
            this.mapGroupBox.Size = new System.Drawing.Size(472, 179);
            this.mapGroupBox.TabIndex = 2;
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
            this.departureBoardDataGridView.TabStop = false;
            // 
            // departureSearchGroupBox
            // 
            this.departureSearchGroupBox.Controls.Add(this.departureEnterGroupBox);
            this.departureSearchGroupBox.Controls.Add(this.departureBoardSearchButton);
            this.departureSearchGroupBox.Location = new System.Drawing.Point(19, 6);
            this.departureSearchGroupBox.Name = "departureSearchGroupBox";
            this.departureSearchGroupBox.Size = new System.Drawing.Size(936, 246);
            this.departureSearchGroupBox.TabIndex = 1;
            this.departureSearchGroupBox.TabStop = false;
            this.departureSearchGroupBox.Text = "Suche";
            // 
            // departureEnterGroupBox
            // 
            this.departureEnterGroupBox.Controls.Add(this.departureBoardComboBox);
            this.departureEnterGroupBox.Location = new System.Drawing.Point(6, 71);
            this.departureEnterGroupBox.Name = "departureEnterGroupBox";
            this.departureEnterGroupBox.Size = new System.Drawing.Size(500, 125);
            this.departureEnterGroupBox.TabIndex = 1;
            this.departureEnterGroupBox.TabStop = false;
            this.departureEnterGroupBox.Text = "Station eingeben";
            // 
            // departureBoardComboBox
            // 
            this.departureBoardComboBox.FormattingEnabled = true;
            this.departureBoardComboBox.Location = new System.Drawing.Point(30, 55);
            this.departureBoardComboBox.Name = "departureBoardComboBox";
            this.departureBoardComboBox.Size = new System.Drawing.Size(400, 56);
            this.departureBoardComboBox.TabIndex = 1;
            this.departureBoardComboBox.TextChanged += new System.EventHandler(this.updateComboBox);
            this.departureBoardComboBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ComboBoxKeyUp);
            // 
            // departureBoardSearchButton
            // 
            this.departureBoardSearchButton.Location = new System.Drawing.Point(601, 71);
            this.departureBoardSearchButton.Name = "departureBoardSearchButton";
            this.departureBoardSearchButton.Size = new System.Drawing.Size(300, 72);
            this.departureBoardSearchButton.TabIndex = 2;
            this.departureBoardSearchButton.TabStop = false;
            this.departureBoardSearchButton.Text = "Suchen";
            this.departureBoardSearchButton.UseVisualStyleBackColor = true;
            this.departureBoardSearchButton.Click += new System.EventHandler(this.DepartureBoardSearchButtonClick);
            // 
            // stationSearchTab
            // 
            this.stationSearchTab.Controls.Add(this.stationSearchGroupBox);
            this.stationSearchTab.Controls.Add(this.groupBox3);
            this.stationSearchTab.Location = new System.Drawing.Point(12, 69);
            this.stationSearchTab.Name = "stationSearchTab";
            this.stationSearchTab.Padding = new System.Windows.Forms.Padding(3);
            this.stationSearchTab.Size = new System.Drawing.Size(2249, 1148);
            this.stationSearchTab.TabIndex = 2;
            this.stationSearchTab.Text = "Stationssuche";
            this.stationSearchTab.UseVisualStyleBackColor = true;
            // 
            // stationSearchGroupBox
            // 
            this.stationSearchGroupBox.Controls.Add(this.stationSearchEnterGroupBox);
            this.stationSearchGroupBox.Controls.Add(this.stationSearchButton);
            this.stationSearchGroupBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.stationSearchGroupBox.Location = new System.Drawing.Point(19, 6);
            this.stationSearchGroupBox.Name = "stationSearchGroupBox";
            this.stationSearchGroupBox.Size = new System.Drawing.Size(936, 246);
            this.stationSearchGroupBox.TabIndex = 1;
            this.stationSearchGroupBox.TabStop = false;
            this.stationSearchGroupBox.Text = "Suche";
            // 
            // stationSearchEnterGroupBox
            // 
            this.stationSearchEnterGroupBox.Controls.Add(this.searchStationComboBox);
            this.stationSearchEnterGroupBox.Location = new System.Drawing.Point(6, 71);
            this.stationSearchEnterGroupBox.Name = "stationSearchEnterGroupBox";
            this.stationSearchEnterGroupBox.Size = new System.Drawing.Size(500, 125);
            this.stationSearchEnterGroupBox.TabIndex = 1;
            this.stationSearchEnterGroupBox.TabStop = false;
            this.stationSearchEnterGroupBox.Text = "Station eingeben";
            // 
            // searchStationComboBox
            // 
            this.searchStationComboBox.FormattingEnabled = true;
            this.searchStationComboBox.Location = new System.Drawing.Point(30, 55);
            this.searchStationComboBox.Name = "searchStationComboBox";
            this.searchStationComboBox.Size = new System.Drawing.Size(400, 56);
            this.searchStationComboBox.TabIndex = 1;
            this.searchStationComboBox.TextChanged += new System.EventHandler(this.updateComboBox);
            // 
            // stationSearchButton
            // 
            this.stationSearchButton.Location = new System.Drawing.Point(601, 71);
            this.stationSearchButton.Name = "stationSearchButton";
            this.stationSearchButton.Size = new System.Drawing.Size(300, 72);
            this.stationSearchButton.TabIndex = 2;
            this.stationSearchButton.TabStop = false;
            this.stationSearchButton.Text = "Suchen";
            this.stationSearchButton.UseVisualStyleBackColor = true;
            this.stationSearchButton.Click += new System.EventHandler(this.stationSearchButtonClick);
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
            this.stationDataGridView.TabStop = false;
            // 
            // SwissTransport
            // 
            this.AcceptButton = this.searchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2285, 1241);
            this.Controls.Add(this.mainTabControl);
            this.MaximumSize = new System.Drawing.Size(2321, 1344);
            this.MinimumSize = new System.Drawing.Size(2321, 1344);
            this.Name = "SwissTransport";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormLoad);
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
            this.destinationGroupBox.ResumeLayout(false);
            this.startGroupBox.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.mapGroupBox.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.departureBoardDataGridView)).EndInit();
            this.departureSearchGroupBox.ResumeLayout(false);
            this.departureEnterGroupBox.ResumeLayout(false);
            this.stationSearchTab.ResumeLayout(false);
            this.stationSearchGroupBox.ResumeLayout(false);
            this.stationSearchEnterGroupBox.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stationDataGridView)).EndInit();
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
        private ComboBox destinationComboBox;
        private ComboBox startComboBox;
        private GroupBox departureSearchGroupBox;
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
        private TabPage stationSearchTab;
        private GroupBox groupBox3;
        private DataGridView stationDataGridView;
        private GroupBox stationSearchGroupBox;
        private ComboBox searchStationComboBox;
        private Button stationSearchButton;
        private GroupBox mapGroupBox;
        private Button mapShowButton;
        private GroupBox destinationGroupBox;
        private GroupBox startGroupBox;
        private GroupBox departureEnterGroupBox;
        private ComboBox departureBoardComboBox;
        private GroupBox stationSearchEnterGroupBox;
    }
}