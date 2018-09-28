using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMaker
{
    public class Group
    {
        private int Number;
        private Person Coach;
        private List<Person> Membres = new List<Person>();

        public Group(int number, Person coach)
        {
            Number = number;
            Coach = coach;
        }

        public int GetDiscord()
        {
            int xx = 0;
            return xx;
        }

        public void AddMember(Person p)
        {
            Membres.Add(p);
            for (int i = 0; i < Membres.Count; i++)
            {
                Console.WriteLine(Membres[i].ToString());
            }
            
        }

        public Person ExtractMember(int index)
        {
            Person xx = new Person("Joe", 1);
            return xx;
        }

        public string GetGroupDescription()
        {
            string xx = "cc";
            return xx;
        }

        public int GetNbMembers()
        {
            int xx = 0;
            return xx;
        }
    }
}
