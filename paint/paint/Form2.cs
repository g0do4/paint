using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paint
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		//public int idOfUser;

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "usersDataSet1.User". При необходимости она может быть перемещена или удалена.
			this.userTableAdapter.Fill(this.usersDataSet1.User);

		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (textBoxLogin != null && textBoxPass != null)
			{
				if (radioReg.Checked)
				{
					if (textBoxLogin.Text != Convert.ToString(((DataRowView)userBindingSource.Current).Row["Login"]))
					{
						userTableAdapter.Insert(textBoxLogin.Text, textBoxPass.Text);
						MessageBox.Show("Вы успешно зарегестрировались. Войдите в учётную запись", "Успех");
					}
					else
						MessageBox.Show("Пользователь с таким именем уже существует.", "Ошибка");
				}
				else
				{
					userBindingSource.Filter = "(Login = '" + textBoxLogin.Text + "') and (Password = '" + textBoxPass.Text + "')";
					if (userBindingSource.Count != 0)
					{
						MessageBox.Show("Вход выполнен успешно","Успех");
						Form1 form1 = (Form1)Application.OpenForms[0];
						form1.idOfUser = (int)((DataRowView)userBindingSource.Current).Row["KodeUser"];
						form1.userName = (string)((DataRowView)userBindingSource.Current).Row["Login"];
						this.Close();
					}
					else
						MessageBox.Show("Такого пользователя не существует", "Ошибка");
				}
			}
		}
	}
}
