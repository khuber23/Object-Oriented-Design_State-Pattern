using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.States
{
	public class WinnerState : IState
	{
		private GumballMachine gumballMachine;


		public WinnerState(GumballMachine gumballMachine)
		{
			this.gumballMachine = gumballMachine;
		}

		public void Dispense()
		{
			Console.WriteLine("YOU'RE A WINNER!! You get two gumballs for your quarter");
			gumballMachine.ReleaseBall();
			if (gumballMachine.Count == 0)
			{
				gumballMachine.CurrentState = gumballMachine.SoldOutState;
			}
			else
			{
				gumballMachine.ReleaseBall();
				if (gumballMachine.Count> 0)
				{
					gumballMachine.CurrentState = gumballMachine.NoQuarterState;
				}
				else
				{
					Console.WriteLine("Oops, out of gumballs!");
					gumballMachine.CurrentState = gumballMachine.SoldOutState;
				}
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
