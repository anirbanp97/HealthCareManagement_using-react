using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Pharmacy.Infrastructure.Logging
{
    public static class SerilogConfiguration
    {


        public static ILogger CreateLogger()
        {


            return new LoggerConfiguration()


                .MinimumLevel.Information()


                .WriteTo.Console()


                .WriteTo.File(

                    "Logs/log.txt",

                    rollingInterval:
                    RollingInterval.Day)


                .CreateLogger();

        }


    }
}
