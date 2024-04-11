using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._10_12._04._2024.DesignPatterns.Behavioral.Command
{
    internal class RemoveFromGardenCommand : GardenCommand
    {
        public RemoveFromGardenCommand(Garden receiver, string plantName) : base(receiver, plantName)
        {
        }

        public override bool Execute()
        {
            return Receiver.Remove(PlantName);
        }

        public override void Reverse()
        {
            Receiver.Add(PlantName);
        }
    }
}
