using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace paint
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			SetDefoult();
			this.Width = Screen.PrimaryScreen.Bounds.Width;
			this.Height = Screen.PrimaryScreen.Bounds.Height;
			//pictureBox1.Height = Screen.PrimaryScreen.Bounds.Height * 80 / 100;
		}

		private class ArrPoint
		{
			private int index = 0;
			private Point[] pnts;

			public ArrPoint(int size)
			{
				if (size >= 0)
					size = 2;
				pnts = new Point[size];
			}

			public void SetPoint(int x, int y)
			{
				if (index >= pnts.Length)
				{
					index = 0;
				}
				pnts[index] = new Point(x, y);
				index++;
			}

			public void Reset()
			{
				index = 0;
			}

			public int GetIndex()
			{
				return index;
			}

			public Point[] Getpnts()
			{
				return pnts;
			}
		}

		private bool PushMouse = false;
		private ArrPoint arrPoint = new ArrPoint(2);

		Bitmap map = new Bitmap(100, 100);
		Graphics graphics;

		Pen pen = new Pen(Color.Black, 3f);

		Bitmap[] history = new Bitmap[20];
		int historyCount = 0;
		int lastHist = 0;

		bool thisSave = false;

		public int idOfUser = -1;
		public string userName = null;
		private void SetDefoult()
		{
			Rectangle rectangle = Screen.PrimaryScreen.Bounds;
			map = new Bitmap(rectangle.Width, rectangle.Height);
			//map = new Bitmap(pictureBox1.Size.Width, pictureBox1.Size.Height);
			graphics = Graphics.FromImage(map);

			pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
			pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
			history[historyCount] = (Bitmap)map.Clone();
		}
		private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
		{
			PushMouse = true;
			if (!radioLastik.Checked && !radioKriw.Checked)
			{
				arrPoint.SetPoint(e.X, e.Y);
				lastPict = (Bitmap)map.Clone();
			}
		}

		private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
		{
			PushMouse = false;

			//рисование кривой
			if (radioKriw.Checked)
			{
				arrPoint.Reset();

				if (RadioFill.Checked && pointsFill.Count > 1)
				{
					graphics.FillPolygon(new SolidBrush(pen.Color), pointsFill.ToArray());
					pictureBox1.Image = map;
					pointsFill.Clear();
				}

			}

			if (radioLastik.Checked)
			{
				arrPoint.Reset();

				Color bufCol = pen.Color;
				pen.Color = pictureBox1.BackColor;

				if (RadioFill.Checked && pointsFill.Count > 1)
				{
					graphics.FillPolygon(new SolidBrush(pen.Color), pointsFill.ToArray());
					pictureBox1.Image = map;
					pointsFill.Clear();
				}

				pen.Color = bufCol;

			}

			//рисование прямой
			if (radioLine.Checked)
			{
				map = lastPict;
				graphics = Graphics.FromImage(map);
				pictureBox1.Image = map;
				arrPoint.SetPoint(e.X, e.Y);
				graphics.DrawLines(pen, arrPoint.Getpnts());
				pictureBox1.Image = map;
				arrPoint.Reset();
			}

			if (radioKwadr.Checked)
			{
				map = lastPict;
				graphics = Graphics.FromImage(map);
				pictureBox1.Image = map;
				arrPoint.SetPoint(e.X, e.Y);
				int width = arrPoint.Getpnts()[1].X - arrPoint.Getpnts()[0].X;
				int height = arrPoint.Getpnts()[1].Y - arrPoint.Getpnts()[0].Y;
				Size size = new Size(width, height);
				Rectangle rectangle = new Rectangle(arrPoint.Getpnts()[0], size);
				if (RadioFill.Checked)
					graphics.FillRectangle(new SolidBrush(pen.Color), rectangle);
				else
					graphics.DrawRectangle(pen, rectangle);
				pictureBox1.Image = map;
				arrPoint.Reset();
			}

			if (radioKrug.Checked)
			{
				map = lastPict;
				graphics = Graphics.FromImage(map);
				pictureBox1.Image = map;
				arrPoint.SetPoint(e.X, e.Y);
				int width = arrPoint.Getpnts()[1].X - arrPoint.Getpnts()[0].X;
				int height = arrPoint.Getpnts()[1].Y - arrPoint.Getpnts()[0].Y;
				Size size = new Size(width, height);
				Rectangle rectangle = new Rectangle(arrPoint.Getpnts()[0], size);
				if (RadioFill.Checked)
					graphics.FillEllipse(new SolidBrush(pen.Color), rectangle);
				else
					graphics.DrawEllipse(pen, rectangle);
				pictureBox1.Image = map;
				arrPoint.Reset();
			}

			if (historyCount < history.Length - 1)
				historyCount++;
			else
				for (int i = 0; i < history.Length - 1; i++)
				{
					history[i] = (Bitmap)history[i + 1].Clone();
				}
			history[historyCount] = (Bitmap)map.Clone();
			lastHist = historyCount;
		}


		List<Point> pointsFill = new List<Point>();

		Bitmap lastPict;
		private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
		{
			if (!PushMouse)
				return;

			if (radioKriw.Checked)
			{
				arrPoint.SetPoint(e.X, e.Y);
				if (arrPoint.GetIndex() >= 2)
				{
					graphics.DrawLines(pen, arrPoint.Getpnts());
					pictureBox1.Image = map;
					arrPoint.SetPoint(e.X, e.Y);
				}
				if (RadioFill.Checked)
				{
					pointsFill.Add(new Point(e.X, e.Y));
				}
			}

			if (radioLastik.Checked)
			{
				Color bufCol = pen.Color;
				pen.Color = pictureBox1.BackColor;
				arrPoint.SetPoint(e.X, e.Y);
				if (arrPoint.GetIndex() >= 2)
				{
					graphics.DrawLines(pen, arrPoint.Getpnts());
					pictureBox1.Image = map;
					arrPoint.SetPoint(e.X, e.Y);
				}
				if (RadioFill.Checked)
				{
					pointsFill.Add(new Point(e.X, e.Y));
				}
				pen.Color = bufCol;
			}

			if (radioLine.Checked)
			{
				graphics.Clear(pictureBox1.BackColor);
				map = lastPict.Clone() as Bitmap;
				graphics = Graphics.FromImage(map);
				pictureBox1.Image = map;
				graphics.DrawLine(pen, arrPoint.Getpnts()[0], new Point(e.X, e.Y));
				pictureBox1.Image = map;
			}

			if (radioKwadr.Checked)
			{
				graphics.Clear(pictureBox1.BackColor);
				map = lastPict.Clone() as Bitmap;
				graphics = Graphics.FromImage(map);
				pictureBox1.Image = map;
				int width = e.X - arrPoint.Getpnts()[0].X;
				int height = e.Y - arrPoint.Getpnts()[0].Y;
				Size size = new Size(width, height);
				Rectangle rectangle = new Rectangle(arrPoint.Getpnts()[0], size);
				if (RadioFill.Checked)
					graphics.FillRectangle(new SolidBrush(pen.Color), rectangle);
				else
					graphics.DrawRectangle(pen, rectangle);
				pictureBox1.Image = map;
			}

			if (radioKrug.Checked)
			{
				graphics.Clear(pictureBox1.BackColor);
				map = lastPict.Clone() as Bitmap;
				graphics = Graphics.FromImage(map);
				pictureBox1.Image = map;
				int width = e.X - arrPoint.Getpnts()[0].X;
				int height = e.Y - arrPoint.Getpnts()[0].Y;
				Size size = new Size(width, height);
				Rectangle rectangle = new Rectangle(arrPoint.Getpnts()[0], size);
				if (RadioFill.Checked)
					graphics.FillEllipse(new SolidBrush(pen.Color), rectangle);
				else
					graphics.DrawEllipse(pen, rectangle);
				pictureBox1.Image = map;
			}
		}

		private void ChangeColor(object sender, EventArgs e)
		{
			pen.Color = ((Button)sender).BackColor;
		}

		private void butBack_Click(object sender, EventArgs e)
		{
			graphics.Clear(pictureBox1.BackColor);
			if (historyCount > 0)
			{
				map = history[historyCount = historyCount - 1];
				history[historyCount] = (Bitmap)map.Clone();
			}
			graphics = Graphics.FromImage(map);
			pictureBox1.Image = map;
		}

		private void butForvard_Click(object sender, EventArgs e)
		{
			if (historyCount < lastHist)
			{
				graphics.Clear(pictureBox1.BackColor);
				if (historyCount < history.Length)
				{
					map = history[historyCount = historyCount + 1];
					history[historyCount] = (Bitmap)map.Clone();
				}
				graphics = Graphics.FromImage(map);
				pictureBox1.Image = map;
			}
		}

		private void button9_Click(object sender, EventArgs e)
		{
			ColorDialog colorDialog = new ColorDialog();
			if (colorDialog.ShowDialog() == DialogResult.OK)
			{
				pen.Color = colorDialog.Color;
				butColDialog.BackColor = colorDialog.Color;
			}
		}

		private void trackBar1_Scroll(object sender, EventArgs e)
		{
			pen.Width = ((TrackBar)sender).Value;
		}

		private void выходToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void войтиToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form2 f2 = new Form2();
			f2.ShowDialog();
			if (idOfUser != -1)
			{
				this.недавниеToolStripMenuItem.Enabled = true;
			}
		}

		private void отчиститьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (beforeActoinSave(sender, e))
			{
				graphics.Clear(pictureBox1.BackColor);
				historyCount = 0;
				lastHist = 0;
				history[historyCount] = map;
				pictureBox1.Image = null;
				thisSave = false;
			}
		}

		private void сохранитToolStripMenuItem_Click(object sender, EventArgs e)
		{
			saveFileDialog1.Filter = "JPG(*.JPG)|*.jpg|PNG(*.PNG)|*.png";
			if (pictureBox1.Image != null)
			{
				if (saveFileDialog1.ShowDialog() == DialogResult.OK)
				{
					pictureBox1.Image.Save(saveFileDialog1.FileName);
					if (idOfUser != -1)
					{
						this.jurnalTableAdapter.Insert(saveFileDialog1.FileName, DateTime.Now, idOfUser);
					}
					thisSave = true;
				}
			}
		}

		private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (beforeActoinSave(sender, e))
			{
				if (openFileDialog1.ShowDialog() == DialogResult.OK)
				{

					if (idOfUser != -1)
					{
						this.jurnalTableAdapter.Insert(openFileDialog1.FileName, DateTime.Now, idOfUser);
					}

					graphics.Clear(pictureBox1.BackColor);
					graphics.DrawImage(Image.FromFile(openFileDialog1.FileName), 0, 0);
					pictureBox1.Image = map;

				}
				thisSave = false;
			}
		}

		private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AboutBox1 aboutBox = new AboutBox1();
			aboutBox.ShowDialog();
		}

		private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (beforeActoinSave(sender, e))
			{
				graphics.Clear(pictureBox1.BackColor);
				historyCount = 0;
				lastHist = 0;
				history[historyCount] = map;
				pictureBox1.Image = null;
				thisSave = false;
			}
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!thisSave && pictureBox1.Image != null)
			{
				DialogResult dialogResult = MessageBox.Show("Файл не сохранён. Сохранить его?", "Сохранить", MessageBoxButtons.YesNoCancel);
				if (dialogResult == DialogResult.Yes)
				{
					this.сохранитToolStripMenuItem_Click(sender, e);
				}
				if (dialogResult == DialogResult.Cancel)
				{
					e.Cancel = true;
					return;
				}
			}
		}

		public void DbLoad()
		{
			try
			{
				// TODO: данная строка кода позволяет загрузить данные в таблицу "usersDataSet1.Jurnal". При необходимости она может быть перемещена или удалена.
				this.jurnalTableAdapter.Fill(this.usersDataSet1.Jurnal);
				this.пользовательToolStripMenuItem.Enabled = true;
				MessageBox.Show("База данных подключина");
			}
			catch (Exception)
			{
				MessageBox.Show("Ошибка при загрузке базы данных. Пункты меню 'Пользователь' и 'Недавние' недоступны.");
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Thread thread = new Thread(DbLoad);
			thread.Start();
			MessageBox.Show("Идёт подключение к базе данных, подождите");
		}

		public bool boolNewPath = false;
		public string newPath;
		private void недавниеToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form3 form3 = new Form3();
			form3.ShowDialog();
			if (boolNewPath)
			{
				if (beforeActoinSave(sender, e))
				{
					graphics.Clear(pictureBox1.BackColor);
					graphics.DrawImage(Image.FromFile(newPath), 0, 0);
					pictureBox1.Image = map;
					boolNewPath = false;
				}
			}
		}

		public bool beforeActoinSave(object sender, EventArgs e)
		{
			if (!thisSave && pictureBox1.Image != null)
			{
				DialogResult dialogResult = MessageBox.Show("Файл не сохранён. Сохранить его?", "Сохранить", MessageBoxButtons.YesNoCancel);
				switch (dialogResult)
				{
					case DialogResult.Cancel:
						break;
					case DialogResult.Yes:
						this.сохранитToolStripMenuItem_Click(sender, e);
						return true;
					case DialogResult.No:
						return true;
					default:
						return false;
				}
			}
			return true;
		}

		private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Help.ShowHelp(this, @"..\..\FIQ\FIQ.chm");
		}
	}
}
