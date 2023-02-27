/*
// using DesignPattern2.Flyweight;

// Tocador tocador = new Tocador();
// tocador.Toca();
*/

/* 
using DesignPattern2.Memento;

Historico historico = new Historico();

Contrato contrato = new Contrato(DateTime.Now, "mateus", TipoContrato.Novo);
historico.Adiciona(contrato);

contrato.Avanca();
historico.Adiciona(contrato);

contrato.Avanca();
historico.Adiciona(contrato);

contrato.Avanca();
historico.Adiciona(contrato);

Console.WriteLine(historico.Pega(1).Contrato.Tipo);
*/

/*
using DesignPattern2.Interpreter;

IExpression esquerda = new Soma(new Numero(1), new Numero(5));
IExpression direita = new Subtracao(new Numero(10), new Numero(5));

IExpression soma = new Soma(esquerda, direita);

Console.WriteLine(soma.Avalia());
*/
/*
using DesignPattern2.Interpreter;
using DesignPattern2.Visitor;

IExpression esquerda = new Soma(new Numero(1), new Numero(5));
IExpression direita = new Subtracao(new Numero(10), new Numero(5));

IExpression soma = new Soma(esquerda, direita);

Console.WriteLine(soma.Avalia());
IVisitor impressora = new Impressora();
IVisitor preFixa = new PreFixa();
soma.Aceita(impressora);
Console.WriteLine();
soma.Aceita(preFixa);
*/

/*
using DesignPattern2.Bridge;

IMensagem mensagem = new MensagemAdmin("Carlos");
mensagem.Enviador = new EnviaPorEmail();
mensagem.Envia();
*/
/*
using DesignPattern2.Commannd;

Pedido pedido1 = new Pedido("Mateus", 30.1);
Pedido pedido2 = new Pedido("Lucas", 28.17);

FilaDeTrabalho filaDeTrabalho = new FilaDeTrabalho();
filaDeTrabalho.Adiciona(new PagaPedido(pedido1));
filaDeTrabalho.Adiciona(new PagaPedido(pedido2));
filaDeTrabalho.Adiciona(new FinalizaPedido(pedido2));

filaDeTrabalho.Processa();
*/

using DesignPattern2.Adapter;

Cliente cliente = new Cliente();
cliente.Nome = "mateus";
cliente.Endereco = "Rua avenida";
cliente.DataNascimento = DateTime.Now;

GeradorXML gerador = new GeradorXML();
String xml = gerador.GeraXml(cliente);

Console.WriteLine(xml);


