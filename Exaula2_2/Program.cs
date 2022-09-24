namespace Exaula2_2 {
    internal class Program {
        static void Main(string[] args) {
            int dia,mes,ano,calculo;

            Console.WriteLine("Digite o ano do seu nascimento: ");
            ano = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o mes do seu nascimento: ");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o dia do seu nascimento: ");
            dia = int.Parse(Console.ReadLine());

            calculo = ((2020-ano) * 365) + ((mes-1) * 30) + dia;

            Console.WriteLine("Você tem {0} dias em idade.", calculo);

        }
    }
}