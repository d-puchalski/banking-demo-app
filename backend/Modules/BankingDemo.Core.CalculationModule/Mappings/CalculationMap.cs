using AutoMapper;
using BankingDemo.Core.CalculationModule.Models;
using BankingDemo.Core.Extensions.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingDemo.Core.CalculationModule.Mappings {
    public class MapperMaps {
        public static IConfigurationProvider CalculationMapper() {
            return new MapperConfiguration(c => c.CreateMap<GetCalculationRequest, Calculation>());
        }
    }
}
