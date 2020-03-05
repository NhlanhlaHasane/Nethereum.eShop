using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts;
using System.Threading;

namespace Nethereum.Commerce.Contracts.Funding.ContractDefinition
{


    public partial class FundingDeployment : FundingDeploymentBase
    {
        public FundingDeployment() : base(BYTECODE) { }
        public FundingDeployment(string byteCode) : base(byteCode) { }
    }

    public class FundingDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "608060405234801561001057600080fd5b506040516118bc3803806118bc83398101604081905261002f9161009d565b600080546001600160a01b03191633178082556040516001600160a01b039190911691907f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e0908290a3600380546001600160a01b0319166001600160a01b03929092169190911790556100cb565b6000602082840312156100ae578081fd5b81516001600160a01b03811681146100c4578182fd5b9392505050565b6117e2806100da6000396000f3fe608060405234801561001057600080fd5b506004361061010b5760003560e01c80638e5fc30b116100a2578063c016d9b611610071578063c016d9b6146101fc578063c76ea97814610204578063cfb5192814610217578063f2fde38b1461022a578063f3ad65f41461023d5761010b565b80638e5fc30b146101ac5780638f32d59b146101cc5780639cf3037a146101d4578063abefab87146101e75761010b565b80636b6a291a116100de5780636b6a291a14610176578063802706cb1461017e57806387a211b5146101915780638da5cb5b146101a45761010b565b8063150e99f91461011057806340a0a2dd146101255780634360beb5146101385780636b00e9d814610156575b600080fd5b61012361011e3660046110f0565b610245565b005b61012361013336600461141b565b610320565b610140610526565b60405161014d919061144a565b60405180910390f35b6101696101643660046110f0565b610535565b60405161014d919061149b565b61014061054a565b61012361018c366004611170565b610559565b61012361019f366004611403565b61070d565b6101406108d4565b6101bf6101ba36600461114f565b6108e3565b60405161014d91906114de565b610169610a0d565b6101236101e236600461141b565b610a1e565b6101ef610c8b565b60405161014d91906114a6565b610140610c91565b6101236102123660046110f0565b610ca0565b6101ef6102253660046111d9565b610d75565b6101236102383660046110f0565b610d97565b610140610dc4565b61024d610a0d565b6102725760405162461bcd60e51b81526004016102699061160a565b60405180910390fd5b6001600160a01b03811660009081526001602052604090205460ff16156102e8576001600160a01b038116600081815260016020526040808220805460ff1916905560028054600019019055517f8ddb5a2efd673581f97000ec107674428dc1ed37e8e7944654e48fb0688114779190a261031d565b6040516001600160a01b038216907f21aa6b3368eceb61c9fc1bdfd2cb6337c87cc1510c1afcc7d5a45371551b43b890600090a25b50565b6103286108d4565b6001600160a01b0316336001600160a01b0316148061035657503360009081526001602052604090205460ff165b1561050a57610363610e2e565b60055460405163191a607f60e31b81526001600160a01b039091169063c8d303f8906103939086906004016114a6565b60006040518083038186803b1580156103ab57600080fd5b505afa1580156103bf573d6000803e3d6000fd5b505050506040513d6000823e601f3d908101601f191682016040526103e79190810190611263565b905060006001830360ff1690506000826101a00151828151811061040757fe5b60200260200101516101200151905060008360a00151905060006001600160a01b031684602001516001600160a01b031614156104565760405162461bcd60e51b815260040161026990611576565b602084015160405163a9059cbb60e01b81526000916001600160a01b0384169163a9059cbb9161048a918790600401611482565b602060405180830381600087803b1580156104a457600080fd5b505af11580156104b8573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052506104dc919081019061112f565b90506001811515146105005760405162461bcd60e51b81526004016102699061168c565b5050505050610522565b60405162461bcd60e51b815260040161026990611704565b5050565b6004546001600160a01b031681565b60016020526000908152604090205460ff1681565b6006546001600160a01b031681565b610561610a0d565b61057d5760405162461bcd60e51b81526004016102699061160a565b60035460405163d9c4c15360e01b81526001600160a01b039091169063d9c4c153906105af90859085906004016114af565b60206040518083038186803b1580156105c757600080fd5b505afa1580156105db573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052506105ff9190810190611113565b600480546001600160a01b0319166001600160a01b0392831617908190551661063a5760405162461bcd60e51b8152600401610269906115ad565b60035460405163d9c4c15360e01b81526001600160a01b039091169063d9c4c1539061066c90879087906004016114af565b60206040518083038186803b15801561068457600080fd5b505afa158015610698573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052506106bc9190810190611113565b600680546001600160a01b03199081166001600160a01b0393841617918290556005805492909316911681179091556107075760405162461bcd60e51b81526004016102699061163f565b50505050565b6107156108d4565b6001600160a01b0316336001600160a01b0316148061074357503360009081526001602052604090205460ff165b1561050a57610750610e2e565b60055460405163191a607f60e31b81526001600160a01b039091169063c8d303f8906107809085906004016114a6565b60006040518083038186803b15801561079857600080fd5b505afa1580156107ac573d6000803e3d6000fd5b505050506040513d6000823e601f3d908101601f191682016040526107d49190810190611263565b90506000805b82610180015160ff1681101561081957826101a0015181815181106107fb57fe5b602002602001015161012001518201915080806001019150506107da565b5060a082015160608301516040516323b872dd60e01b81526000916001600160a01b038416916323b872dd91610855913090889060040161145e565b602060405180830381600087803b15801561086f57600080fd5b505af1158015610883573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052506108a7919081019061112f565b90506001811515146108cb5760405162461bcd60e51b815260040161026990611531565b5050505061031d565b6000546001600160a01b031690565b6040805160208082528183019092526060918291906020820181803883390190505090506000805b6020811015610961576008810260020a86026001600160f81b0319811615610958578084848151811061093a57fe5b60200101906001600160f81b031916908160001a9053506001909201915b5060010161090b565b50600081851180610970575084155b1561097c575080610983565b5060001984015b6060816040519080825280601f01601f1916602001820160405280156109b0576020820181803883390190505b50905060005b82811015610a00578481815181106109ca57fe5b602001015160f81c60f81b8282815181106109e157fe5b60200101906001600160f81b031916908160001a9053506001016109b6565b5093505050505b92915050565b6000546001600160a01b0316331490565b610a266108d4565b6001600160a01b0316336001600160a01b03161480610a5457503360009081526001602052604090205460ff165b1561050a57610a61610e2e565b60055460405163191a607f60e31b81526001600160a01b039091169063c8d303f890610a919086906004016114a6565b60006040518083038186803b158015610aa957600080fd5b505afa158015610abd573d6000803e3d6000fd5b505050506040513d6000823e601f3d908101601f19168201604052610ae59190810190611263565b905060006001830360ff1690506000826101a001518281518110610b0557fe5b60200260200101516101200151905060008360a001519050610b25610ea5565b60048054610140870151604051631f91394160e21b81526001600160a01b0390921692637e44e50492610b599291016114a6565b60a06040518083038186803b158015610b7157600080fd5b505afa158015610b85573d6000803e3d6000fd5b505050506040513d601f19601f82011682018060405250610ba9919081019061139b565b60408101519091506001600160a01b0316610bd65760405162461bcd60e51b8152600401610269906116c3565b604080820151905163a9059cbb60e01b81526000916001600160a01b0385169163a9059cbb91610c0a918890600401611482565b602060405180830381600087803b158015610c2457600080fd5b505af1158015610c38573d6000803e3d6000fd5b505050506040513d601f19601f82011682018060405250610c5c919081019061112f565b9050600181151514610c805760405162461bcd60e51b81526004016102699061168c565b505050505050610522565b60025481565b6005546001600160a01b031681565b610ca8610a0d565b610cc45760405162461bcd60e51b81526004016102699061160a565b6001600160a01b03811660009081526001602052604090205460ff1615610d1e576040516001600160a01b038216907ff6831fd5f976003f3acfcf6b2784b2f81e3abb43d161884873a310d6beadf38090600090a261031d565b6001600160a01b0381166000818152600160208190526040808320805460ff19168317905560028054909201909155517f3c4dcdfdb789d0f39b8a520a4f83ab2599db1d2ececebe4db2385f360c0d3ce19190a250565b80516000908290610d8a575060009050610d92565b505060208101515b919050565b610d9f610a0d565b610dbb5760405162461bcd60e51b81526004016102699061160a565b61031d81610dd3565b6003546001600160a01b031681565b600080546040516001600160a01b03808516939216917f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e091a3600080546001600160a01b0319166001600160a01b0392909216919091179055565b604080516101c081018252600080825260208201819052918101829052606081018290526080810182905260a0810182905260c0810182905260e0810182905261010081018290529061012082019081526020016000801916815260200160008152602001600060ff168152602001606081525090565b6040805160a08101825260008082526020820181905291810182905260608101829052608081019190915290565b8051610a0781611788565b600082601f830112610eee578081fd5b815167ffffffffffffffff811115610f04578182fd5b6020610f138182840201611761565b828152925080830184820161022080850287018401881015610f3457600080fd5b60005b85811015610f5b57610f498984610feb565b84529284019291810191600101610f37565b50505050505092915050565b80518015158114610a0757600080fd5b805160048110610a0757600080fd5b805160098110610a0757600080fd5b805160038110610a0757600080fd5b60008083601f840112610fb5578182fd5b50813567ffffffffffffffff811115610fcc578182fd5b602083019150836020828501011115610fe457600080fd5b9250929050565b6000610220808385031215610ffe578182fd5b61100781611761565b9150508151815261101b83602084016110e5565b602082015260408201516040820152606082015160608201526080820151608082015260a082015160a082015260c082015160c082015260e082015160e082015261010061106b84828501610ed3565b90820152610120828101519082015261014061108984828501610f86565b90820152610160828101519082015261018080830151908201526101a080830151908201526101c080830151908201526101e06110c884828501610f67565b908201526102006110db84848301610f77565b9082015292915050565b8051610a078161179d565b600060208284031215611101578081fd5b813561110c81611788565b9392505050565b600060208284031215611124578081fd5b815161110c81611788565b600060208284031215611140578081fd5b8151801515811461110c578182fd5b60008060408385031215611161578081fd5b50508035926020909101359150565b60008060008060408587031215611185578182fd5b843567ffffffffffffffff8082111561119c578384fd5b6111a888838901610fa4565b909650945060208701359150808211156111c0578384fd5b506111cd87828801610fa4565b95989497509550505050565b600060208083850312156111eb578182fd5b823567ffffffffffffffff80821115611202578384fd5b81850186601f820112611213578485fd5b8035925081831115611223578485fd5b611235601f8401601f19168501611761565b9150828252868484830101111561124a578485fd5b8284820185840137509081019091019190915292915050565b600060208284031215611274578081fd5b815167ffffffffffffffff8082111561128b578283fd5b6101c091840180860383131561129f578384fd5b6112a883611761565b815181526112b98760208401610ed3565b60208201526112cb8760408401610ed3565b60408201526112dd8760608401610ed3565b6060820152608082015160808201526112f98760a08401610ed3565b60a082015260c082015160c082015260e082015160e0820152610100935061132387858401610ed3565b84820152610120935061133887858401610f95565b938101939093526101408181015190840152610160808201519084015261018092611365878584016110e5565b848201526101a09350838201518381111561137e578586fd5b61138a88828501610ede565b948201949094529695505050505050565b600060a082840312156113ac578081fd5b6113b660a0611761565b825181526020830151602082015260408301516113d281611788565b604082015260608301516113e581611788565b60608201526113f78460808501610f67565b60808201529392505050565b600060208284031215611414578081fd5b5035919050565b6000806040838503121561142d578182fd5b82359150602083013561143f8161179d565b809150509250929050565b6001600160a01b0391909116815260200190565b6001600160a01b039384168152919092166020820152604081019190915260600190565b6001600160a01b03929092168252602082015260400190565b901515815260200190565b90815260200190565b60006020825282602083015282846040840137818301604090810191909152601f909201601f19160101919050565b6000602082528251806020840152815b8181101561150b57602081860181015160408684010152016114ee565b8181111561151c5782604083860101525b50601f01601f19169190910160400192915050565b60208082526025908201527f496e73756666696369656e742066756e6473207472616e7366657272656420666040820152646f7220504f60d81b606082015260800190565b60208082526017908201527f504f20686173206e6f2062757965722061646472657373000000000000000000604082015260600190565b60208082526039908201527f436f756c64206e6f742066696e6420427573696e657373506172746e6572537460408201527f6f72616765206164647265737320696e20726567697374727900000000000000606082015260800190565b6020808252818101527f4f776e61626c653a2063616c6c6572206973206e6f7420746865206f776e6572604082015260600190565b6020808252602d908201527f436f756c64206e6f742066696e642050757263686173696e672061646472657360408201526c7320696e20726567697374727960981b606082015260800190565b6020808252601c908201527f4e6f7420656e6f7567682066756e6473207472616e7366657272656400000000604082015260600190565b60208082526021908201527f53656c6c657220496420686173206e6f20636f6e7472616374206164647265736040820152607360f81b606082015260800190565b6020808252603e908201527f4f6e6c7920636f6e7472616374206f776e6572206f72206120626f756e64206160408201527f646472657373206d61792063616c6c20746869732066756e6374696f6e2e0000606082015260800190565b60405181810167ffffffffffffffff8111828210171561178057600080fd5b604052919050565b6001600160a01b038116811461031d57600080fd5b60ff8116811461031d57600080fdfea26469706673582212206fe2cf25c99691677d003892b73ab10ebd1a39f5ecdbb938e98e7f95287e2ff464736f6c63430006010033";
        public FundingDeploymentBase() : base(BYTECODE) { }
        public FundingDeploymentBase(string byteCode) : base(byteCode) { }
        [Parameter("address", "contractAddressOfRegistry", 1)]
        public virtual string ContractAddressOfRegistry { get; set; }
    }

    public partial class BoundAddressCountFunction : BoundAddressCountFunctionBase { }

    [Function("BoundAddressCount", "int256")]
    public class BoundAddressCountFunctionBase : FunctionMessage
    {

    }

    public partial class BoundAddressesFunction : BoundAddressesFunctionBase { }

    [Function("BoundAddresses", "bool")]
    public class BoundAddressesFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class AddressRegistryFunction : AddressRegistryFunctionBase { }

    [Function("addressRegistry", "address")]
    public class AddressRegistryFunctionBase : FunctionMessage
    {

    }

    public partial class BindAddressFunction : BindAddressFunctionBase { }

    [Function("bindAddress")]
    public class BindAddressFunctionBase : FunctionMessage
    {
        [Parameter("address", "a", 1)]
        public virtual string A { get; set; }
    }

    public partial class BusinessPartnerStorageFunction : BusinessPartnerStorageFunctionBase { }

    [Function("businessPartnerStorage", "address")]
    public class BusinessPartnerStorageFunctionBase : FunctionMessage
    {

    }

    public partial class Bytes32ToStringFunction : Bytes32ToStringFunctionBase { }

    [Function("bytes32ToString", "string")]
    public class Bytes32ToStringFunctionBase : FunctionMessage
    {
        [Parameter("bytes32", "x", 1)]
        public virtual byte[] X { get; set; }
        [Parameter("uint256", "truncateToLength", 2)]
        public virtual BigInteger TruncateToLength { get; set; }
    }

    public partial class ConfigureFunction : ConfigureFunctionBase { }

    [Function("configure")]
    public class ConfigureFunctionBase : FunctionMessage
    {
        [Parameter("string", "nameOfPurchasing", 1)]
        public virtual string NameOfPurchasing { get; set; }
        [Parameter("string", "nameOfBusinessPartnerStorage", 2)]
        public virtual string NameOfBusinessPartnerStorage { get; set; }
    }

    public partial class IsOwnerFunction : IsOwnerFunctionBase { }

    [Function("isOwner", "bool")]
    public class IsOwnerFunctionBase : FunctionMessage
    {

    }

    public partial class OwnerFunction : OwnerFunctionBase { }

    [Function("owner", "address")]
    public class OwnerFunctionBase : FunctionMessage
    {

    }

    public partial class PurchasingFunction : PurchasingFunctionBase { }

    [Function("purchasing", "address")]
    public class PurchasingFunctionBase : FunctionMessage
    {

    }

    public partial class PurchasingContractAddressFunction : PurchasingContractAddressFunctionBase { }

    [Function("purchasingContractAddress", "address")]
    public class PurchasingContractAddressFunctionBase : FunctionMessage
    {

    }

    public partial class StringToBytes32Function : StringToBytes32FunctionBase { }

    [Function("stringToBytes32", "bytes32")]
    public class StringToBytes32FunctionBase : FunctionMessage
    {
        [Parameter("string", "source", 1)]
        public virtual string Source { get; set; }
    }

    public partial class TransferInFundsForPoFromBuyerWalletFunction : TransferInFundsForPoFromBuyerWalletFunctionBase { }

    [Function("transferInFundsForPoFromBuyerWallet")]
    public class TransferInFundsForPoFromBuyerWalletFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "poNumber", 1)]
        public virtual BigInteger PoNumber { get; set; }
    }

    public partial class TransferOutFundsForPoItemToBuyerFunction : TransferOutFundsForPoItemToBuyerFunctionBase { }

    [Function("transferOutFundsForPoItemToBuyer")]
    public class TransferOutFundsForPoItemToBuyerFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "poNumber", 1)]
        public virtual BigInteger PoNumber { get; set; }
        [Parameter("uint8", "poItemNumber", 2)]
        public virtual byte PoItemNumber { get; set; }
    }

    public partial class TransferOutFundsForPoItemToSellerFunction : TransferOutFundsForPoItemToSellerFunctionBase { }

    [Function("transferOutFundsForPoItemToSeller")]
    public class TransferOutFundsForPoItemToSellerFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "poNumber", 1)]
        public virtual BigInteger PoNumber { get; set; }
        [Parameter("uint8", "poItemNumber", 2)]
        public virtual byte PoItemNumber { get; set; }
    }

    public partial class TransferOwnershipFunction : TransferOwnershipFunctionBase { }

    [Function("transferOwnership")]
    public class TransferOwnershipFunctionBase : FunctionMessage
    {
        [Parameter("address", "newOwner", 1)]
        public virtual string NewOwner { get; set; }
    }

    public partial class UnBindAddressFunction : UnBindAddressFunctionBase { }

    [Function("unBindAddress")]
    public class UnBindAddressFunctionBase : FunctionMessage
    {
        [Parameter("address", "a", 1)]
        public virtual string A { get; set; }
    }

    public partial class AddressAlreadyBoundEventDTO : AddressAlreadyBoundEventDTOBase { }

    [Event("AddressAlreadyBound")]
    public class AddressAlreadyBoundEventDTOBase : IEventDTO
    {
        [Parameter("address", "a", 1, true )]
        public virtual string A { get; set; }
    }

    public partial class AddressAlreadyUnBoundEventDTO : AddressAlreadyUnBoundEventDTOBase { }

    [Event("AddressAlreadyUnBound")]
    public class AddressAlreadyUnBoundEventDTOBase : IEventDTO
    {
        [Parameter("address", "a", 1, true )]
        public virtual string A { get; set; }
    }

    public partial class AddressBoundEventDTO : AddressBoundEventDTOBase { }

    [Event("AddressBound")]
    public class AddressBoundEventDTOBase : IEventDTO
    {
        [Parameter("address", "a", 1, true )]
        public virtual string A { get; set; }
    }

    public partial class AddressUnBoundEventDTO : AddressUnBoundEventDTOBase { }

    [Event("AddressUnBound")]
    public class AddressUnBoundEventDTOBase : IEventDTO
    {
        [Parameter("address", "a", 1, true )]
        public virtual string A { get; set; }
    }

    public partial class OwnershipTransferredEventDTO : OwnershipTransferredEventDTOBase { }

    [Event("OwnershipTransferred")]
    public class OwnershipTransferredEventDTOBase : IEventDTO
    {
        [Parameter("address", "previousOwner", 1, true )]
        public virtual string PreviousOwner { get; set; }
        [Parameter("address", "newOwner", 2, true )]
        public virtual string NewOwner { get; set; }
    }

    public partial class BoundAddressCountOutputDTO : BoundAddressCountOutputDTOBase { }

    [FunctionOutput]
    public class BoundAddressCountOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("int256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class BoundAddressesOutputDTO : BoundAddressesOutputDTOBase { }

    [FunctionOutput]
    public class BoundAddressesOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class AddressRegistryOutputDTO : AddressRegistryOutputDTOBase { }

    [FunctionOutput]
    public class AddressRegistryOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }



    public partial class BusinessPartnerStorageOutputDTO : BusinessPartnerStorageOutputDTOBase { }

    [FunctionOutput]
    public class BusinessPartnerStorageOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class Bytes32ToStringOutputDTO : Bytes32ToStringOutputDTOBase { }

    [FunctionOutput]
    public class Bytes32ToStringOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("string", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }



    public partial class IsOwnerOutputDTO : IsOwnerOutputDTOBase { }

    [FunctionOutput]
    public class IsOwnerOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class OwnerOutputDTO : OwnerOutputDTOBase { }

    [FunctionOutput]
    public class OwnerOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class PurchasingOutputDTO : PurchasingOutputDTOBase { }

    [FunctionOutput]
    public class PurchasingOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class PurchasingContractAddressOutputDTO : PurchasingContractAddressOutputDTOBase { }

    [FunctionOutput]
    public class PurchasingContractAddressOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class StringToBytes32OutputDTO : StringToBytes32OutputDTOBase { }

    [FunctionOutput]
    public class StringToBytes32OutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bytes32", "result", 1)]
        public virtual byte[] Result { get; set; }
    }










}
