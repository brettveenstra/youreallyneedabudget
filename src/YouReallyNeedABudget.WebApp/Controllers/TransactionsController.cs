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
        public IActionResult Post([FromBody]DTO.Transaction transaction)
        {
            var newTransaction = _mapper.Map<Transaction>(transaction);

            _dbContext.Transactions.Add(newTransaction);
            _dbContext.SaveChanges();

            return Created(string.Format("/api/transaction/{0}", newTransaction.ID), newTransaction);
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
