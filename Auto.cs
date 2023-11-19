using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Задача_01_02
{
    internal class Auto:Device
    {
        public Auto(string? name, double power, string? color, string? desc, string? sound)
        {
            Name = name;
            Power = power;
            Color = color;
            _Desc = desc;
            _Sound = sound;
        }

        public override void Sound()
        {
            Console.WriteLine($"Устройство: {Name}. Издает звук при работе: {_Sound}");
        }

        public override void Show()
        {
            Console.WriteLine($"Название устройства: {Name}");
        }

        public override void Desc()
        {
            Console.WriteLine($"Устройство {Name}. Назначение: {_Desc}");
        }
    
    }
}
