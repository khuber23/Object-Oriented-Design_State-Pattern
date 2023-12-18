using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.States
{
	public class SoldState : IState
	{
		private GumballMachine gumballMachine;
		

		public SoldState(GumballMachine gumballMachine)
		{
			this.gumballMachine = gumballMachine;
		}

		public void Dispense()
		{
			gumballMachine.ReleaseBall();
			if (gumballMachine.Count > 0)
			{
				this.gumballMachine.CurrentState = this.gumballMachine.NoQuarterState;				
			}
			else
			{
				Console.WriteLine("Oops, out of gumballs!!");
				this.gumballMachine.CurrentState = this.gumballMachine.SoldOutState;
			}
		}

		public void EjectQuarter()
		{
			Console.WriteLine("Sorry, you already turned the crank.");
		}

		public void InsertQuarter()
		{
			Console.WriteLine("Please wait, we're already giving you a gumball.");
		}

		public void TurnCrank()
		{
			Console.WriteLine("Turning twice doesn't get you another gumball!");
		}
	}
}
