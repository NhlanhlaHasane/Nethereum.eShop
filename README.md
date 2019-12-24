# Nethereum.eShop

Nethereum eShop, a partially decentralised shopping cart based on https://github.com/dotnet-architecture/eShopOnWeb.

## Phase 1 Goals
+ Providing an out of the box solution for anyone to create an eShop integrated with Ethereum or use the infrastructure as a template for other solutions.
+ Demonstrate business integration with an Ethereum blockchain.
+ Demonstrate authentication and authorisation on a web site using an Ethereum account.
+ Demonstrate integration using Nethereum.UI with a connection with Metamask.
+ Demonstrate a familiar business process and benefits of integrating with mainnet smart contracts (Purchasing, Escrow, Trust, Proof of purchage).
+ Demonstrate upgradable rules using a rules engine (Wonka) which could be on chain.
+ Demonstrate other business usages outside of a wallet and token launches.
+ Demonstrate integration with a stable token DAI.
+ Demonstrate business privacy by combining Blazor Server with sql server storage, in conjunction with public mainnet smart contracts.

## Why an eShop using Ethereum?
* Consumer protection (proof of purchase)
* Consumer protection (escrow of funds)
* Consumer protection (new "untrusted" shop)
* Shops don't rely on third parties for trust (ie ebay, amazon, etc)
* Shops don't rely on third parties for reputation (ie ebay, amazon, etc)
* Capability in the future to enable supply chain
* Capability in the future to enable finance based on invoices
* Capability to enable reputation systems (out of the box)
* Capability to provide NFTs related to purchases
* Capability to provide transparent and/or persistent auditing
* A shop can be used for services
* Mix and match cloud allows for privacy

## Phase 1 Tasks
- [x] Clone eShopOnWeb and migrate namespaces
- [ ] Migrate front end to Blazor
- [ ] Data schema changes. 
     - [ ] Identify, remove and design storage areas that will be on the blochain
     - [ ] Users, Authorisation linked to Ethereum accounts
     - [ ] Change data schema for the specific business domain (BookStore)
     - [ ] Identify general process flow for transactions (business rules, etc.)
      
- [ ] Create new specific blockchain services and smart contracts
     - [ ] DAI payment
     - [ ] Purchasing process
     - [ ] Pre-order
     - [ ] Escrow
     - [ ] Cancelation
     - [ ] Delivery     
     - [ ] Dispute / Return
     - [ ] Upgradable business rules (Wonka rules, related to book purchasing)

- [ ] Authentication and authorisation
    - [ ] Integration  with Nethereum.UI
    - [ ] Login screens
    - [ ] Admin areas
    - [ ] Product management (metadata, inventory, prices, etc.)

## Phase 2 
+ Proxys of smart contracts
+ Upgrade storage
+ Validation and verification of smart contracts
+ Different front ends:
     - Desktop
     - Mobile
     - IoT
     - Gaming (ie vbucks style purchasing of skins, etc)
     - VR 
+ Moving to a common framework and capability to change front ends, Avalonia, Xamarin Forms, etc and leveraging ReactiveUI (see https://github.com/Nethereum/NethereumBlazor Readme for motivation).
+ Integration with other Ethereum connection providers using Netheruem.UI (Nethereum, Hardware Wallets, Gnosis, etc)
+ Provide integration / demo to UBI tokens (Circles, Idena)
+ Other framework integrations

## Phase 3
Providing solutions and integrations (ie supply chain, finance, reputation (idena?) )
