namespace EstruturaDeDados.Pilha01.Models
{
    public class Pilha<T>
    {
        private T[] elementos;
        private int topo;

        public Pilha(int tamanho)
        {
            elementos = new T[tamanho];
            topo = -1;
        }

        public void Empilhar(T item) 
        {
            if (topo == elementos.Length - 1)
            {
                throw new InvalidOperationException("A pilha está cheia.");
            }
            elementos[++topo] = item;
        }

        public T Desempilhar() 
        {
            if (topo == -1)
            {
                throw new InvalidOperationException("A pilha está vazia.");
            }
            return elementos[topo--];
        }

        public T Topo() 
        {
            if (topo == -1) 
            {
                throw new InvalidOperationException("A pilha está vazia.");
            }

            return elementos[topo];
        }

        public bool EstaVazia() 
        {
            return topo == -1;
        }

        public int Tamanho() 
        {
            return topo + 1;
        }
    }
}
