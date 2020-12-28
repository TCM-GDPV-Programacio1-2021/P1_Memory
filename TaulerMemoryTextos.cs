using System;

namespace P1_Memory_student
{
	public class TaulerMemoryTextos
	{

		// Delaració dels atributs
		private string[,] tauler; // Matriu per emmagatzemar les parelles de text
		private int mida; // número de files i columnes de la matriu quadrada
		private string[] textos; // Vector per emmagatzemar els textos de longuitud 4
		private int quantsTextos; // mida del vector dels textos
		private string cellaBuida; // Definir la casella buida
		private Random rnd = new Random();

		// Constructor
		/* Cal inicialitzar els atributs degudament i a continuació cridar al mètode omplirTauler()*/
		public TaulerMemoryTextos()
		{
			//PENDENT IMPLEMENTAR

		}

		/* Inicialitzar la matriu tauler amb el caràcter nul
		 * Aquest métode és cridat pel constructor.
		 */
		private void inicialitzarTauler()
		{
			//PENDENT IMPLEMENTAR
		}

		/*
		 * Cal emplenar el vector dels textos amb els 10 textos de longuitud 4	
		 * Aquest métode és cridat pel constructor.
		 */
		private void inicialitzarVectorElememtsParelles()
		{
			//PENDENT IMPLEMENTAR
		}

		/*
		 * Aquest métode és el responsable d'omplir l'atribut tauler amb les vuit  parelles 
		 * de textos. Per fer-ho caldrà:
		 *   1.Obtenir un text aleatòriament d'entre tots els possibles.
		 *   2.Col·locar el text dos cops en el tauler de forma aleatòria (mètode collocarText()). 
		 * Aquest métode és cridat pel constructor.
		 */
		private void omplirTauler()
		{
			//PENDENT IMPLEMENTAR
		}

		/*
		 *Col·locar el text de l'argument a la matriu tauler en una casella triada aleatòriament
		 * i que tingui el valor de la casella buida. Per fer-ho caldrà fer:
		 *   1.Triar dos números aleatòriament que seran la fila i la columna d'una de les caselles
		 *     de la matriu tauler.
		 *   2.Si la casella escollida té el valor de la casella buida, col·locar-li el text de l'argument i 
		 *     finalitzar el mètode. Altrament tornar al pas 1.
		 * Aquest mètode serà cridat pel mètode omplirTaulell(), que haurà de garantir que la matriu
		 * tauler tindrà com a mínim un casella amb el valor de la casella buida, per evitar un bucle infinit.
		 */
		private void collocarText(string text)
		{
			//PENDENT IMPLEMENTAR
		}

		/* retorna el contingut de la casella del tauler de la coordenada de l'argument */
		public string getElementDelTauler(int[] coordenada)
		{
			//PENDENT IMPLEMENTAR
			return null;
		}

		/*
		 * Retorna una còpia de la matriu tauler, no retorna la matriu tauler
		 */
		public string[,] getTauler()
		{
			//PENDENT IMPLEMENTAR
			return null;
		}

		public int getMida()
		{
			//PENDENT IMPLEMENTAR
			return 0;
		}

		public string getCellaBuida()
		{
			//PENDENT IMPLEMENTAR
			return null;
		}
	}
}