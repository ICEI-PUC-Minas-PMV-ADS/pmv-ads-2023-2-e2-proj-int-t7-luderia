class Usuario {
    public string nomeUsuario;
    public string senha;
    public string estadoLogin;

    public Date dataCadastro;

    
    public Usuario() {}

    public Usuario(string nomeUsuario, string senha, string estadoLogin, Date dataCadastro) {
        this.nomeUsuario = nomeUsuario;
        this.senha = senha;
        this.estadoLogin = estadoLogin;
        this.dataCadastro = dataCadastro;
    }


    public bool verificaLogin() {
        
    }

}