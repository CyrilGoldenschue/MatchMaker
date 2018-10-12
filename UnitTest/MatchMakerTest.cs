using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace MatchMaker
{
    [TestClass]
    public class MatchMakerTest
    {
        [TestMethod]
        public void TestPersonIncompatibility()
        {
            int Discord = 0;
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
            //Console.WriteLine(sommeDiscord);
            Assert.AreEqual(sommeDiscord, 7, "Bad computation of incompatibility score");
        }
    }
}
