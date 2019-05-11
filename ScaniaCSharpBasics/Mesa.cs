namespace Objeto01
{
    public class Mesa
    {
        // Aqui escrevendo PROP + TAB + TAB eu criei a propriedade Cor abaixo que permite leitura (get) e escrita (set)
        public string Cor { get; set; }
        public int Tamanho { get; set; }

        // Isto se chama construtor: basicamente é onde um objeto novo nasce e onde você pode definir valores iniciais para a nova mesa que você criar
        public Mesa()
        {
            Cor = "Ametista";
            Tamanho = 10;
        }
    }
}