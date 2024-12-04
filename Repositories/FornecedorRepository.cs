
public class FornecedorRepository : IFornecedorRepository
{
    private readonly AppDbContext _context;
    public FornecedorRepository(AppDbContext context)
    {
        _context = context;
    }
    public Fornecedor Delete(int id)
    {
        var fornecedor = _context.Fornecedores.Find(id);
      if(fornecedor == null) 
        return fornecedor;

        _context.Fornecedores.Remove(fornecedor);
        _context.SaveChanges();
        return fornecedor;
    }

    public Fornecedor Get(int id)
    {
        return _context.Fornecedores.Find(id);
    }

    public List<Fornecedor> GetAll()
    {
        return _context.Fornecedores.ToList();
    }

    public void Post(Fornecedor fornecedor)
    {
        _context.Fornecedores.Add(fornecedor);
        _context.SaveChanges();
    }

    public Fornecedor Put(int id, Fornecedor fornecedorAtualizado)
    {
        var fornecedor = _context.Fornecedores.Find(id);
        if (fornecedor == null)
            return fornecedor;

        fornecedor.Nome = fornecedorAtualizado.Nome;
        fornecedor.CNPJ = fornecedorAtualizado.CNPJ;
        fornecedor.Telefone = fornecedorAtualizado.Telefone;
        fornecedor.Email = fornecedorAtualizado.Email;
        fornecedor.Endereco = fornecedorAtualizado.Endereco;
       
        _context.SaveChanges();
        return fornecedor;
    }
}