namespace ProjetoEscola.Clasees
{
    class Verbetes<TChave, TValor>
    {

        
        public TChave Chave { get; private set; }
        public TValor Valor { get; private set; }
       

        public Verbetes(TChave chave,TValor valor)
        {
            this.Chave = chave;
            this.Valor = valor;
        }

        public override string ToString()
        {
            return $"Chave: {Chave.ToString()}, valor: {Valor.ToString()}\n";
        }
    }
}
