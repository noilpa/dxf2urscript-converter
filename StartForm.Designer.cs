namespace Dxf2UrScript
{
    partial class StartForm
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
            this.InputFilePathText = new System.Windows.Forms.TextBox();
            this.OutputFilePathText = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.InputPathLabel = new System.Windows.Forms.Label();
            this.OutputPathLabel = new System.Windows.Forms.Label();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputFilePathText
            // 
            this.InputFilePathText.AllowDrop = true;
            this.InputFilePathText.Location = new System.Drawing.Point(106, 52);
            this.InputFilePathText.Name = "InputFilePathText";
            this.InputFilePathText.Size = new System.Drawing.Size(166, 20);
            this.InputFilePathText.TabIndex = 0;
            // 
            // OutputFilePathText
            // 
            this.OutputFilePathText.AllowDrop = true;
            this.OutputFilePathText.Location = new System.Drawing.Point(106, 89);
            this.OutputFilePathText.Name = "OutputFilePathText";
            this.OutputFilePathText.Size = new System.Drawing.Size(166, 20);
            this.OutputFilePathText.TabIndex = 1;
            // 
            // convertButton
            // 
            this.convertButton.Font = new System.Drawing.Font("Meiryo UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.convertButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.convertButton.Location = new System.Drawing.Point(106, 143);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 23);
            this.convertButton.TabIndex = 3;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // InputPathLabel
            // 
            this.InputPathLabel.AutoSize = true;
            this.InputPathLabel.Location = new System.Drawing.Point(21, 55);
            this.InputPathLabel.Name = "InputPathLabel";
            this.InputPathLabel.Size = new System.Drawing.Size(75, 13);
            this.InputPathLabel.TabIndex = 4;
            this.InputPathLabel.Text = "Input File Path";
            this.InputPathLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // OutputPathLabel
            // 
            this.OutputPathLabel.AutoSize = true;
            this.OutputPathLabel.Location = new System.Drawing.Point(13, 92);
            this.OutputPathLabel.Name = "OutputPathLabel";
            this.OutputPathLabel.Size = new System.Drawing.Size(83, 13);
            this.OutputPathLabel.TabIndex = 5;
            this.OutputPathLabel.Text = "Output File Path";
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MessageLabel.Location = new System.Drawing.Point(79, 18);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(112, 20);
            this.MessageLabel.TabIndex = 6;
            this.MessageLabel.Text = "Fill text boxes";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(284, 204);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.OutputPathLabel);
            this.Controls.Add(this.InputPathLabel);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.OutputFilePathText);
            this.Controls.Add(this.InputFilePathText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartForm";
            this.Text = "DXF_2_URScript";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputFilePathText;
        private System.Windows.Forms.TextBox OutputFilePathText;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Label InputPathLabel;
        private System.Windows.Forms.Label OutputPathLabel;
        private System.Windows.Forms.Label MessageLabel;
    }
}