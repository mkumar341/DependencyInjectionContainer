using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionContainer.Services
{
    public class LuckyDrawService
    {
        private readonly string[] Contestants = { "A100","B200","C300","D400","E500","F600","G700","H800", "I900", "J1000", "K1100", "L1200", "M1300", "N1400", "O1500", "P1600", "Q1700", 
            "R1800", "S1900", "T2000", "U2100" };
        private readonly string lucky;
        public LuckyDrawService()
        {            
            lucky = Contestants[new Random().Next(0,20)];
        }
        public string GetWinner() => lucky;
    }
}
