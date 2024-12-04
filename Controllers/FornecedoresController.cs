using Microsoft.AspNetCore.Mvc;
[ApiController]
[Route("fornecedores")]
public class FornecedoresController : ControllerBase
{
    private readonly IFornecedorRepository _repository;
    public FornecedoresController(IFornecedorRepository repository)
    {
        _repository = repository;
    }
    [HttpGet]
    public ActionResult<List<Fornecedor>> GetAll()
    {
        var fornecedores = _repository.GetAll();
        return Ok(fornecedores);
    }

    [HttpGet("{id}")]
    public ActionResult<Fornecedor> Get(int id)
    {
        var fornecedor = _repository.Get(id);

        if (fornecedor == null)
        {
            return NotFound();
        }

        return Ok(fornecedor);
    }
    [HttpPost]
    public ActionResult Post(Fornecedor fornecedor)
    {
        _repository.Post(fornecedor);
        return Created();
    }

    [HttpPut("{id}")]
    public ActionResult Put(int id, Fornecedor fornecedorAtualizado)
    {
        var fornecedor = _repository.Put(id, fornecedorAtualizado);

        if (fornecedor == null)
        {
            return NotFound();
        }

        return Ok(fornecedor);
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        var fornecedor = _repository.Delete(id);


        if (fornecedor == null)
        {
            return NotFound();
        }


        return NoContent();
    }

}
