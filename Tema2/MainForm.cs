using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema2
{
    public partial class MainForm : Form
    {
        public AutomatPushDown automatPushDown;
        string file;
        public MainForm()
        {
            InitializeComponent();
            automatPushDown = new AutomatPushDown();
        }

        private void btnVerificare_Click(object sender, EventArgs e)
        {
            if (file == null)
            {
                MessageBox.Show("Alege un fisier!");
            }
            else
            {
                if (textBoxIn.Text.Length.Equals(0))
                {
                    MessageBox.Show("Introdu un sir de intrare!");

                }
                else
                {
                    automatPushDown.Verificare(textBoxIn.Text, listBoxIn, listBoxStiva, listBoxOp);
                }
            }
        }

        private void btnIncarcare_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = @"./";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files(*.*)|(*.*)";
                openFileDialog.FilterIndex = 1;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    file = openFileDialog.FileName;
                    var fileStream = openFileDialog.OpenFile();
                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        PushDownReader.Read(automatPushDown, reader);
                    }
                }
            }
        }
    }
}
