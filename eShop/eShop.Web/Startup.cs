using eShop.CoreBusiness.Services;
using eShop.CoreBusiness.Services.Interfaces;
using eShop.DataStore.HardCoded;
using eShop.ShoppingCart.LocalStorage;
using eShop.StateStore.DI;
using eShop.UseCases.OrderConfirmationScreen;
using eShop.UseCases.PlugInInterfaces.DataStore;
using eShop.UseCases.PlugInInterfaces.StateStore;
using eShop.UseCases.PlugInInterfaces.UI;
using eShop.UseCases.SearchProductScreen;
using eShop.UseCases.ShoppingCartScreen;
using eShop.UseCases.ShoppingCartScreen.Interfaces;
using eShop.UseCases.ViewProductScreen;
using eShop.Web.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<WeatherForecastService>();

            services.AddSingleton<IProductRepository, ProductRepository>();

            services.AddTransient<IViewProductUseCase, ViewProductUseCase>()
                    .AddTransient<ISearchProductUseCase, SearchProductUseCase>()
                    .AddTransient<IAddProductToCartUseCase, AddProdcutToCartUseCase>()
                    .AddTransient<IViewShoppingCartUseCase, ViewShoppingCartUseCase>()
                    .AddTransient<IDeleteProductUseCase, DeleteProductUseCase>()
                    .AddTransient<IUpdateQuantityUseCase, UpdateQuantityUseCase>()
                    .AddTransient<IOrderServices, OrderServices>()
                    .AddTransient<IPlaceOrderUseCase, PlaceOrderUseCase>()
                    .AddTransient<IViewOrderConfirmationUseCase, ViewOrderConfirmationUseCase>();

            services.AddScoped<IShoppingCart, eShop.ShoppingCart.LocalStorage.ShoppingCart>()
                    .AddScoped<IShoppingCartStateStore, ShoppingCartStateStore>()
                    .AddScoped< IOrderRepository,OrderRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
