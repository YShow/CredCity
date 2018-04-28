using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoBancoDados;
using ObjetoTransferencia;
using System.Data;
namespace Negocios
{
    class negAplicacao
    { //INCOMPLETO
        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();
        public int Inserir(Aplicacao aplicacao)
        {
            string queryInserir = "INSERT INTO tblAplicacao () VALUES ();";
            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@idcartao", cartao.IdCartao);
            acessoDados.AdicionarParametros("@limite_cartao", cartao.Limite);
            acessoDados.AdicionarParametros("@idcliente", cartao.Cliente.IdCLiente);


            acessoDados.ExecutarManipulacao(CommandType.Text, queryInserir);
            return Convert.ToInt32(acessoDados.ExecutarConsultaScalar(CommandType.Text, "SELECT @@IDENTITY"));
        }

        public int Alterar(Aplicacao aplicacao)
        {


            string queryAlterar = "update tblAplicacao set   where ";
            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@idcartao", cartao.IdCartao);
            acessoDados.AdicionarParametros("@limite_cartao", cartao.Limite);
            acessoDados.AdicionarParametros("@idcliente", cartao.Cliente.IdCLiente);

            return acessoDados.ExecutarManipulacao(CommandType.Text, queryAlterar);


        }

        public int Apagar(int IdAplicacao)
        {
            string queryApagar = "DELETE FROM tblAplicacao WHERE ";
            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@", IdAplicacao);
            return acessoDados.ExecutarManipulacao(CommandType.Text, queryApagar);


        }
    }
}
