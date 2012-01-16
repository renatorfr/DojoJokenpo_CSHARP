using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace DojoJokenpo
{
    public class Jokenpo
    {
        public String Jogar(String jogador1, String jogador2)
        {
            ArrayList array = new ArrayList();

            array.Add(jogador1);
            array.Add(jogador2);

            array.Sort();

            if (array[0].Equals("pedra") && array[1].Equals("tesoura"))
            {
                return "pedra";
            }
            else if (array[0].Equals("papel") && array[1].Equals("tesoura"))
            {
                return "tesoura";
            }
            else if (array[0].Equals("papel") && array[1].Equals("pedra"))
            {
                return "papel";
            }

            return "empate";
        }
    }
}
