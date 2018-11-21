using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phoneBook
{
	public partial class Form1 : Form
	{
		DataTable dataShow;
		public Form1()
		{
			InitializeComponent();
			dataGridView1.AutoGenerateColumns = false;
			dataShow = DataAccess.Execute("SELECT * FROM PHONENUMBER");
			dataGridView1.DataSource = dataShow;
		}
		public void clear()
		{
			textBoxFName.Text = "";
			textBoxLName.Text = "";
			textBoxNumber.Text = "";
			textBoxEmail.Text = "";
		}
		private void buttonAdd_Click(object sender, EventArgs e)
		{
			int checkNumber;
			string number= textBoxNumber.Text;
			string email;
			if (textBoxFName.Text == "" || textBoxNumber.Text == "")
			{
				MessageBox.Show("Invalid Contact");
				clear();
			}
			else
			{


				if (textBoxEmail.Text=="")
				{
					email = null;
				}
				else if (textBoxEmail.Text.Contains('@'))
				{
					if (textBoxEmail.Text.Contains('.'))
					{
						email = textBoxEmail.Text;
					}
					else
					{
						MessageBox.Show("Invalid Mail Address");
						clear();
						return;
					}
				}
				else
				{
					MessageBox.Show("Invalid Mail Address");
					clear();
					return;
				}

				number = textBoxNumber.Text;
				if (! int.TryParse(number, out checkNumber))
				{
					if (number[0]=='+')
					{
						number = number.Replace('+','0');
						if (number.Contains('-'))
						{
							number = number.Replace("-", string.Empty);
						}
						if(!int.TryParse(number, out checkNumber))
						{
							MessageBox.Show("Invalid Number");
							clear();
							return;
						}
					}
					else
					{
						MessageBox.Show("Invalid Number");
						clear();
						return;
					}
				}
				else
				{
					number = textBoxNumber.Text;
				}
				dataShow = DataAccess.Execute("SELECT * FROM PHONENUMBER WHERE NUMBER = '" + number + "'");
				if (dataShow.Rows.Count != 0 )
				{
					MessageBox.Show("Contact Already Exists");
					clear();
					return;
				}
				DataAccess.ExecuteNonQuery("INSERT INTO PHONENUMBER (FNAME,LNAME,NUMBER,EMAIL) VALUES('" + textBoxFName.Text + "','" + textBoxLName.Text + "','" + number + "','" + email + "')");
				MessageBox.Show("Contact Added");
				clear();
				dataShow = DataAccess.Execute("SELECT * FROM PHONENUMBER");
				dataGridView1.DataSource = dataShow;
			}
		}

		private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex>=0) {
				DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
				textBoxFName.Text = row.Cells["FNAME"].Value.ToString();
				textBoxLName.Text = row.Cells["LNAME"].Value.ToString();
				textBoxNumber.Text = row.Cells["NUMBER"].Value.ToString();
				textBoxEmail.Text = row.Cells["EMAIL"].Value.ToString();
			}
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			int checkNumber;
			string number = textBoxNumber.Text;
			string email;
			if (textBoxFName.Text == "" || textBoxNumber.Text == "")
			{
				MessageBox.Show("Invalid Contact");
				clear();
			}
			else
			{
				if (textBoxEmail.Text == "")
				{
					email = null;
				}
				else if (textBoxEmail.Text.Contains('@'))
				{
					if (textBoxEmail.Text.Contains('.'))
					{
						email = textBoxEmail.Text;
					}
					else
					{
						MessageBox.Show("Invalid Mail Address");
						clear();
						return;
					}
				}
				else
				{
					MessageBox.Show("Invalid Mail Address");
					clear();
					return;
				}
				number = textBoxNumber.Text;
				if (!int.TryParse(number, out checkNumber))
				{
					if (number[0] == '+')
					{
						number = number.Replace('+', '0');
						if (number.Contains('-'))
						{
							number = number.Replace("-", string.Empty);
						}
						if (!int.TryParse(number, out checkNumber))
						{
							MessageBox.Show("Invalid Number");
							clear();
							return;
						}
					}
					else
					{
						MessageBox.Show("Invalid Number");
						clear();
						return;
					}
				}
				else
				{
					number = textBoxNumber.Text;
				}
				dataShow = DataAccess.Execute("SELECT * FROM PHONENUMBER WHERE NUMBER = '" + number + "'");
				if (dataShow.Rows.Count != 0)
				{
					DataAccess.ExecuteNonQuery("UPDATE PHONENUMBER SET FNAME='" + this.textBoxFName.Text + "',LNAME='" + this.textBoxLName.Text + "',NUMBER='" + this.textBoxNumber.Text + "',EMAIL='" + this.textBoxEmail.Text + "' WHERE  NUMBER='" + this.textBoxNumber.Text +"'");
					MessageBox.Show("Contact Updated");
					clear();
					dataShow = DataAccess.Execute("SELECT * FROM PHONENUMBER");
					dataGridView1.DataSource = dataShow;
				}
				else
				{
					DataAccess.ExecuteNonQuery("INSERT INTO PHONENUMBER (FNAME,LNAME,NUMBER,EMAIL) VALUES('" + textBoxFName.Text + "','" + textBoxLName.Text + "','" + number + "','" + email + "')");
					MessageBox.Show("Contact Added");
					clear();
					dataShow = DataAccess.Execute("SELECT * FROM PHONENUMBER");
					dataGridView1.DataSource = dataShow;
				}
			}
		}
		private void buttonDelete_Click(object sender, EventArgs e)
		{
			if (this.textBoxNumber.Text == "")
			{
				MessageBox.Show("Nothing To Delete");
				return;
			}
			else
			{
				DataAccess.ExecuteNonQuery("DELETE FROM PHONENUMBER WHERE NUMBER='"+this.textBoxNumber.Text+"'");
				MessageBox.Show("Contact Deleted");
				clear();
				dataShow = DataAccess.Execute("SELECT * FROM PHONENUMBER");
				dataGridView1.DataSource = dataShow;
			}
		}

		private void buttonSearch_Click(object sender, EventArgs e)
		{
			int checkNumber;
			if (int.TryParse(textBoxSearch.Text, out checkNumber)) {
				dataShow = DataAccess.Execute("SELECT * FROM PHONENUMBER WHERE NUMBER = '" + textBoxSearch.Text + "'");
				dataGridView1.DataSource = dataShow;
			}
			else
			{
				dataShow = DataAccess.Execute("SELECT * FROM PHONENUMBER WHERE FNAME = '" + textBoxSearch.Text + "' OR LNAME= '" + textBoxSearch.Text + "'");
				dataGridView1.DataSource = dataShow;
			}
		}

		private void buttonAll_Click(object sender, EventArgs e)
		{
			dataShow = DataAccess.Execute("SELECT * FROM PHONENUMBER");
			dataGridView1.DataSource = dataShow;
		}
	}
}
