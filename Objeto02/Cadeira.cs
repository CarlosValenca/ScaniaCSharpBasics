namespace Objeto02
{
    public class Cadeira
    {
        // Aqui escrevendo PROP + TAB + TAB eu criei a propriedade Cor abaixo que permite leitura (get) e escrita (set)
        public string Cor { get; set; }
        public int Tamanho { get; set; }

        // Isto se chama construtor: basicamente é onde um objeto novo nasce e onde você pode definir valores iniciais para a nova mesa que você criar
        public Cadeira()
        {
            Cor = "Azul";
            Tamanho = 5;
        }
    }
}