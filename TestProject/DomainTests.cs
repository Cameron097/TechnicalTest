using System;
using Domain.Models.Vehicles;
using FluentAssertions;
using Xunit;


namespace TestProject
{
    public class DomainTests
    {
        [Fact]
        public void VehicleInitialized_StartWith0People_ShouldThrowArgumentException()
        {
            var vehicle = new Vehicle(10);
            vehicle.Invoking(x => x.StartWithEmptyPeople(0)).Should().Throw<ArgumentException>()
                .WithMessage("People count must be at least 1");
        }

        [Fact]
        public void VehicleInitializedMax10_StartWith15People_ShouldThrowException()
        {
            var vehicle = new Vehicle(10);
            vehicle.Invoking(x => x.StartWithEmptyPeople(15)).Should().Throw<Exception>()
                .WithMessage("Too many passengers");
        }

        [Fact]
        public void VehicleInitializedMax10_StartWith5_ShouldNotThrow()
        {
            var vehicle = new Vehicle(10);
            vehicle.Invoking(x => x.StartWithEmptyPeople(5)).Should().NotThrow();
        }


        public class VehicleStub : Vehicle
        {
            public VehicleStub() : base(10)
            {
                
            }

            public bool TestVehicleRunning => VehicleRunning;
        }

        [Fact]
        public void VehicleStubInitialized_StartWith5_ShouldSetVehicleStartedToTrue()
        {
            var vehicle = new VehicleStub();
            vehicle.StartWithEmptyPeople(5);
            vehicle.TestVehicleRunning.Should().BeTrue();
        }


        [Fact]
        public void VehicleStubInitialized_DoNotStart_VehicleStartedShouldBeFalse()
        {
            var vehicle = new VehicleStub();
            vehicle.TestVehicleRunning.Should().BeFalse();
        }
    }
}
