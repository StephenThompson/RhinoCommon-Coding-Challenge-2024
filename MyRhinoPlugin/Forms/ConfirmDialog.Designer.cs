namespace MyRhinoPlugin.Forms
{
    partial class ConfirmDialog
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
            buttonConfirm = new System.Windows.Forms.Button();
            buttonCancel = new System.Windows.Forms.Button();
            labelMessage = new System.Windows.Forms.Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(buttonConfirm, 0, 1);
            tableLayoutPanel1.Controls.Add(buttonCancel, 1, 1);
            tableLayoutPanel1.Controls.Add(labelMessage, 0, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.31783F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.68217F));
            tableLayoutPanel1.Size = new System.Drawing.Size(286, 107);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonConfirm
            // 
            buttonConfirm.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            buttonConfirm.Location = new System.Drawing.Point(65, 79);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new System.Drawing.Size(75, 23);
            buttonConfirm.TabIndex = 0;
            buttonConfirm.Text = "Confirm";
            buttonConfirm.UseVisualStyleBackColor = true;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new System.Drawing.Point(146, 79);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new System.Drawing.Size(75, 23);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // labelMessage
            // 
            labelMessage.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            labelMessage.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(labelMessage, 2);
            labelMessage.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            labelMessage.Location = new System.Drawing.Point(3, 0);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new System.Drawing.Size(280, 76);
            labelMessage.TabIndex = 2;
            labelMessage.Text = "label1";
            labelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConfirmDialog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(306, 127);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ConfirmDialog";
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
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelMessage;
    }
}
