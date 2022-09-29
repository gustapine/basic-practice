class Tela{
    //atributos
    private ConsoleColor corFundo;
    private ConsoleColor corTexto;
    //'visibilidade' 'tipo' 'nome do atributo';


    //metodos
    //cada método só faz uma única coisa, O nome do método é aquilo que ele faz
    public Tela(ConsoleColor fundo, ConsoleColor texto){
        this.corFundo = fundo;
        this.corTexto = texto;
        this.prepararTela();
    }

    public Tela(){
        this.corFundo = ConsoleColor.Black;
        this.corTexto = ConsoleColor.White;
        this.prepararTela();
    }

    


    public void prepararTela(){
        Console.BackgroundColor = this.corFundo;
        Console.ForegroundColor = this.corTexto;
        Console.Clear();
    }
    
    //todo parametro/variavel precisa começar com uma letra
    public void montarMoldura(int ci, int li, int cf, int lf)//plano cartesiano 
    {
        int coluna, linha;
        this.limparArea(ci, li, cf,lf);

        for(coluna=ci; coluna<=cf; coluna++){
            Console.SetCursorPosition(coluna,li);
            Console.Write("-");

            Console.SetCursorPosition(coluna,lf);
            Console.Write("-");
        }

        for(linha=li; linha <= lf; linha++){
            
            Console.SetCursorPosition(ci,linha);
            Console.Write("|");

            Console.SetCursorPosition(cf,linha);
            Console.Write("|");
        }

        //para ajeitar a janela   
        Console.SetCursorPosition(ci, li); Console.Write("+");
        Console.SetCursorPosition(ci, lf); Console.Write("+");
        Console.SetCursorPosition(cf, li); Console.Write("+");
        Console.SetCursorPosition(ci, lf); Console.Write("+");
    }

    // permite que nada tenha dentro do quadrado
    public void limparArea(int ci, int li, int cf, int lf){
        for(int x=ci; x <= cf; x++){
            for(int y= li; y<= lf; y++){
                Console.SetCursorPosition(x,y);
                Console.Write(" ");
            }
        }       
    }

    public string mostrarMenu(List<string> itens, int ci, int li){
        string op;
        int x,lf, cf;

        cf = ci + itens[0].Count() + 1;//itens existentes na lista
        lf = li + itens.Count() + 2;

        this.montarMoldura(ci, li, cf, lf);//limpa area sozinho
        for(x= 0; x < itens.Count(); x++)//coloca um por um dos itens da moldura
        {    
            Console.SetCursorPosition(ci+1, li+1+x);//na coluna inicial + um pq na coluna 0 tem um traço
            //li+1+x --> isso aqui faz sozinho
            Console.Write(itens[x]);
        }
        //x é o numero de linhas que eu tenho que pular
        Console.SetCursorPosition(ci+1, li+1+x);
        Console.Write("Opcao : ");
        
        op = Console.ReadLine();
        
        return op;
    }
}