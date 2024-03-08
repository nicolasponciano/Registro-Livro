using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_03_PROJETO_2
{
    class BLL_Livro
    {
        public static void ValidarDados(Livro novoLivro)
        {
            Erro.TemErro = false;

            //faz a validação da Base
            if (novoLivro.Titulo.Length == 0)
            {
                Erro.Mensagem = "O campo Titulo é obrigatório!";
                return;
            }

            if (novoLivro.Autor.Length == 0)
            {
                Erro.Mensagem = "O campo Autor  é obrigatório!";
                return;
            }
            if (novoLivro.Editora.Length == 0)
            {
                Erro.Mensagem = "O campo Editora é obrigatório!";
                return;
            }
            if (novoLivro.AnoEdicao.Length == 0)
            {
                Erro.Mensagem = "O campo Ano de Edição é obrigatório!";
                return;
            }
            else
            {
                try
                {
                    float.Parse(novoLivro.AnoEdicao);
                }
                catch
                {
                    Erro.Mensagem = "O campo Ano de Edição deve ser Númerico!";
                    return;
                }
                if (float.Parse(novoLivro.AnoEdicao) <= 0)
                {
                    Erro.Mensagem = "O campo AnoEdicao de Horas  deve ser maior que 0 !";
                    return;
                }
                if (novoLivro.Local.Length == 0)
                {
                    Erro.Mensagem = "O campo Local é obrigatório!";
                    return;
                }
            }
        }
    }
}
