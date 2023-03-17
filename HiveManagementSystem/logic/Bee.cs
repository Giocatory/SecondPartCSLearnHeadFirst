using HiveManagementSystem.logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HiveManagementSystem
{
    class Bee
    {
        public string Job { get; private set; }
        public virtual float CostPerShift {get;}

        public Bee(string job)
        {
            Job = job;
        }

        public void WorkTheNextShift()
        {
            if (HoneyVault.ConsumeHoney(CostPerShift))
            {
                DoJob();
            }
        }

        protected virtual void DoJob() { /* Subclasses overrides this method */}
    }
}