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

using DesignPattern2.Interpreter;

IExpression esquerda = new Soma(new Numero(1), new Numero(5));
IExpression direita = new Subtracao(new Numero(10), new Numero(5));

IExpression soma = new Soma(esquerda, direita);

Console.WriteLine(soma.Avalia());


