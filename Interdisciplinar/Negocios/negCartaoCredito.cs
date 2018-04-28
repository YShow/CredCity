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
    class negCartaoCredito
    {
        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();
        public int Inserir(CartaoCredito cartao)
        {
            string queryInserir = "INSERT INTO tblCartaoCredito (idcartao,limite_cartao,idcliente) VALUES (@idcartao,@limite_cartao,@idcliente);";
            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@idcartao", cartao.IdCartao);
            acessoDados.AdicionarParametros("@limite_cartao", cartao.Limite);
            acessoDados.AdicionarParametros("@idcliente", cartao.Cliente.IdCLiente);
        

            acessoDados.ExecutarManipulacao(CommandType.Text, queryInserir);
            return Convert.ToInt32(acessoDados.ExecutarConsultaScalar(CommandType.Text, "SELECT @@IDENTITY"));
        }

        public int Alterar(CartaoCredito cartao)
        {


            string queryAlterar = "update tblCartaoCredito set idcartao = @idcartao,limite_cartao = @limite_cartao,idcliente = @idcliente  where id_cliente = @idcliente";
            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@idcartao", cartao.IdCartao);
            acessoDados.AdicionarParametros("@limite_cartao", cartao.Limite);
            acessoDados.AdicionarParametros("@idcliente", cartao.Cliente.IdCLiente);

            return acessoDados.ExecutarManipulacao(CommandType.Text, queryAlterar);


        }

        public int Apagar(int IdCartao)
        {
            string queryApagar = "DELETE FROM tblCartao WHERE IDCartao = @IDidcartao";
            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@idcartao", IdCartao);
            return acessoDados.ExecutarManipulacao(CommandType.Text, queryApagar);


        }

    }
}
