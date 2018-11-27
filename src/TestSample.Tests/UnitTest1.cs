using Xunit;
using TestSample.Models;
using TestSample.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace TestSample.Tests
{
    public class UnitTest1
    {
        private readonly IMath _math;

        public UnitTest1()
        {
            var services = new ServiceCollection();
            services.AddTransient<IMath, Math>();
            services.AddSingleton(provider => InitConfiguration());

            var serviceProvider = services.BuildServiceProvider();
            _math = serviceProvider.GetService<IMath>();
        }

        [Fact]
        public void Test1()
        {
            var result = _math.Sum();

            Assert.True(result == 30);
        }

        [Fact]
        public void Test2()
        {
            var result = _math.Sum(10, 20);

            Assert.True(result == 30);
        }

        public static IConfiguration InitConfiguration()
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            return config;
        }
    }
}
