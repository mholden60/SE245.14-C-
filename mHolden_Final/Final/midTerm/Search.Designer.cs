namespace midTerm
{
    partial class Search
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
            this.txtfName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gvResults = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtlName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comment = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.states = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // txtfName
            // 
            this.txtfName.Location = new System.Drawing.Point(98, 25);
            this.txtfName.Name = "txtfName";
            this.txtfName.Size = new System.Drawing.Size(135, 22);
            this.txtfName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name:";
            // 
            // gvResults
            // 
            this.gvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvResults.Location = new System.Drawing.Point(239, 25);
            this.gvResults.Name = "gvResults";
            this.gvResults.Size = new System.Drawing.Size(280, 218);
            this.gvResults.TabIndex = 2;
            this.gvResults.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvResults_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Name:";
            // 
            // txtlName
            // 
            this.txtlName.Location = new System.Drawing.Point(98, 50);
            this.txtlName.Name = "txtlName";
            this.txtlName.Size = new System.Drawing.Size(135, 22);
            this.txtlName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Emp ID:";
            // 
            // txtEmpID
            // 
            this.txtEmpID.Location = new System.Drawing.Point(98, 75);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(135, 22);
            this.txtEmpID.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(98, 177);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Comment:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // comment
            // 
            this.comment.Location = new System.Drawing.Point(98, 102);
            this.comment.Name = "comment";
            this.comment.Size = new System.Drawing.Size(135, 22);
            this.comment.TabIndex = 8;
            this.comment.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 38;
            this.label7.Text = "States:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
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
            this.states.Location = new System.Drawing.Point(98, 130);
            this.states.MaxDropDownItems = 5;
            this.states.Name = "states";
            this.states.Size = new System.Drawing.Size(131, 24);
            this.states.TabIndex = 37;
            this.states.Tag = "";
            this.states.UseWaitCursor = true;
            this.states.SelectedIndexChanged += new System.EventHandler(this.state_SelectedIndexChanged);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 255);
            this.Controls.Add(this.states);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comment);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtlName);
            this.Controls.Add(this.gvResults);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtfName);
            this.Name = "Search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtfName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvResults;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtlName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox comment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox states;
    }
}