using AutoMapper;
using YouReallyNeedABudget.Models;

namespace YouReallyNeedABudget.WebApi
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Log, DTO.Log>();
            CreateMap<DTO.Log, Log>();

            CreateMap<Account, DTO.Account>();
            CreateMap<DTO.Account, Account>();

            CreateMap<Transaction, DTO.Transaction>();
            CreateMap<DTO.Transaction, Transaction>();

        }
    }
}
