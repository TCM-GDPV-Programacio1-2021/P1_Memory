using System;
using System.Collections.Generic;
using System.Text;

namespace P1_Memory_student
{
	public class ControladorJocMemory
	{

		private TaulerMemoryTextos jocMemory;
		private string[,] tauler; // serà el que veura el jugador
		private int[] coordenada1, coordenada2; // les coordenades de la parella que entrarà el jugador
		private int intentsFets; // Quants intents ha fet el jugador per acabar el joc.

		/*
		 * Constructor: cal inicialitzar els atributs de la classe.
		 * L'atribut tauler haurà de tenir totes les caselles amb el
		 * valor de la casella buida.
		 * Inicialment els dos atributs coordenada seran nuls.
		 */
		public ControladorJocMemory()
		{
			//PENDENT IMPLENTAR

		}

		/*
		 * Mostrar en l'atribut tauler l'estat actual 
		 */
		public void mostrarTauler()
		{
			//PENDENT IMPLEMENTAR
		}

		/*
		 * Retorna cert si hi ha alguna casella buida i fals altrament
		 * En cas de final de joc (totes les caselles no buides) cal incrementar el 
		 * número d'intens, doncs la última parella no es compte
		 */
		public bool ContinuarJugant()
		{
			//PENDENT IMPLEMENTAR

		}


		/*
		 * NO FER CAP MODIFICACIÓ!!
		 * Té com a finalitat preparar el tauler que es mostrarà al jugador. Si hi ha
		 * algun error retorna un tex explicatiu, altrament retorna nul.Per fer-ho cal:
		 * 1. Si l'argument no és correcte (mètode validarCoordenada()) retornar al
		 *    missatge d'error escaient
		 * 2. Si ja ha destapat dues caselles, caldrà comprovar si el seu contingut són 
		 *    iguals o no (mètode comprovarResultat())    
		 * 3. Si la casella de l'argument ja està destapada, retornar al missatge d'error
		 *    escaient 
		 * 4. Actualitzar la casella de l'atribut tauler amb la informació de la 
		 *    coordenada de l'argument. 
		 * 5. Actualitzar l'atribut copsDestapat. 
		 * 6. Caldrà actualitzar l'atribut coordenada1 o coordenada2 depenent de si és 
		 *    la primera o segona casella que vol destapar. 
		 * 7. Si no hi ha cap error, retornar null.
		 */
		public string casellaADestapar(int[] coordenada)
		{
			if (coordenada1 != null && coordenada2 != null)
			{
				comprovarResultat();
			}
			string missatge = validarCoordenada(coordenada);
			if (!string.ReferenceEquals(missatge, null))
			{
				return missatge;
			}
			if (tauler[coordenada[0], coordenada[1]] != jocMemory.getCellaBuida())
			{
				return "Aquesta casella ja està destapada.";
			}
			string contingut = jocMemory.getElementDelTauler(coordenada);
			tauler[coordenada[0], coordenada[1]] = contingut;
			if (coordenada1 == null)
			{
				coordenada1 = coordenada;
			}
			else
			{
				coordenada2 = coordenada;
			}
			return null;
		}

		/*
		 * NO FER CAP MODIFICACIÓ!!
		 * Si la fila o la columna no estan dins el rang del tauler, retornar un text
		 * amb l'error, altrament retornar nul
		 */
		private string validarCoordenada(int[] coordenada)
		{
			int mida = jocMemory.getMida();
			if (coordenada[0] < 0 || coordenada[0] >= mida)
			{
				return "La fila no correspon al tauler, entra un enter entre 0 i " + mida;
			}
			if (coordenada[1] < 0 || coordenada[1] >= mida)
			{
				return "La columna no correspon al tauler, entra un enter entre 0 i " + mida;
			}
			return null;
		}


		/*
		 * NO FER CAP MODIFICACIÓ!!
		 * Si el contingut de les caselles que referncien els atributs coordenada1 i
		 * coordenada2 són diferents, cal col·locar, a les dues caselles de l'atribut tauler,
		 * la celdaBuida. Un cop fet al pas anterior, sempre caldrà: 
		 * 1. actualitzar l'atribut intentsPerFerParelles. 
		 * 2. possar a nul els dos atributs coordenada.
		 */
		private void comprovarResultat()
		{
			string element1, element2;
			element1 = jocMemory.getElementDelTauler(coordenada1);
			element2 = jocMemory.getElementDelTauler(coordenada2);
			if (!element1.Equals(element2))
			{
				tauler[coordenada1[0], coordenada1[1]] = jocMemory.getCellaBuida();
				tauler[coordenada2[0], coordenada2[1]] = jocMemory.getCellaBuida();
			}
			intentsFets++;
			coordenada1 = null;
			coordenada2 = null;
		}

		// Retorna el número d'intents per fer parelles
		public int getIntents()
		{
			return intentsFets;

		}


	}
}
