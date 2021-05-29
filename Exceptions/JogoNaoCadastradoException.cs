using System;

namespace CatalogoDeJogosDotNet.Exceptions{
    public class JogoNaoCadastradoException: Exception    {
        public JogoNaoCadastradoException()
            :base("Este jogo não está cadastrado")
        {}
    }
}
