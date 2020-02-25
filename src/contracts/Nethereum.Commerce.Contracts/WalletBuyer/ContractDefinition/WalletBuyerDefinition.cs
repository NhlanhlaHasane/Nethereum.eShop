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

namespace Nethereum.Commerce.Contracts.WalletBuyer.ContractDefinition
{


    public partial class WalletBuyerDeployment : WalletBuyerDeploymentBase
    {
        public WalletBuyerDeployment() : base(BYTECODE) { }
        public WalletBuyerDeployment(string byteCode) : base(byteCode) { }
    }

    public class WalletBuyerDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "608060405234801561001057600080fd5b506040516116de3803806116de83398101604081905261002f9161009d565b600080546001600160a01b03191633178082556040516001600160a01b039190911691907f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e0908290a3600380546001600160a01b0319166001600160a01b03929092169190911790556100cb565b6000602082840312156100ae578081fd5b81516001600160a01b03811681146100c4578182fd5b9392505050565b611604806100da6000396000f3fe608060405234801561001057600080fd5b50600436106101005760003560e01c8063abefab8711610097578063c8d303f811610066578063c8d303f8146101fc578063cb4c86b71461020f578063f2fde38b14610217578063f3ad65f41461022a57610100565b8063abefab87146101b9578063c016d9b6146101ce578063c076cfbf146101d6578063c76ea978146101e957610100565b8063802706cb116100d3578063802706cb146101765780638da5cb5b146101895780638f32d59b1461019e57806391aa0f30146101a657610100565b8063150e99f9146101055780634f0dfe5b1461011a5780636b00e9d81461012d5780636fee6fec14610156575b600080fd5b610118610113366004610bb6565b610232565b005b610118610128366004610e32565b61030d565b61014061013b366004610bb6565b610374565b60405161014d9190611128565b60405180910390f35b610169610164366004610c5e565b610389565b60405161014d91906113ba565b610118610184366004610bf5565b610420565b6101916105a0565b60405161014d9190611114565b6101406105af565b6101186101b4366004610ca8565b6105c0565b6101c16106fa565b60405161014d9190611133565b610191610700565b6101186101e4366004610e32565b61070f565b6101186101f7366004610bb6565b610727565b61016961020a366004610e1a565b6107fc565b61019161088d565b610118610225366004610bb6565b61089c565b6101916108c9565b61023a6105af565b61025f5760405162461bcd60e51b81526004016102569061124a565b60405180910390fd5b6001600160a01b03811660009081526001602052604090205460ff16156102d5576001600160a01b038116600081815260016020526040808220805460ff1916905560028054600019019055517f8ddb5a2efd673581f97000ec107674428dc1ed37e8e7944654e48fb0688114779190a261030a565b6040516001600160a01b038216907f21aa6b3368eceb61c9fc1bdfd2cb6337c87cc1510c1afcc7d5a45371551b43b890600090a25b50565b60048054604051630d9192ef60e01b81526001600160a01b0390911691630d9192ef9161033e9186918691016114a6565b600060405180830381600087803b15801561035857600080fd5b505af115801561036c573d6000803e3d6000fd5b505050505050565b60016020526000908152604090205460ff1681565b610391610933565b60048054604051631bfb9bfb60e21b81526001600160a01b0390911691636fee6fec916103c49188918891889101611150565b60006040518083038186803b1580156103dc57600080fd5b505afa1580156103f0573d6000803e3d6000fd5b505050506040513d6000823e601f3d908101601f191682016040526104189190810190610ce2565b949350505050565b60035460405163d9c4c15360e01b81526001600160a01b039091169063d9c4c15390610452908790879060040161113c565b60206040518083038186803b15801561046a57600080fd5b505afa15801561047e573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052506104a29190810190610bd9565b600480546001600160a01b0319166001600160a01b039283161790819055166104dd5760405162461bcd60e51b8152600401610256906111c7565b60035460405163d9c4c15360e01b81526001600160a01b039091169063d9c4c1539061050f908590859060040161113c565b60206040518083038186803b15801561052757600080fd5b505afa15801561053b573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525061055f9190810190610bd9565b600580546001600160a01b0319166001600160a01b0392831617908190551661059a5760405162461bcd60e51b815260040161025690611174565b50505050565b6000546001600160a01b031690565b6000546001600160a01b0316331490565b600080826101a081018035601e19368490030181126105de57600080fd5b9091016020810191503567ffffffffffffffff8111156105fd57600080fd5b6102208102360382131561061057600080fd5b9150600090505b8181101561069357836101a081018035601e193684900301811261063a57600080fd5b9091016020810191503567ffffffffffffffff81111561065957600080fd5b6102208102360382131561066c57600080fd5b8281811061067657fe5b905061022002016101200135830192508080600101915050610617565b506004805460405163091aa0f360e41b81526001600160a01b03909116916391aa0f30916106c39187910161127f565b600060405180830381600087803b1580156106dd57600080fd5b505af11580156106f1573d6000803e3d6000fd5b50505050505050565b60025481565b6004546001600160a01b031681565b60405162461bcd60e51b81526004016102569061121d565b61072f6105af565b61074b5760405162461bcd60e51b81526004016102569061124a565b6001600160a01b03811660009081526001602052604090205460ff16156107a5576040516001600160a01b038216907ff6831fd5f976003f3acfcf6b2784b2f81e3abb43d161884873a310d6beadf38090600090a261030a565b6001600160a01b0381166000818152600160208190526040808320805460ff19168317905560028054909201909155517f3c4dcdfdb789d0f39b8a520a4f83ab2599db1d2ececebe4db2385f360c0d3ce19190a250565b610804610933565b6004805460405163191a607f60e31b81526001600160a01b039091169163c8d303f89161083391869101611133565b60006040518083038186803b15801561084b57600080fd5b505afa15801561085f573d6000803e3d6000fd5b505050506040513d6000823e601f3d908101601f191682016040526108879190810190610ce2565b92915050565b6005546001600160a01b031681565b6108a46105af565b6108c05760405162461bcd60e51b81526004016102569061124a565b61030a816108d8565b6003546001600160a01b031681565b600080546040516001600160a01b03808516939216917f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e091a3600080546001600160a01b0319166001600160a01b0392909216919091179055565b604080516101c081018252600080825260208201819052918101829052606081018290526080810182905260a0810182905260c0810182905260e0810182905261010081018290529061012082019081526020016000801916815260200160008152602001600060ff168152602001606081525090565b805161088781611575565b600082601f8301126109c5578081fd5b815167ffffffffffffffff8111156109db578182fd5b60206109ea81828402016114b7565b828152925080830184820161022080850287018401881015610a0b57600080fd5b60005b85811015610a3257610a208984610ab1565b84529284019291810191600101610a0e565b50505050505092915050565b80516108878161158a565b805161088781611598565b8051610887816115a5565b8051610887816115b2565b60008083601f840112610a7b578182fd5b50813567ffffffffffffffff811115610a92578182fd5b602083019150836020828501011115610aaa57600080fd5b9250929050565b6000610220808385031215610ac4578182fd5b610acd816114b7565b91505081518152610ae18360208401610bab565b602082015260408201516040820152606082015160608201526080820151608082015260a082015160a082015260c082015160c082015260e082015160e0820152610100610b31848285016109aa565b908201526101208281015190820152610140610b4f84828501610a54565b90820152610160828101519082015261018080830151908201526101a080830151908201526101c080830151908201526101e0610b8e84828501610a3e565b90820152610200610ba184848301610a49565b9082015292915050565b8051610887816115bf565b600060208284031215610bc7578081fd5b8135610bd281611575565b9392505050565b600060208284031215610bea578081fd5b8151610bd281611575565b60008060008060408587031215610c0a578283fd5b843567ffffffffffffffff80821115610c21578485fd5b610c2d88838901610a6a565b90965094506020870135915080821115610c45578384fd5b50610c5287828801610a6a565b95989497509550505050565b600080600060408486031215610c72578081fd5b833567ffffffffffffffff811115610c88578182fd5b610c9486828701610a6a565b909790965060209590950135949350505050565b600060208284031215610cb9578081fd5b813567ffffffffffffffff811115610ccf578182fd5b8083016101c08186031215610418578283fd5b600060208284031215610cf3578081fd5b815167ffffffffffffffff80821115610d0a578283fd5b6101c0918401808603831315610d1e578384fd5b610d27836114b7565b81518152610d3887602084016109aa565b6020820152610d4a87604084016109aa565b6040820152610d5c87606084016109aa565b606082015260808201516080820152610d788760a084016109aa565b60a082015260c082015160c082015260e082015160e08201526101009350610da2878584016109aa565b848201526101209350610db787858401610a5f565b938101939093526101408181015190840152610160808201519084015261018092610de487858401610bab565b848201526101a093508382015183811115610dfd578586fd5b610e09888285016109b5565b948201949094529695505050505050565b600060208284031215610e2b578081fd5b5035919050565b60008060408385031215610e44578182fd5b823591506020830135610e56816115bf565b809150509250929050565b6001600160a01b03169052565b600082845260208401935081815b84811015610f9e5781358652610e956020830183611568565b610ea2602088018261110d565b5060408201356040870152606082013560608701526080820135608087015260a082013560a087015260c082013560c087015260e082013560e0870152610100610eee818401846114de565b610efa82890182610e61565b50506101208281013590870152610140610f168184018461154e565b610f22828901826110cf565b5050610160828101359087015261018080830135908701526101a080830135908701526101c080830135908701526101e0610f5f81840184611534565b610f6b828901826110bb565b5050610200610f7c81840184611541565b610f88828901826110c1565b5050610220958601959190910190600101610e7c565b5093949350505050565b6000815180845260208401935060208301825b82811015610f9e578151805187526020810151610fdb602089018261110d565b5060408101516040880152606081015160608801526080810151608088015260a081015160a088015260c081015160c088015260e081015160e08801526101008082015161102b828a0182610e61565b505061012081810151908801526101408082015161104b828a01826110cf565b5050610160818101519088015261018080820151908801526101a080820151908801526101c080820151908801526101e08082015161108c828a01826110bb565b5050610200808201516110a1828a01826110c1565b505050610220959095019460209190910190600101610fbb565b15159052565b600481106110cb57fe5b9052565b600981106110cb57fe5b600381106110cb57fe5b60008284528282602086013780602084860101526020601f19601f85011685010190509392505050565b60ff169052565b6001600160a01b0391909116815260200190565b901515815260200190565b90815260200190565b6000602082526104186020830184866110e3565b6000604082526111646040830185876110e3565b9050826020830152949350505050565b60208082526033908201527f436f756c64206e6f742066696e642046756e64696e6720636f6e7472616374206040820152726164647265737320696e20726567697374727960681b606082015260800190565b60208082526036908201527f436f756c64206e6f742066696e642050757263686173696e6720636f6e7472616040820152756374206164647265737320696e20726567697374727960501b606082015260800190565b602080825260139082015272139bdd081a5b5c1b195b595b9d1959081e595d606a1b604082015260600190565b6020808252818101527f4f776e61626c653a2063616c6c6572206973206e6f7420746865206f776e6572604082015260600190565b6000602082528235602083015261129960208401846114de565b6112a66040840182610e61565b506112b460408401846114de565b6112c16060840182610e61565b506112cf60608401846114de565b6112dc6080840182610e61565b50608083013560a08301526112f460a08401846114de565b61130160c0840182610e61565b5060c083013560e083015261010060e084013581840152611324818501856114de565b610120915061133582850182610e61565b506113428185018561155b565b6101409150611353828501826110d9565b506101608185013581850152610180915080850135828501525061137981850185611568565b6101a0915061138a8285018261110d565b50611397818501856114eb565b6101c0925082838601526113b06101e086018284610e6e565b9695505050505050565b6000602082528251602083015260208301516113d96040840182610e61565b5060408301516113ec6060840182610e61565b5060608301516113ff6080840182610e61565b50608083015160a083015260a083015161141c60c0840182610e61565b5060c083015160e083015260e083015161010081818501528085015191505061012061144a81850183610e61565b840151905061014061145e848201836110d9565b840151610160848101919091528401516101808085019190915284015190506101a061148c8185018361110d565b8401516101c08481015290506104186101e0840182610fa8565b91825260ff16602082015260400190565b60405181810167ffffffffffffffff811182821017156114d657600080fd5b604052919050565b60008235610bd281611575565b6000808335601e19843603018112611501578283fd5b830160208101925035905067ffffffffffffffff81111561152157600080fd5b61022081023603831315610aaa57600080fd5b60008235610bd28161158a565b60008235610bd281611598565b60008235610bd2816115a5565b60008235610bd2816115b2565b60008235610bd2816115bf565b6001600160a01b038116811461030a57600080fd5b801515811461030a57600080fd5b6004811061030a57600080fd5b6009811061030a57600080fd5b6003811061030a57600080fd5b60ff8116811461030a57600080fdfea26469706673582212202e99bf8074d99e31e9355558fd5fec235d80fabe582ad6a6f309c1b27f05a75864736f6c63430006010033";
        public WalletBuyerDeploymentBase() : base(BYTECODE) { }
        public WalletBuyerDeploymentBase(string byteCode) : base(byteCode) { }
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

    public partial class CancelPurchaseOrderItemFunction : CancelPurchaseOrderItemFunctionBase { }

    [Function("cancelPurchaseOrderItem")]
    public class CancelPurchaseOrderItemFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "poNumber", 1)]
        public virtual BigInteger PoNumber { get; set; }
        [Parameter("uint8", "poItemNumber", 2)]
        public virtual byte PoItemNumber { get; set; }
    }

    public partial class ConfigureFunction : ConfigureFunctionBase { }

    [Function("configure")]
    public class ConfigureFunctionBase : FunctionMessage
    {
        [Parameter("string", "nameOfPurchasing", 1)]
        public virtual string NameOfPurchasing { get; set; }
        [Parameter("string", "nameOfFunding", 2)]
        public virtual string NameOfFunding { get; set; }
    }

    public partial class CreatePurchaseOrderFunction : CreatePurchaseOrderFunctionBase { }

    [Function("createPurchaseOrder")]
    public class CreatePurchaseOrderFunctionBase : FunctionMessage
    {
        [Parameter("tuple", "po", 1)]
        public virtual Po Po { get; set; }
    }

    public partial class FundingFunction : FundingFunctionBase { }

    [Function("funding", "address")]
    public class FundingFunctionBase : FunctionMessage
    {

    }

    public partial class GetPoFunction : GetPoFunctionBase { }

    [Function("getPo", typeof(GetPoOutputDTO))]
    public class GetPoFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "poNumber", 1)]
        public virtual BigInteger PoNumber { get; set; }
    }

    public partial class GetPoBySellerAndQuoteFunction : GetPoBySellerAndQuoteFunctionBase { }

    [Function("getPoBySellerAndQuote", typeof(GetPoBySellerAndQuoteOutputDTO))]
    public class GetPoBySellerAndQuoteFunctionBase : FunctionMessage
    {
        [Parameter("string", "sellerIdString", 1)]
        public virtual string SellerIdString { get; set; }
        [Parameter("uint256", "quoteId", 2)]
        public virtual BigInteger QuoteId { get; set; }
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

    public partial class SetPoItemGoodsReceivedFunction : SetPoItemGoodsReceivedFunctionBase { }

    [Function("setPoItemGoodsReceived")]
    public class SetPoItemGoodsReceivedFunctionBase : FunctionMessage
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









    public partial class FundingOutputDTO : FundingOutputDTOBase { }

    [FunctionOutput]
    public class FundingOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class GetPoOutputDTO : GetPoOutputDTOBase { }

    [FunctionOutput]
    public class GetPoOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("tuple", "po", 1)]
        public virtual Po Po { get; set; }
    }

    public partial class GetPoBySellerAndQuoteOutputDTO : GetPoBySellerAndQuoteOutputDTOBase { }

    [FunctionOutput]
    public class GetPoBySellerAndQuoteOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("tuple", "po", 1)]
        public virtual Po Po { get; set; }
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






}
