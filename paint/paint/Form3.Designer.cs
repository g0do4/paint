
namespace paint
{
	partial class Form3
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
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonOk = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonWord = new System.Windows.Forms.Button();
			this.usersDataSet1 = new paint.UsersDataSet();
			this.jurnalBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.jurnalTableAdapter = new paint.UsersDataSetTableAdapters.JurnalTableAdapter();
			this.listBox1 = new System.Windows.Forms.ListBox();
			((System.ComponentModel.ISupportInitialize)(this.usersDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.jurnalBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(19, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(344, 21);
			this.label1.TabIndex = 0;
			this.label1.Text = "Недавно открытые и сохранённые файлы";
			// 
			// buttonOk
			// 
			this.buttonOk.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonOk.Location = new System.Drawing.Point(16, 353);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(53, 39);
			this.buttonOk.TabIndex = 2;
			this.buttonOk.Text = "Ок";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonCancel.Location = new System.Drawing.Point(286, 353);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(87, 39);
			this.buttonCancel.TabIndex = 4;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// buttonWord
			// 
			this.buttonWord.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonWord.Location = new System.Drawing.Point(75, 353);
			this.buttonWord.Name = "buttonWord";
			this.buttonWord.Size = new System.Drawing.Size(205, 39);
			this.buttonWord.TabIndex = 3;
			this.buttonWord.Text = "Открыть в Word";
			this.buttonWord.UseVisualStyleBackColor = true;
			this.buttonWord.Click += new System.EventHandler(this.buttonWord_Click);
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
			// listBox1
			// 
			this.listBox1.DataSource = this.jurnalBindingSource;
			this.listBox1.DisplayMember = "FilePath";
			this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 20;
			this.listBox1.Location = new System.Drawing.Point(12, 33);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(361, 304);
			this.listBox1.TabIndex = 5;
			this.listBox1.ValueMember = "FilePath";
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(385, 404);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.buttonWord);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.Name = "Form3";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Недавние файлы";
			this.Load += new System.EventHandler(this.Form3_Load);
			((System.ComponentModel.ISupportInitialize)(this.usersDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.jurnalBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonWord;
		private UsersDataSet usersDataSet1;
		private System.Windows.Forms.BindingSource jurnalBindingSource;
		private UsersDataSetTableAdapters.JurnalTableAdapter jurnalTableAdapter;
		private System.Windows.Forms.ListBox listBox1;
	}
}