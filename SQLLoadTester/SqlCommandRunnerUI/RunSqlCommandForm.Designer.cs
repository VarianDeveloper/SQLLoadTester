namespace SqlCommandRunnerUI
{
    partial class FormRunSqlCommand
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
            this.btnRun = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbConnectionString = new System.Windows.Forms.TextBox();
            this.tbCommand = new System.Windows.Forms.TextBox();
            this.tbNumberUsers = new System.Windows.Forms.TextBox();
            this.tbNumberOfThreadsUsers = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(171, 267);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(328, 267);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Connection String";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Command";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number if Users";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Number of runs per user";
            // 
            // tbConnectionString
            // 
            this.tbConnectionString.Location = new System.Drawing.Point(171, 26);
            this.tbConnectionString.Name = "tbConnectionString";
            this.tbConnectionString.Size = new System.Drawing.Size(470, 20);
            this.tbConnectionString.TabIndex = 6;
            this.tbConnectionString.Text = "user id=sa;password=Sa_sqlboxpwd12345;server=10.4.194.152;database=VARIAN";
            // 
            // tbCommand
            // 
            this.tbCommand.Location = new System.Drawing.Point(171, 65);
            this.tbCommand.Name = "tbCommand";
            this.tbCommand.Size = new System.Drawing.Size(600, 20);
            this.tbCommand.TabIndex = 7;
            this.tbCommand.Text = "EXEC [dbo].[vp_syUpdateSessionStatus] @strHstryUserName = N\\\'SysAdmin\\\' ,@strHstr" +
    "yTaskName = N\\\'Scheduling\\\',@nDebug = 3, @strCompletePlanUID01 = N\\\'1.2.246.352." +
    "71.5.339051055.1345.20080812155642\\\'";
            // 
            // tbNumberUsers
            // 
            this.tbNumberUsers.Location = new System.Drawing.Point(171, 101);
            this.tbNumberUsers.Name = "tbNumberUsers";
            this.tbNumberUsers.Size = new System.Drawing.Size(41, 20);
            this.tbNumberUsers.TabIndex = 8;
            this.tbNumberUsers.Text = "10";
            // 
            // tbNumberOfThreadsUsers
            // 
            this.tbNumberOfThreadsUsers.Location = new System.Drawing.Point(171, 143);
            this.tbNumberOfThreadsUsers.Name = "tbNumberOfThreadsUsers";
            this.tbNumberOfThreadsUsers.Size = new System.Drawing.Size(41, 20);
            this.tbNumberOfThreadsUsers.TabIndex = 9;
            this.tbNumberOfThreadsUsers.Text = "10";
            // 
            // FormRunSqlCommand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 310);
            this.Controls.Add(this.tbNumberOfThreadsUsers);
            this.Controls.Add(this.tbNumberUsers);
            this.Controls.Add(this.tbCommand);
            this.Controls.Add(this.tbConnectionString);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRun);
            this.Name = "FormRunSqlCommand";
            this.Text = "SQL command runner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbConnectionString;
        private System.Windows.Forms.TextBox tbCommand;
        private System.Windows.Forms.TextBox tbNumberUsers;
        private System.Windows.Forms.TextBox tbNumberOfThreadsUsers;
    }
}

