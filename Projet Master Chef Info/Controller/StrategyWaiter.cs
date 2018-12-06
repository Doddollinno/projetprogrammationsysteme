using System;
namespace Controller {
	public class StrategyWaiter : Strategy  {
		public override void Behavior() {
			throw new System.Exception("Not implemented");
		}

	}

}
