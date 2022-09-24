namespace Exaula2_5 {
    internal class Program {
        static void Main(string[] args) {
            float [] nota= new float[3];
            float soma=0, media=0;
            

            for (int i = 0; i < nota.Length; i++)
                {
                Console.WriteLine("Digite as nota: ");
                nota[i] = Convert.ToInt32(Console.ReadLine());
                soma = soma + nota[i];
            }
            
            media = soma / 3;
            Console.WriteLine("A média é: {0:F2}", media);
            
        }
    }
}