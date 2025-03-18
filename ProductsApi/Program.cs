using Microsoft.EntityFrameworkCore;
using ProductsApi.Data;




var builder = WebApplication.CreateBuilder();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseInMemoryDatabase("ProductsDb"));