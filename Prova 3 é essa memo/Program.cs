using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_3_é_essa_memo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Dentre as três figuras, escolha uma para ser calculada a àrea :\n \t 1-Triângulo: 2-paralelogramo : 3-Trapézio");
            num = Convert.ToInt32(Console.ReadLine());
            string figura = null;

            switch (num)
            {
                case 1: figura = "Triangulo"; break;
                case 2: figura = "paralelogramo"; break;
                case 3: figura = "Trapézio"; break;
            }

            if (figura == "Triangulo")
            {
                Console.WriteLine("Digite o valor da base do triângulo:");
                double ba = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o valor da altura do triângulo:");
                double alt = Convert.ToDouble(Console.ReadLine());

                double a = (ba * alt) / 2;

                Console.WriteLine("A área do" + figura + " é de " + a + " cm2");
            }
             if (figura == "paralelogramo")
             {

                Console.Write(" Me informe a base do paralelogramo : ");
                double ba = Convert.ToDouble(Console.ReadLine());
                Console.Write(" Informe a altura do paralelogramo :");
                double alt = Convert.ToDouble(Console.ReadLine());
                double a = (ba * alt);
                Console.Write(" A area do paralelogramo é :" + a);
             }
            if (figura == "Trapézio")
            {
                Console.WriteLine("Digite o valor da Base Maior do Trapézio");
                double basemaior = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o valor da Base Menor do Trapézio");
                double basemenor = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o valor da Altura do Trapézio");
                double altura = Convert.ToDouble(Console.ReadLine());

                double area = ((basemaior + basemenor) * altura) / 2;
                Console.WriteLine("A area do trapezio é: " + area);


            }
            Console.ReadKey();
            
        }
    }
}
