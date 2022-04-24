using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibFortress.Models
{
    public class Job
    {
        public string Name { get; private set; }
        public int Level { get; private set; }
        public long Experience { get; private set; }
        public int ExperienceGain { get; set; } = 1;
        public int GainPerTick { get; set; } = 3;
        private int[] LevelGate = { 3, 1 };

        private void LevelUp()
        {
            Level++;
        }

        /// <summary>
        /// Adds Experience based on ExperienceGain Property
        /// </summary>
        /// <param name="exp">overwrites ExperienceGain Property</param>
        public void AddExperience(int exp = 0)
        {
            if (exp == 0)
            {
                exp = ExperienceGain;
            }
            Experience += exp;
        }
    }
}