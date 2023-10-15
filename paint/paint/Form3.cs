using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;
using System.IO;

namespace paint
{
	public partial class Form3 : Form
	{
		public Form3()
		{
			InitializeComponent();
		}

		Form1 form1 = (Form1)Application.OpenForms[0];

		private void Form3_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "usersDataSet1.Jurnal". При необходимости она может быть перемещена или удалена.
			this.jurnalTableAdapter.Fill(this.usersDataSet1.Jurnal);
			jurnalBindingSource.Filter = "KodUser = " + form1.idOfUser;
		}

		private void buttonOk_Click(object sender, EventArgs e)
		{
			if (!File.Exists((string)listBox1.SelectedValue))
			{
				MessageBox.Show("Выбранного файла не существует. Он будет удалён.");
				jurnalTableAdapter.DeleteFile((string)listBox1.SelectedValue);
			}
			else
			{
				form1.newPath = (string)listBox1.SelectedValue;
				form1.boolNewPath = true;
			}
			this.Close();
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void buttonWord_Click(object sender, EventArgs e)
		{
			Word._Application appw;
			appw = new Word.Application();
			appw.Visible = true;
			Word._Document dw;
			dw = appw.Documents.Add(Visible: true);

			var paragraph = appw.ActiveDocument.Paragraphs.Add();
			paragraph.Range.Text = "Пользователь: " + form1.userName;

			paragraph = appw.ActiveDocument.Paragraphs.Add();
			paragraph = appw.ActiveDocument.Paragraphs[2];
			var tableRange = paragraph.Range;
			appw.ActiveDocument.Tables.Add(tableRange, jurnalBindingSource.Count + 1, 2);

			var table = appw.ActiveDocument.Tables[appw.ActiveDocument.Tables.Count];
			table.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
			table.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;

			table.Range.Font.Size = 12;

			table.Cell(1, 1).Range.Text = "Путь к файлу";
			table.Cell(1, 2).Range.Text = "Дата активности";

			var rowCollection = jurnalTableAdapter.GetData().Rows;

			int i = 2;
			foreach (DataRow item in rowCollection)
			{
				table.Cell(i, 1).Range.Text = item[1].ToString();
				table.Cell(i, 2).Range.Text = item[2].ToString();
				i++;
			}
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			return;
		}
	}
}
