using System;

namespace P1_Memory_student
{
	class Program
	{
		private static ControladorJocMemory controlador; //per controlar l'estat del joc.
		static void Main()
		{
			Console.WriteLine("Hello World! online");
			//PENDENT IMPLEMENTAR
		}


		/*
		 * NO FER CAP MODIFICACIÓ!!
		 * Permet que el jugador entri una coordenada del tauler.
		 * Si de la informació entrada no se'n poden extreure dos enters 
		 * (métode validarExecutarEntrada()), cal informar de l'error i
		 * tornar a demanar les coordenades fins a conseguir-ho.
		 * Si tot és correcte, caldrà esborrar la consola del tauler i mostrar 
		 * el nou estat (métode mostrarTauler()).
		 */
		private static void entrarCoordenada()
		{
			//PENDENT IMPLEMENTAR
			string entrada;
			int coord1 = -1, coord2 = -1;
			while (coord1 == -1 || coord2 == -1)
			{
				Console.WriteLine("Entra la fila i la columna de la casella que vols destapar, per exemple 1,3: ");
				entrada = Console.ReadLine();
				//Validar que l'argument entrada de tipus text tingui dos enters.
				string[] coordenadesStr = entrada.Split(',');
				if (coordenadesStr.Length != 2)
				{
					Console.WriteLine("ERROR: cal entrar dos enters separat per una coma");
				}
				else
				{
					try
					{
						coord1 = Int32.Parse(coordenadesStr[0]);
						coord2 = Int32.Parse(coordenadesStr[1]);
					}
					catch (FormatException)
					{
						Console.WriteLine("ERROR: el valor ha de ser un enter.");
						coord1 = -1;
						coord2 = -1;
					}
				}
				int[] coordenada = new int[2] { coord1, coord2 };
				string str = controlador.casellaADestapar(coordenada);
				if (str != null)
				{
					Console.WriteLine(str);
					coord1 = -1;
					coord2 = -1;
				}
			}

		}


	}
}
