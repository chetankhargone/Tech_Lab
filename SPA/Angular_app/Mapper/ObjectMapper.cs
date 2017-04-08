namespace Angular_app.Mapper
{
    using Angular_app.DTO;
    using Angular_app.Models;
    using Angular_app.ViewModel.Account;
    using AutoMapper;
    using System.Collections;
    using System.Collections.Generic;

    public class ObjectMapper
    {
        private readonly IMapper _mapper;

        public ObjectMapper()
        {
           var config = new MapperConfiguration(cfg => 
               {
                   cfg.CreateMap<LoginVM, CustomerTO>()
                      .ForMember(dest => dest.CustEmail, opt => opt.MapFrom(src => src.Username))
                      .ForMember(dest => dest.Password, opt => opt.MapFrom(src => src.Password));
                   cfg.CreateMap<CustomerTO, Customer>()
                       .ForMember(dest => dest.CustId, opt => opt.MapFrom(src => src.CustId))
                       .ForMember(dest => dest.CustName, opt => opt.MapFrom(src => src.CustName))
                       .ForMember(dest => dest.CustEmail, opt => opt.MapFrom(src => src.CustEmail))
                       .ForMember(dest => dest.CustCountry, opt => opt.MapFrom(src => src.CountryId));
               }
                      
                    


            );
           _mapper = config.CreateMapper();
        }

        public CustomerTO Map(LoginVM srcModel)
        {
            var customer = _mapper.Map<LoginVM, CustomerTO>(srcModel);
            return customer;
        }
        public Customer Map(CustomerTO srcModel)
        {
            var customer = _mapper.Map<CustomerTO, Customer>(srcModel);
            return customer;
        }
        public IEnumerable<CustomerTO> Map(IEnumerable<Customer> srcModel)
        {
            var customers = _mapper.Map<IEnumerable<Customer>, IEnumerable<CustomerTO>>(srcModel);
            return customers;
        }
    }
}