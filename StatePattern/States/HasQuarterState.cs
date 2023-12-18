using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.States
{
	public class HasQuarterState : IState
	{
		Random randomWinner = new Random();
		private GumballMachine gumballMachine;

		public HasQuarterState(GumballMachine gumballMachine)
		{
			this.gumballMachine = gumballMachine;
		}

		public void Dispense()
		{
			Console.WriteLine("No gumball dispensed.");
		}

		public void EjectQuarter()
		{
			Console.WriteLine("Quarter returned.");
			this.gumballMachine.CurrentState = this.gumballMachine.NoQuarterState;
		}

		public void InsertQuarter()
		{
			Console.WriteLine("You can't insert another quarter.");
		}

		public void TurnCrank()
		{
			Console.WriteLine("You turned...");
			int winner = this.randomWinner.Next(10);
			if (winner == 0 && gumballMachine.Count > 1)
			{
				this.gumballMachine.CurrentState = this.gumballMachine.WinnerState;
			}
			else
			{
				this.gumballMachine.CurrentState = this.gumballMachine.SoldState;
			}			
		}
	}
}
