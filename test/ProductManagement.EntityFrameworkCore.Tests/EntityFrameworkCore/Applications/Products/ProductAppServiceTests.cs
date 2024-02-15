using ProductManagement.Products;
using ProductManagement.Samples;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Xunit;

namespace ProductManagement.EntityFrameworkCore.Applications.Products
{
    [Collection(ProductManagementTestConsts.CollectionDefinitionName)]
    public class ProductAppServiceTests : SampleAppServiceTests<ProductManagementEntityFrameworkCoreTestModule>
    {
        private readonly IProductAppService _productAppService;
        public ProductAppServiceTests()
        {
            _productAppService = GetRequiredService<IProductAppService>();
        }
        [Fact]
        public async Task Should_Get_Product_List()
        {
            //Act
            var output = await _productAppService.GetListAsync(new PagedAndSortedResultRequestDto());
            //Assert
            output.TotalCount.ShouldBe(3);
            output.Items.ShouldContain(x => x.Name.Contains("Acme Monochrome Laser Printer"));
        }
    }
}
