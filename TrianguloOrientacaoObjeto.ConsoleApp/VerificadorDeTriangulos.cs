namespace TrianguloOrientacaoObjeto.ConsoleApp
{
    internal class VerificadorDeTriangulos
    {
        public double ladoA;
        public double ladoB;
        public double ladoC;

        public VerificadorDeTriangulos()
        {
        }

        private bool VerificarTrinaguloValido()
        {
            if (ladoA + ladoB >= ladoC
             && ladoB + ladoC >= ladoA
             && ladoC + ladoA >= ladoB)
                return true;
            else
                return false;
        }

        private string VerificarTipoDeTriangulo()
        {

            if (ladoA == ladoB && ladoB == ladoC)
                return "Triangulo e equilatero";
            else if (ladoA ==  ladoB
                ||   ladoB == ladoC
                ||   ladoC == ladoA)
                return "Triangulo e isosceles";
            else
                return "Triangulo e escaleno";
        }

        public string VerificarTriangulo()
        {
            if (VerificarTrinaguloValido())
                return VerificarTipoDeTriangulo();
            else
                return "Triangulo e invalido";
        }
    }
}