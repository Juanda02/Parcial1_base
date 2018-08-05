﻿using System;
using System.Collections.Generic;

namespace Parcial1_logic
{
    public class TestObject
    {
        public static void Main(string[] args)
        {
            //Puede hacer llamados aquí para probar su código, aunque se recomienda correr las pruebas.

            Console.ReadKey();
        }

        #region DATA_STRUCTURES

        /*
         * Esta sección del examen evalúa el dominio de las estructuras de datos lineales básicas.
         * VALOR: 2.5 (0.5 cada ejercicio)
         */

        /// <summary>
        /// Reemplaza todas las ocurrencias del número 'lookupValues'
        /// con el valor de 'replaceValue'.
        /// La cola debe retornarse en el mismo orden entregado.
        /// </summary>
        /// <param name="inputQueue">La cola con los valores originales</param>
        /// <param name="lookupValue">Número a reemplazar</param>
        /// <param name="replaceValue">Nuevo valor a insertar</param>
        /// <returns>La lista de entrada con los valores modificados</returns>
        public Queue<int> ReplaceInQueue(Queue<int> inputQueue, int lookupValue, int replaceValue)
        {
            //NOTA: Para la solución NO SE PERMITE USAR el método ToArray().
            //Asuma que T es el tipo de datos

            return null;
        }

        /// <summary>
        /// Realiza la búsqueda binaria del número 'lookupValue' en la lista 'list'
        /// </summary>
        /// <param name="list"></param>
        /// <param name="lookupValue"></param>
        /// <returns>'True' si 'lookupValue' está en la lista; 'False' de otro modo</returns>
        public bool FoundWithBinarySearch(List<int> list, int lookupValue)
        {
            return false;
        }

        /// <summary>
        /// Invierte el contenido de la pila 'stack'
        /// </summary>
        /// <param name="stack">La pila de entrada</param>
        /// <returns>Una pila con los valores de 'stack' invertidos</returns>
        public Stack<string> InverseStack(Stack<string> stack)
        {
            return null;
        }

        /// <summary>
        /// Intercala igual número de elementos de 'stack' y 'queue' en una lista.
        /// La mezcla empieza insertando un elemento de 'stack', luego uno de 'queue' y así sucesivamente.
        /// </summary>
        /// <param name="stack">La pila que contiene parte de los datos</param>
        /// <param name="queue">La cola que contiene parte de los datos</param>
        /// <returns>Una lista con datos intercalados de 'stack' y 'queue'</returns>
        public List<string> MixData(Stack<string> stack, Queue<string> queue)
        {
            return null;
        }

        /// <summary>
        /// Retorna el conteo de las llaves en el diccionario 'dict' que tienen como valor a 'lookupValue'.
        /// Retorna 0 si 'lookupValue' no está presente en el diccionario.
        /// Type1 y Type2 son dos clases cualquiera.
        /// </summary>
        /// <param name="dict">Diccionario con los datos</param>
        /// <param name="lookupValue">El valor a buscar en el diccionario</param>
        /// <returns></returns>
        public int RepeatedTimesInDictionary<Type1, Type2>(Dictionary<Type1, Type2> dict, Type2 lookupValue)
        {
            return -1;
        }

        #endregion DATA_STRUCTURES

        #region BONUS

        /*
         * Este ejercicio de bonificación agrega 0.5 sobre la nota original obtenida,
         * siempre que la nota sea de 3.5 o superior.
         *
         *
         */

        #endregion BONUS
    }
}