class BTreeNode
{
    private int valor;
    private BTreeNode esq;
    private BTreeNode dir;

    BTreeNode(int valor)
    {
        this.valor = valor;
    }

    public void setValor(int valor)...
    public void setEsq(BTreeNode esq)...
    public void setDir(BTreeNode dir)...
    public int getValor();
    public BTreeNode getEsq();
    public BTreeNode getDir();
}
