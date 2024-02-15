using Microsoft.AspNetCore.Builder;
using ProductManagement;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<ProductManagementWebTestModule>();

public partial class Program
{
}
