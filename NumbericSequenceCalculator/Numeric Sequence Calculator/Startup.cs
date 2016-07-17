using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Numeric_Sequence_Calculator.Startup))]
namespace Numeric_Sequence_Calculator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
