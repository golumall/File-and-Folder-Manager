namespace WindowsFormsApplication4
{
    partial class Form2
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
            this.btnshutdown = new System.Windows.Forms.Button();
            this.btnrestart = new System.Windows.Forms.Button();
            this.btnlogoff = new System.Windows.Forms.Button();
            this.btnlock = new System.Windows.Forms.Button();
            this.btnswitch = new System.Windows.Forms.Button();
            this.btnsleep = new System.Windows.Forms.Button();
            this.btnhibernate = new System.Windows.Forms.Button();
            this.btnaboutsys = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnshutdown
            // 
            this.btnshutdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshutdown.Location = new System.Drawing.Point(12, 21);
            this.btnshutdown.Name = "btnshutdown";
            this.btnshutdown.Size = new System.Drawing.Size(97, 38);
            this.btnshutdown.TabIndex = 0;
            this.btnshutdown.Text = "Shutdown";
            this.btnshutdown.UseVisualStyleBackColor = true;
            this.btnshutdown.Click += new System.EventHandler(this.btnshutdown_Click);
            // 
            // btnrestart
            // 
            this.btnrestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrestart.Location = new System.Drawing.Point(142, 21);
            this.btnrestart.Name = "btnrestart";
            this.btnrestart.Size = new System.Drawing.Size(97, 38);
            this.btnrestart.TabIndex = 1;
            this.btnrestart.Text = "Restart";
            this.btnrestart.UseVisualStyleBackColor = true;
            this.btnrestart.Click += new System.EventHandler(this.btnrestart_Click);
            // 
            // btnlogoff
            // 
            this.btnlogoff.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogoff.Location = new System.Drawing.Point(279, 21);
            this.btnlogoff.Name = "btnlogoff";
            this.btnlogoff.Size = new System.Drawing.Size(97, 38);
            this.btnlogoff.TabIndex = 2;
            this.btnlogoff.Text = "LogOff";
            this.btnlogoff.UseVisualStyleBackColor = true;
            this.btnlogoff.Click += new System.EventHandler(this.btnlogoff_Click);
            // 
            // btnlock
            // 
            this.btnlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlock.Location = new System.Drawing.Point(12, 84);
            this.btnlock.Name = "btnlock";
            this.btnlock.Size = new System.Drawing.Size(97, 38);
            this.btnlock.TabIndex = 3;
            this.btnlock.Text = "Lock";
            this.btnlock.UseVisualStyleBackColor = true;
            this.btnlock.Click += new System.EventHandler(this.btnlock_Click);
            // 
            // btnswitch
            // 
            this.btnswitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnswitch.Location = new System.Drawing.Point(142, 84);
            this.btnswitch.Name = "btnswitch";
            this.btnswitch.Size = new System.Drawing.Size(108, 38);
            this.btnswitch.TabIndex = 4;
            this.btnswitch.Text = "SwitchUser";
            this.btnswitch.UseVisualStyleBackColor = true;
            this.btnswitch.Click += new System.EventHandler(this.btnswitch_Click);
            // 
            // btnsleep
            // 
            this.btnsleep.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsleep.Location = new System.Drawing.Point(279, 84);
            this.btnsleep.Name = "btnsleep";
            this.btnsleep.Size = new System.Drawing.Size(97, 38);
            this.btnsleep.TabIndex = 5;
            this.btnsleep.Text = "Sleep";
            this.btnsleep.UseVisualStyleBackColor = true;
            this.btnsleep.Click += new System.EventHandler(this.btnsleep_Click);
            // 
            // btnhibernate
            // 
            this.btnhibernate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhibernate.Location = new System.Drawing.Point(12, 145);
            this.btnhibernate.Name = "btnhibernate";
            this.btnhibernate.Size = new System.Drawing.Size(97, 38);
            this.btnhibernate.TabIndex = 6;
            this.btnhibernate.Text = "Hibernate";
            this.btnhibernate.UseVisualStyleBackColor = true;
            this.btnhibernate.Click += new System.EventHandler(this.btnhibernate_Click);
            // 
            // btnaboutsys
            // 
            this.btnaboutsys.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaboutsys.Location = new System.Drawing.Point(142, 145);
            this.btnaboutsys.Name = "btnaboutsys";
            this.btnaboutsys.Size = new System.Drawing.Size(118, 38);
            this.btnaboutsys.TabIndex = 7;
            this.btnaboutsys.Text = "AboutAuthor";
            this.btnaboutsys.UseVisualStyleBackColor = true;
            this.btnaboutsys.Click += new System.EventHandler(this.btnaboutsys_Click);
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(278, 145);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(97, 38);
            this.btnclose.TabIndex = 8;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(412, 234);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnaboutsys);
            this.Controls.Add(this.btnhibernate);
            this.Controls.Add(this.btnsleep);
            this.Controls.Add(this.btnswitch);
            this.Controls.Add(this.btnlock);
            this.Controls.Add(this.btnlogoff);
            this.Controls.Add(this.btnrestart);
            this.Controls.Add(this.btnshutdown);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "System";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnshutdown;
        private System.Windows.Forms.Button btnrestart;
        private System.Windows.Forms.Button btnlogoff;
        private System.Windows.Forms.Button btnlock;
        private System.Windows.Forms.Button btnswitch;
        private System.Windows.Forms.Button btnsleep;
        private System.Windows.Forms.Button btnhibernate;
        private System.Windows.Forms.Button btnaboutsys;
        private System.Windows.Forms.Button btnclose;
    }
}