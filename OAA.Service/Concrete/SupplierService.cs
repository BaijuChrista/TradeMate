using Microsoft.EntityFrameworkCore;
using SC.Data;
using SC.Repository;
using SC.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SC.Service.Concrete
{
    public class SupplierService : ISupplierService
    {
        private IRepository<Supplier> SupplierRepository;
        private IRepository<suppliercategory> SuppliercategoryRepository;
        private IRepository<SupplierContact> SupplierContactRepository;
        private IRepository<suppliergroup> SuppliergroupRepository;
        public SupplierService(IRepository<Supplier> supplierRepository, IRepository<suppliercategory> suppliercategoryRepository, IRepository<SupplierContact> supplierContactRepository, IRepository<suppliergroup> suppliergroupRepository)
        {

            this.SupplierRepository = supplierRepository;
            this.SuppliercategoryRepository = suppliercategoryRepository;
            this.SupplierContactRepository = supplierContactRepository;
            this.SuppliergroupRepository = suppliergroupRepository;
        }

        public List<Supplier> GetAllSupplier()
        {
            return SupplierRepository.GetQueryable().Include(b=>b.City).Include(b=>b.suppliercategory).Include(b=>b.suppliergroup).ToList();
        }
        public List<Supplier> GetSupplier()
        {
            return SupplierRepository.GetAll().ToList();
        }
        public void AddSupplier(Supplier Supplier)
        {
            SupplierRepository.Insert(Supplier);
        }
        public Supplier GetSupplier(long id)
        {
            return SupplierRepository.Get(id);
        }
        public void UpdateSupplier(Supplier Supplier)
        {
            SupplierRepository.Update(Supplier);
        }

        public List<SupplierContact> GetAllSupplierContact()
        {
            return SupplierContactRepository.GetQueryable().ToList();
        }
        public List<SupplierContact> GetSupplierContact()
        {
            return SupplierContactRepository.GetAll().ToList();
        }
        public void AddSupplierContact(SupplierContact SupplierContact)
        {
            SupplierContactRepository.Insert(SupplierContact);
        }
        public SupplierContact GetSupplierContact(long id)
        {
            return SupplierContactRepository.Get(id);
        }
        public void UpdateSupplierContact(SupplierContact SupplierContact)
        {
            SupplierContactRepository.Update(SupplierContact);
        }

        public List<suppliercategory> GetAllSupplierCategory()
        {
            return SuppliercategoryRepository.GetQueryable().ToList();
        }
        public List<suppliercategory> GetSuppliercategory()
        {
            return SuppliercategoryRepository.GetAll().ToList();
        }
        public void AddSuppliercategory(suppliercategory suppliercategory)
        {
            SuppliercategoryRepository.Insert(suppliercategory);
        }
        public suppliercategory GetSuppliercategory(long id)
        {
            return SuppliercategoryRepository.Get(id);
        }
        public void UpdateSuppliercategory(suppliercategory suppliercategory)
        {
            SuppliercategoryRepository.Update(suppliercategory);
        }

        public List<suppliergroup> GetAllSuppliergroup()
        {
            return SuppliergroupRepository.GetQueryable().ToList();
        }
        public List<suppliergroup> GetSuppliergroup()
        {
            return SuppliergroupRepository.GetAll().ToList();
        }
        public void AddSuppliergroup(suppliergroup suppliergroup)
        {
            SuppliergroupRepository.Insert(suppliergroup);
        }
        public suppliergroup GetSuppliergroup(long id)
        {
            return SuppliergroupRepository.Get(id);
        }
        public void UpdateSuppliergroup(suppliergroup suppliergroup)
        {
            SuppliergroupRepository.Update(suppliergroup);
        }
        public void DeleteSupplierContact(long Id)
        {
            var items = SupplierContactRepository.GetAll().Where(x => x.SupplierId == Id).ToList().ToList();
            foreach (var item in items)
            {
                SupplierContactRepository.Delete(item);
            }
        }

    }
}
