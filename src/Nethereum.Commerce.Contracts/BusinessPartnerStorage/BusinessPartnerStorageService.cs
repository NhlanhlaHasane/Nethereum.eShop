using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts.ContractHandlers;
using Nethereum.Contracts;
using System.Threading;
using Nethereum.Commerce.Contracts.BusinessPartnerStorage.ContractDefinition;

namespace Nethereum.Commerce.Contracts.BusinessPartnerStorage
{
    public partial class BusinessPartnerStorageService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, BusinessPartnerStorageDeployment businessPartnerStorageDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<BusinessPartnerStorageDeployment>().SendRequestAndWaitForReceiptAsync(businessPartnerStorageDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, BusinessPartnerStorageDeployment businessPartnerStorageDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<BusinessPartnerStorageDeployment>().SendRequestAsync(businessPartnerStorageDeployment);
        }

        public static async Task<BusinessPartnerStorageService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, BusinessPartnerStorageDeployment businessPartnerStorageDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, businessPartnerStorageDeployment, cancellationTokenSource);
            return new BusinessPartnerStorageService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public BusinessPartnerStorageService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public Task<string> AddressRegistryQueryAsync(AddressRegistryFunction addressRegistryFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<AddressRegistryFunction, string>(addressRegistryFunction, blockParameter);
        }

        
        public Task<string> AddressRegistryQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<AddressRegistryFunction, string>(null, blockParameter);
        }

        public Task<string> Bytes32ToStringQueryAsync(Bytes32ToStringFunction bytes32ToStringFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<Bytes32ToStringFunction, string>(bytes32ToStringFunction, blockParameter);
        }

        
        public Task<string> Bytes32ToStringQueryAsync(byte[] x, BigInteger truncateToLength, BlockParameter blockParameter = null)
        {
            var bytes32ToStringFunction = new Bytes32ToStringFunction();
                bytes32ToStringFunction.X = x;
                bytes32ToStringFunction.TruncateToLength = truncateToLength;
            
            return ContractHandler.QueryAsync<Bytes32ToStringFunction, string>(bytes32ToStringFunction, blockParameter);
        }

        public Task<string> ConfigureRequestAsync(ConfigureFunction configureFunction)
        {
             return ContractHandler.SendRequestAsync(configureFunction);
        }

        public Task<TransactionReceipt> ConfigureRequestAndWaitForReceiptAsync(ConfigureFunction configureFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(configureFunction, cancellationToken);
        }

        public Task<string> ConfigureRequestAsync(string nameOfEternalStorage)
        {
            var configureFunction = new ConfigureFunction();
                configureFunction.NameOfEternalStorage = nameOfEternalStorage;
            
             return ContractHandler.SendRequestAsync(configureFunction);
        }

        public Task<TransactionReceipt> ConfigureRequestAndWaitForReceiptAsync(string nameOfEternalStorage, CancellationTokenSource cancellationToken = null)
        {
            var configureFunction = new ConfigureFunction();
                configureFunction.NameOfEternalStorage = nameOfEternalStorage;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(configureFunction, cancellationToken);
        }

        public Task<string> EternalStorageQueryAsync(EternalStorageFunction eternalStorageFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<EternalStorageFunction, string>(eternalStorageFunction, blockParameter);
        }

        
        public Task<string> EternalStorageQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<EternalStorageFunction, string>(null, blockParameter);
        }

        public Task<byte[]> GetSystemDescriptionQueryAsync(GetSystemDescriptionFunction getSystemDescriptionFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetSystemDescriptionFunction, byte[]>(getSystemDescriptionFunction, blockParameter);
        }

        
        public Task<byte[]> GetSystemDescriptionQueryAsync(byte[] systemId, BlockParameter blockParameter = null)
        {
            var getSystemDescriptionFunction = new GetSystemDescriptionFunction();
                getSystemDescriptionFunction.SystemId = systemId;
            
            return ContractHandler.QueryAsync<GetSystemDescriptionFunction, byte[]>(getSystemDescriptionFunction, blockParameter);
        }

        public Task<string> GetWalletAddressQueryAsync(GetWalletAddressFunction getWalletAddressFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetWalletAddressFunction, string>(getWalletAddressFunction, blockParameter);
        }

        
        public Task<string> GetWalletAddressQueryAsync(byte[] systemId, BlockParameter blockParameter = null)
        {
            var getWalletAddressFunction = new GetWalletAddressFunction();
                getWalletAddressFunction.SystemId = systemId;
            
            return ContractHandler.QueryAsync<GetWalletAddressFunction, string>(getWalletAddressFunction, blockParameter);
        }

        public Task<string> SetSystemDescriptionRequestAsync(SetSystemDescriptionFunction setSystemDescriptionFunction)
        {
             return ContractHandler.SendRequestAsync(setSystemDescriptionFunction);
        }

        public Task<TransactionReceipt> SetSystemDescriptionRequestAndWaitForReceiptAsync(SetSystemDescriptionFunction setSystemDescriptionFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setSystemDescriptionFunction, cancellationToken);
        }

        public Task<string> SetSystemDescriptionRequestAsync(byte[] systemId, byte[] systemDescription)
        {
            var setSystemDescriptionFunction = new SetSystemDescriptionFunction();
                setSystemDescriptionFunction.SystemId = systemId;
                setSystemDescriptionFunction.SystemDescription = systemDescription;
            
             return ContractHandler.SendRequestAsync(setSystemDescriptionFunction);
        }

        public Task<TransactionReceipt> SetSystemDescriptionRequestAndWaitForReceiptAsync(byte[] systemId, byte[] systemDescription, CancellationTokenSource cancellationToken = null)
        {
            var setSystemDescriptionFunction = new SetSystemDescriptionFunction();
                setSystemDescriptionFunction.SystemId = systemId;
                setSystemDescriptionFunction.SystemDescription = systemDescription;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setSystemDescriptionFunction, cancellationToken);
        }

        public Task<string> SetWalletAddressRequestAsync(SetWalletAddressFunction setWalletAddressFunction)
        {
             return ContractHandler.SendRequestAsync(setWalletAddressFunction);
        }

        public Task<TransactionReceipt> SetWalletAddressRequestAndWaitForReceiptAsync(SetWalletAddressFunction setWalletAddressFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setWalletAddressFunction, cancellationToken);
        }

        public Task<string> SetWalletAddressRequestAsync(byte[] systemId, string walletAddress)
        {
            var setWalletAddressFunction = new SetWalletAddressFunction();
                setWalletAddressFunction.SystemId = systemId;
                setWalletAddressFunction.WalletAddress = walletAddress;
            
             return ContractHandler.SendRequestAsync(setWalletAddressFunction);
        }

        public Task<TransactionReceipt> SetWalletAddressRequestAndWaitForReceiptAsync(byte[] systemId, string walletAddress, CancellationTokenSource cancellationToken = null)
        {
            var setWalletAddressFunction = new SetWalletAddressFunction();
                setWalletAddressFunction.SystemId = systemId;
                setWalletAddressFunction.WalletAddress = walletAddress;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setWalletAddressFunction, cancellationToken);
        }

        public Task<byte[]> StringToBytes32QueryAsync(StringToBytes32Function stringToBytes32Function, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<StringToBytes32Function, byte[]>(stringToBytes32Function, blockParameter);
        }

        
        public Task<byte[]> StringToBytes32QueryAsync(string source, BlockParameter blockParameter = null)
        {
            var stringToBytes32Function = new StringToBytes32Function();
                stringToBytes32Function.Source = source;
            
            return ContractHandler.QueryAsync<StringToBytes32Function, byte[]>(stringToBytes32Function, blockParameter);
        }
    }
}
