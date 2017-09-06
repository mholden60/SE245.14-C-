namespace midTerm
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
            this.fName = new System.Windows.Forms.TextBox();
            this.empID = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.lblfeedback = new System.Windows.Forms.Label();
            this.dTime2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dTime1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblPerson_ID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comment = new System.Windows.Forms.TextBox();
            this.states = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vacation Schedule";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Emplyee ID (4 Digits)";
            // 
            // fName
            // 
            this.fName.Location = new System.Drawing.Point(29, 119);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(100, 22);
            this.fName.TabIndex = 1;
            // 
            // empID
            // 
            this.empID.Location = new System.Drawing.Point(29, 219);
            this.empID.MaxLength = 4;
            this.empID.Name = "empID";
            this.empID.Size = new System.Drawing.Size(100, 22);
            this.empID.TabIndex = 3;
            this.empID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.empID_KeyPress);
            // 
            // lName
            // 
            this.lName.Location = new System.Drawing.Point(29, 164);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(100, 22);
            this.lName.TabIndex = 2;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(29, 271);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 7;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // lblfeedback
            // 
            this.lblfeedback.AutoSize = true;
            this.lblfeedback.Location = new System.Drawing.Point(202, 248);
            this.lblfeedback.Name = "lblfeedback";
            this.lblfeedback.Size = new System.Drawing.Size(74, 17);
            this.lblfeedback.TabIndex = 12;
            this.lblfeedback.Text = "Feedback:";
            // 
            // dTime2
            // 
            this.dTime2.AllowDrop = true;
            this.dTime2.CustomFormat = "MMM d, yy hh:mm";
            this.dTime2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTime2.Location = new System.Drawing.Point(16, 85);
            this.dTime2.MaxDate = new System.DateTime(2016, 12, 25, 23, 59, 0, 0);
            this.dTime2.MinDate = new System.DateTime(2016, 4, 28, 0, 0, 0, 0);
            this.dTime2.Name = "dTime2";
            this.dTime2.Size = new System.Drawing.Size(328, 22);
            this.dTime2.TabIndex = 6;
            this.dTime2.ValueChanged += new System.EventHandler(this.dTime2_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Departure";
            // 
            // dTime1
            // 
            this.dTime1.AllowDrop = true;
            this.dTime1.CustomFormat = "MMM d, yy hh:mm";
            this.dTime1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTime1.Location = new System.Drawing.Point(16, 38);
            this.dTime1.MaxDate = new System.DateTime(2016, 12, 31, 0, 0, 0, 0);
            this.dTime1.MinDate = new System.DateTime(2016, 4, 28, 0, 0, 0, 0);
            this.dTime1.Name = "dTime1";
            this.dTime1.Size = new System.Drawing.Size(328, 22);
            this.dTime1.TabIndex = 5;
            this.dTime1.ValueChanged += new System.EventHandler(this.dTime1_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Return";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dTime2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dTime1);
            this.groupBox1.Location = new System.Drawing.Point(205, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 128);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Flight";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(29, 329);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 32;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(29, 300);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 31;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblPerson_ID
            // 
            this.lblPerson_ID.AutoSize = true;
            this.lblPerson_ID.Location = new System.Drawing.Point(202, 224);
            this.lblPerson_ID.Name = "lblPerson_ID";
            this.lblPerson_ID.Size = new System.Drawing.Size(88, 17);
            this.lblPerson_ID.TabIndex = 33;
            this.lblPerson_ID.Text = "lblPerson_ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(201, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "States";
            // 
            // comment
            // 
            this.comment.Location = new System.Drawing.Point(385, 271);
            this.comment.Multiline = true;
            this.comment.Name = "comment";
            this.comment.Size = new System.Drawing.Size(239, 112);
            this.comment.TabIndex = 34;
            this.comment.TextChanged += new System.EventHandler(this.comment_TextChanged);
            // 
            // states
            // 
            this.states.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.states.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.states.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.states.DisplayMember = "Alabama";
            this.states.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.states.FormattingEnabled = true;
            this.states.IntegralHeight = false;
            this.states.ItemHeight = 16;
            this.states.Location = new System.Drawing.Point(248, 271);
            this.states.MaxDropDownItems = 5;
            this.states.Name = "states";
            this.states.Size = new System.Drawing.Size(131, 24);
            this.states.TabIndex = 35;
            this.states.Tag = "";
            this.states.UseWaitCursor = true;
            this.states.SelectedIndexChanged += new System.EventHandler(this.state_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 393);
            this.Controls.Add(this.states);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comment);
            this.Controls.Add(this.lblPerson_ID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblfeedback);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.empID);
            this.Controls.Add(this.fName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fName;
        private System.Windows.Forms.TextBox empID;
        private System.Windows.Forms.TextBox lName;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label lblfeedback;
        private System.Windows.Forms.DateTimePicker dTime2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dTime1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblPerson_ID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox comment;
        private System.Windows.Forms.ComboBox states;
    }
}

