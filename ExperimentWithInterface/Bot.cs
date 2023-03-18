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
        public string Name { get; set; } = "";
        public int ID { get; private set; }
        public string Description { get; set; } = "";

        #region constructor chain
        public Bot() : this("no-name") { }
        public Bot(string name)
        {
            Name = name;
            Bot.id += 1;
            ID = id;
        }
        #endregion

        public string Print
        {
            get
            {
                return $"Bot object: id({ID}) - name({Name})";
            }
        }
    }
}
