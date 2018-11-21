namespace phoneBook
{
	partial class Form1
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxFName = new System.Windows.Forms.TextBox();
			this.textBoxLName = new System.Windows.Forms.TextBox();
			this.textBoxNumber = new System.Windows.Forms.TextBox();
			this.textBoxEmail = new System.Windows.Forms.TextBox();
			this.buttonAdd = new MetroFramework.Controls.MetroButton();
			this.buttonUpdate = new MetroFramework.Controls.MetroButton();
			this.buttonDelete = new MetroFramework.Controls.MetroButton();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.FNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NUMBER = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.textBoxSearch = new System.Windows.Forms.TextBox();
			this.buttonSearch = new MetroFramework.Controls.MetroButton();
			this.label6 = new System.Windows.Forms.Label();
			this.buttonAll = new MetroFramework.Controls.MetroButton();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(33, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(233, 42);
			this.label1.TabIndex = 0;
			this.label1.Text = "Phone Book";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(22, 119);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(106, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "First Name :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(22, 174);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(105, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Last Name :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(22, 230);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(137, 20);
			this.label4.TabIndex = 3;
			this.label4.Text = "Phone Number :";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(22, 290);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(63, 20);
			this.label5.TabIndex = 4;
			this.label5.Text = "Email :";
			// 
			// textBoxFName
			// 
			this.textBoxFName.Location = new System.Drawing.Point(213, 118);
			this.textBoxFName.Name = "textBoxFName";
			this.textBoxFName.Size = new System.Drawing.Size(179, 20);
			this.textBoxFName.TabIndex = 5;
			// 
			// textBoxLName
			// 
			this.textBoxLName.Location = new System.Drawing.Point(213, 173);
			this.textBoxLName.Name = "textBoxLName";
			this.textBoxLName.Size = new System.Drawing.Size(179, 20);
			this.textBoxLName.TabIndex = 6;
			// 
			// textBoxNumber
			// 
			this.textBoxNumber.Location = new System.Drawing.Point(213, 229);
			this.textBoxNumber.Name = "textBoxNumber";
			this.textBoxNumber.Size = new System.Drawing.Size(179, 20);
			this.textBoxNumber.TabIndex = 7;
			// 
			// textBoxEmail
			// 
			this.textBoxEmail.Location = new System.Drawing.Point(213, 289);
			this.textBoxEmail.Name = "textBoxEmail";
			this.textBoxEmail.Size = new System.Drawing.Size(179, 20);
			this.textBoxEmail.TabIndex = 8;
			// 
			// buttonAdd
			// 
			this.buttonAdd.FontSize = MetroFramework.MetroButtonSize.Medium;
			this.buttonAdd.Location = new System.Drawing.Point(26, 365);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(113, 62);
			this.buttonAdd.TabIndex = 9;
			this.buttonAdd.Text = "Add";
			this.buttonAdd.UseSelectable = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.FontSize = MetroFramework.MetroButtonSize.Medium;
			this.buttonUpdate.Location = new System.Drawing.Point(153, 365);
			this.buttonUpdate.Name = "buttonUpdate";
			this.buttonUpdate.Size = new System.Drawing.Size(113, 62);
			this.buttonUpdate.TabIndex = 10;
			this.buttonUpdate.Text = "Update";
			this.buttonUpdate.UseSelectable = true;
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// buttonDelete
			// 
			this.buttonDelete.FontSize = MetroFramework.MetroButtonSize.Medium;
			this.buttonDelete.Location = new System.Drawing.Point(279, 365);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(113, 62);
			this.buttonDelete.TabIndex = 11;
			this.buttonDelete.Text = "Delete";
			this.buttonDelete.UseSelectable = true;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FNAME,
            this.LNAME,
            this.NUMBER,
            this.EMAIL});
			this.dataGridView1.Location = new System.Drawing.Point(462, 118);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(475, 274);
			this.dataGridView1.TabIndex = 12;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
			// 
			// FNAME
			// 
			this.FNAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.FNAME.DataPropertyName = "FNAME";
			this.FNAME.HeaderText = "First Name";
			this.FNAME.Name = "FNAME";
			this.FNAME.ReadOnly = true;
			// 
			// LNAME
			// 
			this.LNAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.LNAME.DataPropertyName = "LNAME";
			this.LNAME.HeaderText = "Last Name";
			this.LNAME.Name = "LNAME";
			this.LNAME.ReadOnly = true;
			// 
			// NUMBER
			// 
			this.NUMBER.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.NUMBER.DataPropertyName = "NUMBER";
			this.NUMBER.HeaderText = "Phone Number";
			this.NUMBER.Name = "NUMBER";
			this.NUMBER.ReadOnly = true;
			// 
			// EMAIL
			// 
			this.EMAIL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.EMAIL.DataPropertyName = "EMAIL";
			this.EMAIL.HeaderText = "Email";
			this.EMAIL.Name = "EMAIL";
			this.EMAIL.ReadOnly = true;
			// 
			// textBoxSearch
			// 
			this.textBoxSearch.Location = new System.Drawing.Point(462, 79);
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.Size = new System.Drawing.Size(205, 20);
			this.textBoxSearch.TabIndex = 13;
			// 
			// buttonSearch
			// 
			this.buttonSearch.FontSize = MetroFramework.MetroButtonSize.Medium;
			this.buttonSearch.Location = new System.Drawing.Point(682, 79);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(113, 20);
			this.buttonSearch.TabIndex = 14;
			this.buttonSearch.Text = "Search";
			this.buttonSearch.UseSelectable = true;
			this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(459, 411);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(198, 16);
			this.label6.TabIndex = 15;
			this.label6.Text = "(* Select Data To Edit or Delete)";
			// 
			// buttonAll
			// 
			this.buttonAll.FontSize = MetroFramework.MetroButtonSize.Medium;
			this.buttonAll.Location = new System.Drawing.Point(824, 79);
			this.buttonAll.Name = "buttonAll";
			this.buttonAll.Size = new System.Drawing.Size(113, 20);
			this.buttonAll.TabIndex = 16;
			this.buttonAll.Text = "All Data";
			this.buttonAll.UseSelectable = true;
			this.buttonAll.Click += new System.EventHandler(this.buttonAll_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(949, 478);
			this.Controls.Add(this.buttonAll);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.buttonSearch);
			this.Controls.Add(this.textBoxSearch);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonUpdate);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.textBoxEmail);
			this.Controls.Add(this.textBoxNumber);
			this.Controls.Add(this.textBoxLName);
			this.Controls.Add(this.textBoxFName);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "Phone Book";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxFName;
		private System.Windows.Forms.TextBox textBoxLName;
		private System.Windows.Forms.TextBox textBoxNumber;
		private System.Windows.Forms.TextBox textBoxEmail;
		private MetroFramework.Controls.MetroButton buttonAdd;
		private MetroFramework.Controls.MetroButton buttonUpdate;
		private MetroFramework.Controls.MetroButton buttonDelete;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn FNAME;
		private System.Windows.Forms.DataGridViewTextBoxColumn LNAME;
		private System.Windows.Forms.DataGridViewTextBoxColumn NUMBER;
		private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
		private System.Windows.Forms.TextBox textBoxSearch;
		private MetroFramework.Controls.MetroButton buttonSearch;
		private System.Windows.Forms.Label label6;
		private MetroFramework.Controls.MetroButton buttonAll;
	}
}

