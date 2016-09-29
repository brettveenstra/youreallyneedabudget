using System.Linq;
using Microsoft.AspNetCore.Mvc;
using YouReallyNeedABudget.DataAccess;
using YouReallyNeedABudget.Models;
using AutoMapper;

namespace YouReallyNeedABudget.WebApp.Controllers
{
    [Route("api/[controller]")]
    public class TransactionsController : Controller
    {

        private readonly BudgetContext _dbContext;
        private readonly IMapper _mapper;

        public TransactionsController(BudgetContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult Post([FromBody]DTO.Transaction transactionDTO)
        {
            var newTransaction = _mapper.Map<Transaction>(transactionDTO);

            _dbContext.Transactions.Add(newTransaction);
            _dbContext.SaveChanges();

            return Created(string.Format("/api/transaction/{0}", newTransaction.ID), _mapper.Map<DTO.Transaction>(newTransaction));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _dbContext.Transactions.Remove(_dbContext.Transactions.Where(tx => tx.ID == id).SingleOrDefault());
            _dbContext.SaveChanges();

            return NoContent();
        }
    }
}
