using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperimentWithInterface
{
    internal class Bot : IPrintInfo
    {
        private static int id = 0;
        public string Name { get; set; }
        public int ID { get; private set; }

        #region constructor chain
        public Bot(string name)
        {
            Name = name;
            Bot.id += 1;
            ID = id;
        }
        #endregion

        public string ToString(object obj)
        {
            return $"Bot object: id({ID}) - name({Name})";
        }
        
    }
}
