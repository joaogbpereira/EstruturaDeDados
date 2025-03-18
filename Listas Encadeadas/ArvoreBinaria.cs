class BTree
{
    private BTreeNode raiz;

    private BTreeNode insertr(BTreeNode arvore, int novo)
    {
        BTreeNode aux = null;
        if (arvore == null)
        {
            aux.setValor(novo);
            return aux;
        }
        else if (novo < arvore.getValor())
            arvore.setEsq(insertr(arvore.getEsq(), novo));
        else
            arvore.setDir(insertr(arvore.getDir(), novo));
        return arvore;
    }

    public void insertrNo(int novo)
    {
        raiz = insertr(raiz, novo);
    }
}
