public interface IFornecedorRepository
{
    public List<Fornecedor> GetAll();
    public Fornecedor Get(int id);
    public void  Post(Fornecedor fornecedor);
    public Fornecedor Put(int id, Fornecedor fornecedorAtualizado);
    public Fornecedor Delete(int id);
}