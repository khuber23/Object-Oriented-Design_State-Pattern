using System;

namespace StatePattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
			GumballMachine gumballMachine = new GumballMachine(5);

			Console.WriteLine(gumballMachine.ToString());

			gumballMachine.InsertQuarter();
			gumballMachine.TurnCrank();

			Console.WriteLine(gumballMachine.ToString());

			gumballMachine.InsertQuarter();
			gumballMachine.TurnCrank();
			gumballMachine.InsertQuarter();
			gumballMachine.TurnCrank();
			gumballMachine.InsertQuarter();
			gumballMachine.TurnCrank();

			Console.WriteLine(gumballMachine.ToString());

			Console.Read();
		}
    }
}