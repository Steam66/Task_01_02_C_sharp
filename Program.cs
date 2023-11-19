using System.ComponentModel;

namespace Задача_01_02
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Teapot teapot01 = new Teapot("Tefal 01", 1500, "Red", "Предназначен кипятить воду.", "Буль-буль-буль");
            teapot01.Desc();
            teapot01.Show();
            teapot01.Sound();
            Console.WriteLine();

            Microwave microwave = new Microwave("R2D2", 1000, "White", "Назначение разогревать еду.", "Хур-Хур-Хур");
            microwave.Desc();
            microwave.Show();
            microwave.Sound();
            Console.WriteLine();

            Steamboat steamboat = new Steamboat("Братьев Черепановых", 1000000, "Black", "Предназначен для перевоза людей и грузов.", "Пых-пых-пых");
            steamboat.Desc();
            steamboat.Show();
            steamboat.Sound();
            Console.WriteLine();

            Auto auto = new Auto("F1", 800000, "Red", "Предначзначен для участия в гоночных соревнованиях.", "Вжииххх!");
            auto.Desc();
            auto.Show();
            auto.Sound();
            
        }
    }
}