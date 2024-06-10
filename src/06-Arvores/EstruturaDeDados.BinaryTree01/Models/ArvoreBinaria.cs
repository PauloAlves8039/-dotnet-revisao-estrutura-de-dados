namespace EstruturaDeDados.BinaryTree01.Models
{
    public class ArvoreBinaria
    {
        private int[] arvore;
        private int tamanho;

        public ArvoreBinaria(int capacidade)
        {
            arvore = new int[capacidade];
            tamanho = 0;
        }

        public void Inserir(int valor) 
        {
            if (tamanho == arvore.Length) 
            {
                Console.WriteLine("A árvore está cheia");
                return;
            }

            arvore[tamanho] = valor;
            tamanho++;
        }

        public void ImprimirEmOrdem(int indice) 
        {
            if (!VerificarIndiceValido(indice)) 
            {
                return;
            }

            ImprimirEmOrdem(2 * indice + 1);

            Console.Write($"{arvore[indice]}  ");

            ImprimirEmOrdem(2 * indice + 2);
        }

        public void ImprimirPreOrdem(int indice) 
        {
            if (!VerificarIndiceValido(indice))
            {
                return;
            }

            Console.Write($"{arvore[indice]}  ");

            ImprimirPreOrdem(2 * indice + 1);

            ImprimirPreOrdem(2 * indice + 2);
        }

        public void ImprimirPosOrdem(int indice) 
        {
            if (!VerificarIndiceValido(indice))
            {
                return;
            }

            ImprimirPosOrdem(2 * indice + 1);

            ImprimirPosOrdem(2 * indice + 2);

            Console.Write($"{arvore[indice]}  ");
        }

        private bool VerificarIndiceValido(int indice)
        {
            return indice < tamanho;
        }
    }
}
