namespace MyRhinoPlugin
{
    [System.Runtime.InteropServices.Guid("83D6FCC8-4F31-4AE3-BF60-C6528DB232D1")]
    partial class MyRhinoPluginUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.Windows.Forms.GroupBox groupBox4;
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            buttonBlockAdd = new System.Windows.Forms.Button();
            buttonBlockDelete = new System.Windows.Forms.Button();
            buttonBlockRename = new System.Windows.Forms.Button();
            listBoxBlocks = new System.Windows.Forms.ListBox();
            groupBox3 = new System.Windows.Forms.GroupBox();
            textBoxWidth = new System.Windows.Forms.TextBox();
            blockSettingsBindingSource = new System.Windows.Forms.BindingSource(components);
            label1 = new System.Windows.Forms.Label();
            textBoxHeight = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            textBoxSpacing = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            textBoxLength = new System.Windows.Forms.TextBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            buttonAddBlock = new System.Windows.Forms.Button();
            buttonDeleteLast = new System.Windows.Forms.Button();
            ButtonDeleteAll = new System.Windows.Forms.Button();
            buttonRecenterCamera = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            labelStats = new System.Windows.Forms.Label();
            bindingPresenterSource = new System.Windows.Forms.BindingSource(components);
            groupBox4 = new System.Windows.Forms.GroupBox();
            groupBox4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)blockSettingsBindingSource).BeginInit();
            groupBox2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingPresenterSource).BeginInit();
            SuspendLayout();
            // 
            // groupBox4
            // 
            groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            groupBox4.Controls.Add(tableLayoutPanel2);
            groupBox4.Controls.Add(listBoxBlocks);
            groupBox4.Location = new System.Drawing.Point(5, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new System.Drawing.Size(198, 156);
            groupBox4.TabIndex = 19;
            groupBox4.TabStop = false;
            groupBox4.Text = "Blocks";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            tableLayoutPanel2.Controls.Add(buttonBlockAdd, 0, 0);
            tableLayoutPanel2.Controls.Add(buttonBlockDelete, 2, 0);
            tableLayoutPanel2.Controls.Add(buttonBlockRename, 1, 0);
            tableLayoutPanel2.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            tableLayoutPanel2.Location = new System.Drawing.Point(6, 122);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new System.Drawing.Size(186, 28);
            tableLayoutPanel2.TabIndex = 12;
            // 
            // buttonBlockAdd
            // 
            buttonBlockAdd.Location = new System.Drawing.Point(3, 3);
            buttonBlockAdd.Name = "buttonBlockAdd";
            buttonBlockAdd.Size = new System.Drawing.Size(45, 22);
            buttonBlockAdd.TabIndex = 9;
            buttonBlockAdd.Text = "New";
            buttonBlockAdd.UseVisualStyleBackColor = true;
            buttonBlockAdd.Click += buttonBlockAdd_Click;
            // 
            // buttonBlockDelete
            // 
            buttonBlockDelete.Location = new System.Drawing.Point(131, 3);
            buttonBlockDelete.Name = "buttonBlockDelete";
            buttonBlockDelete.Size = new System.Drawing.Size(50, 22);
            buttonBlockDelete.TabIndex = 10;
            buttonBlockDelete.Text = "Delete";
            buttonBlockDelete.UseVisualStyleBackColor = true;
            buttonBlockDelete.Click += buttonBlockDelete_Click;
            // 
            // buttonBlockRename
            // 
            buttonBlockRename.Location = new System.Drawing.Point(54, 3);
            buttonBlockRename.Name = "buttonBlockRename";
            buttonBlockRename.Size = new System.Drawing.Size(71, 22);
            buttonBlockRename.TabIndex = 11;
            buttonBlockRename.Text = "Rename";
            buttonBlockRename.UseVisualStyleBackColor = true;
            buttonBlockRename.Click += buttonBlockRename_Click;
            // 
            // listBoxBlocks
            // 
            listBoxBlocks.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            listBoxBlocks.FormattingEnabled = true;
            listBoxBlocks.ItemHeight = 15;
            listBoxBlocks.Location = new System.Drawing.Point(6, 22);
            listBoxBlocks.Name = "listBoxBlocks";
            listBoxBlocks.Size = new System.Drawing.Size(186, 94);
            listBoxBlocks.TabIndex = 0;
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
            groupBox3.Location = new System.Drawing.Point(5, 409);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(198, 160);
            groupBox3.TabIndex = 19;
            groupBox3.TabStop = false;
            groupBox3.Text = "Values";
            // 
            // textBoxWidth
            // 
            textBoxWidth.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBoxWidth.DataBindings.Add(new System.Windows.Forms.Binding("Text", blockSettingsBindingSource, "Width", true));
            textBoxWidth.Location = new System.Drawing.Point(92, 23);
            textBoxWidth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxWidth.Name = "textBoxWidth";
            textBoxWidth.Size = new System.Drawing.Size(99, 23);
            textBoxWidth.TabIndex = 5;
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
            // textBoxHeight
            // 
            textBoxHeight.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBoxHeight.DataBindings.Add(new System.Windows.Forms.Binding("Text", blockSettingsBindingSource, "Height", true));
            textBoxHeight.Location = new System.Drawing.Point(92, 93);
            textBoxHeight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxHeight.Name = "textBoxHeight";
            textBoxHeight.Size = new System.Drawing.Size(99, 23);
            textBoxHeight.TabIndex = 9;
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
            textBoxSpacing.Size = new System.Drawing.Size(99, 23);
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
            // textBoxLength
            // 
            textBoxLength.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBoxLength.DataBindings.Add(new System.Windows.Forms.Binding("Text", blockSettingsBindingSource, "Length", true));
            textBoxLength.Location = new System.Drawing.Point(92, 57);
            textBoxLength.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxLength.Name = "textBoxLength";
            textBoxLength.Size = new System.Drawing.Size(99, 23);
            textBoxLength.TabIndex = 7;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            groupBox2.Controls.Add(tableLayoutPanel1);
            groupBox2.Location = new System.Drawing.Point(5, 298);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(198, 105);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Commands";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(buttonAddBlock, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonDeleteLast, 1, 0);
            tableLayoutPanel1.Controls.Add(ButtonDeleteAll, 1, 1);
            tableLayoutPanel1.Controls.Add(buttonRecenterCamera, 0, 1);
            tableLayoutPanel1.Location = new System.Drawing.Point(6, 22);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.3076935F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.6923065F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new System.Drawing.Size(185, 78);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // buttonAddBlock
            // 
            buttonAddBlock.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            buttonAddBlock.Location = new System.Drawing.Point(4, 3);
            buttonAddBlock.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonAddBlock.Name = "buttonAddBlock";
            buttonAddBlock.Size = new System.Drawing.Size(84, 27);
            buttonAddBlock.TabIndex = 0;
            buttonAddBlock.Text = "Add";
            buttonAddBlock.UseVisualStyleBackColor = true;
            buttonAddBlock.Click += buttonAddBlock_Click;
            // 
            // buttonDeleteLast
            // 
            buttonDeleteLast.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            buttonDeleteLast.Location = new System.Drawing.Point(96, 3);
            buttonDeleteLast.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonDeleteLast.Name = "buttonDeleteLast";
            buttonDeleteLast.Size = new System.Drawing.Size(85, 27);
            buttonDeleteLast.TabIndex = 1;
            buttonDeleteLast.Text = "Delete Last";
            buttonDeleteLast.UseVisualStyleBackColor = true;
            // 
            // ButtonDeleteAll
            // 
            ButtonDeleteAll.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            ButtonDeleteAll.Location = new System.Drawing.Point(96, 36);
            ButtonDeleteAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ButtonDeleteAll.Name = "ButtonDeleteAll";
            ButtonDeleteAll.Size = new System.Drawing.Size(85, 39);
            ButtonDeleteAll.TabIndex = 2;
            ButtonDeleteAll.Text = "Delete All";
            ButtonDeleteAll.UseVisualStyleBackColor = true;
            // 
            // buttonRecenterCamera
            // 
            buttonRecenterCamera.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            buttonRecenterCamera.Location = new System.Drawing.Point(4, 36);
            buttonRecenterCamera.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonRecenterCamera.Name = "buttonRecenterCamera";
            buttonRecenterCamera.Size = new System.Drawing.Size(84, 39);
            buttonRecenterCamera.TabIndex = 4;
            buttonRecenterCamera.Text = "Recenter Camera";
            buttonRecenterCamera.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            groupBox1.Controls.Add(labelStats);
            groupBox1.Location = new System.Drawing.Point(5, 165);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(198, 127);
            groupBox1.TabIndex = 18;
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
            // MyRhinoPluginUserControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "MyRhinoPluginUserControl";
            Size = new System.Drawing.Size(206, 599);
            groupBox4.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)blockSettingsBindingSource).EndInit();
            groupBox2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingPresenterSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.BindingSource blockSettingsBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSpacing;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxLength;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonAddBlock;
        private System.Windows.Forms.Button buttonDeleteLast;
        private System.Windows.Forms.Button ButtonDeleteAll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelStats;
        private System.Windows.Forms.BindingSource bindingPresenterSource;
        private System.Windows.Forms.Button buttonRecenterCamera;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonBlockDelete;
        private System.Windows.Forms.Button buttonBlockAdd;
        private System.Windows.Forms.ListBox listBoxBlocks;
        private System.Windows.Forms.Button buttonBlockRename;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}
