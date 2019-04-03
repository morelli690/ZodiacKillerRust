using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZodiacKillerRust
{
    public class Weapon
    {
        public string Name;
        public FiringMode Mode = FiringMode.Automatic;
        public double MovementMultiplier;
        public int[][] RecoilTable;
        public int FireRate;
        public int SmoothValue = 0;
    }

    public enum FiringMode
    {
        Automatic = 1,
        SemiAutomatic = 2
    }
}
