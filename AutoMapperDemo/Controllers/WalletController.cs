using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperDemo.Controllers
{


    [ApiController]
    [Route("api/[controller]")]
    public class WalletController : ControllerBase
    {

        private readonly IMapper _mapper;

        public WalletController(IMapper mapper)
        {
            _mapper = mapper;
        }


        private List<Wallet> wallets = new List<Wallet>()
        {
            new Wallet
            {
                Id = 1,
                Name = "PayPal",
                FirstNameOwner = "Imad",
                LastNameOwner = "Ettamen",
                Agency = "CIH",
                DateStart = new DateTime(2023, 09, 12),
                DateFinish = new DateTime(2027, 01, 12),
            },
            new Wallet
            {
                Id = 2,
                Name = "Venmo",
                FirstNameOwner = "Abdellah",
                LastNameOwner = "Ettamen",
                Agency = "BMCI",
                DateStart = new DateTime(2012, 06, 12),
                DateFinish = new DateTime(2021, 04, 23),
            }
        };


        // first without dto (return just wallets) after with dto 
        //[HttpGet]
        //public ActionResult<List<Wallet>> GetWallets()
        //{
        //    // when i create the DTO
        //    // without AutoMapper :
        //    //var walletdto = new WalletDTO();
        //    //walletdto.Name = wallets[0].Name;
        //    //walletdto.FirstNameOwner = wallets[0].FirstNameOwner;

        //    // without DTO
        //    return wallets;
        //}



        // with AutoMapper :
        [HttpGet]
        public ActionResult<List<Wallet>> GetWallets()
        {
            return Ok(wallets.Select(wallet => _mapper.Map<WalletDTO>(wallet)));
        }

        [HttpPost]
        public ActionResult<List<Wallet>> AddWallet(WalletDTO walletDTO)
        {

            var wallet =  _mapper.Map<Wallet>(walletDTO);  
            wallets.Add(wallet);
            return Ok(wallets.Select(wallet => _mapper.Map<WalletDTO>(wallet)));
        }
    }
}
