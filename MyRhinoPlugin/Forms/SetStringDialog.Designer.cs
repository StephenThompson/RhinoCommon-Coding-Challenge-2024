namespace MyRhinoPlugin.Forms
{
    partial class SetStringDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            labelMessage = new System.Windows.Forms.Label();
            textBoxInput = new System.Windows.Forms.TextBox();
            buttonConfirm = new System.Windows.Forms.Button();
            buttonCancel = new System.Windows.Forms.Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.9859161F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.0140839F));
            tableLayoutPanel1.Controls.Add(labelMessage, 0, 0);
            tableLayoutPanel1.Controls.Add(textBoxInput, 1, 0);
            tableLayoutPanel1.Controls.Add(buttonConfirm, 0, 2);
            tableLayoutPanel1.Controls.Add(buttonCancel, 1, 2);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.8571434F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.1428566F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new System.Drawing.Size(355, 89);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // labelMessage
            // 
            labelMessage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            labelMessage.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(labelMessage, 2);
            labelMessage.Location = new System.Drawing.Point(158, 9);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new System.Drawing.Size(38, 15);
            labelMessage.TabIndex = 0;
            labelMessage.Text = "label1";
            // 
            // textBoxInput
            // 
            tableLayoutPanel1.SetColumnSpan(textBoxInput, 2);
            textBoxInput.Dock = System.Windows.Forms.DockStyle.Fill;
            textBoxInput.Location = new System.Drawing.Point(3, 27);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new System.Drawing.Size(349, 23);
            textBoxInput.TabIndex = 1;
            // 
            // buttonConfirm
            // 
            buttonConfirm.Dock = System.Windows.Forms.DockStyle.Right;
            buttonConfirm.Location = new System.Drawing.Point(103, 59);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new System.Drawing.Size(75, 27);
            buttonConfirm.TabIndex = 2;
            buttonConfirm.Text = "Confirm";
            buttonConfirm.UseVisualStyleBackColor = true;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Dock = System.Windows.Forms.DockStyle.Left;
            buttonCancel.Location = new System.Drawing.Point(184, 59);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new System.Drawing.Size(75, 27);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // SetStringDialog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(375, 109);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SetStringDialog";
            Padding = new System.Windows.Forms.Padding(10);
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "MyRhinoPlugin";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonConfirm;
    }
}
