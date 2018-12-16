using System;
using System.Collections.Generic;
using System.Threading;

namespace Model {
	public class MobileActor : IMobile , IActor  {
		public Controller.Strategy strategy;
		public String InvSize;
		public Thread Thread;
		public bool Occupied;
		public IActor Target;
		public Point Position;
		public List<ICarriable> Items;

		public void CallStrategy() {
			throw new System.Exception("Not implemented");
		}
		public void Move() {
			
		}

	}

}
