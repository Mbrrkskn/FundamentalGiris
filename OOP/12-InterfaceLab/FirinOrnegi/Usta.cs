﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_InterfaceLab.FirinOrnegi
{
    public class Usta:IYogurma
    {
        public string AdSoyad { get; set; }

        public void MolaVer()
        { }
        public void CayIc()
        { }
        public void HamurYogur()
        {
            Console.WriteLine(AdSoyad + " Hamur yoğurdu");
        }
    }
}
