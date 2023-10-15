
namespace paint
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.butCol1 = new System.Windows.Forms.Button();
			this.butCol2 = new System.Windows.Forms.Button();
			this.butCol3 = new System.Windows.Forms.Button();
			this.butCol4 = new System.Windows.Forms.Button();
			this.butCol5 = new System.Windows.Forms.Button();
			this.butCol6 = new System.Windows.Forms.Button();
			this.butColDialog = new System.Windows.Forms.Button();
			this.LabelColor = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.butForvard = new System.Windows.Forms.Button();
			this.butBack = new System.Windows.Forms.Button();
			this.panel4 = new System.Windows.Forms.Panel();
			this.radioLastik = new System.Windows.Forms.RadioButton();
			this.radioKrug = new System.Windows.Forms.RadioButton();
			this.radioKwadr = new System.Windows.Forms.RadioButton();
			this.radioLine = new System.Windows.Forms.RadioButton();
			this.radioKriw = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.RadioFill = new System.Windows.Forms.RadioButton();
			this.RadioPen = new System.Windows.Forms.RadioButton();
			this.panel2 = new System.Windows.Forms.Panel();
			this.labelWinth = new System.Windows.Forms.Label();
			this.trackBarWidth = new System.Windows.Forms.TrackBar();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.файлыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.отчиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.сохранитToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.недавниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.пользовательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.войтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.информацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.panel6 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.usersDataSet1 = new paint.UsersDataSet();
			this.jurnalBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.jurnalTableAdapter = new paint.UsersDataSetTableAdapters.JurnalTableAdapter();
			this.flowLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBarWidth)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.panel6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.usersDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.jurnalBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.butCol1);
			this.flowLayoutPanel1.Controls.Add(this.butCol2);
			this.flowLayoutPanel1.Controls.Add(this.butCol3);
			this.flowLayoutPanel1.Controls.Add(this.butCol4);
			this.flowLayoutPanel1.Controls.Add(this.butCol5);
			this.flowLayoutPanel1.Controls.Add(this.butCol6);
			this.flowLayoutPanel1.Controls.Add(this.butColDialog);
			this.flowLayoutPanel1.Controls.Add(this.LabelColor);
			resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			// 
			// butCol1
			// 
			this.butCol1.BackColor = System.Drawing.Color.Red;
			this.butCol1.Cursor = System.Windows.Forms.Cursors.Default;
			resources.ApplyResources(this.butCol1, "butCol1");
			this.butCol1.Name = "butCol1";
			this.butCol1.UseVisualStyleBackColor = false;
			this.butCol1.Click += new System.EventHandler(this.ChangeColor);
			// 
			// butCol2
			// 
			this.butCol2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.butCol2.Cursor = System.Windows.Forms.Cursors.Default;
			resources.ApplyResources(this.butCol2, "butCol2");
			this.butCol2.Name = "butCol2";
			this.butCol2.UseVisualStyleBackColor = false;
			this.butCol2.Click += new System.EventHandler(this.ChangeColor);
			// 
			// butCol3
			// 
			this.butCol3.BackColor = System.Drawing.Color.Yellow;
			this.butCol3.Cursor = System.Windows.Forms.Cursors.Default;
			resources.ApplyResources(this.butCol3, "butCol3");
			this.butCol3.Name = "butCol3";
			this.butCol3.UseVisualStyleBackColor = false;
			this.butCol3.Click += new System.EventHandler(this.ChangeColor);
			// 
			// butCol4
			// 
			this.butCol4.BackColor = System.Drawing.Color.Lime;
			this.butCol4.Cursor = System.Windows.Forms.Cursors.Default;
			resources.ApplyResources(this.butCol4, "butCol4");
			this.butCol4.Name = "butCol4";
			this.butCol4.UseVisualStyleBackColor = false;
			this.butCol4.Click += new System.EventHandler(this.ChangeColor);
			// 
			// butCol5
			// 
			this.butCol5.BackColor = System.Drawing.Color.Aqua;
			this.butCol5.Cursor = System.Windows.Forms.Cursors.Default;
			resources.ApplyResources(this.butCol5, "butCol5");
			this.butCol5.Name = "butCol5";
			this.butCol5.UseVisualStyleBackColor = false;
			this.butCol5.Click += new System.EventHandler(this.ChangeColor);
			// 
			// butCol6
			// 
			this.butCol6.BackColor = System.Drawing.Color.Black;
			this.butCol6.Cursor = System.Windows.Forms.Cursors.Default;
			resources.ApplyResources(this.butCol6, "butCol6");
			this.butCol6.Name = "butCol6";
			this.butCol6.UseVisualStyleBackColor = false;
			this.butCol6.Click += new System.EventHandler(this.ChangeColor);
			// 
			// butColDialog
			// 
			this.butColDialog.BackgroundImage = global::paint.Properties.Resources.color;
			resources.ApplyResources(this.butColDialog, "butColDialog");
			this.butColDialog.Cursor = System.Windows.Forms.Cursors.Default;
			this.butColDialog.Name = "butColDialog";
			this.butColDialog.UseVisualStyleBackColor = false;
			this.butColDialog.Click += new System.EventHandler(this.button9_Click);
			// 
			// LabelColor
			// 
			resources.ApplyResources(this.LabelColor, "LabelColor");
			this.LabelColor.Name = "LabelColor";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel5);
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.flowLayoutPanel1);
			this.panel1.Controls.Add(this.menuStrip1);
			resources.ApplyResources(this.panel1, "panel1");
			this.panel1.Name = "panel1";
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.butForvard);
			this.panel5.Controls.Add(this.butBack);
			resources.ApplyResources(this.panel5, "panel5");
			this.panel5.Name = "panel5";
			// 
			// butForvard
			// 
			this.butForvard.BackgroundImage = global::paint.Properties.Resources.forward;
			resources.ApplyResources(this.butForvard, "butForvard");
			this.butForvard.Name = "butForvard";
			this.butForvard.UseVisualStyleBackColor = true;
			this.butForvard.Click += new System.EventHandler(this.butForvard_Click);
			// 
			// butBack
			// 
			this.butBack.BackgroundImage = global::paint.Properties.Resources.back;
			resources.ApplyResources(this.butBack, "butBack");
			this.butBack.Name = "butBack";
			this.butBack.UseVisualStyleBackColor = true;
			this.butBack.Click += new System.EventHandler(this.butBack_Click);
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.radioLastik);
			this.panel4.Controls.Add(this.radioKrug);
			this.panel4.Controls.Add(this.radioKwadr);
			this.panel4.Controls.Add(this.radioLine);
			this.panel4.Controls.Add(this.radioKriw);
			this.panel4.Controls.Add(this.label2);
			resources.ApplyResources(this.panel4, "panel4");
			this.panel4.Name = "panel4";
			// 
			// radioLastik
			// 
			resources.ApplyResources(this.radioLastik, "radioLastik");
			this.radioLastik.BackgroundImage = global::paint.Properties.Resources.lastik;
			this.radioLastik.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.radioLastik.Name = "radioLastik";
			this.radioLastik.UseVisualStyleBackColor = true;
			// 
			// radioKrug
			// 
			resources.ApplyResources(this.radioKrug, "radioKrug");
			this.radioKrug.BackgroundImage = global::paint.Properties.Resources.krug;
			this.radioKrug.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.radioKrug.Name = "radioKrug";
			this.radioKrug.UseVisualStyleBackColor = true;
			// 
			// radioKwadr
			// 
			resources.ApplyResources(this.radioKwadr, "radioKwadr");
			this.radioKwadr.BackgroundImage = global::paint.Properties.Resources.kwadr;
			this.radioKwadr.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.radioKwadr.Name = "radioKwadr";
			this.radioKwadr.UseVisualStyleBackColor = true;
			// 
			// radioLine
			// 
			resources.ApplyResources(this.radioLine, "radioLine");
			this.radioLine.BackgroundImage = global::paint.Properties.Resources.pram;
			this.radioLine.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.radioLine.Name = "radioLine";
			this.radioLine.UseVisualStyleBackColor = true;
			// 
			// radioKriw
			// 
			resources.ApplyResources(this.radioKriw, "radioKriw");
			this.radioKriw.BackgroundImage = global::paint.Properties.Resources.kriw;
			this.radioKriw.Checked = true;
			this.radioKriw.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.radioKriw.Name = "radioKriw";
			this.radioKriw.TabStop = true;
			this.radioKriw.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			resources.ApplyResources(this.label2, "label2");
			this.label2.Name = "label2";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.label1);
			this.panel3.Controls.Add(this.RadioFill);
			this.panel3.Controls.Add(this.RadioPen);
			resources.ApplyResources(this.panel3, "panel3");
			this.panel3.Name = "panel3";
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			// 
			// RadioFill
			// 
			resources.ApplyResources(this.RadioFill, "RadioFill");
			this.RadioFill.BackgroundImage = global::paint.Properties.Resources.fill;
			this.RadioFill.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.RadioFill.Name = "RadioFill";
			this.RadioFill.UseVisualStyleBackColor = true;
			// 
			// RadioPen
			// 
			resources.ApplyResources(this.RadioPen, "RadioPen");
			this.RadioPen.BackgroundImage = global::paint.Properties.Resources.pen;
			this.RadioPen.Checked = true;
			this.RadioPen.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.RadioPen.Name = "RadioPen";
			this.RadioPen.TabStop = true;
			this.RadioPen.UseVisualStyleBackColor = true;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.labelWinth);
			this.panel2.Controls.Add(this.trackBarWidth);
			resources.ApplyResources(this.panel2, "panel2");
			this.panel2.Name = "panel2";
			// 
			// labelWinth
			// 
			resources.ApplyResources(this.labelWinth, "labelWinth");
			this.labelWinth.Name = "labelWinth";
			// 
			// trackBarWidth
			// 
			resources.ApplyResources(this.trackBarWidth, "trackBarWidth");
			this.trackBarWidth.LargeChange = 1;
			this.trackBarWidth.Maximum = 15;
			this.trackBarWidth.Minimum = 1;
			this.trackBarWidth.Name = "trackBarWidth";
			this.trackBarWidth.Value = 3;
			this.trackBarWidth.Scroll += new System.EventHandler(this.trackBar1_Scroll);
			// 
			// menuStrip1
			// 
			resources.ApplyResources(this.menuStrip1, "menuStrip1");
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлыToolStripMenuItem,
            this.пользовательToolStripMenuItem,
            this.информацияToolStripMenuItem});
			this.menuStrip1.Name = "menuStrip1";
			// 
			// файлыToolStripMenuItem
			// 
			this.файлыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.отчиститьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитToolStripMenuItem,
            this.недавниеToolStripMenuItem,
            this.выходToolStripMenuItem});
			this.файлыToolStripMenuItem.Name = "файлыToolStripMenuItem";
			resources.ApplyResources(this.файлыToolStripMenuItem, "файлыToolStripMenuItem");
			// 
			// создатьToolStripMenuItem
			// 
			this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
			resources.ApplyResources(this.создатьToolStripMenuItem, "создатьToolStripMenuItem");
			this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
			// 
			// отчиститьToolStripMenuItem
			// 
			this.отчиститьToolStripMenuItem.Name = "отчиститьToolStripMenuItem";
			resources.ApplyResources(this.отчиститьToolStripMenuItem, "отчиститьToolStripMenuItem");
			this.отчиститьToolStripMenuItem.Click += new System.EventHandler(this.отчиститьToolStripMenuItem_Click);
			// 
			// открытьToolStripMenuItem
			// 
			this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
			resources.ApplyResources(this.открытьToolStripMenuItem, "открытьToolStripMenuItem");
			this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
			// 
			// сохранитToolStripMenuItem
			// 
			this.сохранитToolStripMenuItem.Name = "сохранитToolStripMenuItem";
			resources.ApplyResources(this.сохранитToolStripMenuItem, "сохранитToolStripMenuItem");
			this.сохранитToolStripMenuItem.Click += new System.EventHandler(this.сохранитToolStripMenuItem_Click);
			// 
			// недавниеToolStripMenuItem
			// 
			resources.ApplyResources(this.недавниеToolStripMenuItem, "недавниеToolStripMenuItem");
			this.недавниеToolStripMenuItem.Name = "недавниеToolStripMenuItem";
			this.недавниеToolStripMenuItem.Click += new System.EventHandler(this.недавниеToolStripMenuItem_Click);
			// 
			// выходToolStripMenuItem
			// 
			this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
			resources.ApplyResources(this.выходToolStripMenuItem, "выходToolStripMenuItem");
			this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
			// 
			// пользовательToolStripMenuItem
			// 
			this.пользовательToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.войтиToolStripMenuItem});
			resources.ApplyResources(this.пользовательToolStripMenuItem, "пользовательToolStripMenuItem");
			this.пользовательToolStripMenuItem.Name = "пользовательToolStripMenuItem";
			// 
			// войтиToolStripMenuItem
			// 
			this.войтиToolStripMenuItem.Name = "войтиToolStripMenuItem";
			resources.ApplyResources(this.войтиToolStripMenuItem, "войтиToolStripMenuItem");
			this.войтиToolStripMenuItem.Click += new System.EventHandler(this.войтиToolStripMenuItem_Click);
			// 
			// информацияToolStripMenuItem
			// 
			this.информацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.справкаToolStripMenuItem});
			this.информацияToolStripMenuItem.Name = "информацияToolStripMenuItem";
			resources.ApplyResources(this.информацияToolStripMenuItem, "информацияToolStripMenuItem");
			// 
			// оПрограммеToolStripMenuItem
			// 
			this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
			resources.ApplyResources(this.оПрограммеToolStripMenuItem, "оПрограммеToolStripMenuItem");
			this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
			// 
			// справкаToolStripMenuItem
			// 
			this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
			resources.ApplyResources(this.справкаToolStripMenuItem, "справкаToolStripMenuItem");
			this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			resources.ApplyResources(this.openFileDialog1, "openFileDialog1");
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.pictureBox1);
			resources.ApplyResources(this.panel6, "panel6");
			this.panel6.Name = "panel6";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.White;
			this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
			resources.ApplyResources(this.pictureBox1, "pictureBox1");
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.TabStop = false;
			this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
			this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
			this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
			// 
			// usersDataSet1
			// 
			this.usersDataSet1.DataSetName = "UsersDataSet";
			this.usersDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// jurnalBindingSource
			// 
			this.jurnalBindingSource.DataMember = "Jurnal";
			this.jurnalBindingSource.DataSource = this.usersDataSet1;
			// 
			// jurnalTableAdapter
			// 
			this.jurnalTableAdapter.ClearBeforeFill = true;
			// 
			// Form1
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.Controls.Add(this.panel6);
			this.Controls.Add(this.panel1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBarWidth)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel6.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.usersDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.jurnalBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Button butCol1;
		private System.Windows.Forms.Button butCol2;
		private System.Windows.Forms.Button butCol3;
		private System.Windows.Forms.Button butCol4;
		private System.Windows.Forms.Button butCol5;
		private System.Windows.Forms.Button butCol6;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button butBack;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem файлыToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem сохранитToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem недавниеToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem пользовательToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem войтиToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem информацияToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
		private System.Windows.Forms.Button butForvard;
		private System.Windows.Forms.Button butColDialog;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TrackBar trackBarWidth;
		private System.Windows.Forms.Label LabelColor;
		private System.Windows.Forms.Label labelWinth;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.RadioButton RadioFill;
		private System.Windows.Forms.RadioButton RadioPen;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.RadioButton radioKrug;
		private System.Windows.Forms.RadioButton radioKwadr;
		private System.Windows.Forms.RadioButton radioLine;
		private System.Windows.Forms.RadioButton radioKriw;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RadioButton radioLastik;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem отчиститьToolStripMenuItem;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Panel panel6;
		private UsersDataSet usersDataSet1;
		private System.Windows.Forms.BindingSource jurnalBindingSource;
		private UsersDataSetTableAdapters.JurnalTableAdapter jurnalTableAdapter;
	}
}

