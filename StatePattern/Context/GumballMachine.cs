using StatePattern.States;
using System;

namespace StatePattern
{
    public class GumballMachine
    {
        private int count = 0;
        private IState soldState;
        private IState noQuarterState;
        private IState hasQuarterState;
        private IState soldOutState;
        private IState currentState;
        private IState winnerState;

        public GumballMachine(int gumballCount)
        {
			this.count = gumballCount;
			this.noQuarterState = new NoQuarterState(this);
            this.hasQuarterState = new HasQuarterState(this);
            this.soldState = new SoldState(this);
            this.soldOutState = new SoldOutState(this);
            this.winnerState = new WinnerState(this);
            
            if (gumballCount > 0)
            {
				this.currentState = noQuarterState;
			}
            else
            {
                this.currentState = soldOutState;
            }
        }

        public IState SoldOutState { get { return this.soldOutState; } }
        public IState NoQuarterState { get { return this.noQuarterState; } }
        public IState HasQuarterState { get { return this.hasQuarterState; } }
        public IState SoldState { get { return this.soldState; } }
        public IState WinnerState { get { return this.winnerState; } }
        public IState CurrentState { get { return this.currentState; } set { this.currentState = value; } }
        public int Count { get { return count; } }


        public void ReleaseBall()
        {
            this.count--;
            Console.WriteLine("A gumball comes rolling out of the slot.");
        }

        public void EjectQuarter()
        {
           this.currentState.EjectQuarter();
        }

        public void InsertQuarter()
        {
            this.currentState.InsertQuarter();
        }

        public override string ToString()
        {
            string machineState = this.count > 0 ? "Machine is waiting for quarter..." : "Machine is sold out.";

            return $"\nMighty Gumball, Inc.\nInventory: {this.count}\n{machineState}\n";
        }

        public void TurnCrank()
        {
            this.currentState.TurnCrank();
            this.currentState.Dispense();
        }
    }
}