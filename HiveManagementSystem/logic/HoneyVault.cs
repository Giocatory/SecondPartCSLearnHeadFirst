using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiveManagementSystem.logic
{
    static class HoneyVault
    {
        public const float NECTAR_CONVERSION_RATIO = .19f;
        public const float LOW_LEVEL_WARNING = 10f;

        private static float honey = 25f;
        private static float nectar = 100f;

        public static string StatusReport
        {
            get 
            {
                if (honey < LOW_LEVEL_WARNING)
                {
                    return "LOW HONEY — ADD A HONEY MANUFACTURER";
                }
                else if (nectar < LOW_LEVEL_WARNING) { }
                {
                    return "LOW NECTAR — ADD A NECTAR MANUFACTURER";
                }
            }
        }

        public static void ConvertNectarToHoney(float amount)
        {
            if (nectar == 0)
            {
                return;
            }
            if (amount >= nectar) 
            {
                nectar = 0;
            }
            else
            {
                nectar -= amount;
            }
            honey += amount * NECTAR_CONVERSION_RATIO;
        }

        public static bool ConsumeHoney(float amount)
        {
            if (amount < honey)
            {
                amount -= honey;
                return true;
            }
            return false;
        }

        public static void CollectNectar(float amount)
        {
            if(amount > 0)
            {
                honey += amount;
            }
        }
    }
}
