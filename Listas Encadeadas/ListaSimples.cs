Node buscaNo(Object item)
{
    int i = 0;
    Node aux = primeiro;
    while (aux != null)
    {
        if(aux.getItem() == item)
        {
            return aux;
        }
        i++;
        aux = aux.getProx();
    }
    return null;
}
