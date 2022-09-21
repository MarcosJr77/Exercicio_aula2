namespace Exaula2_4 {
    internal class Program {
        static void Main(string[] args) {
            double htb = 10.00;
            double hora_extra = 15.00;
            int horas, hextra;
            double sal_bruto, sal_liquid;

            Console.WriteLine("Digite horas trabalhadas: ");
            horas = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a hora extra: ");
            hextra = int.Parse(Console.ReadLine());

            if (hextra == 0) {
                sal_bruto = htb * horas;
                sal_liquid = sal_bruto - ((sal_bruto * 10) / 100);
                Console.WriteLine("O salário líquido é: R${0} e o salário bruto é: R${1}", sal_bruto, sal_liquid);
            } else {
                sal_bruto = (htb * horas) + (hora_extra * hextra);
                sal_liquid = sal_bruto - ((sal_bruto * 10) / 100);
                Console.WriteLine("O salário bruto é: R${0} e o salário líquido é: R${1:F2}", sal_bruto, sal_liquid);
            }
        }
    }
}