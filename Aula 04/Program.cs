Tela tela = new Tela(ConsoleColor.Black, ConsoleColor.White);//(ConsoleColor.Green, ConsoleColor.Yellow)definir a cor da tela
//amarela e letra verda

Clientes clientes = new Clientes(tela);

// a classe eu só uso uma vez no inicio EX: classe objeto = new OBJETO-MÉTODO CONSTRUTOR

string op;


//definição do menu do progrma
List<string> opcoes = new List<string>();
opcoes.Add("1 - Cadastro de Clientes");
opcoes.Add("2 - Cadastro de Contas  ");
opcoes.Add("3 - Registrar movimento ");
opcoes.Add("4 - Emitir extrato      ");
opcoes.Add("0 - Sair do sistema     ");

while(true){
    tela.montarMoldura(0,0,80,25);
    op = tela.mostrarMenu(opcoes, 30, 2);//mostra aonde o menu vai ficar

    if (op=="0") break;
    
    if (op=="1") clientes.executarCRUD(); // o executar é um método (objeto.MÉTODO) -- QUESTÃO DE PROVA

    // if (op=="2")
}
Console.Clear();

