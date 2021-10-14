namespace Compori.MagentoApi.SoapClient.RemoteServices.ComporiPrice
{
    public sealed class Registration
    {
        /// <summary>
        /// Registers the remote services in implementing assembly to the service registry.
        /// </summary>
        /// <param name="registry">The service registry.</param>
        public static void Register(IServiceRegistry registry)
        {
            registry.Register(new ServiceRegistryItem(
                typeof(ResourceModel.ComporiPricePriceListRepositoryV1.comporiPricePriceListRepositoryV1PortTypeChannel), "comporiPricePriceListRepositoryV1", false));
            registry.Register(new ServiceRegistryItem(
                typeof(ResourceModel.ComporiPricePriceRepositoryV1.comporiPricePriceRepositoryV1PortTypeChannel), "comporiPricePriceRepositoryV1", false));
            registry.Register(new ServiceRegistryItem(
                typeof(ResourceModel.ComporiPricePriceListAssignmentRepositoryV1.comporiPricePriceListAssignmentRepositoryV1PortTypeChannel), "comporiPricePriceListAssignmentRepositoryV1", false));
            registry.Register(new ServiceRegistryItem(
                typeof(ResourceModel.ComporiPriceDiscountCustomerRepositoryV1.comporiPriceDiscountCustomerRepositoryV1PortTypeChannel), "comporiPriceDiscountCustomerRepositoryV1", false));
            registry.Register(new ServiceRegistryItem(
                typeof(ResourceModel.ComporiPriceDiscountProductRepositoryV1.comporiPriceDiscountProductRepositoryV1PortTypeChannel), "comporiPriceDiscountProductRepositoryV1", false));
            registry.Register(new ServiceRegistryItem(
                typeof(ResourceModel.ComporiPriceDiscountRepositoryV1.comporiPriceDiscountRepositoryV1PortTypeChannel), "comporiPriceDiscountRepositoryV1", false));
            registry.Register(new ServiceRegistryItem(
                typeof(ResourceModel.ComporiPriceDiscountProductGroupRepositoryV1.comporiPriceDiscountProductGroupRepositoryV1PortTypeChannel), "comporiPriceDiscountProductGroupRepositoryV1", false));
            registry.Register(new ServiceRegistryItem(
                typeof(ResourceModel.ComporiPriceDiscountProductGroupManagementV1.comporiPriceDiscountProductGroupManagementV1PortTypeChannel), "comporiPriceDiscountProductGroupManagementV1", false));
        }
    }
}
