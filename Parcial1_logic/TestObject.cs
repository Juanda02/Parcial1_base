using System;
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
         * VALOR: 2.5 (0.625 cada ejercicio)
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

            int recorrido = inputQueue.Count;
            Queue<int> cola2 = new Queue<int>(recorrido);

           for(lookupValue=0;lookupValue<=inputQueue.Count;lookupValue++)
            {
                int evaluado = inputQueue.Dequeue();

                if (evaluado == lookupValue)
                {

                    cola2.Enqueue(evaluado);

                }
                else
                {

                    cola2.Enqueue(evaluado);

                }

                

            }



            //NOTA: Para la solución NO SE PERMITE USAR el método ToArray().
            return cola2;

        }

        /// <summary>
        /// Invierte el contenido de la pila 'stack'
        /// </summary>
        /// <param name="stack">La pila de entrada</param>
        /// <returns>Una pila con los valores de 'stack' invertidos</returns>
        public Stack<string> InverseStack(Stack<string> stack)
        {

            Stack<string> inverse = new Stack<string>();
            while (stack.Count > 0)
            {
                inverse.Push(stack.Pop());
            }
            return inverse;


            //NOTA: Para la solución NO SE PERMITE USAR el método ToArray().




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

            List<string> mixList = new List<string>();
            for (int i = 0; i < queue.Count; i++)
            {
                mixList.Add(stack.Pop());
                mixList.Add(queue.Dequeue());
            }
            return mixList;


            //NOTA: Para la solución NO SE PERMITE USAR el método ToArray().
            
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