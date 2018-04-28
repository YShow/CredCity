using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjetoTransferencia;
using AcessoDados;

namespace Negocios
{
        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

        public int Inserir(Previdencia previdencia)
        {
            string queryInserir = "INSERT INTO tblPrevidencia(idprevidencia,idcliente,cobertura_risco_invalidez," 
            + "cobertura_risco_morte,contribuicao, contribuicao_total) VALUES @IdPrevidencia, @IdCliente, @CoberturaRiscoInvalidez," +
     "@CoberturaRiscoMorte, @Contribuicao, @ContribuicaoTotal);";
 
            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@IdPrevidencia", previdencia.idprevidencia);
            acessoDados.AdicionarParametros("@IdCliente", previdencia.idcliente);
            acessoDados.AdicionarParametros("@CoberturaRiscoInvalidez", previdencia.cobertura_risco_invalidez);
            acessoDados.AdicionarParametros("@CoberturaRiscoMorte", previdencia.cobertura_risco_morte);
            acessoDados.AdicionarParametros("@Contribuicao", previdencia.cotribuicao);
            acessoDados.AdicionarParametros("@ContribuicaoTotal", previdencia.contribuicao_total);

            acessoDados.ExecutarManipulacao(CommandType.Text, queryInserir);

            return Convert.ToInt32(acessoDados.ExecutarConsultaScalar(CommandType.Text, "SELECT @@IDENTITY"));

        }

        public int Alterar(Cliente cliente)
        {
            string queryAlterar = "UPDATE cliente SET nome = @Nome,rg = @RG,cpf = @CPF,"
            + "data_nascimento = @DataMascimento, telefone = @Telefone WHERE id_cliente = @IdCliente;";

            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@IdCliente", cliente.IdCliente);
            acessoDados.AdicionarParametros("@Nome", cliente.Nome);
            acessoDados.AdicionarParametros("@RG", cliente.RG);
            acessoDados.AdicionarParametros("@CPF", cliente.CPF);
            acessoDados.AdicionarParametros("@DataNascimento", cliente.DataNascimento);
            acessoDados.AdicionarParametros("@Telefone", cliente.Telefone);


            return acessoDados.ExecutarManipulacao(CommandType.Text, queryAlterar);

        }

        public int Apagar(int IdCliente)
        {
            string queryApagar = "DELETE FROM cliente WHERE id_cliente = @IdCliente";

            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@IdCliente", IdCliente);

            return acessoDados.ExecutarManipulacao(CommandType.Text, queryApagar);
        }
    }
}
