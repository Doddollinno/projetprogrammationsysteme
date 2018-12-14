using System;

namespace Model {

	interface IFixedActor  {

		
		 Travail();

		/*public override void CallStrategy() {
			throw new System.Exception("Not implemented");
		}*/

	}

	public class Table : IFixedActor
	{
		public int Nombre_Place;
		public int Numero_Table;
		public bool Dispo;
	}

	class Maitre_Hotel : Table, IFixedActor
	{
		String Name;
		public Travail()
		{
			
			return ;
		}

	}

	class Chef_Cuisine : IFixedActor
	{

	}

	class Four : IFixedActor
	{

	}



}
