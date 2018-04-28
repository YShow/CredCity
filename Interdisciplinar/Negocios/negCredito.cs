using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjetoTransferencia;
using AcessoDados;
using System.Data;

namespace Negocios
{
    public class negCredito
    {
        
        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

        public int Inserir(Credito credito)
        {
            string queryInserir = "INSERT INTO cliente(idCredito, juros_anual," 
            + "max_parcelas, nome_linha) VALUES @IdCredito, @JurosAnual, @MaxParcelas, @NomeLinha);";
 
            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@IdCredito", credito.idCredito);
            acessoDados.AdicionarParametros("@JurosAnual", credito.juros_anual);
            acessoDados.AdicionarParametros("@MaxParcelas", credito.max_parcelas);
            acessoDados.AdicionarParametros("@NomeLinha", credito.nome_linha);
            
            acessoDados.ExecutarManipulacao(CommandType.Text, queryInserir);

            return Convert.ToInt32(acessoDados.ExecutarConsultaScalar(CommandType.Text, "SELECT @@IDENTITY"));

        }

        public int Alterar(Credito credito)
        {
            string queryAlterar = "UPDATE credito SET idCredito = @IdCredito,juros_anual = @JurosAnual,max_parcelas = @MaxParcelas,"
            + "nome_linha = @NomeLinha WHERE idCredito = @IdCredito;";

            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@IdCredito", credito.IdCliente);
            acessoDados.AdicionarParametros("@JurosAnual", credito.juros_anual);
            acessoDados.AdicionarParametros("@MaxParcelas", credito.max_parcelas);
            acessoDados.AdicionarParametros("@NomeLinha", credito.nome_linha);

            return acessoDados.ExecutarManipulacao(CommandType.Text, queryAlterar);

        }

        public int Apagar(int IdCliente)
        {
            string queryApagar = "DELETE FROM credito WHERE idCredito = @IdCredito";

            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@IdCredito", IdCliente);

            return acessoDados.ExecutarManipulacao(CommandType.Text, queryApagar);
        }
    }
}

