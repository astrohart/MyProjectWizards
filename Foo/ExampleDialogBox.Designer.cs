
namespace Foo
{
    partial class ExampleDialogBox
    {
///  <summary> Required designer variable. </summary>
        private System.ComponentModel.IContainer components = null;

///  <summary> Clean up any resources being used. </summary> <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

///  <summary> Required method for Designer support - do not modify the contents of this method with the code editor. </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cancelButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.mainInstructionLabel = new System.Windows.Forms.Label();
            this.createDataAccessLayerCheckBox = new System.Windows.Forms.CheckBox();
            this.configurationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.createUserInterfaceLayerCheckBox = new System.Windows.Forms.CheckBox();
            this.selectAllLinkLabel = new System.Windows.Forms.LinkLabel();
            this.selectNoneLinkLabel = new System.Windows.Forms.LinkLabel();
            this.dividerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.configurationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(352, 173);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(87, 27);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // createButton
            // 
            this.createButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.createButton.Location = new System.Drawing.Point(259, 173);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(87, 27);
            this.createButton.TabIndex = 1;
            this.createButton.Text = "&Create";
            this.createButton.UseVisualStyleBackColor = true;
            // 
            // mainInstructionLabel
            // 
            this.mainInstructionLabel.Location = new System.Drawing.Point(12, 9);
            this.mainInstructionLabel.Name = "mainInstructionLabel";
            this.mainInstructionLabel.Size = new System.Drawing.Size(427, 63);
            this.mainInstructionLabel.TabIndex = 0;
            this.mainInstructionLabel.Text = "Select the checkboxes to confirm which project(s) in this solution you\'d like to " +
    "create.\r\n\r\nTo confirm the generation action, click Create.";
            // 
            // createDataAccessLayerCheckBox
            // 
            this.createDataAccessLayerCheckBox.AutoSize = true;
            this.createDataAccessLayerCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.configurationBindingSource, "CreateDataAccessLayer", true));
            this.createDataAccessLayerCheckBox.Location = new System.Drawing.Point(60, 88);
            this.createDataAccessLayerCheckBox.Name = "createDataAccessLayerCheckBox";
            this.createDataAccessLayerCheckBox.Size = new System.Drawing.Size(120, 19);
            this.createDataAccessLayerCheckBox.TabIndex = 3;
            this.createDataAccessLayerCheckBox.Text = "&Data Access Layer";
            this.createDataAccessLayerCheckBox.UseVisualStyleBackColor = true;
            this.createDataAccessLayerCheckBox.CheckedChanged += new System.EventHandler(this.OnCheckedChanged);
            // 
            // configurationBindingSource
            // 
            this.configurationBindingSource.DataSource = typeof(Core.Config.Configuration);
            // 
            // createUserInterfaceLayerCheckBox
            // 
            this.createUserInterfaceLayerCheckBox.AutoSize = true;
            this.createUserInterfaceLayerCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.configurationBindingSource, "CreateUserInterfaceLayer", true));
            this.createUserInterfaceLayerCheckBox.Location = new System.Drawing.Point(60, 114);
            this.createUserInterfaceLayerCheckBox.Name = "createUserInterfaceLayerCheckBox";
            this.createUserInterfaceLayerCheckBox.Size = new System.Drawing.Size(129, 19);
            this.createUserInterfaceLayerCheckBox.TabIndex = 4;
            this.createUserInterfaceLayerCheckBox.Text = "&User Interface Layer";
            this.createUserInterfaceLayerCheckBox.UseVisualStyleBackColor = true;
            this.createUserInterfaceLayerCheckBox.CheckedChanged += new System.EventHandler(this.OnCheckedChanged);
            // 
            // selectAllLinkLabel
            // 
            this.selectAllLinkLabel.AutoSize = true;
            this.selectAllLinkLabel.Location = new System.Drawing.Point(13, 150);
            this.selectAllLinkLabel.Name = "selectAllLinkLabel";
            this.selectAllLinkLabel.Size = new System.Drawing.Size(55, 15);
            this.selectAllLinkLabel.TabIndex = 5;
            this.selectAllLinkLabel.TabStop = true;
            this.selectAllLinkLabel.Text = "Select All";
            this.selectAllLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnLinkClickedSelectAllLabel);
            // 
            // selectNoneLinkLabel
            // 
            this.selectNoneLinkLabel.AutoSize = true;
            this.selectNoneLinkLabel.Location = new System.Drawing.Point(91, 150);
            this.selectNoneLinkLabel.Name = "selectNoneLinkLabel";
            this.selectNoneLinkLabel.Size = new System.Drawing.Size(70, 15);
            this.selectNoneLinkLabel.TabIndex = 6;
            this.selectNoneLinkLabel.TabStop = true;
            this.selectNoneLinkLabel.Text = "Select None";
            this.selectNoneLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnLinkClickedSelectNoneLabel);
            // 
            // dividerLabel
            // 
            this.dividerLabel.AutoSize = true;
            this.dividerLabel.Location = new System.Drawing.Point(75, 150);
            this.dividerLabel.Name = "dividerLabel";
            this.dividerLabel.Size = new System.Drawing.Size(10, 15);
            this.dividerLabel.TabIndex = 7;
            this.dividerLabel.Text = "|";
            // 
            // ExampleDialogBox
            // 
            this.AcceptButton = this.createButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(453, 214);
            this.Controls.Add(this.dividerLabel);
            this.Controls.Add(this.selectNoneLinkLabel);
            this.Controls.Add(this.selectAllLinkLabel);
            this.Controls.Add(this.createUserInterfaceLayerCheckBox);
            this.Controls.Add(this.createDataAccessLayerCheckBox);
            this.Controls.Add(this.mainInstructionLabel);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.cancelButton);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExampleDialogBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brian Hart Solution Template";
            ((System.ComponentModel.ISupportInitialize)(this.configurationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label mainInstructionLabel;
        private System.Windows.Forms.CheckBox createDataAccessLayerCheckBox;
        private System.Windows.Forms.CheckBox createUserInterfaceLayerCheckBox;
        private System.Windows.Forms.BindingSource configurationBindingSource;
        private System.Windows.Forms.LinkLabel selectAllLinkLabel;
        private System.Windows.Forms.LinkLabel selectNoneLinkLabel;
        private System.Windows.Forms.Label dividerLabel;
    }
}
