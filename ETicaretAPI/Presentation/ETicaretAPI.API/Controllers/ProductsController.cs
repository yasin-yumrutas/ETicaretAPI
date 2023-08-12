//using ETicaretAPI.Application.Abstractions;
using ETicaretAPI.Application.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        // private readonly IProductService _productService;

        //
        readonly private IProductWriteRepository _productWriteRepository;
        readonly private IProductReadRepository _productReadRepository;

        public ProductsController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
        }
        [HttpGet]
        public async void Get()
        {
            await _productWriteRepository.AddRangeAsync(new()
                {
            new() { Id =Guid.NewGuid(),Name="Produc 1",Price=100, CreateDate=DateTime.UtcNow,Stock=10},
            new() { Id =Guid.NewGuid(),Name="Produc 2",Price=200, CreateDate=DateTime.UtcNow,Stock=20},
            new() { Id =Guid.NewGuid(),Name="Produc 3",Price=300, CreateDate=DateTime.UtcNow,Stock=330},
            });
            var count =await _productWriteRepository.SaveAsync();
        }
    }
}
