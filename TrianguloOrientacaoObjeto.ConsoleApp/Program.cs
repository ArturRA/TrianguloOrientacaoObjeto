namespace TrianguloOrientacaoObjeto.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VerificadorDeTriangulos verificador = new VerificadorDeTriangulos();
            verificador.ladoA = 10.00;
            verificador.ladoB = 10.00;
            verificador.ladoC = 10.00;

            Console.Write($"A verificação sera realizada com os valores:\n" +
                              $"lado A = {verificador.ladoA}\n" +
                              $"lado B = {verificador.ladoB}\n" +
                              $"lado C = {verificador.ladoC}\n" +
                              $"Sendo o resultado igual a: {verificador.VerificarTriangulo()}");
            Console.ReadLine();
        }
    }
}