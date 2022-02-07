
namespace WinForm
{
    partial class Form1
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
            this.machineList = new System.Windows.Forms.DataGridView();
            this.message = new MaterialSkin.Controls.MaterialTextBox();
            this.SyncButton = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.machineList)).BeginInit();
            this.SuspendLayout();
            // 
            // machineList
            // 
            this.machineList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.machineList.Location = new System.Drawing.Point(-7, 160);
            this.machineList.Margin = new System.Windows.Forms.Padding(4);
            this.machineList.Name = "machineList";
            this.machineList.RowHeadersWidth = 51;
            this.machineList.Size = new System.Drawing.Size(1067, 369);
            this.machineList.TabIndex = 6;
            // 
            // message
            // 
            this.message.AnimateReadOnly = false;
            this.message.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.message.Depth = 0;
            this.message.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.message.LeadingIcon = null;
            this.message.Location = new System.Drawing.Point(-7, 103);
            this.message.MaxLength = 50;
            this.message.MouseState = MaterialSkin.MouseState.OUT;
            this.message.Multiline = false;
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(1067, 50);
            this.message.TabIndex = 8;
            this.message.Text = "";
            this.message.TrailingIcon = null;
            // 
            // SyncButton
            // 
            this.SyncButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SyncButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.SyncButton.Depth = 0;
            this.SyncButton.HighEmphasis = true;
            this.SyncButton.Icon = null;
            this.SyncButton.Location = new System.Drawing.Point(514, 25);
            this.SyncButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SyncButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SyncButton.Name = "SyncButton";
            this.SyncButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.SyncButton.Size = new System.Drawing.Size(97, 36);
            this.SyncButton.TabIndex = 9;
            this.SyncButton.Text = "Sync Data";
            this.SyncButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.SyncButton.UseAccentColor = false;
            this.SyncButton.UseVisualStyleBackColor = true;
            this.SyncButton.Click += new System.EventHandler(this.SyncDataClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 535);
            this.Controls.Add(this.SyncButton);
            this.Controls.Add(this.message);
            this.Controls.Add(this.machineList);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(3, 64, 3, 2);
            this.Text = "Rite Attendance";
            ((System.ComponentModel.ISupportInitialize)(this.machineList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView machineList;
        private MaterialSkin.Controls.MaterialTextBox message;
        private MaterialSkin.Controls.MaterialButton SyncButton;
    }
}

