using System;
namespace Model {
	public class AbstractFixedActor : IFixed , IActor  {
		public Strategy strategy;
		public String InvSize;
		public Thread Thread;
		public bool Occupied;
		public IActor Target;
		public Point Position;
		public list<ICarriable> Items;

		public void Operation() {
			throw new System.Exception("Not implemented");
		}
		public void CallStrategy() {
			throw new System.Exception("Not implemented");
		}

	}

}
