using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarachiBoard
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			if (textBox1.Text != "")
			{
				int obtainedMarks = (int.Parse(textBox1.Text) * 100) / 850;
				//label3.Text = String.Format(obtainedMarks.ToString());
				if (int.Parse(textBox1.Text) <= 850)
				{
					if (obtainedMarks >= 80)
					{
						label5.Text = "A-one";
						label6.Text = "YOU'VE PASSED!";
					}
					else if (obtainedMarks >= 70 && obtainedMarks < 80)
					{
						label5.Text = "A";
						label6.Text = "YOU'VE PASSED!";
					}
					else if (obtainedMarks >= 60 && obtainedMarks < 70)
					{
						label5.Text = "B";
						label6.Text = "YOU'VE PASSED!";
					}
					else if (obtainedMarks >= 50 && obtainedMarks < 60)
					{
						label5.Text = "C";
						label6.Text = "YOU'VE PASSED!";
					}
					else if (obtainedMarks >= 40 && obtainedMarks < 50)
					{
						label5.Text = "D";
						label6.Text = "YOU'VE PASSED!";
					}
					else if (obtainedMarks >= 33 && obtainedMarks < 40)
					{
						label5.Text = "E";
						label6.Text = "YOU'VE PASSED!";
					}
					else
					{
						label5.Text = "F";
						label6.Text = "NOT PASS";
					}

					label3.Text = textBox1.Text + " / 850";
					label8.Text = obtainedMarks.ToString() + "%";
				}
				else
				{
					MessageBox.Show("Enter below 1100", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Enter Obtained Marks", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		

		private void Button2_Click(object sender, EventArgs e)
		{
			if (textBox2.Text != "")
			{
				int obtainedMarks = (int.Parse(textBox2.Text) * 100) / 1100;
				//label3.Text = String.Format(obtainedMarks.ToString());
				if (int.Parse(textBox2.Text) <= 1100)
				{
					if (obtainedMarks >= 80)
					{
						label12.Text = "A-one";
						label11.Text = "YOU'VE PASSED!";
					}
					else if (obtainedMarks >= 70 && obtainedMarks < 80)
					{
						label12.Text = "A";
						label11.Text = "YOU'VE PASSED!";
					}
					else if (obtainedMarks >= 60 && obtainedMarks < 70)
					{
						label12.Text = "B";
						label11.Text = "YOU'VE PASSED!";
					}
					else if (obtainedMarks >= 50 && obtainedMarks < 60)
					{
						label12.Text = "C";
						label11.Text = "YOU'VE PASSED!";
					}
					else if (obtainedMarks >= 40 && obtainedMarks < 50)
					{
						label12.Text = "D";
						label11.Text = "YOU'VE PASSED!";
					}
					else if (obtainedMarks >= 33 && obtainedMarks < 40)
					{
						label12.Text = "E";
						label11.Text = "YOU'VE PASSED!";
					}
					else
					{
						label12.Text = "F";
						label11.Text = "NOT PASS";
					}

					label14.Text = textBox2.Text + " / 1100";
					label9.Text = obtainedMarks.ToString() + "%";
				}
				else
				{
					MessageBox.Show("Enter below 1100", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Enter Obtained Marks", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void TabPage1_Click(object sender, EventArgs e)
		{

		}

		private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			Char chr = e.KeyChar;
			if (!Char.IsDigit(chr) && chr != 8)
			{
				e.Handled = true;
				MessageBox.Show("Enter only numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
		}

		private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
		{
			Char chr = e.KeyChar;
			if (!Char.IsDigit(chr) && chr != 8)
			{
				e.Handled = true;
				MessageBox.Show("Enter only numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
		}

		private void Button3_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void TabPage2_Click(object sender, EventArgs e)
		{

		}

		private void Button4_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
