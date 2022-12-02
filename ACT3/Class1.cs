using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT3
{
    internal class Class1
    {
        private string _nom;
        private uint _Oreilles;

        public Class1(string nom, uint Oreilles)
        {
            _nom = nom;
            _Oreilles = Oreilles;
        }

       

       

        public void LectureMessage(string message, Class1 quiDit)
        {
            Console.WriteLine(_nom + " a entendu un message \n" + quiDit._nom + " a dit : " + message);
        }

        public string AfficherElephant()
        {
            return _nom + " mes oreilles  font " + _Oreilles.ToString() + " cm";
        }
        public void Message(string message, Class1 quiRecoit)
        {
            quiRecoit.LectureMessage(message, this);
        }
        public uint AvoirOreilles()
        {
            return _Oreilles;
        }
    }
}
