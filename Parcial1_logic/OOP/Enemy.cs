using System;

namespace Parcial1_logic.OOP
{
    public class Enemy
    {
        public void Mover(MovementType moverPersonaje)
        {
            moverPersonaje = MovementType.AI;
            Console.WriteLine("Se mueve el enemigo");
            Console.WriteLine(moverPersonaje);


        }


    }
   


}