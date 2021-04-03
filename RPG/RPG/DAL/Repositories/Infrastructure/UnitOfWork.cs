namespace RPG.DAL.Repositories.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        #region IUnitOfWork Members

        private AdminRepository _adminRepository;
        private ClientRepository _clientRepository;
        private InvoiceItemRepository _invoiceItemRepository;
        private InvoicePaymentRepository _invoicePaymentRepository;
        private InvoiceRepository _invoiceRepository;
        private MaterialRepository _materialRepository;
        private PurchaseInvoiceItemRepository _purchaseInvoiceItemRepository;
        private PurchaseInvoicePaymentRepository _purchaseInvoicePaymentRepository;
        private PurchaseInvoiceRepository _purchaseInvoiceRepository;
        private SupplierRepository _supplierRepository;

        #endregion

        #region Repositries Properties

        public AdminRepository AdminRepository => _adminRepository ?? (_adminRepository = new AdminRepository());
        public ClientRepository ClientRepository => _clientRepository ?? (_clientRepository = new ClientRepository());

        public InvoiceItemRepository InvoiceItemRepository =>
            _invoiceItemRepository ?? (_invoiceItemRepository = new InvoiceItemRepository());

        public InvoicePaymentRepository InvoicePaymentRepository =>
            _invoicePaymentRepository ?? (_invoicePaymentRepository = new InvoicePaymentRepository());

        public InvoiceRepository InvoiceRepository =>
            _invoiceRepository ?? (_invoiceRepository = new InvoiceRepository());

        public MaterialRepository MaterialRepository =>
            _materialRepository ?? (_materialRepository = new MaterialRepository());

        public PurchaseInvoiceItemRepository PurchaseInvoiceItemRepository =>
            _purchaseInvoiceItemRepository ?? (_purchaseInvoiceItemRepository = new PurchaseInvoiceItemRepository());

        public PurchaseInvoicePaymentRepository PurchaseInvoicePaymentRepository =>
            _purchaseInvoicePaymentRepository ??
            (_purchaseInvoicePaymentRepository = new PurchaseInvoicePaymentRepository());

        public PurchaseInvoiceRepository PurchaseInvoiceRepository =>
            _purchaseInvoiceRepository ?? (_purchaseInvoiceRepository = new PurchaseInvoiceRepository());

        public SupplierRepository SupplierRepository =>
            _supplierRepository ?? (_supplierRepository = new SupplierRepository());

        #endregion
    }
}