namespace Exaula2_3 {
    internal class Program {
        static void Main(string[] args) {

            int ma = 0;
            double pre1=1.00, pre2=1.30, calculo;

            Console.WriteLine("Digite numero de maças desejada: ");
            ma = int.Parse(Console.ReadLine());

            if (ma >= 12) {
                calculo = ma * pre1;
                Console.WriteLine("Total da compra é: R${0:F2}", calculo);
            } else {
                calculo = ma * pre2;
                Console.WriteLine("Total da compra é: R${0:F2}", calculo);
            }
        }
    }
}