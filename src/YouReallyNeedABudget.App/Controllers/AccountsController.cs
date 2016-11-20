using Microsoft.AspNetCore.Mvc;
using YouReallyNeedABudget.DataAccess;
using AutoMapper;
using YouReallyNeedABudget.Models;
using System.Collections.Generic;

namespace YouReallyNeedABudget.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class AccountsController : Controller
    {

        private readonly IAccountRepository _accountRepo;
        private readonly IMapper _mapper;

        public AccountsController(IAccountRepository accountRepo, IMapper mapper)
        {
            _accountRepo = accountRepo;
            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<DTO.Account> GetAll()
        {
            var accounts = _accountRepo.GetAll();

            return _mapper.Map<IEnumerable<DTO.Account>>(accounts);
        }

        [HttpGet("{id}")]
        public DTO.Account Get(int id)
        {
            var account = _accountRepo.Get(id);

            return _mapper.Map<DTO.Account>(account);
        }

        [HttpPost]
        public IActionResult Post([FromBody]DTO.Account accountDTO)
        {
            var newAccount = _mapper.Map<Account>(accountDTO);

            _accountRepo.Add(newAccount);

            return Created(string.Format("/api/accounts/{0}", newAccount.ID), _mapper.Map<DTO.Account>(newAccount));
        }


    }
}
