using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace automat.test
{
    public class Class1 
    {
        //4 yra lyginis skaicius

        [Test]
        public static void TestIf4IsEvening()
        {
            int skaicius = 4 % 2;
            Assert.AreEqual(0, skaicius, "4 yra blogas");
        }
        [Test]
        public static void TestNow17()
        {
            DateTime curentTime = DateTime.Now;
            Assert.AreEqual(15, curentTime.Hour, "dabar ne 17 val.");
        }

        [Test]
        public static void Pirmadienis()
        {
            DateTime diena = DateTime.Now;
            Assert.AreEqual(DayOfWeek.Sunday, diena.DayOfWeek, "kita diena");
        }

        [Test]
        public static void Laukiam5sekundes()
        {
            Thread.Sleep(2000);
        }
    }
}
