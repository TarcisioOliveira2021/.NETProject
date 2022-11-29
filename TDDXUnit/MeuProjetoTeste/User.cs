namespace MeuProjetoTeste
{
    public class User
    {
       
        public string Nome { get; set; }
        public int Idade { get; set; }


        //Para usar no TDDExemplo2 --> UsersTemConteudo
        public User()
        {

        }

        public User(string Nome, int Idade)
        {
            this.Nome = Nome;
            this.Idade = Idade;
        }



        public bool ValidaIdade()
        {
            if (Idade >= 18)
            {
                return true;
            }
            return false;
        }

    }
}