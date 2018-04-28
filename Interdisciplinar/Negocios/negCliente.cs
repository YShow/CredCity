using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjetoTransferencia;
using AcessoBancoDados;
using System.Data;
namespace Negocios
{
    class negCliente
    {
        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();


        public int Inserir(Cliente cliente)
        {
            string queryInserir = "INSERT INTO CLIENT (renda,nome,registro,rua,bairro,numero,cep,cidade,estado,tipo_pessoa,telefone,stato,idcartao) VALUES (@idcliente,@renda,@nome,@registro,@rua,@bairro,@numero,@cep,@cidade,@estado,@tipo_pessoa,@telefone,@stato,@idcartao);";
            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@renda", cliente.Renda);
            acessoDados.AdicionarParametros("@nome",cliente.Nome);
            acessoDados.AdicionarParametros("@registro",cliente.Registro);
            acessoDados.AdicionarParametros("@rua",cliente.Rua);
            acessoDados.AdicionarParametros("@bairro",cliente.Bairro);
            acessoDados.AdicionarParametros("@numero",cliente.Numero);
            acessoDados.AdicionarParametros("@cep",cliente.Cep);
            acessoDados.AdicionarParametros("@cidade",cliente.Cidade);
            acessoDados.AdicionarParametros("@estado",cliente.Estado);
            acessoDados.AdicionarParametros("@tipo_pessoa",cliente.TipoPessoa);
            acessoDados.AdicionarParametros("@telefone",cliente.Telefone);
            acessoDados.AdicionarParametros("@stato",cliente.Status);
            acessoDados.AdicionarParametros("@idcartao",cliente.CartaoCredito.IdCartao);

            acessoDados.ExecutarManipulacao(CommandType.Text, queryInserir);
            return Convert.ToInt32(acessoDados.ExecutarConsultaScalar(CommandType.Text, "SELECT @@IDENTITY"));
        }

        public int Alterar(Cliente cliente)
        {


            string queryAlterar = "update CLIENTE set renda = @renda,nome = @nome,registro = @registro,rua = @rua,bairro = @rua,numero = @numero,cep = @cep,cidade = @cidade,estado  = @estado,tipo_pessoa = @tipo_pessoa,telefone = @telefone,stato = @stato,idcartao = @idcartao where id_cliente = @idcliente";
            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@renda", cliente.Renda);
            acessoDados.AdicionarParametros("@nome", cliente.Nome);
            acessoDados.AdicionarParametros("@registro", cliente.Registro);
            acessoDados.AdicionarParametros("@rua", cliente.Rua);
            acessoDados.AdicionarParametros("@bairro", cliente.Bairro);
            acessoDados.AdicionarParametros("@numero", cliente.Numero);
            acessoDados.AdicionarParametros("@cep", cliente.Cep);
            acessoDados.AdicionarParametros("@cidade", cliente.Cidade);
            acessoDados.AdicionarParametros("@estado", cliente.Estado);
            acessoDados.AdicionarParametros("@tipo_pessoa", cliente.TipoPessoa);
            acessoDados.AdicionarParametros("@telefone", cliente.Telefone);
            acessoDados.AdicionarParametros("@stato", cliente.Status);
            acessoDados.AdicionarParametros("@idcartao", cliente.CartaoCredito.IdCartao);

            return acessoDados.ExecutarManipulacao(CommandType.Text, queryAlterar);


        }

        public int Apagar(int IdCliente)
        {
            string queryApagar = "DELETE FROM CLIENTE WHERE ID_CLIENTE = IDCLIENTE";
            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@idcliente", IdCliente);
            return acessoDados.ExecutarManipulacao(CommandType.Text, queryApagar);


        }


    }
}
