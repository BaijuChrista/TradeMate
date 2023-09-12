using System;
using System.Collections.Generic;
using System.Text;
using SC.Data;

namespace SC.Service.Interface
{
    public interface ISupplierService
    {
        List<Supplier> GetAllSupplier();
        void AddSupplier(Supplier Supplier);
        Supplier GetSupplier(long id);
        void UpdateSupplier(Supplier Supplier);
        List<Supplier> GetSupplier();


        List<SupplierContact> GetAllSupplierContact();
        void AddSupplierContact(SupplierContact SupplierContact);
        SupplierContact GetSupplierContact(long id);
        void UpdateSupplierContact(SupplierContact SupplierContact);
        List<SupplierContact> GetSupplierContact();
        void DeleteSupplierContact(long Id);


        List<suppliercategory> GetAllSupplierCategory();
        void AddSuppliercategory(suppliercategory suppliercategory);
        suppliercategory GetSuppliercategory(long id);
        void UpdateSuppliercategory(suppliercategory suppliercategory);
        List<suppliercategory> GetSuppliercategory();

        List<suppliergroup> GetAllSuppliergroup();
        List<suppliergroup> GetSuppliergroup();
        void AddSuppliergroup(suppliergroup suppliergroup);
        suppliergroup GetSuppliergroup(long id);
        void UpdateSuppliergroup(suppliergroup suppliergroup);
    }
}
