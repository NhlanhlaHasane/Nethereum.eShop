using FluentAssertions;
using Nethereum.Commerce.ContractDeployments.IntegrationTests.Config;
using Nethereum.Commerce.Contracts.Deployment;
using System;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;
using Nethereum.Commerce.Contracts;

namespace Nethereum.Commerce.ContractDeployments.IntegrationTests
{
    [Trait("Buyer", "")]
    [Collection("Contract Deployment Collection v2")]
    public class BuyerDeploymentTests
    {
        private readonly ITestOutputHelper _output;
        private readonly ContractDeploymentsFixturev2 _contracts;
        private readonly TestOutputHelperLogger _xunitlogger;

        public BuyerDeploymentTests(ContractDeploymentsFixturev2 fixture, ITestOutputHelper output)
        {
            // See Output window -> Tests for fixture deployment logs.
            _contracts = fixture;
            _output = output;
            _xunitlogger = new TestOutputHelperLogger(_output);
        }

        [Fact]
        public async void ShouldDeployNewContract()
        {
            var buyerDeployment = BuyerDeployment.CreateFromNewDeployment(
                 _contracts.Web3,
                 _contracts.BusinessPartnersDeployment.BusinessPartnerStorageService.ContractHandler.ContractAddress,
                 _xunitlogger);
            Func<Task> act = async () => await buyerDeployment.InitializeAsync();
            await act.Should().NotThrowAsync();

            // If buyer deployed ok then its global business partner storage address should have a value
            var bpStorageAddress = await buyerDeployment.BuyerWalletService.BusinessPartnerStorageGlobalQueryAsync().ConfigureAwait(false);
            bpStorageAddress.Should().NotBeNullOrEmpty();
            bpStorageAddress.IsZeroAddress().Should().BeFalse();
        }

        [Fact]
        public async void ShouldConnectExistingContract()
        {
            // Deploy a buyer wallet
            var buyerDeployment = BuyerDeployment.CreateFromNewDeployment(
                 _contracts.Web3,
                 _contracts.BusinessPartnersDeployment.BusinessPartnerStorageService.ContractHandler.ContractAddress,
                 _xunitlogger);
            Func<Task> act = async () => await buyerDeployment.InitializeAsync();
            await act.Should().NotThrowAsync();

            // Create an additional buyer wallet by connecting to the existing first one
            var buyerDeployment2 = BuyerDeployment.CreateFromConnectExistingContract(
                _contracts.Web3,
                buyerDeployment.BuyerWalletService.ContractHandler.ContractAddress,
                _xunitlogger);
            Func<Task> act2 = async () => await buyerDeployment2.InitializeAsync();
            await act2.Should().NotThrowAsync();

            buyerDeployment2.Owner.Should().Be(buyerDeployment.Owner);
        }

        [Fact]
        public async void ShouldFailToConnectNonExistingContract()
        {
            // Give a rubbish address for the existing buyer wallet deployment
            var buyerDeployment = BuyerDeployment.CreateFromConnectExistingContract(
                 _contracts.Web3,
                 "0x32A555F2328e85E489f9a5f03669DC820CE7EBe9", // no buyer contract deployed here
                 _xunitlogger);
            Func<Task> act = async () => await buyerDeployment.InitializeAsync();
            await act.Should().ThrowAsync<ContractDeploymentException>().WithMessage("*Failed to set up*");
        }
    }
}
