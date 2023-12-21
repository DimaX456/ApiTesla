﻿using AutoMapper;
using TicketSelling.Services.AutoMappers;
using Xunit;

namespace TicketSelling.Services.Tests.Tests
{
    public class MapperTest
    {
        [Fact]
        public void TestMapper()
        {
            var configuration = new MapperConfiguration(cfg => cfg.AddProfile<ServiceMapper>());
            configuration.AssertConfigurationIsValid();
        }
    }
}
