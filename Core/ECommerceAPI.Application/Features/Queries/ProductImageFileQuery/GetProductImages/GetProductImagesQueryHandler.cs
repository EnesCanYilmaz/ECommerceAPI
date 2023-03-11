using ECommerceAPI.Application.Abstractions.Storage;
using ECommerceAPI.Application.Abstractions.Storage.Local;
using ECommerceAPI.Application.Repositories;
using ECommerceAPI.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Application.Features.Queries.ProductImageFileQuery.GetProductImages
{
    public class GetProductImagesQueryHandler : IRequestHandler<GetProductImagesQueryRequest, List<GetProductImagesQueryResponse>>
    {
        private readonly IProductReadRepository _productReadRepository;
        private readonly IConfiguration _configuration;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public GetProductImagesQueryHandler(IProductReadRepository productReadRepository, IConfiguration configuration, IWebHostEnvironment webHostEnvironment)
        {
            _productReadRepository = productReadRepository;
            _configuration = configuration;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<List<GetProductImagesQueryResponse>> Handle(GetProductImagesQueryRequest request, CancellationToken cancellationToken)
        {
            Product? product = await _productReadRepository.Table.Include(p => p.ProductImageFiles)
                 .FirstOrDefaultAsync(x => x.Id == Guid.Parse(request.Id));
            


            return product.ProductImageFiles.Select(x => new GetProductImagesQueryResponse
            {
                Id = x.Id,
                FileName = x.FileName,
                Path = Path.Combine("http://127.0.0.1:8887", x.Path)
            }).ToList();
        }
    }
}
