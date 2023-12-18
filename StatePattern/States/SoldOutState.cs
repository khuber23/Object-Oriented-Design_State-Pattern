using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.States
{
	public class SoldOutState : IState
	{
		private GumballMachine gumballMachine;

		public SoldOutState(GumballMachine gumballMachine)
		{
			this.gumballMachine = gumballMachine;
		}

		public void Dispense()
		{
			Console.WriteLine("No gumball dispensed.");
		}

		public void EjectQuarter()
		{
			Console.WriteLine("You can't eject, you haven't inserted a quarter yet.");
		}

		public void InsertQuarter()
		{
			Console.WriteLine("You can't insert a quarter, the machine is sold out.");
		}

		public void TurnCrank()
		{
			Console.WriteLine("You turned, but there are no gumballs.");
		}
	}
}
