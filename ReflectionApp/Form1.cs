using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ReflectionApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog filedialog = new OpenFileDialog();
            filedialog.Title = "Choose one DLL";
            filedialog.Filter = "Files| *.dll";
            filedialog.InitialDirectory = @"C:\";
            filedialog.InitialDirectory = @"C:\";
            filedialog.InitialDirectory = @"C:\";
            filedialog.InitialDirectory = @"C:\";
            if (filedialog.ShowDialog()==DialogResult.OK)
            {
                textBox1.Text = filedialog.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = textBox1.Text;
            DirectoryInfo directory = new DirectoryInfo(path);
            directory.GetFiles();
        }
    }
}
