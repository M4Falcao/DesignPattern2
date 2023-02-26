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

using DesignPattern2.Bridge;

IMensagem mensagem = new MensagemAdmin("Carlos");
mensagem.Enviador = new EnviaPorEmail();
mensagem.Envia();



