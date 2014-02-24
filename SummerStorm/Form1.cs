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

namespace SummerStorm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdFile_Click(object sender, EventArgs e)
        {
            //Check if we have variables we need to save first
            if (openFileDialog1.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                //parse the incoming text file
                parseFile(openFileDialog1.FileName);
            }

        }

        private void parseFile(string filename)
        {
            if (!File.Exists(filename))
            {
                //error out.  somehow thiis doesn't exist anymore
                return;
            }
            ConfigData cfg = new ConfigData();
            string[] fullconfigfile = File.ReadAllLines(filename);
            Dictionary<string, float> fileValues = new Dictionary<string, float>();
            for (int i = 0; i < fullconfigfile.Length; i++)
            {
                if(fullconfigfile[i].StartsWith("#define"))
                {
                    string tmpstr = fullconfigfile[i].Replace("#define ", string.Empty);
                    tmpstr = tmpstr.Replace(";", string.Empty);
                    string[] keyval = tmpstr.Split(' ');
                    fileValues.Add(keyval[0].Trim(), keyval.Length > 1 ? float.Parse(keyval[1].Trim()) : 0);


                }
            }
        }
    }
}
