using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OrderSense.Models;

namespace OrderSense.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<OrderSense.Models.ApplicationUser> ApplicationUser { get; set; }

        public DbSet<OrderSense.Models.Bill> Bill { get; set; }

        public DbSet<OrderSense.Models.BillType> BillType { get; set; }

        public DbSet<OrderSense.Models.Branch> Branch { get; set; }

        public DbSet<OrderSense.Models.CashBank> CashBank { get; set; }

        public DbSet<OrderSense.Models.Currency> Currency { get; set; }

        public DbSet<OrderSense.Models.Customer> Customer { get; set; }

        public DbSet<OrderSense.Models.CustomerType> CustomerType { get; set; }

        public DbSet<OrderSense.Models.GoodsReceivedNote> GoodsReceivedNote { get; set; }

        public DbSet<OrderSense.Models.Invoice> Invoice { get; set; }

        public DbSet<OrderSense.Models.InvoiceType> InvoiceType { get; set; }

        public DbSet<OrderSense.Models.NumberSequence> NumberSequence { get; set; }

        public DbSet<OrderSense.Models.PaymentReceive> PaymentReceive { get; set; }

        public DbSet<OrderSense.Models.PaymentType> PaymentType { get; set; }

        public DbSet<OrderSense.Models.PaymentVoucher> PaymentVoucher { get; set; }

        public DbSet<OrderSense.Models.Product> Product { get; set; }

        public DbSet<OrderSense.Models.ProductType> ProductType { get; set; }

        public DbSet<OrderSense.Models.PurchaseOrder> PurchaseOrder { get; set; }

        public DbSet<OrderSense.Models.PurchaseOrderLine> PurchaseOrderLine { get; set; }

        public DbSet<OrderSense.Models.PurchaseType> PurchaseType { get; set; }

        public DbSet<OrderSense.Models.SalesOrder> SalesOrder { get; set; }

        public DbSet<OrderSense.Models.SalesOrderLine> SalesOrderLine { get; set; }

        public DbSet<OrderSense.Models.SalesType> SalesType { get; set; }

        public DbSet<OrderSense.Models.Shipment> Shipment { get; set; }

        public DbSet<OrderSense.Models.ShipmentType> ShipmentType { get; set; }

        public DbSet<OrderSense.Models.UnitOfMeasure> UnitOfMeasure { get; set; }

        public DbSet<OrderSense.Models.Vendor> Vendor { get; set; }

        public DbSet<OrderSense.Models.VendorType> VendorType { get; set; }

        public DbSet<OrderSense.Models.Warehouse> Warehouse { get; set; }

        public DbSet<OrderSense.Models.UserProfile> UserProfile { get; set; }
    }
}
