using AutoMapper;

namespace AutoMapperDemo
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Wallet, WalletDTO>();
            CreateMap<WalletDTO, Wallet>();
        }
    }
}
