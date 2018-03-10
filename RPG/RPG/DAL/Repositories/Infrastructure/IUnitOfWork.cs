namespace RPG.DAL.Repositories.Infrastructure
{
    public interface IUnitOfWork
    {
        AdminRepository AdminRepository { get; }
        ClientRepository ClientRepository { get; }
        InvoiceItemRepository InvoiceItemRepository { get; }
        InvoicePaymentRepository InvoicePaymentRepository { get; }
        InvoiceRepository InvoiceRepository { get; }
        MaterialRepository MaterialRepository { get; }
    }
}