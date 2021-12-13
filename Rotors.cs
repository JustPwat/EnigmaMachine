using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaInterfaceINF1433
{
    internal class Rotors
    {
        public int Position { get; set; }
        public int Decalage { get; set; }
        public bool PositifOuNegatif { get; set; }
        public bool GaucheOuDroite { get; set; }
        

        public Rotors(int position, int decalage, bool positifNegatif, bool gaucheDroite)
        {
            this.Position = position;
            this.Decalage = decalage;
            this.PositifOuNegatif = positifNegatif;
            this.GaucheOuDroite = gaucheDroite;

        }

        public Rotors()
        {

        }

        public int QuiEstPlusGrand(int rotorA, int rotorB)
        {
            if(rotorA > rotorB)
            {
                return rotorA;
            }
            else return rotorB;
        }

        public int QuiEstPlusPetit(int rotorA, int rotorB)
        {
            if (rotorA < rotorB)
            {
                return rotorA;
            }
            else return rotorB;
        }
        public int [] SetRotorPosition(int PosRotor1, int PosRotor2, int PosRotor3)
        {
            int [] positionR = {PosRotor1, PosRotor2, PosRotor3};

            if (PosRotor1 != PosRotor2 && PosRotor1 != PosRotor3 && PosRotor2 != PosRotor3)
            {
                if (PosRotor1 == 1)
                {
                    positionR[0] = PosRotor1;
                    positionR[1] = QuiEstPlusPetit(PosRotor2, PosRotor3);
                    positionR[2] = QuiEstPlusGrand(PosRotor2, PosRotor3);

                    return positionR;
                }
                else if (PosRotor2 == 1)
                {
                    positionR[0] = PosRotor2;
                    positionR[1] = QuiEstPlusPetit(PosRotor1, PosRotor3);
                    positionR[2] = QuiEstPlusGrand(PosRotor1, PosRotor3);

                    return positionR;
                }
                else if (PosRotor3 == 1)
                {
                    positionR[0] = PosRotor3;
                    positionR[1] = QuiEstPlusPetit(PosRotor1, PosRotor2);
                    positionR[2] = QuiEstPlusGrand(PosRotor1, PosRotor2);

                    return positionR;
                }

            }
            else
                positionR[0] = 1;
                positionR[1] = 2;
                positionR[2] = 3;

            return positionR;


        }

        public void DecalageRotor(int r1, int r2, int r3)
        {

        }
    }
}
