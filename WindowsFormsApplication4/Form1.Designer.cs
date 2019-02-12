namespace WindowsFormsApplication4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbdrive = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbcrfolder = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtfolder = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbfile = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtfile = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbfileext = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdata = new System.Windows.Forms.RichTextBox();
            this.btncreatefolder = new System.Windows.Forms.Button();
            this.btndlfolder = new System.Windows.Forms.Button();
            this.btncrfile = new System.Windows.Forms.Button();
            this.btndlfile = new System.Windows.Forms.Button();
            this.btnread = new System.Windows.Forms.Button();
            this.btnwrite = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnsystem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Drive:";
            // 
            // cmbdrive
            // 
            this.cmbdrive.FormattingEnabled = true;
            this.cmbdrive.Location = new System.Drawing.Point(153, 24);
            this.cmbdrive.Name = "cmbdrive";
            this.cmbdrive.Size = new System.Drawing.Size(248, 21);
            this.cmbdrive.TabIndex = 1;
            this.cmbdrive.SelectedIndexChanged += new System.EventHandler(this.cmbdrive_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Folder:";
            // 
            // cmbcrfolder
            // 
            this.cmbcrfolder.FormattingEnabled = true;
            this.cmbcrfolder.Location = new System.Drawing.Point(153, 69);
            this.cmbcrfolder.Name = "cmbcrfolder";
            this.cmbcrfolder.Size = new System.Drawing.Size(137, 21);
            this.cmbcrfolder.TabIndex = 3;
            this.cmbcrfolder.SelectedIndexChanged += new System.EventHandler(this.cmbcrfolder_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(305, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter Folder Name:";
            // 
            // txtfolder
            // 
            this.txtfolder.Location = new System.Drawing.Point(495, 68);
            this.txtfolder.Name = "txtfolder";
            this.txtfolder.Size = new System.Drawing.Size(144, 20);
            this.txtfolder.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Select File:";
            // 
            // cmbfile
            // 
            this.cmbfile.FormattingEnabled = true;
            this.cmbfile.Location = new System.Drawing.Point(153, 106);
            this.cmbfile.Name = "cmbfile";
            this.cmbfile.Size = new System.Drawing.Size(137, 21);
            this.cmbfile.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(305, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Enter File Name:";
            // 
            // txtfile
            // 
            this.txtfile.Location = new System.Drawing.Point(471, 106);
            this.txtfile.Name = "txtfile";
            this.txtfile.Size = new System.Drawing.Size(144, 20);
            this.txtfile.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(284, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Select File Extension:";
            // 
            // cmbfileext
            // 
            this.cmbfileext.FormattingEnabled = true;
            this.cmbfileext.Items.AddRange(new object[] {
            ".txt",
            ".docx",
            ".html"});
            this.cmbfileext.Location = new System.Drawing.Point(508, 143);
            this.cmbfileext.Name = "cmbfileext";
            this.cmbfileext.Size = new System.Drawing.Size(87, 21);
            this.cmbfileext.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 22);
            this.label7.TabIndex = 12;
            this.label7.Text = "Data of File:";
            // 
            // txtdata
            // 
            this.txtdata.Location = new System.Drawing.Point(16, 200);
            this.txtdata.Name = "txtdata";
            this.txtdata.Size = new System.Drawing.Size(579, 156);
            this.txtdata.TabIndex = 13;
            this.txtdata.Text = "";
            // 
            // btncreatefolder
            // 
            this.btncreatefolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncreatefolder.Location = new System.Drawing.Point(16, 362);
            this.btncreatefolder.Name = "btncreatefolder";
            this.btncreatefolder.Size = new System.Drawing.Size(121, 37);
            this.btncreatefolder.TabIndex = 14;
            this.btncreatefolder.Text = "CreateFolder";
            this.btncreatefolder.UseVisualStyleBackColor = true;
            this.btncreatefolder.Click += new System.EventHandler(this.btncreatefolder_Click);
            // 
            // btndlfolder
            // 
            this.btndlfolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndlfolder.Location = new System.Drawing.Point(153, 362);
            this.btndlfolder.Name = "btndlfolder";
            this.btndlfolder.Size = new System.Drawing.Size(121, 37);
            this.btndlfolder.TabIndex = 15;
            this.btndlfolder.Text = "DeleteFolder";
            this.btndlfolder.UseVisualStyleBackColor = true;
            this.btndlfolder.Click += new System.EventHandler(this.btndlfolder_Click);
            // 
            // btncrfile
            // 
            this.btncrfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncrfile.Location = new System.Drawing.Point(282, 362);
            this.btncrfile.Name = "btncrfile";
            this.btncrfile.Size = new System.Drawing.Size(121, 37);
            this.btncrfile.TabIndex = 16;
            this.btncrfile.Text = "CreateFile";
            this.btncrfile.UseVisualStyleBackColor = true;
            this.btncrfile.Click += new System.EventHandler(this.btncrfile_Click);
            // 
            // btndlfile
            // 
            this.btndlfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndlfile.Location = new System.Drawing.Point(409, 362);
            this.btndlfile.Name = "btndlfile";
            this.btndlfile.Size = new System.Drawing.Size(121, 37);
            this.btndlfile.TabIndex = 17;
            this.btndlfile.Text = "DeleteFile";
            this.btndlfile.UseVisualStyleBackColor = true;
            this.btndlfile.Click += new System.EventHandler(this.btndlfile_Click);
            // 
            // btnread
            // 
            this.btnread.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnread.Location = new System.Drawing.Point(547, 362);
            this.btnread.Name = "btnread";
            this.btnread.Size = new System.Drawing.Size(79, 37);
            this.btnread.TabIndex = 18;
            this.btnread.Text = "Read";
            this.btnread.UseVisualStyleBackColor = true;
            this.btnread.Click += new System.EventHandler(this.btnread_Click);
            // 
            // btnwrite
            // 
            this.btnwrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnwrite.Location = new System.Drawing.Point(83, 425);
            this.btnwrite.Name = "btnwrite";
            this.btnwrite.Size = new System.Drawing.Size(81, 37);
            this.btnwrite.TabIndex = 19;
            this.btnwrite.Text = "Write";
            this.btnwrite.UseVisualStyleBackColor = true;
            this.btnwrite.Click += new System.EventHandler(this.btnwrite_Click);
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(191, 425);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(99, 37);
            this.btnclose.TabIndex = 20;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnsystem
            // 
            this.btnsystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsystem.Location = new System.Drawing.Point(309, 425);
            this.btnsystem.Name = "btnsystem";
            this.btnsystem.Size = new System.Drawing.Size(95, 37);
            this.btnsystem.TabIndex = 21;
            this.btnsystem.Text = "System";
            this.btnsystem.UseVisualStyleBackColor = true;
            this.btnsystem.Click += new System.EventHandler(this.button8_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(431, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 37);
            this.button1.TabIndex = 22;
            this.button1.Text = "Help";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(651, 469);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnsystem);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnwrite);
            this.Controls.Add(this.btnread);
            this.Controls.Add(this.btndlfile);
            this.Controls.Add(this.btncrfile);
            this.Controls.Add(this.btndlfolder);
            this.Controls.Add(this.btncreatefolder);
            this.Controls.Add(this.txtdata);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbfileext);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtfile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbfile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtfolder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbcrfolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbdrive);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbdrive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbcrfolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtfolder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbfile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtfile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbfileext;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txtdata;
        private System.Windows.Forms.Button btncreatefolder;
        private System.Windows.Forms.Button btndlfolder;
        private System.Windows.Forms.Button btncrfile;
        private System.Windows.Forms.Button btndlfile;
        private System.Windows.Forms.Button btnread;
        private System.Windows.Forms.Button btnwrite;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnsystem;
        private System.Windows.Forms.Button button1;
    }
}

