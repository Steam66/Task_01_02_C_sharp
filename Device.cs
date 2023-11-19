using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_01_02
{
    public class Device
    {
        public string? Name {  get; set; }
        public double Power {  get; set; }
        public string? Color {  get; set; }
        public string?_Desc {  get; set; }
        public string? _Sound {  get; set; }
        public Device() { }
       
        public virtual void Sound()
        {
         
        }

        public virtual void Show()
        {
         
        }

        public virtual void Desc() 
        {
        
        }
    }
}
