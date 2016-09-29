using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using YouReallyNeedABudget.DataAccess;
using YouReallyNeedABudget.Models;
using AutoMapper.QueryableExtensions;
using AutoMapper;

namespace YouReallyNeedABudget.WebApp.Controllers
{
    [Route("api/[controller]")]
    public class LogsController : Controller
    {
        private readonly BudgetContext _dbContext;
        private readonly IMapper _mapper;

        public LogsController(BudgetContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }


        [HttpGet]
        public IEnumerable<DTO.Log> Get()
        {
            return _dbContext.Logs.ProjectTo<DTO.Log>().ToList();
        }

        [HttpGet("{id}")]
        public DTO.Log Get(int id)
        {
            return _dbContext.Logs.Where(log => log.ID == id).ProjectTo<DTO.Log>().SingleOrDefault();
        }

        [HttpPost]
        public IActionResult Post([FromBody]DTO.Log logDTO)
        {
            var newLog = _mapper.Map<Log>(logDTO);

            _dbContext.Logs.Add(newLog);
            _dbContext.SaveChanges();
            
            return Created(string.Format("/api/logs/{0}", newLog.ID), _mapper.Map<DTO.Log>(newLog));
        }

    }
}
