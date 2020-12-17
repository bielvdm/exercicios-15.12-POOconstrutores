namespace POOconstrutores.classes
{
    public class construtor
    {
        public int Codigo {get; set;}
        public string Nome {get; set;}
        public string Descricao {get; set;}
        public int Estoque {get; set;}

        public construtor(){}
        public construtor (int codigo){
            Codigo=codigo;
        }
        public construtor (int codigo, string nome, string descricao, int estoque){
            Codigo=codigo;
            Nome=nome;
            Descricao=descricao;
            Estoque=estoque;
        }
    }
}