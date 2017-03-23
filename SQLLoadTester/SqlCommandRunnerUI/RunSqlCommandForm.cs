using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlCommandRunnerUI
{
    public partial class FormRunSqlCommand : Form
    {
        public FormRunSqlCommand()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            new ThreadRunners.SqlCommands().RunSqlCmdThread(
                tbCommand.Text, int.Parse(tbNumberUsers.Text), int.Parse(tbNumberOfThreadsUsers.Text));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
