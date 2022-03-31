namespace devStandardsManager
{
    partial class frmInsNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInsNote));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Ok_Button = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTextStyles = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picTab1Preview = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.boxTab0Groups = new System.Windows.Forms.ListBox();
            this.lblTab1Lbl1 = new System.Windows.Forms.Label();
            this.tabDimStyles = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.boxTab1Groups = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabLeaderStyles = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.boxTab2Groups = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabLinetypes = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.boxTab3Groups = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabTextStyles.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTab1Preview)).BeginInit();
            this.tabDimStyles.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabLeaderStyles.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabLinetypes.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Ok_Button, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(306, 359);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(146, 29);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Location = new System.Drawing.Point(76, 3);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(67, 23);
            this.Cancel_Button.TabIndex = 1;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // Ok_Button
            // 
            this.Ok_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Ok_Button.Location = new System.Drawing.Point(3, 3);
            this.Ok_Button.Name = "Ok_Button";
            this.Ok_Button.Size = new System.Drawing.Size(67, 23);
            this.Ok_Button.TabIndex = 0;
            this.Ok_Button.Text = "Ok";
            this.Ok_Button.UseVisualStyleBackColor = true;
            this.Ok_Button.Click += new System.EventHandler(this.Ok_Button_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabTextStyles);
            this.tabControl1.Controls.Add(this.tabDimStyles);
            this.tabControl1.Controls.Add(this.tabLeaderStyles);
            this.tabControl1.Controls.Add(this.tabLinetypes);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 1;
            this.tabControl1.Size = new System.Drawing.Size(460, 340);
            this.tabControl1.TabIndex = 7;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabTextStyles
            // 
            this.tabTextStyles.BackColor = System.Drawing.SystemColors.Control;
            this.tabTextStyles.Controls.Add(this.panel1);
            this.tabTextStyles.Controls.Add(this.checkBox1);
            this.tabTextStyles.Controls.Add(this.boxTab0Groups);
            this.tabTextStyles.Controls.Add(this.lblTab1Lbl1);
            this.tabTextStyles.Location = new System.Drawing.Point(4, 22);
            this.tabTextStyles.Name = "tabTextStyles";
            this.tabTextStyles.Padding = new System.Windows.Forms.Padding(3);
            this.tabTextStyles.Size = new System.Drawing.Size(452, 314);
            this.tabTextStyles.TabIndex = 0;
            this.tabTextStyles.Text = "Text Styes";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.picTab1Preview);
            this.panel1.Location = new System.Drawing.Point(142, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 306);
            this.panel1.TabIndex = 3;
            // 
            // picTab1Preview
            // 
            this.picTab1Preview.Image = ((System.Drawing.Image)(resources.GetObject("picTab1Preview.Image")));
            this.picTab1Preview.Location = new System.Drawing.Point(0, 0);
            this.picTab1Preview.Margin = new System.Windows.Forms.Padding(0);
            this.picTab1Preview.Name = "picTab1Preview";
            this.picTab1Preview.Size = new System.Drawing.Size(300, 300);
            this.picTab1Preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picTab1Preview.TabIndex = 0;
            this.picTab1Preview.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(14, 286);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(110, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Overwrite Existing";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // boxTab0Groups
            // 
            this.boxTab0Groups.FormattingEnabled = true;
            this.boxTab0Groups.Location = new System.Drawing.Point(14, 26);
            this.boxTab0Groups.Name = "boxTab0Groups";
            this.boxTab0Groups.Size = new System.Drawing.Size(120, 251);
            this.boxTab0Groups.TabIndex = 1;
            // 
            // lblTab1Lbl1
            // 
            this.lblTab1Lbl1.AutoSize = true;
            this.lblTab1Lbl1.Location = new System.Drawing.Point(13, 10);
            this.lblTab1Lbl1.Name = "lblTab1Lbl1";
            this.lblTab1Lbl1.Size = new System.Drawing.Size(87, 13);
            this.lblTab1Lbl1.TabIndex = 0;
            this.lblTab1Lbl1.Text = "Select Text Style";
            // 
            // tabDimStyles
            // 
            this.tabDimStyles.BackColor = System.Drawing.SystemColors.Control;
            this.tabDimStyles.Controls.Add(this.panel2);
            this.tabDimStyles.Controls.Add(this.checkBox2);
            this.tabDimStyles.Controls.Add(this.boxTab1Groups);
            this.tabDimStyles.Controls.Add(this.label1);
            this.tabDimStyles.Location = new System.Drawing.Point(4, 22);
            this.tabDimStyles.Name = "tabDimStyles";
            this.tabDimStyles.Padding = new System.Windows.Forms.Padding(3);
            this.tabDimStyles.Size = new System.Drawing.Size(452, 314);
            this.tabDimStyles.TabIndex = 1;
            this.tabDimStyles.Text = "Dim Styles";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(145, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(297, 302);
            this.panel2.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(11, 286);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(110, 17);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "Overwrite Existing";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // boxTab1Groups
            // 
            this.boxTab1Groups.FormattingEnabled = true;
            this.boxTab1Groups.Location = new System.Drawing.Point(11, 26);
            this.boxTab1Groups.Name = "boxTab1Groups";
            this.boxTab1Groups.Size = new System.Drawing.Size(120, 251);
            this.boxTab1Groups.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select Dim Style Group";
            // 
            // tabLeaderStyles
            // 
            this.tabLeaderStyles.BackColor = System.Drawing.SystemColors.Control;
            this.tabLeaderStyles.Controls.Add(this.panel3);
            this.tabLeaderStyles.Controls.Add(this.checkBox3);
            this.tabLeaderStyles.Controls.Add(this.boxTab2Groups);
            this.tabLeaderStyles.Controls.Add(this.label2);
            this.tabLeaderStyles.Location = new System.Drawing.Point(4, 22);
            this.tabLeaderStyles.Name = "tabLeaderStyles";
            this.tabLeaderStyles.Size = new System.Drawing.Size(452, 314);
            this.tabLeaderStyles.TabIndex = 2;
            this.tabLeaderStyles.Text = "Leader Styles";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Location = new System.Drawing.Point(145, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(297, 302);
            this.panel3.TabIndex = 7;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 100);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(11, 286);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(110, 17);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "Overwrite Existing";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // boxTab2Groups
            // 
            this.boxTab2Groups.FormattingEnabled = true;
            this.boxTab2Groups.Location = new System.Drawing.Point(11, 26);
            this.boxTab2Groups.Name = "boxTab2Groups";
            this.boxTab2Groups.Size = new System.Drawing.Size(120, 251);
            this.boxTab2Groups.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select Leader Style Group";
            // 
            // tabLinetypes
            // 
            this.tabLinetypes.BackColor = System.Drawing.SystemColors.Control;
            this.tabLinetypes.Controls.Add(this.panel4);
            this.tabLinetypes.Controls.Add(this.checkBox4);
            this.tabLinetypes.Controls.Add(this.boxTab3Groups);
            this.tabLinetypes.Controls.Add(this.label3);
            this.tabLinetypes.Location = new System.Drawing.Point(4, 22);
            this.tabLinetypes.Name = "tabLinetypes";
            this.tabLinetypes.Size = new System.Drawing.Size(452, 314);
            this.tabLinetypes.TabIndex = 3;
            this.tabLinetypes.Text = "Linetypes";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Location = new System.Drawing.Point(145, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(297, 302);
            this.panel4.TabIndex = 7;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 100);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Location = new System.Drawing.Point(11, 286);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(110, 17);
            this.checkBox4.TabIndex = 6;
            this.checkBox4.Text = "Overwrite Existing";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // boxTab3Groups
            // 
            this.boxTab3Groups.FormattingEnabled = true;
            this.boxTab3Groups.Location = new System.Drawing.Point(11, 26);
            this.boxTab3Groups.Name = "boxTab3Groups";
            this.boxTab3Groups.Size = new System.Drawing.Size(120, 251);
            this.boxTab3Groups.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Select Linetype Group";
            // 
            // frmInsNote
            // 
            this.AcceptButton = this.Ok_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel_Button;
            this.ClientSize = new System.Drawing.Size(464, 400);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInsNote";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PMX Standards Manager";
            this.Shown += new System.EventHandler(this.frmInsNote_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabTextStyles.ResumeLayout(false);
            this.tabTextStyles.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTab1Preview)).EndInit();
            this.tabDimStyles.ResumeLayout(false);
            this.tabDimStyles.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabLeaderStyles.ResumeLayout(false);
            this.tabLeaderStyles.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabLinetypes.ResumeLayout(false);
            this.tabLinetypes.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button Ok_Button;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabTextStyles;
        private System.Windows.Forms.Label lblTab1Lbl1;
        private System.Windows.Forms.TabPage tabDimStyles;
        private System.Windows.Forms.TabPage tabLeaderStyles;
        private System.Windows.Forms.TabPage tabLinetypes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picTab1Preview;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ListBox boxTab0Groups;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ListBox boxTab1Groups;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.ListBox boxTab2Groups;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.ListBox boxTab3Groups;
        private System.Windows.Forms.Label label3;
    }
}