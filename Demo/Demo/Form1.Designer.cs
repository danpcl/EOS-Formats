﻿namespace Demo
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lstProperty = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.treeKeys = new System.Windows.Forms.TreeView();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.chkFill = new System.Windows.Forms.CheckBox();
            this.txt_m33 = new System.Windows.Forms.TextBox();
            this.txt_m32 = new System.Windows.Forms.TextBox();
            this.txt_m31 = new System.Windows.Forms.TextBox();
            this.txt_m23 = new System.Windows.Forms.TextBox();
            this.txt_m22 = new System.Windows.Forms.TextBox();
            this.txt_m21 = new System.Windows.Forms.TextBox();
            this.txt_m13 = new System.Windows.Forms.TextBox();
            this.txt_m12 = new System.Windows.Forms.TextBox();
            this.txt_m11 = new System.Windows.Forms.TextBox();
            this.picOutput = new System.Windows.Forms.PictureBox();
            this.sliceLayer = new System.Windows.Forms.TrackBar();
            this.txtSliFileName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labLayerPos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labLayerIndex = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliceLayer)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(829, 372);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lstProperty);
            this.tabPage1.Controls.Add(this.treeKeys);
            this.tabPage1.Controls.Add(this.btnSelectFile);
            this.tabPage1.Controls.Add(this.txtFileName);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnOpen);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(821, 346);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Job File Viewer";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lstProperty
            // 
            this.lstProperty.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstProperty.Location = new System.Drawing.Point(325, 73);
            this.lstProperty.Name = "lstProperty";
            this.lstProperty.Size = new System.Drawing.Size(482, 267);
            this.lstProperty.TabIndex = 11;
            this.lstProperty.UseCompatibleStateImageBehavior = false;
            this.lstProperty.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Value";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Comment";
            this.columnHeader3.Width = 300;
            // 
            // treeKeys
            // 
            this.treeKeys.Location = new System.Drawing.Point(6, 73);
            this.treeKeys.Name = "treeKeys";
            this.treeKeys.Size = new System.Drawing.Size(313, 267);
            this.treeKeys.TabIndex = 10;
            this.treeKeys.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeKeys_AfterSelect);
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(520, 28);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(33, 28);
            this.btnSelectFile.TabIndex = 9;
            this.btnSelectFile.Text = "...";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(18, 33);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(496, 20);
            this.txtFileName.TabIndex = 8;
            this.txtFileName.Text = "D:\\Entwicklung\\VC\\ThermoBoxEmgu\\_test_files_\\ScanV_Micro.Job";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Filename (*.job, *ctr, *.conf)";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(669, 23);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(67, 33);
            this.btnOpen.TabIndex = 6;
            this.btnOpen.Text = "open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labLayerIndex);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.labLayerPos);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.chkFill);
            this.tabPage2.Controls.Add(this.txt_m33);
            this.tabPage2.Controls.Add(this.txt_m32);
            this.tabPage2.Controls.Add(this.txt_m31);
            this.tabPage2.Controls.Add(this.txt_m23);
            this.tabPage2.Controls.Add(this.txt_m22);
            this.tabPage2.Controls.Add(this.txt_m21);
            this.tabPage2.Controls.Add(this.txt_m13);
            this.tabPage2.Controls.Add(this.txt_m12);
            this.tabPage2.Controls.Add(this.txt_m11);
            this.tabPage2.Controls.Add(this.picOutput);
            this.tabPage2.Controls.Add(this.sliceLayer);
            this.tabPage2.Controls.Add(this.txtSliFileName);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(821, 346);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "show slice";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(669, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Transformation matrix";
            // 
            // chkFill
            // 
            this.chkFill.AutoSize = true;
            this.chkFill.Location = new System.Drawing.Point(672, 154);
            this.chkFill.Name = "chkFill";
            this.chkFill.Size = new System.Drawing.Size(59, 17);
            this.chkFill.TabIndex = 20;
            this.chkFill.Text = "fill slice";
            this.chkFill.UseVisualStyleBackColor = true;
            // 
            // txt_m33
            // 
            this.txt_m33.BackColor = System.Drawing.SystemColors.Control;
            this.txt_m33.Enabled = false;
            this.txt_m33.Location = new System.Drawing.Point(759, 117);
            this.txt_m33.Name = "txt_m33";
            this.txt_m33.Size = new System.Drawing.Size(32, 20);
            this.txt_m33.TabIndex = 19;
            this.txt_m33.Text = "1";
            // 
            // txt_m32
            // 
            this.txt_m32.BackColor = System.Drawing.SystemColors.Control;
            this.txt_m32.Enabled = false;
            this.txt_m32.Location = new System.Drawing.Point(721, 117);
            this.txt_m32.Name = "txt_m32";
            this.txt_m32.Size = new System.Drawing.Size(32, 20);
            this.txt_m32.TabIndex = 18;
            this.txt_m32.Tag = "";
            this.txt_m32.Text = "0";
            // 
            // txt_m31
            // 
            this.txt_m31.BackColor = System.Drawing.SystemColors.Control;
            this.txt_m31.Enabled = false;
            this.txt_m31.Location = new System.Drawing.Point(683, 117);
            this.txt_m31.Name = "txt_m31";
            this.txt_m31.Size = new System.Drawing.Size(32, 20);
            this.txt_m31.TabIndex = 17;
            this.txt_m31.Tag = "";
            this.txt_m31.Text = "0";
            // 
            // txt_m23
            // 
            this.txt_m23.Location = new System.Drawing.Point(759, 91);
            this.txt_m23.Name = "txt_m23";
            this.txt_m23.Size = new System.Drawing.Size(32, 20);
            this.txt_m23.TabIndex = 16;
            this.txt_m23.Text = "0";
            // 
            // txt_m22
            // 
            this.txt_m22.Location = new System.Drawing.Point(721, 91);
            this.txt_m22.Name = "txt_m22";
            this.txt_m22.Size = new System.Drawing.Size(32, 20);
            this.txt_m22.TabIndex = 15;
            this.txt_m22.Text = "1";
            // 
            // txt_m21
            // 
            this.txt_m21.Location = new System.Drawing.Point(683, 91);
            this.txt_m21.Name = "txt_m21";
            this.txt_m21.Size = new System.Drawing.Size(32, 20);
            this.txt_m21.TabIndex = 14;
            this.txt_m21.Text = "0";
            // 
            // txt_m13
            // 
            this.txt_m13.Location = new System.Drawing.Point(759, 65);
            this.txt_m13.Name = "txt_m13";
            this.txt_m13.Size = new System.Drawing.Size(32, 20);
            this.txt_m13.TabIndex = 13;
            this.txt_m13.Text = "0";
            // 
            // txt_m12
            // 
            this.txt_m12.Location = new System.Drawing.Point(721, 65);
            this.txt_m12.Name = "txt_m12";
            this.txt_m12.Size = new System.Drawing.Size(32, 20);
            this.txt_m12.TabIndex = 12;
            this.txt_m12.Text = "0";
            // 
            // txt_m11
            // 
            this.txt_m11.Location = new System.Drawing.Point(683, 65);
            this.txt_m11.Name = "txt_m11";
            this.txt_m11.Size = new System.Drawing.Size(32, 20);
            this.txt_m11.TabIndex = 11;
            this.txt_m11.Text = "1";
            // 
            // picOutput
            // 
            this.picOutput.Location = new System.Drawing.Point(6, 42);
            this.picOutput.Name = "picOutput";
            this.picOutput.Size = new System.Drawing.Size(651, 286);
            this.picOutput.TabIndex = 0;
            this.picOutput.TabStop = false;
            this.picOutput.Click += new System.EventHandler(this.picOutput_Click);
            this.picOutput.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picOutput_MouseDown);
            this.picOutput.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picOutput_MouseMove);
            // 
            // sliceLayer
            // 
            this.sliceLayer.Location = new System.Drawing.Point(560, 15);
            this.sliceLayer.Name = "sliceLayer";
            this.sliceLayer.Size = new System.Drawing.Size(217, 42);
            this.sliceLayer.TabIndex = 10;
            this.sliceLayer.TickStyle = System.Windows.Forms.TickStyle.None;
            this.sliceLayer.Scroll += new System.EventHandler(this.sliceLayer_Scroll);
            // 
            // txtSliFileName
            // 
            this.txtSliFileName.Location = new System.Drawing.Point(6, 12);
            this.txtSliFileName.Name = "txtSliFileName";
            this.txtSliFileName.Size = new System.Drawing.Size(464, 20);
            this.txtSliFileName.TabIndex = 9;
            this.txtSliFileName.Text = "D:\\Entwicklung\\VC\\ThermoBoxEmgu\\_test_files_\\V11_1997_SLM_skaliert.sli";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(476, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labLayerPos
            // 
            this.labLayerPos.AutoSize = true;
            this.labLayerPos.Location = new System.Drawing.Point(741, 3);
            this.labLayerPos.Name = "labLayerPos";
            this.labLayerPos.Size = new System.Drawing.Size(23, 13);
            this.labLayerPos.TabIndex = 22;
            this.labLayerPos.Text = "mm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(647, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Layer:";
            // 
            // labLayerIndex
            // 
            this.labLayerIndex.AutoSize = true;
            this.labLayerIndex.Location = new System.Drawing.Point(680, 3);
            this.labLayerIndex.Name = "labLayerIndex";
            this.labLayerIndex.Size = new System.Drawing.Size(13, 13);
            this.labLayerIndex.TabIndex = 24;
            this.labLayerIndex.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 400);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Demo: EOS - File Formats";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliceLayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView lstProperty;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TreeView treeKeys;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picOutput;
        private System.Windows.Forms.TextBox txtSliFileName;
        private System.Windows.Forms.TrackBar sliceLayer;
        private System.Windows.Forms.TextBox txt_m33;
        private System.Windows.Forms.TextBox txt_m32;
        private System.Windows.Forms.TextBox txt_m31;
        private System.Windows.Forms.TextBox txt_m23;
        private System.Windows.Forms.TextBox txt_m22;
        private System.Windows.Forms.TextBox txt_m21;
        private System.Windows.Forms.TextBox txt_m13;
        private System.Windows.Forms.TextBox txt_m12;
        private System.Windows.Forms.TextBox txt_m11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkFill;
        private System.Windows.Forms.Label labLayerPos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labLayerIndex;

    }
}

