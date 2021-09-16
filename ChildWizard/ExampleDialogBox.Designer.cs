
namespace ChildWizard
{
    partial class ExampleDialogBox
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.noButton = new System.Windows.Forms.Button();
            this.mainInstructionLabel = new System.Windows.Forms.Label();
            this.yesButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(354, 112);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(87, 27);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // noButton
            // 
            this.noButton.DialogResult = System.Windows.Forms.DialogResult.No;
            this.noButton.Location = new System.Drawing.Point(261, 112);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(87, 27);
            this.noButton.TabIndex = 1;
            this.noButton.Text = "&No";
            this.noButton.UseVisualStyleBackColor = true;
            this.noButton.Click += new System.EventHandler(this.OnClickNoButton);
            // 
            // mainInstructionLabel
            // 
            this.mainInstructionLabel.Location = new System.Drawing.Point(109, 32);
            this.mainInstructionLabel.Name = "mainInstructionLabel";
            this.mainInstructionLabel.Size = new System.Drawing.Size(332, 49);
            this.mainInstructionLabel.TabIndex = 0;
            this.mainInstructionLabel.Text = "You\'ve requested to generate the project \'$safeprojectname$\'.\r\n\r\nAre you sure you" +
    " want to continue?";
            // 
            // yesButton
            // 
            this.yesButton.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.yesButton.Location = new System.Drawing.Point(168, 112);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(87, 27);
            this.yesButton.TabIndex = 3;
            this.yesButton.Text = "&Yes";
            this.yesButton.UseVisualStyleBackColor = true;
            this.yesButton.Click += new System.EventHandler(this.OnClickYesButton);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ChildWizard.Properties.Resources._230_2304659_computer_icons_warning_sign_windows_10_download_warning;
            this.pictureBox1.Location = new System.Drawing.Point(27, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // ExampleDialogBox
            // 
            this.AcceptButton = this.noButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(458, 156);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.mainInstructionLabel);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.cancelButton);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExampleDialogBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brian Hart Solution";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button noButton;
        private System.Windows.Forms.Label mainInstructionLabel;
        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}