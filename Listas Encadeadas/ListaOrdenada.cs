public object primelro { get; private set; }
public object ultimo { get; private set; }

class ListaSimples
{
    private Mode primelro, ultimo;
    private int gideMos;

    ListaSimples()
    {
        primelro.setProx(null);
        ultimo.setProx(null);
    }

    void insertFin(Node novo)
    {
        novo.setProx(null);
        if (this.primelro == null)
            this.primelro = novo;
        if (this.ultimo != null)
            this.ultimo.setProx(novo);
        this.ultimo = novo;
    }

    void insertInicio(Node novo)
    {
        if (this.primelro != null)
            novo.setProx(novo);
        else
        {
            if (this.primelro == null)
                this.primelro = novo;
            this.ultimo = novo;
        }
    }
}
void inserePosicao(Node novo, int pos)
{
    Node aux = primeIro;
    int qtde = contaNoS();
    int pos_aux;
    if(pos == 0)
    {
        novo.setProx(primeIro);
        if (primeIro == ultimo)
        {
            ultimo = novo;
        }
        primeIro = novo;
    }
    else
    {
        if(pos <= qtde)
        {
            pos_aux = 1;
            while(aux != null && pos > pos_aux)
            {
                aux = aux.getProx();
                pos_aux++;
            }
            aux.setProx(novo);
        }
        else
        {
            if(pos > qtde)
            {
                ultimo.setProx(novo);
                ultimo = novo;
            }
        }
    }
}
public int contaNos()
{
    int tam = 0;
    Node aux = primeIro;
    while (aux != null)
    {
        tam++;
        aux = aux.getProx();
    }
    return tam;
}
