﻿using System;
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
                string status = $"{honey:0.0} unit of honey\n{nectar:0.0} unit of nectar";
                string warnings = "";

                if (honey < LOW_LEVEL_WARNING)
                {
                    warnings += "\nLOW HONEY — ADD A HONEY MANUFACTURER";
                }
                else if (nectar < LOW_LEVEL_WARNING) { }
                {
                    warnings += "\nLOW NECTAR — ADD A NECTAR COLLECTOR";
                }
                return status + warnings;
            }
        }

        public static void ConvertNectarToHoney(float amount)
        {
            if (amount > nectar) 
            {
                amount = nectar;
            }
            
            nectar -= amount;
            honey += amount * NECTAR_CONVERSION_RATIO;
        }

        public static bool ConsumeHoney(float amount)
        {
            if (honey >= amount)
            {
                honey -= amount;
                return true;
            }
            return false;
        }

        public static void CollectNectar(float amount)
        {
            if(amount > 0)
            {
                nectar += amount;
            }
        }
    }
}
