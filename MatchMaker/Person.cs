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
            int Result = 0;
            for(int i = 0; i < p.Responses.Count; i++)
            {
                Result += (int)Math.Pow((Responses[i] - p.Responses[i]), 2); 
            }
            //Console.WriteLine(Result);
            return Result;
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
