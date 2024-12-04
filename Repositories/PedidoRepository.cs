
public class PedidoRepository : IPedidoRepository
{   private readonly AppDbContext _context;
    public PedidoRepository(AppDbContext context)
    {
        _context = context;
    }
    public Pedido Delete(int id)
    {
      var pedido = _context.Pedidos.Find(id);
      if(pedido == null) 
        return pedido;

        _context.Pedidos.Remove(pedido);
        _context.SaveChanges();
        return pedido;
    }

    public Pedido Get(int id)
    {
       return _context.Pedidos.Find(id);
    }

    public List<Pedido> GetAll()
    {
       return _context.Pedidos.ToList();
    }

    public void Post(Pedido pedido)
    {
        _context.Pedidos.Add(pedido);
        _context.SaveChanges();
    }

    public Pedido Put(int id, Pedido pedidoAtualizado)
    {
        var pedido = _context.Pedidos.Find(id);
        if (pedido == null)
            return pedido;
        
        pedido.Data= pedidoAtualizado.Data;
        pedido.Status = pedidoAtualizado.Status;
        pedido.Descricao = pedidoAtualizado.Descricao;
        pedido.ValorTotal = pedidoAtualizado.ValorTotal;
       
        _context.SaveChanges();
        return pedido;
    }
    
}