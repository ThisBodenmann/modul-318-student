namespace SwissTransportGUI
{
    partial class EmailForm
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
            this.emailGroupBox = new System.Windows.Forms.GroupBox();
            this.emailTextGroupBox = new System.Windows.Forms.GroupBox();
            this.emailTextRichTextBox = new System.Windows.Forms.RichTextBox();
            this.emailSubjectGroupBox = new System.Windows.Forms.GroupBox();
            this.emailSubjectTextBox = new System.Windows.Forms.TextBox();
            this.emailEnterGroupBox = new System.Windows.Forms.GroupBox();
            this.emailEnterTextBox = new System.Windows.Forms.TextBox();
            this.emailSendButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.emailGroupBox.SuspendLayout();
            this.emailTextGroupBox.SuspendLayout();
            this.emailSubjectGroupBox.SuspendLayout();
            this.emailEnterGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // emailGroupBox
            // 
            this.emailGroupBox.Controls.Add(this.closeButton);
            this.emailGroupBox.Controls.Add(this.emailTextGroupBox);
            this.emailGroupBox.Controls.Add(this.emailSubjectGroupBox);
            this.emailGroupBox.Controls.Add(this.emailEnterGroupBox);
            this.emailGroupBox.Controls.Add(this.emailSendButton);
            this.emailGroupBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.emailGroupBox.Location = new System.Drawing.Point(25, 25);
            this.emailGroupBox.Name = "emailGroupBox";
            this.emailGroupBox.Size = new System.Drawing.Size(2188, 1131);
            this.emailGroupBox.TabIndex = 2;
            this.emailGroupBox.TabStop = false;
            this.emailGroupBox.Text = "Email";
            // 
            // emailTextGroupBox
            // 
            this.emailTextGroupBox.Controls.Add(this.emailTextRichTextBox);
            this.emailTextGroupBox.Location = new System.Drawing.Point(7, 397);
            this.emailTextGroupBox.Name = "emailTextGroupBox";
            this.emailTextGroupBox.Size = new System.Drawing.Size(1729, 639);
            this.emailTextGroupBox.TabIndex = 3;
            this.emailTextGroupBox.TabStop = false;
            this.emailTextGroupBox.Text = "zusätzlichen Text angeben";
            // 
            // emailTextRichTextBox
            // 
            this.emailTextRichTextBox.Location = new System.Drawing.Point(56, 91);
            this.emailTextRichTextBox.Name = "emailTextRichTextBox";
            this.emailTextRichTextBox.Size = new System.Drawing.Size(1626, 512);
            this.emailTextRichTextBox.TabIndex = 3;
            this.emailTextRichTextBox.Text = "";
            // 
            // emailSubjectGroupBox
            // 
            this.emailSubjectGroupBox.Controls.Add(this.emailSubjectTextBox);
            this.emailSubjectGroupBox.Location = new System.Drawing.Point(6, 232);
            this.emailSubjectGroupBox.Name = "emailSubjectGroupBox";
            this.emailSubjectGroupBox.Size = new System.Drawing.Size(500, 125);
            this.emailSubjectGroupBox.TabIndex = 2;
            this.emailSubjectGroupBox.TabStop = false;
            this.emailSubjectGroupBox.Text = "Betreff angeben";
            // 
            // emailSubjectTextBox
            // 
            this.emailSubjectTextBox.Location = new System.Drawing.Point(30, 55);
            this.emailSubjectTextBox.Name = "emailSubjectTextBox";
            this.emailSubjectTextBox.Size = new System.Drawing.Size(400, 55);
            this.emailSubjectTextBox.TabIndex = 2;
            this.emailSubjectTextBox.TextChanged += new System.EventHandler(this.CheckIfEmpty);
            // 
            // emailEnterGroupBox
            // 
            this.emailEnterGroupBox.Controls.Add(this.emailEnterTextBox);
            this.emailEnterGroupBox.Location = new System.Drawing.Point(6, 71);
            this.emailEnterGroupBox.Name = "emailEnterGroupBox";
            this.emailEnterGroupBox.Size = new System.Drawing.Size(500, 125);
            this.emailEnterGroupBox.TabIndex = 1;
            this.emailEnterGroupBox.TabStop = false;
            this.emailEnterGroupBox.Text = "Email eingeben";
            // 
            // emailEnterTextBox
            // 
            this.emailEnterTextBox.Location = new System.Drawing.Point(30, 55);
            this.emailEnterTextBox.Name = "emailEnterTextBox";
            this.emailEnterTextBox.Size = new System.Drawing.Size(400, 55);
            this.emailEnterTextBox.TabIndex = 1;
            this.emailEnterTextBox.TextChanged += new System.EventHandler(this.CheckIfEmpty);
            // 
            // emailSendButton
            // 
            this.emailSendButton.Location = new System.Drawing.Point(601, 71);
            this.emailSendButton.Name = "emailSendButton";
            this.emailSendButton.Size = new System.Drawing.Size(300, 72);
            this.emailSendButton.TabIndex = 2;
            this.emailSendButton.TabStop = false;
            this.emailSendButton.Text = "Senden";
            this.emailSendButton.UseVisualStyleBackColor = true;
            this.emailSendButton.Click += new System.EventHandler(this.EmailSendButtonClick);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(1837, 928);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(300, 72);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Schliessen";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButtonClick);
            // 
            // EmailForm
            // 
            this.AcceptButton = this.emailSendButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeButton;
            this.ClientSize = new System.Drawing.Size(2264, 1197);
            this.Controls.Add(this.emailGroupBox);
            this.MaximumSize = new System.Drawing.Size(2300, 1300);
            this.MinimumSize = new System.Drawing.Size(2300, 1300);
            this.Name = "EmailForm";
            this.Text = "Email";
            this.emailGroupBox.ResumeLayout(false);
            this.emailTextGroupBox.ResumeLayout(false);
            this.emailSubjectGroupBox.ResumeLayout(false);
            this.emailSubjectGroupBox.PerformLayout();
            this.emailEnterGroupBox.ResumeLayout(false);
            this.emailEnterGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox emailGroupBox;
        private GroupBox emailTextGroupBox;
        private RichTextBox emailTextRichTextBox;
        private GroupBox emailSubjectGroupBox;
        private TextBox emailSubjectTextBox;
        private GroupBox emailEnterGroupBox;
        private TextBox emailEnterTextBox;
        private Button emailSendButton;
        private Button closeButton;
    }
}