using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            string role;
            Person p = new Person("Joe", 1);
            p.SetResponses(new List<int> { 3, 4, 7, 8, 1, 9 });
            if (p.IsCoach())
            {
                role = "Coach";
            }
            else
            {
                role = "Eleve";
            }
            MessageBox.Show("Objet p :" + p.GetName() + role);





        }

     
    }
}
