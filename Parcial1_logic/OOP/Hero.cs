using System;

namespace Parcial1_logic.OOP
    


{
    public class Hero : Actor
    {
        public Weapon CurrentWeapon { get; protected set; }
        public Armor CurrentArmor { get; protected set; }

        public void ResetEquipment()
        {
            CurrentArmor = null;
            CurrentWeapon = null;
        }

        public void Mover(MovementType moverPersonaje)
        {
            moverPersonaje = MovementType.Input;
            Console.WriteLine("El Heroe se mueve");
            Console.WriteLine(moverPersonaje);

            

        }
        public Hero(float ataque, float defensa)
        {

            BaseAtk = ataque;
            BaseDef = defensa;

        }



    }
}