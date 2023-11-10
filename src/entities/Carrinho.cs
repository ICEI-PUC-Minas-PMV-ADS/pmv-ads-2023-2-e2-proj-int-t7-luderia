class Carrinho {
    private int numCarrinho;
    private int numProduto;
    private int quantitade;
    private int dataAdd;


    public Carrinho() {}

    public Carrinho(int numCarrinho, int numProduto, int quantitade, Date dataAdd) {
        this.numCarrinho = numCarrinho;
        this.numProduto = numProduto;
        this.quantitade = quantitade;
        this.dataAdd = dataAdd;
    }

    public Carrinho addItemCarrinho() {

    }

    public void atualizarQtd(int quantitade) {
        this.quantitade += quantitade; 
    }

    public DetalhesDoPedido verDetalheCarrinho() {
        return DetalhesDoPedido;
    }

    public void prossegCompra() {

    }
}
