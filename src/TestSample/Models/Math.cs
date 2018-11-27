using System;
using TestSample.Interfaces;
using Microsoft.Extensions.Configuration;

namespace TestSample.Models
{
    public class Math : IMath
    {
        public IConfiguration Configuration { get; }

        public Math(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public int Sum()
        {
            var a = Convert.ToInt16(Configuration.GetSection("Valor1").Value);
            var b = Convert.ToInt16(Configuration.GetSection("Valor2").Value);

            return a + b;
        }

        public int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
