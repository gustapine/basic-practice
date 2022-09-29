class Clientes{

    //atributos
    Tela tela;
    List<ClienteData> registros = new List<ClienteData>();


    //métodos
    public Clientes(Tela t){
        //something
        this.tela = t;
        this.registros.Add(new  ClienteData ("1", "Xunda", "x@b.com", "123"));
        this.registros.Add(new  ClienteData ("2", "Babalu", "b@b.com", "456"));
        this.registros.Add(new  ClienteData ("2", "Babalu", "b@b.com", "456"));
        this.registros.Add(new  ClienteData ("2", "Babalu", "b@b.com", "456"));
    }
    }
    
    
    public void executarCRUD() //public pra que possa ser acessado por qualquer parte do programa, void pra n retornar nada
    {
        string cod, nom, eml, tel;
        int ci, li;
        
        ci = 10;
        li = 8;
        this.montarTela(ci,li);
        ci += 11;

        Console.SetCursorPosition(ci, li+2);
        cod = Console.ReadLine();

        // busca pelo cosifo inserido
        bool achei = false;
        for (int x=0; this.registros.Count ; x++){
            if (this.registros[x].codigo == cod){
                achei == true;
                break;
            }
        }
        Console.SetCursorPosition(ci, li+3);
        if(achei) Console.Write("Codigo já registrado!");
        else Console.Write("Código ainda não usado");
        Console.ReadKey();
        

    }

    public void montarTela(int ci, int li){
        int cf, lf;
        cf = ci + 40 + 1; //isso é pedagogico mas pode por 41/7
        lf = li + 6 + 1;

        this.tela.montarMoldura(ci, li, cf, lf);

        Console.SetCursorPosition(ci+1,li+1); 
        Console.Write("Cadastro de Clientes");

        Console.SetCursorPosition(ci+1,li+2); 
        Console.Write("Código          :");

        Console.SetCursorPosition(ci+1,li+3); 
        Console.Write("Nome            :");

        Console.SetCursorPosition(ci+1,li+4); 
        Console.Write("Email           :");
        
        Console.SetCursorPosition(ci+1,li+5); 
        Console.Write("Telefone        :");

        Console.SetCursorPosition(ci+1,li+6); 
        Console.Write("Confirma (S/N): ");



        Console.ReadKey();
    }
}   
