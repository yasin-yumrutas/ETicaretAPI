//using ETicaretAPI.Application.Abstractions;
using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
 
        readonly private IProductWriteRepository _productWriteRepository;
        readonly private IProductReadRepository _productReadRepository;
        readonly private IOrderWriteRepository _orderWriteRepository;
        readonly private IOrderReadRepository _orderReadRepository;
        readonly private ICustomerWriteRepository _customerWriteRepository;
        public ProductsController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository, IOrderWriteRepository orderWriteRepository,IOrderReadRepository orderReadRepository, ICustomerWriteRepository customerWriteRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
            _orderWriteRepository = orderWriteRepository;
            _orderReadRepository = orderReadRepository;
            _customerWriteRepository = customerWriteRepository;
        }
        [HttpGet]
        public async Task Get()
        {
            Order order=await _orderReadRepository.GetByIdAsync("0fd7c950-b52d-4ed3-9534-f06164017901");
            order.Adress = "İstanbul";
            await _orderWriteRepository.SaveAsync();
        }

        //[HttpGet("{id}")]
        //public async Task<IActionResult>Get(string id)
        //{
        //    Product product = await _productReadRepository.GetByIdAsync(id);
        //    return Ok(product);
        //}
    }
}
