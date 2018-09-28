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

namespace MatchMaker
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

            AddPersonToFile();
        }

        private void AddPersonToFile()
        {
            /*string role;
            Person p1 = new Person("Joe", 1);
            Person p2 = new Person("Cyril", 2);
            p1.SetResponses(new List<int> { 3, 4, 7, 8, 1, 9 });
            p2.SetResponses(new List<int> { 7, 4, 6, 3, 3, 3 });
            if (p1.IsCoach())
            {
                role = "Coach";
            }
            else
            {
                role = "Eleve";
            }
            Group g = new Group(1, p);
            g.AddMember(p);
            MessageBox.Show(p1.GetDiscordWith(p2).ToString());*/





        }

        private void cmdPathFile_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Browse Text Files";

            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;

            openFileDialog1.DefaultExt = "csv";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)

            {

                txtPathFile.Text = openFileDialog1.FileName;

            }

            /*Person role;
            Person p1 = new Person("Joe", 1);
            Person p2 = new Person("Cyril", 2);
            p1.SetResponses(new List<int> { 3, 4, 7, 8, 1, 9 });
            p2.SetResponses(new List<int> { 7, 4, 6, 3, 3, 3 });
            if (p1.IsCoach())
            {
                role = p1;
            }
            else
            {
                role = p2;
            }
            Group g = new Group(1, role);
            g.AddMember(p1);
            g.AddMember(p2);
            MessageBox.Show(p1.GetDiscordWith(p2).ToString());*/
        }

        private void cmdValidate_Click(object sender, EventArgs e)
        {
            string Path = txtPathFile.Text;
            string[] tokens;
            // Create an instance of StreamReader to read from a file.
            // The using statement also closes the StreamReader.
            using (StreamReader sr = new StreamReader(Path))
            {
                string line;
                // Read and display lines from the file until the end of 
                // the file is reached.
                while ((line = sr.ReadLine()) != null)
                {
                    tokens = line.Split(';');
                }
            }
        }

        private void CountMinute_SelectedItemChanged(object sender, EventArgs e)
        {

        }
    }
}
