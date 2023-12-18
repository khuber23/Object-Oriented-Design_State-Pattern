using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.States
{
	public class NoQuarterState : IState
	{
		private GumballMachine gumballMachine;
		public NoQuarterState(GumballMachine gumballMachine)
		{
			this.gumballMachine = gumballMachine;
		}

		public void Dispense()
		{
			Console.WriteLine("You need to pay first");
		}

		public void EjectQuarter()
		{
			Console.WriteLine("You have't inserted a quarter.");
		}

		public void InsertQuarter()
		{
			this.gumballMachine.CurrentState = this.gumballMachine.HasQuarterState;
			Console.WriteLine("You inserted a quarter");
		}

		public void TurnCrank()
		{
			Console.WriteLine("You turned but there's no quarter.");
		}
	}
}
