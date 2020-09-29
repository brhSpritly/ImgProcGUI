namespace imgProc {
   partial class fMain {
      /// <summary>
      /// Erforderliche Designervariable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Verwendete Ressourcen bereinigen.
      /// </summary>
      /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
      protected override void Dispose(bool disposing) {
         if (disposing && (components != null)) {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Vom Windows Form-Designer generierter Code

      /// <summary>
      /// Erforderliche Methode für die Designerunterstützung.
      /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
      /// </summary>
      private void InitializeComponent() {
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.groupBox8 = new System.Windows.Forms.GroupBox();
         this.groupBox7 = new System.Windows.Forms.GroupBox();
         this.tbBinThresh = new System.Windows.Forms.TrackBar();
         this.cbBinInImg = new System.Windows.Forms.CheckBox();
         this.groupBox6 = new System.Windows.Forms.GroupBox();
         this.btOpening = new System.Windows.Forms.Button();
         this.btClosing = new System.Windows.Forms.Button();
         this.btDila = new System.Windows.Forms.Button();
         this.btErosion = new System.Windows.Forms.Button();
         this.groupBox5 = new System.Windows.Forms.GroupBox();
         this.cbSmoothFilter = new System.Windows.Forms.ComboBox();
         this.label1 = new System.Windows.Forms.Label();
         this.cbMaskSize = new System.Windows.Forms.ComboBox();
         this.btCalcSmoothFilter = new System.Windows.Forms.Button();
         this.groupBox4 = new System.Windows.Forms.GroupBox();
         this.cbEdgeFilter = new System.Windows.Forms.ComboBox();
         this.btCalcEdgeFilter = new System.Windows.Forms.Button();
         this.loadImgDialog = new System.Windows.Forms.OpenFileDialog();
         this.groupBox2 = new System.Windows.Forms.GroupBox();
         this.picBoxResImg = new System.Windows.Forms.PictureBox();
         this.groupBox3 = new System.Windows.Forms.GroupBox();
         this.picBoxInImg = new System.Windows.Forms.PictureBox();
         this.btClose = new System.Windows.Forms.Button();
         this.menu = new System.Windows.Forms.MenuStrip();
         this.mnFile = new System.Windows.Forms.ToolStripMenuItem();
         this.File_LoadImg = new System.Windows.Forms.ToolStripMenuItem();
         this.File_SaveResImg = new System.Windows.Forms.ToolStripMenuItem();
         this.File_Close = new System.Windows.Forms.ToolStripMenuItem();
         this.mnEdit = new System.Windows.Forms.ToolStripMenuItem();
         this.mnInfo = new System.Windows.Forms.ToolStripMenuItem();
         this.saveImgDialog = new System.Windows.Forms.SaveFileDialog();
         this.statusBar = new System.Windows.Forms.StatusStrip();
         this.statusBarLabel = new System.Windows.Forms.ToolStripStatusLabel();
         this.btLoadImg = new System.Windows.Forms.Button();
         this.groupBox1.SuspendLayout();
         this.groupBox8.SuspendLayout();
         this.groupBox7.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.tbBinThresh)).BeginInit();
         this.groupBox6.SuspendLayout();
         this.groupBox5.SuspendLayout();
         this.groupBox4.SuspendLayout();
         this.groupBox2.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.picBoxResImg)).BeginInit();
         this.groupBox3.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.picBoxInImg)).BeginInit();
         this.menu.SuspendLayout();
         this.statusBar.SuspendLayout();
         this.SuspendLayout();
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.groupBox8);
         this.groupBox1.Controls.Add(this.groupBox6);
         this.groupBox1.Controls.Add(this.groupBox5);
         this.groupBox1.Controls.Add(this.groupBox4);
         this.groupBox1.Location = new System.Drawing.Point(2, 450);
         this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
         this.groupBox1.Size = new System.Drawing.Size(1008, 216);
         this.groupBox1.TabIndex = 0;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Filter";
         // 
         // groupBox8
         // 
         this.groupBox8.Controls.Add(this.groupBox7);
         this.groupBox8.Controls.Add(this.cbBinInImg);
         this.groupBox8.Location = new System.Drawing.Point(758, 25);
         this.groupBox8.Name = "groupBox8";
         this.groupBox8.Size = new System.Drawing.Size(240, 185);
         this.groupBox8.TabIndex = 3;
         this.groupBox8.TabStop = false;
         this.groupBox8.Text = "Binarisierung";
         // 
         // groupBox7
         // 
         this.groupBox7.Controls.Add(this.tbBinThresh);
         this.groupBox7.Location = new System.Drawing.Point(21, 76);
         this.groupBox7.Name = "groupBox7";
         this.groupBox7.Size = new System.Drawing.Size(200, 92);
         this.groupBox7.TabIndex = 15;
         this.groupBox7.TabStop = false;
         this.groupBox7.Text = "Schwellwert";
         // 
         // tbBinThresh
         // 
         this.tbBinThresh.AutoSize = false;
         this.tbBinThresh.Location = new System.Drawing.Point(9, 26);
         this.tbBinThresh.Maximum = 255;
         this.tbBinThresh.Name = "tbBinThresh";
         this.tbBinThresh.Size = new System.Drawing.Size(177, 62);
         this.tbBinThresh.TabIndex = 11;
         this.tbBinThresh.TickFrequency = 10;
         this.tbBinThresh.Value = 50;
         this.tbBinThresh.Scroll += new System.EventHandler(this.tbBinThresh_Scroll);
         // 
         // cbBinInImg
         // 
         this.cbBinInImg.AutoSize = true;
         this.cbBinInImg.Location = new System.Drawing.Point(21, 36);
         this.cbBinInImg.Name = "cbBinInImg";
         this.cbBinInImg.Size = new System.Drawing.Size(218, 24);
         this.cbBinInImg.TabIndex = 14;
         this.cbBinInImg.Text = "Eingangsbild binarisieren";
         this.cbBinInImg.UseVisualStyleBackColor = true;
         this.cbBinInImg.Click += new System.EventHandler(this.cbBinInImg_CheckedChanged);
         // 
         // groupBox6
         // 
         this.groupBox6.Controls.Add(this.btOpening);
         this.groupBox6.Controls.Add(this.btClosing);
         this.groupBox6.Controls.Add(this.btDila);
         this.groupBox6.Controls.Add(this.btErosion);
         this.groupBox6.Location = new System.Drawing.Point(434, 25);
         this.groupBox6.Name = "groupBox6";
         this.groupBox6.Size = new System.Drawing.Size(311, 185);
         this.groupBox6.TabIndex = 2;
         this.groupBox6.TabStop = false;
         this.groupBox6.Text = "Morphologische Filter";
         // 
         // btOpening
         // 
         this.btOpening.Location = new System.Drawing.Point(177, 113);
         this.btOpening.Margin = new System.Windows.Forms.Padding(4);
         this.btOpening.Name = "btOpening";
         this.btOpening.Size = new System.Drawing.Size(112, 32);
         this.btOpening.TabIndex = 9;
         this.btOpening.Text = "Opening";
         this.btOpening.UseVisualStyleBackColor = true;
         // 
         // btClosing
         // 
         this.btClosing.Location = new System.Drawing.Point(177, 47);
         this.btClosing.Margin = new System.Windows.Forms.Padding(4);
         this.btClosing.Name = "btClosing";
         this.btClosing.Size = new System.Drawing.Size(112, 32);
         this.btClosing.TabIndex = 8;
         this.btClosing.Text = "Closing";
         this.btClosing.UseVisualStyleBackColor = true;
         // 
         // btDila
         // 
         this.btDila.Location = new System.Drawing.Point(27, 113);
         this.btDila.Margin = new System.Windows.Forms.Padding(4);
         this.btDila.Name = "btDila";
         this.btDila.Size = new System.Drawing.Size(112, 32);
         this.btDila.TabIndex = 7;
         this.btDila.Text = "Dilatation";
         this.btDila.UseVisualStyleBackColor = true;
         // 
         // btErosion
         // 
         this.btErosion.Location = new System.Drawing.Point(27, 47);
         this.btErosion.Margin = new System.Windows.Forms.Padding(4);
         this.btErosion.Name = "btErosion";
         this.btErosion.Size = new System.Drawing.Size(112, 32);
         this.btErosion.TabIndex = 6;
         this.btErosion.Text = "Erosion";
         this.btErosion.UseVisualStyleBackColor = true;
         // 
         // groupBox5
         // 
         this.groupBox5.Controls.Add(this.cbSmoothFilter);
         this.groupBox5.Controls.Add(this.label1);
         this.groupBox5.Controls.Add(this.cbMaskSize);
         this.groupBox5.Controls.Add(this.btCalcSmoothFilter);
         this.groupBox5.Location = new System.Drawing.Point(222, 25);
         this.groupBox5.Name = "groupBox5";
         this.groupBox5.Size = new System.Drawing.Size(200, 185);
         this.groupBox5.TabIndex = 1;
         this.groupBox5.TabStop = false;
         this.groupBox5.Text = "Glättungsfilter";
         // 
         // cbSmoothFilter
         // 
         this.cbSmoothFilter.FormattingEnabled = true;
         this.cbSmoothFilter.Location = new System.Drawing.Point(16, 34);
         this.cbSmoothFilter.Name = "cbSmoothFilter";
         this.cbSmoothFilter.Size = new System.Drawing.Size(167, 28);
         this.cbSmoothFilter.TabIndex = 11;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(5, 91);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(115, 20);
         this.label1.TabIndex = 10;
         this.label1.Text = "Maskengröße:";
         // 
         // cbMaskSize
         // 
         this.cbMaskSize.FormattingEnabled = true;
         this.cbMaskSize.Items.AddRange(new object[] {
            "3",
            "5",
            "7",
            "9",
            "11"});
         this.cbMaskSize.Location = new System.Drawing.Point(122, 88);
         this.cbMaskSize.Name = "cbMaskSize";
         this.cbMaskSize.Size = new System.Drawing.Size(61, 28);
         this.cbMaskSize.TabIndex = 9;
         // 
         // btCalcSmoothFilter
         // 
         this.btCalcSmoothFilter.Location = new System.Drawing.Point(39, 136);
         this.btCalcSmoothFilter.Margin = new System.Windows.Forms.Padding(4);
         this.btCalcSmoothFilter.Name = "btCalcSmoothFilter";
         this.btCalcSmoothFilter.Size = new System.Drawing.Size(120, 32);
         this.btCalcSmoothFilter.TabIndex = 7;
         this.btCalcSmoothFilter.Text = "Glättungsbild";
         this.btCalcSmoothFilter.UseVisualStyleBackColor = true;
         this.btCalcSmoothFilter.Click += new System.EventHandler(this.btCalcSmoothFilter_Click);
         // 
         // groupBox4
         // 
         this.groupBox4.Controls.Add(this.cbEdgeFilter);
         this.groupBox4.Controls.Add(this.btCalcEdgeFilter);
         this.groupBox4.Location = new System.Drawing.Point(10, 25);
         this.groupBox4.Name = "groupBox4";
         this.groupBox4.Size = new System.Drawing.Size(200, 185);
         this.groupBox4.TabIndex = 0;
         this.groupBox4.TabStop = false;
         this.groupBox4.Text = "Kantenfilter";
         // 
         // cbEdgeFilter
         // 
         this.cbEdgeFilter.FormattingEnabled = true;
         this.cbEdgeFilter.Location = new System.Drawing.Point(16, 34);
         this.cbEdgeFilter.Name = "cbEdgeFilter";
         this.cbEdgeFilter.Size = new System.Drawing.Size(167, 28);
         this.cbEdgeFilter.TabIndex = 10;
         // 
         // btCalcEdgeFilter
         // 
         this.btCalcEdgeFilter.Location = new System.Drawing.Point(33, 136);
         this.btCalcEdgeFilter.Margin = new System.Windows.Forms.Padding(4);
         this.btCalcEdgeFilter.Name = "btCalcEdgeFilter";
         this.btCalcEdgeFilter.Size = new System.Drawing.Size(120, 32);
         this.btCalcEdgeFilter.TabIndex = 9;
         this.btCalcEdgeFilter.Text = "Kantenbild";
         this.btCalcEdgeFilter.UseVisualStyleBackColor = true;
         this.btCalcEdgeFilter.Click += new System.EventHandler(this.btCalcEdgeFilter_Click);
         // 
         // loadImgDialog
         // 
         this.loadImgDialog.FileName = "openFileDialog1";
         // 
         // groupBox2
         // 
         this.groupBox2.Controls.Add(this.picBoxResImg);
         this.groupBox2.Location = new System.Drawing.Point(510, 36);
         this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
         this.groupBox2.Name = "groupBox2";
         this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
         this.groupBox2.Size = new System.Drawing.Size(500, 406);
         this.groupBox2.TabIndex = 3;
         this.groupBox2.TabStop = false;
         this.groupBox2.Text = "Ergebnis Bild";
         // 
         // picBoxResImg
         // 
         this.picBoxResImg.Location = new System.Drawing.Point(10, 36);
         this.picBoxResImg.Margin = new System.Windows.Forms.Padding(4);
         this.picBoxResImg.Name = "picBoxResImg";
         this.picBoxResImg.Size = new System.Drawing.Size(480, 360);
         this.picBoxResImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.picBoxResImg.TabIndex = 3;
         this.picBoxResImg.TabStop = false;
         // 
         // groupBox3
         // 
         this.groupBox3.Controls.Add(this.picBoxInImg);
         this.groupBox3.Location = new System.Drawing.Point(2, 36);
         this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
         this.groupBox3.Name = "groupBox3";
         this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
         this.groupBox3.Size = new System.Drawing.Size(500, 406);
         this.groupBox3.TabIndex = 4;
         this.groupBox3.TabStop = false;
         this.groupBox3.Text = "Original Bild";
         // 
         // picBoxInImg
         // 
         this.picBoxInImg.Location = new System.Drawing.Point(10, 36);
         this.picBoxInImg.Margin = new System.Windows.Forms.Padding(4);
         this.picBoxInImg.Name = "picBoxInImg";
         this.picBoxInImg.Size = new System.Drawing.Size(480, 360);
         this.picBoxInImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.picBoxInImg.TabIndex = 2;
         this.picBoxInImg.TabStop = false;
         this.picBoxInImg.Click += new System.EventHandler(this.picBoxInImg_Click);
         // 
         // btClose
         // 
         this.btClose.Location = new System.Drawing.Point(888, 674);
         this.btClose.Margin = new System.Windows.Forms.Padding(4);
         this.btClose.Name = "btClose";
         this.btClose.Size = new System.Drawing.Size(112, 32);
         this.btClose.TabIndex = 5;
         this.btClose.Text = "Beenden";
         this.btClose.UseVisualStyleBackColor = true;
         this.btClose.Click += new System.EventHandler(this.btClose_Click);
         // 
         // menu
         // 
         this.menu.BackColor = System.Drawing.SystemColors.Menu;
         this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
         this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnFile,
            this.mnEdit,
            this.mnInfo});
         this.menu.Location = new System.Drawing.Point(0, 0);
         this.menu.Name = "menu";
         this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
         this.menu.Size = new System.Drawing.Size(1016, 28);
         this.menu.TabIndex = 8;
         this.menu.Text = "menu";
         // 
         // mnFile
         // 
         this.mnFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_LoadImg,
            this.File_SaveResImg,
            this.File_Close});
         this.mnFile.Name = "mnFile";
         this.mnFile.Size = new System.Drawing.Size(59, 24);
         this.mnFile.Text = "Datei";
         // 
         // File_LoadImg
         // 
         this.File_LoadImg.Name = "File_LoadImg";
         this.File_LoadImg.Size = new System.Drawing.Size(242, 26);
         this.File_LoadImg.Text = "Bild laden";
         // 
         // File_SaveResImg
         // 
         this.File_SaveResImg.Name = "File_SaveResImg";
         this.File_SaveResImg.Size = new System.Drawing.Size(242, 26);
         this.File_SaveResImg.Text = "Ergebnisbild speichern";
         this.File_SaveResImg.Click += new System.EventHandler(this.File_SaveResImg_Click);
         // 
         // File_Close
         // 
         this.File_Close.Name = "File_Close";
         this.File_Close.Size = new System.Drawing.Size(242, 26);
         this.File_Close.Text = "Schliessen";
         this.File_Close.Click += new System.EventHandler(this.File_Close_Click);
         // 
         // mnEdit
         // 
         this.mnEdit.Name = "mnEdit";
         this.mnEdit.Size = new System.Drawing.Size(95, 24);
         this.mnEdit.Text = "Bearbeiten";
         // 
         // mnInfo
         // 
         this.mnInfo.Name = "mnInfo";
         this.mnInfo.Size = new System.Drawing.Size(49, 24);
         this.mnInfo.Text = "Info";
         // 
         // statusBar
         // 
         this.statusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
         this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarLabel});
         this.statusBar.Location = new System.Drawing.Point(0, 708);
         this.statusBar.Name = "statusBar";
         this.statusBar.Size = new System.Drawing.Size(1016, 26);
         this.statusBar.TabIndex = 9;
         this.statusBar.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusBar_ItemClicked);
         // 
         // statusBarLabel
         // 
         this.statusBarLabel.BackColor = System.Drawing.SystemColors.MenuBar;
         this.statusBarLabel.Name = "statusBarLabel";
         this.statusBarLabel.Size = new System.Drawing.Size(237, 20);
         this.statusBarLabel.Text = "Bild wird bearbeitet, bitte warten...";
         // 
         // btLoadImg
         // 
         this.btLoadImg.Location = new System.Drawing.Point(12, 673);
         this.btLoadImg.Margin = new System.Windows.Forms.Padding(4);
         this.btLoadImg.Name = "btLoadImg";
         this.btLoadImg.Size = new System.Drawing.Size(120, 32);
         this.btLoadImg.TabIndex = 10;
         this.btLoadImg.Text = "Bild laden";
         this.btLoadImg.UseVisualStyleBackColor = true;
         this.btLoadImg.Click += new System.EventHandler(this.btLoadImg_Click);
         // 
         // fMain
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1016, 734);
         this.Controls.Add(this.btLoadImg);
         this.Controls.Add(this.statusBar);
         this.Controls.Add(this.btClose);
         this.Controls.Add(this.groupBox3);
         this.Controls.Add(this.groupBox2);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.menu);
         this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MainMenuStrip = this.menu;
         this.Margin = new System.Windows.Forms.Padding(4);
         this.Name = "fMain";
         this.Text = "Bildbearbeitung";
         this.Load += new System.EventHandler(this.fMain_Load);
         this.groupBox1.ResumeLayout(false);
         this.groupBox8.ResumeLayout(false);
         this.groupBox8.PerformLayout();
         this.groupBox7.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.tbBinThresh)).EndInit();
         this.groupBox6.ResumeLayout(false);
         this.groupBox5.ResumeLayout(false);
         this.groupBox5.PerformLayout();
         this.groupBox4.ResumeLayout(false);
         this.groupBox2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.picBoxResImg)).EndInit();
         this.groupBox3.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.picBoxInImg)).EndInit();
         this.menu.ResumeLayout(false);
         this.menu.PerformLayout();
         this.statusBar.ResumeLayout(false);
         this.statusBar.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.OpenFileDialog loadImgDialog;
      private System.Windows.Forms.GroupBox groupBox2;
      private System.Windows.Forms.PictureBox picBoxResImg;
      private System.Windows.Forms.GroupBox groupBox3;
      private System.Windows.Forms.PictureBox picBoxInImg;
      private System.Windows.Forms.Button btClose;
      private System.Windows.Forms.GroupBox groupBox5;
      private System.Windows.Forms.GroupBox groupBox4;
      private System.Windows.Forms.Button btCalcSmoothFilter;
      private System.Windows.Forms.GroupBox groupBox6;
      private System.Windows.Forms.Button btOpening;
      private System.Windows.Forms.Button btClosing;
      private System.Windows.Forms.Button btDila;
      private System.Windows.Forms.Button btErosion;
      private System.Windows.Forms.Button btCalcEdgeFilter;
      private System.Windows.Forms.MenuStrip menu;
      private System.Windows.Forms.ToolStripMenuItem mnFile;
      private System.Windows.Forms.ToolStripMenuItem File_LoadImg;
      private System.Windows.Forms.ToolStripMenuItem mnInfo;
      private System.Windows.Forms.ToolStripMenuItem File_Close;
      private System.Windows.Forms.ToolStripMenuItem mnEdit;
      private System.Windows.Forms.ToolStripMenuItem File_SaveResImg;
      private System.Windows.Forms.SaveFileDialog saveImgDialog;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.ComboBox cbMaskSize;
      private System.Windows.Forms.ComboBox cbEdgeFilter;
      private System.Windows.Forms.ComboBox cbSmoothFilter;
      private System.Windows.Forms.StatusStrip statusBar;
      private System.Windows.Forms.ToolStripStatusLabel statusBarLabel;
      private System.Windows.Forms.Button btLoadImg;
      private System.Windows.Forms.GroupBox groupBox8;
      private System.Windows.Forms.GroupBox groupBox7;
      private System.Windows.Forms.TrackBar tbBinThresh;
      private System.Windows.Forms.CheckBox cbBinInImg;
   }
}

