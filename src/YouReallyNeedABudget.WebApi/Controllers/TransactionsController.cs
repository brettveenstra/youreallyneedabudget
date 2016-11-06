using Microsoft.AspNetCore.Mvc;
using YouReallyNeedABudget.DataAccess;
using YouReallyNeedABudget.Models;
using AutoMapper;

namespace YouReallyNeedABudget.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class TransactionsController : Controller
    {

        private readonly ITransactionRepository _transactionRepo;
        private readonly IMapper _mapper;

        public TransactionsController(ITransactionRepository repo, IMapper mapper)
        {
            _transactionRepo = repo;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult Post([FromBody]DTO.Transaction transactionDTO)
        {
            var newTransaction = _mapper.Map<Transaction>(transactionDTO);

            _transactionRepo.Add(newTransaction);

            return Created(string.Format("/api/transaction/{0}", newTransaction.ID), _mapper.Map<DTO.Transaction>(newTransaction));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _transactionRepo.Remove(id);

            return NoContent();
        }
    }
}
