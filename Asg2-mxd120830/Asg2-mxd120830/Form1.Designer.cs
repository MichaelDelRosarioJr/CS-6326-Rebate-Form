namespace Asg2_mxd120830
{
    partial class main
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
            this.clearButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.firstNBox = new System.Windows.Forms.TextBox();
            this.LastNBox = new System.Windows.Forms.TextBox();
            this.middleIBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.firstLabel = new System.Windows.Forms.Label();
            this.MILabel = new System.Windows.Forms.Label();
            this.lastLabel = new System.Windows.Forms.Label();
            this.address1Box = new System.Windows.Forms.TextBox();
            this.address2Box = new System.Windows.Forms.TextBox();
            this.addr1Label = new System.Windows.Forms.Label();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.stateBox = new System.Windows.Forms.TextBox();
            this.zipBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.zipLabel = new System.Windows.Forms.Label();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.receivedBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateBox = new System.Windows.Forms.DateTimePicker();
            this.dateEntryPanel = new System.Windows.Forms.Panel();
            this.Customer_List = new System.Windows.Forms.ListView();
            this.n = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateEntryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(338, 477);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(94, 34);
            this.clearButton.TabIndex = 14;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(196, 477);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(94, 34);
            this.deleteButton.TabIndex = 16;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(54, 477);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(94, 34);
            this.saveButton.TabIndex = 17;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // firstNBox
            // 
            this.firstNBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNBox.Location = new System.Drawing.Point(10, 50);
            this.firstNBox.MaxLength = 20;
            this.firstNBox.Name = "firstNBox";
            this.firstNBox.Size = new System.Drawing.Size(168, 28);
            this.firstNBox.TabIndex = 0;
            this.firstNBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LastNBox
            // 
            this.LastNBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNBox.Location = new System.Drawing.Point(306, 50);
            this.LastNBox.MaxLength = 20;
            this.LastNBox.Name = "LastNBox";
            this.LastNBox.Size = new System.Drawing.Size(168, 28);
            this.LastNBox.TabIndex = 2;
            this.LastNBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // middleIBox
            // 
            this.middleIBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middleIBox.Location = new System.Drawing.Point(223, 50);
            this.middleIBox.MaxLength = 1;
            this.middleIBox.Name = "middleIBox";
            this.middleIBox.Size = new System.Drawing.Size(38, 28);
            this.middleIBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(212, 3);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(61, 24);
            this.nameLabel.TabIndex = 19;
            this.nameLabel.Text = "Name";
            this.nameLabel.Click += new System.EventHandler(this.nameLabel_Click);
            // 
            // firstLabel
            // 
            this.firstLabel.AutoSize = true;
            this.firstLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstLabel.Location = new System.Drawing.Point(69, 23);
            this.firstLabel.Name = "firstLabel";
            this.firstLabel.Size = new System.Drawing.Size(52, 24);
            this.firstLabel.TabIndex = 20;
            this.firstLabel.Text = "First*";
            // 
            // MILabel
            // 
            this.MILabel.AutoSize = true;
            this.MILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MILabel.Location = new System.Drawing.Point(227, 23);
            this.MILabel.Name = "MILabel";
            this.MILabel.Size = new System.Drawing.Size(30, 24);
            this.MILabel.TabIndex = 21;
            this.MILabel.Text = "MI";
            this.MILabel.Click += new System.EventHandler(this.MILabel_Click);
            // 
            // lastLabel
            // 
            this.lastLabel.AutoSize = true;
            this.lastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastLabel.Location = new System.Drawing.Point(366, 23);
            this.lastLabel.Name = "lastLabel";
            this.lastLabel.Size = new System.Drawing.Size(50, 24);
            this.lastLabel.TabIndex = 22;
            this.lastLabel.Text = "Last*";
            // 
            // address1Box
            // 
            this.address1Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address1Box.Location = new System.Drawing.Point(11, 118);
            this.address1Box.MaxLength = 35;
            this.address1Box.Name = "address1Box";
            this.address1Box.Size = new System.Drawing.Size(464, 28);
            this.address1Box.TabIndex = 3;
            this.address1Box.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // address2Box
            // 
            this.address2Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address2Box.Location = new System.Drawing.Point(10, 152);
            this.address2Box.MaxLength = 35;
            this.address2Box.Name = "address2Box";
            this.address2Box.Size = new System.Drawing.Size(464, 28);
            this.address2Box.TabIndex = 4;
            // 
            // addr1Label
            // 
            this.addr1Label.AutoSize = true;
            this.addr1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addr1Label.Location = new System.Drawing.Point(211, 84);
            this.addr1Label.Name = "addr1Label";
            this.addr1Label.Size = new System.Drawing.Size(87, 24);
            this.addr1Label.TabIndex = 24;
            this.addr1Label.Text = "Address*";
            // 
            // cityBox
            // 
            this.cityBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityBox.Location = new System.Drawing.Point(11, 210);
            this.cityBox.MaxLength = 25;
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(220, 28);
            this.cityBox.TabIndex = 5;
            this.cityBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // stateBox
            // 
            this.stateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateBox.Location = new System.Drawing.Point(259, 210);
            this.stateBox.MaxLength = 2;
            this.stateBox.Name = "stateBox";
            this.stateBox.Size = new System.Drawing.Size(60, 28);
            this.stateBox.TabIndex = 6;
            this.stateBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // zipBox
            // 
            this.zipBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipBox.Location = new System.Drawing.Point(347, 210);
            this.zipBox.MaxLength = 9;
            this.zipBox.Name = "zipBox";
            this.zipBox.Size = new System.Drawing.Size(126, 28);
            this.zipBox.TabIndex = 7;
            this.zipBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.Location = new System.Drawing.Point(101, 183);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(47, 24);
            this.cityLabel.TabIndex = 25;
            this.cityLabel.Text = "City*";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateLabel.Location = new System.Drawing.Point(261, 183);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(58, 24);
            this.stateLabel.TabIndex = 26;
            this.stateLabel.Text = "State*";
            this.stateLabel.Click += new System.EventHandler(this.stateLabel_Click);
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipLabel.Location = new System.Drawing.Point(368, 183);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(95, 24);
            this.zipLabel.TabIndex = 27;
            this.zipLabel.Text = "Zip Code*";
            // 
            // phoneBox
            // 
            this.phoneBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneBox.Location = new System.Drawing.Point(132, 266);
            this.phoneBox.MaxLength = 21;
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(220, 28);
            this.phoneBox.TabIndex = 10;
            this.phoneBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(206, 242);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(73, 24);
            this.phoneLabel.TabIndex = 28;
            this.phoneLabel.Text = "Phone*";
            // 
            // emailBox
            // 
            this.emailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBox.Location = new System.Drawing.Point(10, 327);
            this.emailBox.MaxLength = 60;
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(464, 28);
            this.emailBox.TabIndex = 11;
            this.emailBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(173, 297);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(139, 24);
            this.emailLabel.TabIndex = 29;
            this.emailLabel.Text = "Email Address*";
            // 
            // receivedBox
            // 
            this.receivedBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receivedBox.Location = new System.Drawing.Point(348, 380);
            this.receivedBox.MaxLength = 1;
            this.receivedBox.Name = "receivedBox";
            this.receivedBox.Size = new System.Drawing.Size(25, 28);
            this.receivedBox.TabIndex = 12;
            this.receivedBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 24);
            this.label1.TabIndex = 30;
            this.label1.Text = "Proof of Purchase Attatched (Y/N)*";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(16, 431);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(140, 24);
            this.dateLabel.TabIndex = 31;
            this.dateLabel.Text = "Date Received*";
            this.dateLabel.Click += new System.EventHandler(this.dateLabel_Click);
            // 
            // dateBox
            // 
            this.dateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateBox.Location = new System.Drawing.Point(171, 427);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(292, 28);
            this.dateBox.TabIndex = 13;
            this.dateBox.ValueChanged += new System.EventHandler(this.dateBox_ValueChanged);
            // 
            // dateEntryPanel
            // 
            this.dateEntryPanel.Controls.Add(this.dateBox);
            this.dateEntryPanel.Controls.Add(this.saveButton);
            this.dateEntryPanel.Controls.Add(this.deleteButton);
            this.dateEntryPanel.Controls.Add(this.clearButton);
            this.dateEntryPanel.Controls.Add(this.dateLabel);
            this.dateEntryPanel.Controls.Add(this.label1);
            this.dateEntryPanel.Controls.Add(this.receivedBox);
            this.dateEntryPanel.Controls.Add(this.emailLabel);
            this.dateEntryPanel.Controls.Add(this.emailBox);
            this.dateEntryPanel.Controls.Add(this.phoneLabel);
            this.dateEntryPanel.Controls.Add(this.phoneBox);
            this.dateEntryPanel.Controls.Add(this.zipLabel);
            this.dateEntryPanel.Controls.Add(this.stateLabel);
            this.dateEntryPanel.Controls.Add(this.cityLabel);
            this.dateEntryPanel.Controls.Add(this.zipBox);
            this.dateEntryPanel.Controls.Add(this.stateBox);
            this.dateEntryPanel.Controls.Add(this.cityBox);
            this.dateEntryPanel.Controls.Add(this.addr1Label);
            this.dateEntryPanel.Controls.Add(this.address2Box);
            this.dateEntryPanel.Controls.Add(this.address1Box);
            this.dateEntryPanel.Controls.Add(this.lastLabel);
            this.dateEntryPanel.Controls.Add(this.MILabel);
            this.dateEntryPanel.Controls.Add(this.firstLabel);
            this.dateEntryPanel.Controls.Add(this.nameLabel);
            this.dateEntryPanel.Controls.Add(this.middleIBox);
            this.dateEntryPanel.Controls.Add(this.LastNBox);
            this.dateEntryPanel.Controls.Add(this.firstNBox);
            this.dateEntryPanel.Location = new System.Drawing.Point(1, 9);
            this.dateEntryPanel.Name = "dateEntryPanel";
            this.dateEntryPanel.Size = new System.Drawing.Size(501, 534);
            this.dateEntryPanel.TabIndex = 32;
            // 
            // Customer_List
            // 
            this.Customer_List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.n,
            this.Phone});
            this.Customer_List.Location = new System.Drawing.Point(530, 12);
            this.Customer_List.Name = "Customer_List";
            this.Customer_List.Size = new System.Drawing.Size(440, 531);
            this.Customer_List.TabIndex = 33;
            this.Customer_List.UseCompatibleStateImageBehavior = false;
            this.Customer_List.View = System.Windows.Forms.View.Details;
            this.Customer_List.SelectedIndexChanged += new System.EventHandler(this.Customer_List_SelectedIndexChanged_1);
            // 
            // n
            // 
            this.n.Text = "Name";
            this.n.Width = 223;
            // 
            // Phone
            // 
            this.Phone.Text = "Phone";
            this.Phone.Width = 155;
            // 
            // main
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 555);
            this.Controls.Add(this.Customer_List);
            this.Controls.Add(this.dateEntryPanel);
            this.Name = "main";
            this.Text = "Rebate Applications";
            this.dateEntryPanel.ResumeLayout(false);
            this.dateEntryPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox firstNBox;
        private System.Windows.Forms.TextBox LastNBox;
        private System.Windows.Forms.TextBox middleIBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label firstLabel;
        private System.Windows.Forms.Label MILabel;
        private System.Windows.Forms.Label lastLabel;
        private System.Windows.Forms.TextBox address1Box;
        private System.Windows.Forms.TextBox address2Box;
        private System.Windows.Forms.Label addr1Label;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.TextBox stateBox;
        private System.Windows.Forms.TextBox zipBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox receivedBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DateTimePicker dateBox;
        private System.Windows.Forms.Panel dateEntryPanel;
        private System.Windows.Forms.ListView Customer_List;
        private System.Windows.Forms.ColumnHeader n;
        private System.Windows.Forms.ColumnHeader Phone;
    }
}

