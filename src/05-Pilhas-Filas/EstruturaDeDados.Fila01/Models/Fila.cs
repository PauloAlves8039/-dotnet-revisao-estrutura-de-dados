namespace EstruturaDeDados.Fila01.Models
{
    public class Fila<T>
    {
        private T[] elementos;
        private int inicio;
        private int fim;
        private int tamanho;

        public Fila(int capacidade)
        {
            elementos = new T[capacidade];
            inicio = 0;
            fim = -1;
            tamanho = 0;
        }

        public void Enfileirar(T item)
        {
            if (tamanho == elementos.Length)
            {
                throw new InvalidOperationException("A fila está cheia.");
            }

            fim = (fim + 1) % elementos.Length;
            elementos[fim] = item;
            tamanho++;
        }

        public T Desenfileirar()
        {
            if (tamanho == 0)
            {
                throw new InvalidOperationException("A fila está vazia.");
            }

            T item = elementos[inicio];
            inicio = (inicio + 1) % elementos.Length;
            tamanho--;
            return item;
        }

        public T Frente()
        {
            if (tamanho == 0)
            {
                throw new InvalidOperationException("A fila está vazia.");
            }

            return elementos[inicio];
        }

        public bool EstaVazia()
        {
            return tamanho == 0;
        }

        public int Tamanho()
        {
            return tamanho;
        }
    }
}
