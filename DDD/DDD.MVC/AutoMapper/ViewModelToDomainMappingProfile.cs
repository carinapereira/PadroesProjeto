using AutoMapper;
using DDD.Domain.Entities;
using DDD.MVC.ViewModels;

namespace DDD.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile 
    {
        public override string ProfileName 
        {   
            get { return "DomainToViewModelMappings"; }

        }

        protected override void Configure()
        {
            Mapper.CreateMap<Cliente, ClienteViewModel >();
            Mapper.CreateMap<Produto, ProdutoViewModel>();

        }
    }
}