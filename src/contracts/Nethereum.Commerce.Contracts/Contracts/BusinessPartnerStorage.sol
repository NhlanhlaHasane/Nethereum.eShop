pragma solidity ^0.6.1;
pragma experimental ABIEncoderV2;

import "./IAddressRegistry.sol";
import "./IBusinessPartnerStorage.sol";
import "./IEternalStorage.sol";
import "./Ownable.sol";
import "./StringConvertible.sol";

contract BusinessPartnerStorage is IBusinessPartnerStorage, Ownable, StringConvertible
{
    // Client is hashed into every key to avoid collisions with other contracts using the same eternal storage
    string constant private CLIENT = "BpStorage"; 
    
    // Shop Id
    string constant private DATA_ESHOP = "eShop";
    string constant private ESHOP_ID = "eShopId";
    string constant private ESHOP_DESCRIPTION = "eShopDescription";
    string constant private PURCH_CONTRACT_ADDRESS = "purchasingContractAddress";
    string constant private QUOTE_SIGNER_ADDRESS = "quoteSignerAddress";
    string constant private IS_ACTIVE = "isActive";
    string constant private CREATED_BY_ADDRESS = "createdByAddress";
    
    // Seller Id
    string constant private DATA_SELLER = "seller";
    string constant private SELLER_ID = "sellerId";
    string constant private SELLER_DESC = "sellerDescription";
    string constant private ADMIN_CONTRACT_ADDRESS = "adminContractAddress";
    
    IEternalStorage public eternalStorage;
    IAddressRegistry public addressRegistry;

    constructor (address contractAddressOfRegistry) public
    {
        addressRegistry = IAddressRegistry(contractAddressOfRegistry);
    }

    /// Configure contract
    /// @param nameOfEternalStorage key of the entry in the address registry that holds the eternal storage contract address
    function configure(string memory nameOfEternalStorage) onlyOwner() override public
    {
        // Eternal storage
        eternalStorage = IEternalStorage(addressRegistry.getAddressString(nameOfEternalStorage));
        require(address(eternalStorage) != address(0), "Could not find EternalStorage address in registry");
    }
    
    function getEshop(bytes32 eShopId) override public view returns (IPoTypes.Eshop memory eShop)
    {
        bytes32 recordKey = keccak256(abi.encodePacked(CLIENT, DATA_ESHOP, eShopId));
        eShop.eShopId = eternalStorage.getBytes32Value(keccak256(abi.encodePacked(recordKey, ESHOP_ID)));
        eShop.eShopDescription = eternalStorage.getBytes32Value(keccak256(abi.encodePacked(recordKey, ESHOP_DESCRIPTION)));
        eShop.purchasingContractAddress = eternalStorage.getAddressValue(keccak256(abi.encodePacked(recordKey, PURCH_CONTRACT_ADDRESS)));
        eShop.quoteSignerAddress = eternalStorage.getAddressValue(keccak256(abi.encodePacked(recordKey, QUOTE_SIGNER_ADDRESS)));
        eShop.isActive = eternalStorage.getBooleanValue(keccak256(abi.encodePacked(recordKey, IS_ACTIVE)));
        eShop.createdByAddress = eternalStorage.getAddressValue(keccak256(abi.encodePacked(recordKey, CREATED_BY_ADDRESS)));
    }
    
    function setEshop(IPoTypes.Eshop memory eShop) override public
    {
        // Validation
        require(eShop.purchasingContractAddress != address(0), "Must specify a purchasing contract address");
        
        // Is this a new record?
        IPoTypes.Eshop memory existingEshop = getEshop(eShop.eShopId);
        if (existingEshop.purchasingContractAddress == address(0))
        {
            // New record
            eShop.createdByAddress = msg.sender;
        }
        else
        {
            // Existing record
            require(eShop.createdByAddress == msg.sender, "Only createdByAddress can change this record");
        }
        
        // Store
        bytes32 recordKey = keccak256(abi.encodePacked(CLIENT, DATA_ESHOP, eShop.eShopId));
        eternalStorage.setBytes32Value(keccak256(abi.encodePacked(recordKey, ESHOP_ID)), eShop.eShopId);
        eternalStorage.setBytes32Value(keccak256(abi.encodePacked(recordKey, ESHOP_DESCRIPTION)), eShop.eShopDescription);
        eternalStorage.setAddressValue(keccak256(abi.encodePacked(recordKey, PURCH_CONTRACT_ADDRESS)), eShop.purchasingContractAddress);
        eternalStorage.setAddressValue(keccak256(abi.encodePacked(recordKey, QUOTE_SIGNER_ADDRESS)), eShop.quoteSignerAddress);
        eternalStorage.setBooleanValue(keccak256(abi.encodePacked(recordKey, IS_ACTIVE)), eShop.isActive);
        eternalStorage.setAddressValue(keccak256(abi.encodePacked(recordKey, CREATED_BY_ADDRESS)), eShop.createdByAddress);
    }
    
    function getSeller(bytes32 sellerId) override public view returns (IPoTypes.Seller memory seller)
    {
        bytes32 recordKey = keccak256(abi.encodePacked(CLIENT, DATA_SELLER, sellerId));
        seller.sellerId = eternalStorage.getBytes32Value(keccak256(abi.encodePacked(recordKey, SELLER_ID)));
        seller.sellerDescription = eternalStorage.getBytes32Value(keccak256(abi.encodePacked(recordKey, SELLER_DESC)));
        seller.adminContractAddress = eternalStorage.getAddressValue(keccak256(abi.encodePacked(recordKey, ADMIN_CONTRACT_ADDRESS)));
        seller.isActive = eternalStorage.getBooleanValue(keccak256(abi.encodePacked(recordKey, IS_ACTIVE)));
        seller.createdByAddress = eternalStorage.getAddressValue(keccak256(abi.encodePacked(recordKey, CREATED_BY_ADDRESS)));
    }
    
    function setSeller(IPoTypes.Seller memory seller) override public
    {
        // Validation
        require(seller.adminContractAddress != address(0), "Must specify an admin contract address");
        
        // Is this a new record?
        IPoTypes.Seller memory existingSeller = getSeller(seller.sellerId);
        if (existingSeller.adminContractAddress == address(0))
        {
            // New record
            seller.createdByAddress = msg.sender;
        }
        else
        {
            // Existing record
            require(seller.createdByAddress == msg.sender, "Only createdByAddress can change this record");
        }
        
        // Store
        bytes32 recordKey = keccak256(abi.encodePacked(CLIENT, DATA_SELLER, seller.sellerId));
        eternalStorage.setBytes32Value(keccak256(abi.encodePacked(recordKey, SELLER_ID)), seller.sellerId);
        eternalStorage.setBytes32Value(keccak256(abi.encodePacked(recordKey, SELLER_DESC)), seller.sellerDescription);
        eternalStorage.setAddressValue(keccak256(abi.encodePacked(recordKey, ADMIN_CONTRACT_ADDRESS)), seller.adminContractAddress);
        eternalStorage.setBooleanValue(keccak256(abi.encodePacked(recordKey, IS_ACTIVE)), seller.isActive);
        eternalStorage.setAddressValue(keccak256(abi.encodePacked(recordKey, CREATED_BY_ADDRESS)), seller.createdByAddress);
    }
}