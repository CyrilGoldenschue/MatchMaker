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

            /*int Discord = 0;
            int sommeDiscord = 0;
            Person p1 = new Person("Sacha", 1);
            Person p2 = new Person("Cyril", 2);
            Person p3 = new Person("Dorian", 2);
            Person p4 = new Person("Quentin", 2);
            p1.SetResponses(new List<int> { 3, 4, 3, 4, 1, 5 });
            p2.SetResponses(new List<int> { 5, 4, 3, 3, 3, 3 });
            p3.SetResponses(new List<int> { 5, 4, 4, 4, 1, 5 });
            p4.SetResponses(new List<int> { 4, 4, 3, 3, 3, 3 });
            // Incompatibility is 82: (7-3)^2+(4-4)^2+(6-7)^2+(3-8)^2+(3-1)^2+(3-9)^2
            //Assert.AreEqual(p1.GetDiscordWith(p2), 82, "Bad computation of incompatibility score");
            Discord = Discord + p1.GetDiscordWith(p2);
            Discord = Discord + p1.GetDiscordWith(p3);
            Discord = Discord + p1.GetDiscordWith(p4);
            sommeDiscord = Discord / 4;
            Console.WriteLine(sommeDiscord);*/



        }

        private void cmdPathFile_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = @"C:\GIT\MatchMaker";
            openFileDialog1.Title = "Browse Text Files";

            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;

            openFileDialog1.DefaultExt = "csv";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)

            {

                txtPathFile.Text = openFileDialog1.FileName;

            }
            cmdValidate.Enabled = true;
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
                var ListPersonCoach = new List<Person>();
                var ListPersonMember = new List<Person>();
                var ListNameCoach = new List<string>();
                var ListNameMember = new List<string>();
                // Read and display lines from the file until the end of 
                // the file is reached.
                while ((line = sr.ReadLine()) != null)
                {

                    tokens = line.Split(';');
                    string name = tokens[0];
                    int role = Convert.ToInt32(tokens[1]);
                    Person person = new Person(name, role);
                    int NbResponse = tokens.Count()-1;
                    var ListResponse = new List<int>();
                    for (int i = 2; i<=NbResponse; i++)
                    {
                        ListResponse.Add(Convert.ToInt32(tokens[i]));
                    }
                    person.SetResponses(ListResponse);



                    if (person.IsCoach())
                    {
                        ListPersonCoach.Add(person);
                        ListNameCoach.Add(name);
                        
                        /*for (int i = 0; i <= NbResponse-2; i++)
                        {
                            ListPersonCoach.Add(ListResponse[i].ToString());
                        }*/

                        /*Group group = new Group(GroupNumber, person);
                        GroupNumber++;*/
                    }
                    if(!person.IsCoach())
                    {
                        ListPersonMember.Add(person);
                        ListNameMember.Add(name);
                        /*for (int i = 0; i <= NbResponse-2; i++)
                        {
                            ListPersonMember.Add(ListResponse[i].ToString());
                        }*/

                        //group.AddMember
                    }

                }
                int NumberCoach = ListPersonCoach.Count();
                int NumberMember = ListPersonMember.Count();
                int NumberPerson = 1;
                int NbGroup = NumberMember / NumberCoach;
                int NumberMemberGroup = NumberMember / NbGroup;
                int horizontal = 10;
                int vertical = 135;
                int x = 1;
                int sommeDiscord = 0;
                

                for (int GroupNumber = 1; GroupNumber <= NumberCoach; GroupNumber++)
                {
                    int discord = 0;
                    NumberPerson = x;
                    x++;
                    TextBox Groupe = new TextBox();
                    Groupe.Size = new Size(205, 165);
                    Groupe.Location = new Point(horizontal, vertical);
                    Groupe.Name = Groupe + x.ToString();
                    Groupe.Multiline = true;
                    this.Controls.Add(Groupe);
                    Group group = new Group(GroupNumber, (Person)ListPersonCoach[GroupNumber-1]);
                    horizontal += 210;
                    if(GroupNumber == 4 || GroupNumber == 8 || GroupNumber == 12)
                    {
                        vertical += 170;
                        horizontal = 10;
                    }
                    Groupe.Text = "Groupe numéro :" + GroupNumber + "\r\nCoach: " + ListNameCoach[GroupNumber - 1].ToString() + "\r\n Membres: \r\n\t";
                    int NumberPersonGroup = GroupNumber;
                    while(NumberPerson < NumberMember)
                    {
                        discord += ListPersonCoach[GroupNumber - 1].GetDiscordWith(ListPersonMember[NumberPerson]);
                        group.AddMember(ListPersonMember[NumberPerson]);
                        Groupe.Text += ListNameMember[NumberPerson] + "\r\n\t";
                        NumberPerson += NumberCoach;
                        NumberPersonGroup += 1;
                    }
                    sommeDiscord = discord / NumberMemberGroup;
                    Groupe.Text += "\r\n Discord total : "+ sommeDiscord;
                }
            }
        }

        private void CountMinute_SelectedItemChanged(object sender, EventArgs e)
        {

        }
    }
}
