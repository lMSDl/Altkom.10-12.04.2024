using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._10_12._04._2024.DesignPatterns.Creational.FactoryMethod
{
    internal class Client
    {
        class OpenDoorsOperation : IElevatorOperation
        {
            public void Operate(int floor)
            {
                Console.WriteLine($"Drzwi otworzą się na piętrze {floor}");
            }
        }

        class MyElevator : Elevator
        {
            public override IElevatorOperation? GetOperation(string operation)
            {
                if(operation == "door")
                    return new OpenDoorsOperation();
                return base.GetOperation(operation);
            }
        }

        public static void Execute()
        {
            var elevator = new MyElevator();
            var action = ReceiveAction();

            elevator.Execute(action, 3);

            action = ReceiveAction();
            elevator.Execute(action, 5);

            /*IElevatorOperation elevatorOperation = null;
            switch (nameof(Elevator) + action)
            {
                case nameof(ElevatorDown):
                    elevatorOperation = new ElevatorDown();
                    break;
                case nameof(ElevatorUp):
                    elevatorOperation = new ElevatorUp();
                    break;
            }*/

            /*if (elevatorOperation != null)
            {
                elevator.Execute(elevatorOperation, 3);
            }*/
        }

        private static string ReceiveAction()
        {
            return "door";
        }
    }
}
