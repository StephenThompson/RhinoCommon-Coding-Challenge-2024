using MyRhinoPlugin.Data;

namespace MyRhinoPlugin
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
            components = new System.ComponentModel.Container();
            buttonAddBlock = new System.Windows.Forms.Button();
            buttonDeleteLast = new System.Windows.Forms.Button();
            ButtonDeleteAll = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            textBoxWidth = new System.Windows.Forms.TextBox();
            blockSettingsBindingSource = new System.Windows.Forms.BindingSource(components);
            textBoxLength = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            textBoxHeight = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            textBoxSpacing = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            labelStats = new System.Windows.Forms.Label();
            bindingPresenterSource = new System.Windows.Forms.BindingSource(components);
            groupBox2 = new System.Windows.Forms.GroupBox();
            buttonRecenterCamera = new System.Windows.Forms.Button();
            groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)blockSettingsBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingPresenterSource).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // buttonAddBlock
            // 
            buttonAddBlock.Location = new System.Drawing.Point(7, 22);
            buttonAddBlock.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonAddBlock.Name = "buttonAddBlock";
            buttonAddBlock.Size = new System.Drawing.Size(88, 27);
            buttonAddBlock.TabIndex = 0;
            buttonAddBlock.Text = "Add";
            buttonAddBlock.UseVisualStyleBackColor = true;
            buttonAddBlock.Click += ButtonAddBlock_Click;
            // 
            // buttonDeleteLast
            // 
            buttonDeleteLast.Location = new System.Drawing.Point(7, 60);
            buttonDeleteLast.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonDeleteLast.Name = "buttonDeleteLast";
            buttonDeleteLast.Size = new System.Drawing.Size(88, 27);
            buttonDeleteLast.TabIndex = 1;
            buttonDeleteLast.Text = "Delete Last";
            buttonDeleteLast.UseVisualStyleBackColor = true;
            buttonDeleteLast.Click += buttonDeleteLast_Click;
            // 
            // ButtonDeleteAll
            // 
            ButtonDeleteAll.Location = new System.Drawing.Point(7, 96);
            ButtonDeleteAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ButtonDeleteAll.Name = "ButtonDeleteAll";
            ButtonDeleteAll.Size = new System.Drawing.Size(88, 27);
            ButtonDeleteAll.TabIndex = 2;
            ButtonDeleteAll.Text = "Delete All";
            ButtonDeleteAll.UseVisualStyleBackColor = true;
            ButtonDeleteAll.Click += ButtonDeleteAll_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(18, 26);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(75, 15);
            label1.TabIndex = 4;
            label1.Text = "Width (mm):";
            // 
            // textBoxWidth
            // 
            textBoxWidth.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBoxWidth.DataBindings.Add(new System.Windows.Forms.Binding("Text", blockSettingsBindingSource, "Width", true));
            textBoxWidth.Location = new System.Drawing.Point(92, 23);
            textBoxWidth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxWidth.Name = "textBoxWidth";
            textBoxWidth.Size = new System.Drawing.Size(114, 23);
            textBoxWidth.TabIndex = 5;
            // 
            // textBoxLength
            // 
            textBoxLength.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBoxLength.DataBindings.Add(new System.Windows.Forms.Binding("Text", blockSettingsBindingSource, "Length", true));
            textBoxLength.Location = new System.Drawing.Point(92, 57);
            textBoxLength.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxLength.Name = "textBoxLength";
            textBoxLength.Size = new System.Drawing.Size(114, 23);
            textBoxLength.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(13, 60);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(80, 15);
            label2.TabIndex = 6;
            label2.Text = "Length (mm):";
            // 
            // textBoxHeight
            // 
            textBoxHeight.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBoxHeight.DataBindings.Add(new System.Windows.Forms.Binding("Text", blockSettingsBindingSource, "Height", true));
            textBoxHeight.Location = new System.Drawing.Point(92, 93);
            textBoxHeight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxHeight.Name = "textBoxHeight";
            textBoxHeight.Size = new System.Drawing.Size(114, 23);
            textBoxHeight.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(14, 96);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(79, 15);
            label3.TabIndex = 8;
            label3.Text = "Height (mm):";
            // 
            // textBoxSpacing
            // 
            textBoxSpacing.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBoxSpacing.DataBindings.Add(new System.Windows.Forms.Binding("Text", blockSettingsBindingSource, "Spacing", true));
            textBoxSpacing.Location = new System.Drawing.Point(92, 126);
            textBoxSpacing.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxSpacing.Name = "textBoxSpacing";
            textBoxSpacing.Size = new System.Drawing.Size(114, 23);
            textBoxSpacing.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(8, 129);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(85, 15);
            label4.TabIndex = 10;
            label4.Text = "Spacing (mm):";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            groupBox1.Controls.Add(labelStats);
            groupBox1.Location = new System.Drawing.Point(339, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(205, 183);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Stats";
            // 
            // labelStats
            // 
            labelStats.AutoSize = true;
            labelStats.DataBindings.Add(new System.Windows.Forms.Binding("Text", bindingPresenterSource, "Stats", true));
            labelStats.Location = new System.Drawing.Point(6, 19);
            labelStats.Name = "labelStats";
            labelStats.Size = new System.Drawing.Size(38, 15);
            labelStats.TabIndex = 0;
            labelStats.Text = "label5";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonRecenterCamera);
            groupBox2.Controls.Add(buttonAddBlock);
            groupBox2.Controls.Add(buttonDeleteLast);
            groupBox2.Controls.Add(ButtonDeleteAll);
            groupBox2.Location = new System.Drawing.Point(9, 9);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(102, 183);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Commands";
            // 
            // buttonRecenterCamera
            // 
            buttonRecenterCamera.Location = new System.Drawing.Point(7, 132);
            buttonRecenterCamera.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonRecenterCamera.Name = "buttonRecenterCamera";
            buttonRecenterCamera.Size = new System.Drawing.Size(88, 39);
            buttonRecenterCamera.TabIndex = 3;
            buttonRecenterCamera.Text = "Recenter Camera";
            buttonRecenterCamera.UseVisualStyleBackColor = true;
            buttonRecenterCamera.Click += buttonRecenterCamera_Click;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            groupBox3.Controls.Add(textBoxWidth);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(textBoxHeight);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(textBoxSpacing);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(textBoxLength);
            groupBox3.Location = new System.Drawing.Point(117, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(216, 180);
            groupBox3.TabIndex = 17;
            groupBox3.TabStop = false;
            groupBox3.Text = "Values";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(552, 197);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "XFrame RhinoCommon-Coding-Challenge-2024";
            ((System.ComponentModel.ISupportInitialize)blockSettingsBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingPresenterSource).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button buttonAddBlock;
        private System.Windows.Forms.Button buttonDeleteLast;
        private System.Windows.Forms.Button ButtonDeleteAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.TextBox textBoxLength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSpacing;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.BindingSource blockSettingsBindingSource;
        private System.Windows.Forms.Label labelStats;
        private System.Windows.Forms.BindingSource bindingPresenterSource;
        private System.Windows.Forms.Button buttonRecenterCamera;
    }
}