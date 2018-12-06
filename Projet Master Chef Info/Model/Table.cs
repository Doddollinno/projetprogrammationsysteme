using System;
namespace Model {
	public class Table : FixedActor  {
		public int Place;
		public ActorGroup Group;

		public override void CallStrategy() {
			throw new System.Exception("Not implemented");
		}

	}

}
