using Microsoft.EntityFrameworkCore;
namespace SC.Data
{
    public class ApplicationContext : DbContext
    {

        public DbSet<ApplicationUser> ApplicationUser { get; set; }      
        public DbSet<UserType> UserType { get; set; }
        public DbSet<MotherCompany> MotherCompany { get; set; }
        public DbSet<FinanceYear> FinanceYear { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<City> City { get; set; }       
        public DbSet<TaxMaster> TaxMaster { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<CompanyContact> CompanyContact { get; set; }
        public DbSet<Store> Store { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<CustomerUserAssign> CustomerUserAssign { get; set; }
        public DbSet<ItemCategory> ItemCategory { get; set; }             
        public DbSet<StockMaster> StockMaster { get; set; }        
        public DbSet<ItemMaster> ItemMaster { get; set; }
        public DbSet<ItemBrand> ItemBrand { get; set; }
        public DbSet<Currency> Currency { get; set; }
        public DbSet<ItemImage> ItemImage { get; set; }
        public DbSet<customercategory> customercategory { get; set; }
        public DbSet<suppliercategory> suppliercategory { get; set; }
        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<SupplierContact> SupplierContact { get; set; }
        public DbSet<SalesOrder> SalesOrder { get; set; }
        public DbSet<SalesOrderDetail> SalesOrderDetail { get; set; }
        public DbSet<Deliverycategory> Deliverycategory { get; set; }
        public DbSet<AssetCategory> AssetCategory { get; set; }
        public DbSet<Asset> Asset { get; set; }
        public DbSet<Bankcategory> Bankcategory { get; set; }
        public DbSet<Bank> Bank { get; set; }
        public DbSet<BranchGroup> BranchGroup { get; set; }
        public DbSet<Branch> Branch { get; set; }
        public DbSet<CreditCardcategory> CreditCardcategory { get; set; }
        public DbSet<CreditCard> CreditCard { get; set; }
        public DbSet<DepartmentGroup> DepartmentGroup { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<DesignationGroup> DesignationGroup { get; set; }
        public DbSet<Designation> Designation { get; set; }
        public DbSet<EmployeeCategory> EmployeeCategory { get; set; }

        public DbSet<EmployeeGroup> EmployeeGroup { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<suppliergroup> suppliergroup { get; set; }
        public DbSet<CustomerContact> CustomerContact { get; set; }
        public DbSet<Purchase> Purchase { get; set; }
        public DbSet<PurchaseDetail> PurchaseDetail { get; set; }
        public DbSet<purchasepaiddetail> purchasepaiddetail { get; set; }
        public DbSet<Sales> Sales { get; set; }
        public DbSet<SalesDetail> SalesDetail { get; set; }
        public DbSet<Salespaiddetail> Salespaiddetail { get; set; }
        public DbSet<Receipt> Receipt { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Task> Task { get; set; }
        public DbSet<DeliveryItem> DeliveryItem { get; set; }
        public DbSet<DeliveryPayment> DeliveryPayment { get; set; }


        
        public DbSet<COAType> COAType { get; set; }
        public DbSet<Coabase> Coabase { get; set; }
        public DbSet<coa> coa { get; set; }    
        public DbSet<ledger> ledger { get; set; }
        public DbSet<ledgertxn> ledgertxn { get; set; }
        public DbSet<defaultaccount> defaultaccount { get; set; }
        public DbSet<BankTxn> BankTxn { get; set; }
        public DbSet<servicetype> servicetype { get; set; }
        public DbSet<service> service { get; set; }
        public DbSet<PaymentTransactions> PaymentTransactions { get; set; }
        public DbSet<ReceiptTransactions> ReceiptTransactions { get; set; }
        public DbSet<ScrollText> ScrollText { get; set; }

        

        public DbSet<salereturn> salereturn { get; set; }
        public DbSet<salereturnDetail> salereturnDetail { get; set; }
        public DbSet<purchasereturn> purchasereturn { get; set; }
        public DbSet<purchasereturnDetail> purchasereturnDetail { get; set; }
        public DbSet<UserPagesAssigned> UserPagesAssigned { get; set; }
        public DbQuery<GetCustomerInfo_Trademate> GetCustomerInfo_Trademate { get; set; }
        public DbQuery<GetItemInfo_Trademate> GetItemInfo_Trademate { get; set; }
        public DbQuery<GetItemInfo_Trademate> GetVatInfo_Trademate { get; set; }
        public DbQuery<GetProduct_Trademate> GetProduct_Trademate { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            //new CountryMapper(modelBuilder.Entity<Country>());
            //new StateMapper(modelBuilder.Entity<State>());
            //new CityMapper(modelBuilder.Entity<City>());
            //new ZipMapper(modelBuilder.Entity<ZipCode>());
            //new MotherCompanyMapper(modelBuilder.Entity<MotherCompany>());
            //new FinanceYearMapper(modelBuilder.Entity<FinanceYear>());
            //Database.SetInitializer<ApplicationContext>(null);
            //base.OnModelCreating(modelBuilder);
            //modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            //base.OnModelCreating(modelBuilder);
        }
    }
}
