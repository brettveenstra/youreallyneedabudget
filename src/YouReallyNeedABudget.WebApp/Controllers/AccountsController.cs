﻿using System.Linq;
using Microsoft.AspNetCore.Mvc;
using YouReallyNeedABudget.DataAccess;
using AutoMapper.QueryableExtensions;
using AutoMapper;
using YouReallyNeedABudget.Models;

namespace YouReallyNeedABudget.WebApp.Controllers
{
    [Route("api/[controller]")]
    public class AccountsController : Controller
    {

        private readonly BudgetContext _dbContext;
        private readonly IMapper _mapper;

        public AccountsController(BudgetContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public DTO.Account Get(int id)
        {
            return _dbContext.Accounts.Where(account => account.ID == id).ProjectTo<DTO.Account>().SingleOrDefault();
        }

        [HttpPost]
        public IActionResult Post([FromBody]DTO.Account account)
        {
            var newAccount = _mapper.Map<Account>(account);

            _dbContext.Accounts.Add(newAccount);
            _dbContext.SaveChanges();

            return Created(string.Format("/api/accounts/{0}", newAccount.ID), newAccount);
        }


    }
}