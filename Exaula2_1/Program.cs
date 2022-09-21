namespace Exaula2_1 {
    internal class Program {
        static void Main(string[] args) {
            int A = 10;
            int B = 20;
            int C = A;

            A = B;
            B = C;

            Console.WriteLine("Valor de A: {0} - valor de B: {1}",A,B);
        }
    }
}