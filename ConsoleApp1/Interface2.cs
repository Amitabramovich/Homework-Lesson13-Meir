using System;
using System.Collections.Generic;
using System.Text;
namespace InterfaceHW
{
    class Program
    {
        public static void Main(string[] args)
        {
            Birds americanEagle = new Birds();
            Dinosaur tirex = new Dinosaur();
            Fish nilePrincess = new Fish();

            AnimalMakeSoundBeforeEating(americanEagle);
            AnimalMakeSoundBeforeEating(tirex);

            AnimalIsHungery(americanEagle);
            AnimalIsHungery(tirex);
            AnimalIsHungery(nilePrincess);

            AnimalIsTired(americanEagle);
            AnimalIsTired(tirex);
            AnimalIsTired(nilePrincess);


        }
        public static void AnimalIsHungery(IAnimal aa)
        {
            
            if (aa is IMakeSoundable)
            {
                IMakeSoundable xx = aa as IMakeSoundable;
                xx.MakeSoundBeforeEating();
                aa.Eat();
            }
        }
        public static void AnimalIsTired(IAnimal aa)
        {
            aa.Sleep();
        }
        public static void AnimalMakeSoundBeforeEating(IMakeSoundable aa)
        {
            aa.MakeSoundBeforeEating();
        }            
    }

    interface IAnimal
    {
        void Eat();
        void Sleep();
        void Move();
    }

    interface IMakeSoundable
    {
        void MakeSoundBeforeEating();
    }
}
