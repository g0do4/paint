
namespace paint
{
	partial class Form2
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			this.buttonExit = new System.Windows.Forms.Button();
			this.textBoxLogin = new System.Windows.Forms.TextBox();
			this.textBoxPass = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.radioEnter = new System.Windows.Forms.RadioButton();
			this.radioReg = new System.Windows.Forms.RadioButton();
			this.buttonRegOrEn = new System.Windows.Forms.Button();
			this.usersDataSet1 = new paint.UsersDataSet();
			this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.userTableAdapter = new paint.UsersDataSetTableAdapters.UserTableAdapter();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.usersDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonExit
			// 
			resources.ApplyResources(this.buttonExit, "buttonExit");
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBoxLogin
			// 
			resources.ApplyResources(this.textBoxLogin, "textBoxLogin");
			this.textBoxLogin.Name = "textBoxLogin";
			// 
			// textBoxPass
			// 
			resources.ApplyResources(this.textBoxPass, "textBoxPass");
			this.textBoxPass.Name = "textBoxPass";
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			// 
			// label2
			// 
			resources.ApplyResources(this.label2, "label2");
			this.label2.Name = "label2";
			// 
			// panel1
			// 
			resources.ApplyResources(this.panel1, "panel1");
			this.panel1.Controls.Add(this.radioEnter);
			this.panel1.Controls.Add(this.radioReg);
			this.panel1.Name = "panel1";
			// 
			// radioEnter
			// 
			resources.ApplyResources(this.radioEnter, "radioEnter");
			this.radioEnter.Name = "radioEnter";
			this.radioEnter.UseVisualStyleBackColor = true;
			// 
			// radioReg
			// 
			resources.ApplyResources(this.radioReg, "radioReg");
			this.radioReg.Checked = true;
			this.radioReg.Name = "radioReg";
			this.radioReg.TabStop = true;
			this.radioReg.UseVisualStyleBackColor = true;
			// 
			// buttonRegOrEn
			// 
			resources.ApplyResources(this.buttonRegOrEn, "buttonRegOrEn");
			this.buttonRegOrEn.Name = "buttonRegOrEn";
			this.buttonRegOrEn.UseVisualStyleBackColor = true;
			this.buttonRegOrEn.Click += new System.EventHandler(this.button2_Click);
			// 
			// usersDataSet1
			// 
			this.usersDataSet1.DataSetName = "UsersDataSet";
			this.usersDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// userBindingSource
			// 
			this.userBindingSource.DataMember = "User";
			this.userBindingSource.DataSource = this.usersDataSet1;
			// 
			// userTableAdapter
			// 
			this.userTableAdapter.ClearBeforeFill = true;
			// 
			// Form2
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.buttonRegOrEn);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxPass);
			this.Controls.Add(this.textBoxLogin);
			this.Controls.Add(this.buttonExit);
			this.Name = "Form2";
			this.Load += new System.EventHandler(this.Form2_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.usersDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.TextBox textBoxLogin;
		private System.Windows.Forms.TextBox textBoxPass;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton radioEnter;
		private System.Windows.Forms.RadioButton radioReg;
		private System.Windows.Forms.Button buttonRegOrEn;
		private UsersDataSet usersDataSet1;
		private System.Windows.Forms.BindingSource userBindingSource;
		private UsersDataSetTableAdapters.UserTableAdapter userTableAdapter;
	}
}