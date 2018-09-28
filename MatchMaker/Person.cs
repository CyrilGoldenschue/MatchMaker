using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMaker
{
    public class Person
    {
        private string Nickname;
        public List<int> Responses;
        private int Role;


        public Person(string nickname, int role)
        {
            Nickname = nickname;
            Role = role;
        }

        public int GetDiscordWith(Person p)
        {
            int xx = 0;
            return xx;
        }

        public string GetName()
        {
            return Nickname;
        }

        public void SetResponses(List<int> resp)
        {
            Responses = resp;
        }

        public bool IsCoach()
        {
            if(Role == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
