namespace pmxLayerCreater
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
            this.lblInsPoint = new System.Windows.Forms.Label();
            this.lblNoteType = new System.Windows.Forms.Label();
            this.txtInsPoint = new System.Windows.Forms.TextBox();
            this.btnInsPoint = new System.Windows.Forms.Button();
            this.cmbNoteTypes = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Ok_Button = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInsPoint
            // 
            this.lblInsPoint.AutoSize = true;
            this.lblInsPoint.Location = new System.Drawing.Point(12, 9);
            this.lblInsPoint.Name = "lblInsPoint";
            this.lblInsPoint.Size = new System.Drawing.Size(77, 13);
            this.lblInsPoint.TabIndex = 0;
            this.lblInsPoint.Text = "Insertion Point:";
            // 
            // lblNoteType
            // 
            this.lblNoteType.AutoSize = true;
            this.lblNoteType.Location = new System.Drawing.Point(12, 35);
            this.lblNoteType.Name = "lblNoteType";
            this.lblNoteType.Size = new System.Drawing.Size(60, 13);
            this.lblNoteType.TabIndex = 1;
            this.lblNoteType.Text = "Note Type:";
            // 
            // txtInsPoint
            // 
            this.txtInsPoint.Enabled = false;
            this.txtInsPoint.Location = new System.Drawing.Point(115, 6);
            this.txtInsPoint.Name = "txtInsPoint";
            this.txtInsPoint.Size = new System.Drawing.Size(141, 20);
            this.txtInsPoint.TabIndex = 2;
            // 
            // btnInsPoint
            // 
            this.btnInsPoint.Location = new System.Drawing.Point(266, 4);
            this.btnInsPoint.Name = "btnInsPoint";
            this.btnInsPoint.Size = new System.Drawing.Size(75, 23);
            this.btnInsPoint.TabIndex = 5;
            this.btnInsPoint.Text = "Pick";
            this.btnInsPoint.UseVisualStyleBackColor = true;
            this.btnInsPoint.Click += new System.EventHandler(this.btnInsPoint_Click);
            // 
            // cmbNoteTypes
            // 
            this.cmbNoteTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNoteTypes.DropDownWidth = 222;
            this.cmbNoteTypes.FormattingEnabled = true;
            this.cmbNoteTypes.Location = new System.Drawing.Point(115, 32);
            this.cmbNoteTypes.Name = "cmbNoteTypes";
            this.cmbNoteTypes.Size = new System.Drawing.Size(222, 21);
            this.cmbNoteTypes.TabIndex = 4;
            this.cmbNoteTypes.Leave += new System.EventHandler(this.cmbNoteTypes_Leave);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Ok_Button, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(194, 78);
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
            // frmInsNote
            // 
            this.AcceptButton = this.Ok_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel_Button;
            this.ClientSize = new System.Drawing.Size(352, 119);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.cmbNoteTypes);
            this.Controls.Add(this.btnInsPoint);
            this.Controls.Add(this.txtInsPoint);
            this.Controls.Add(this.lblNoteType);
            this.Controls.Add(this.lblInsPoint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInsNote";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insert Note";
            this.Shown += new System.EventHandler(this.frmInsNote_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInsPoint;
        private System.Windows.Forms.Label lblNoteType;
        private System.Windows.Forms.TextBox txtInsPoint;
        private System.Windows.Forms.Button btnInsPoint;
        private System.Windows.Forms.ComboBox cmbNoteTypes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button Ok_Button;
    }
}