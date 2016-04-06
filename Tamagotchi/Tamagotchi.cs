using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    class Tamagotchi
    {

        private string Name = "";
        private string Gender = "";
        private int Fullness = 0;
        private int Happiness = 0;
​
​
        public Tamagotchi(string name, string gender, int fullness, int happiness)
        {
            Name = name;
            Gender = gender;
            Fullness = fullness;
            Happiness = happiness;
        }
​
        public string getName()
        {
            return Name;
        }
​
        public string getGender()
        {
            return Gender;
        }
​
        public int getFullness()
        {
            return Fullness;
        }
​
        public int getHappiness()
        {
            return Happiness;
        }
​
        public int pet()
        {
            Happiness += 1;
            return Happiness;
        }
​
        public int feed()
        {
            Fullness += 1;
            return Fullness;
        }
​
        public void dostuff()
        {
            Random rnd = new Random();
            int CoolNumber = rnd.Next(0, 10);
            Console.WriteLine(CoolNumber);
            Fullness -= CoolNumber;
            Happiness -= CoolNumber;
        }
    }
}
    
