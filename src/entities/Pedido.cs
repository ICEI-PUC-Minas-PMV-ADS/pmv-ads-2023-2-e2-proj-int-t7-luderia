class Pedido {
    private int numPedido;
    private string dataCriacao;
    private string nomeCliente;
    private string numCliente;
    private string estado;

    public Pedido() {}

    public Pedido(int numPedido, string dataCriacao, string nomeCliente, string numCliente, string estado) {
        this.numPedido = numPedido;
        this.dataCriacao = dataCriacao;
        this.nomeCliente = nomeCliente;
        this.numCliente = numCliente;
        this.estado = estado;
    }

    public void finalizarPedido() {
        
    }
}