using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BeautyHall.Models.Db.Models;

public partial class BeautyHallContext : DbContext
{
    private readonly IConfiguration Configuration;
    private readonly string? ConnectionString;
    public BeautyHallContext(IConfiguration configuration)
    {
        Configuration = configuration;
        ConnectionString = Configuration.GetConnectionString("DB");
    }

    public BeautyHallContext(DbContextOptions<BeautyHallContext> options, IConfiguration configuration)
        : base(options)
    {
        Configuration = configuration;
        ConnectionString = Configuration.GetConnectionString("DB");
    }

    public virtual DbSet<Appointment> Appointments { get; set; }

    public virtual DbSet<DailySummary> DailySummaries { get; set; }

    public virtual DbSet<Discount> Discounts { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderService> OrderServices { get; set; }

    public virtual DbSet<PaymentSummary> PaymentSummaries { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Service> Services { get; set; }

    public virtual DbSet<Stock> Stocks { get; set; }

    public virtual DbSet<Subject> Subjects { get; set; }
    public virtual DbSet<Login> Logins { get; set; }
    public virtual DbSet<Category> Categories { get; set; }
    public virtual DbSet<OrderProduct> OrderProducts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(ConnectionString);
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Appointment>(entity =>
        {
            entity.HasKey(e => e.AppointmentId).HasName("PK__Appointm__8ECDFCC259B26E9C");

            entity.ToTable("Appointment");

            entity.Property(e => e.AppointmentDate).HasColumnType("datetime");
            entity.Property(e => e.AppointmentStatus).HasDefaultValueSql("((0))");

            entity.HasOne(d => d.Customer).WithMany(p => p.Appointments)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Appointment_Subject");

            entity.HasOne(d => d.Order).WithMany(p => p.Appointments)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Appointment_Order");
        });

        modelBuilder.Entity<DailySummary>(entity =>
        {
            entity.HasKey(e => e.SummaryDate).HasName("PK__Daily_Su__5B3F15F9A39AB85D");

            entity.ToTable("Daily_Summary");

            entity.Property(e => e.SummaryDate).HasColumnType("datetime");
            entity.Property(e => e.DailyCosts).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalCash).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalCashNet).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalGross).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalNet).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalPos).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<Discount>(entity =>
        {
            entity.HasKey(e => new { e.ServiceId, e.CustomerId });

            entity.Property(e => e.DiscountPercentage).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DiscountTimestamp).HasColumnType("datetime");

            entity.HasOne(d => d.Customer).WithMany(p => p.Discounts)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Discounts_Subject");

            entity.HasOne(d => d.Service).WithMany(p => p.Discounts)
                .HasForeignKey(d => d.ServiceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Discounts_Service");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("PK__Employee__7AD04F11D36FAF6D");

            entity.ToTable("Employee");

            entity.Property(e => e.EmployeeRole).HasMaxLength(200);
            entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("PK__Order__C3905BCFB6F21A02");

            entity.ToTable("Order");

            entity.Property(e => e.OrderDate).HasColumnType("datetime");

            entity.HasOne(d => d.Customer).WithMany(p => p.Orders)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Order_Subject");
        });

        modelBuilder.Entity<OrderService>(entity =>
        {
            entity.HasKey(e => new { e.OrderId, e.ServiceId });

            entity.ToTable("Order_Service");

            entity.Property(e => e.ServicePrice).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Employee).WithMany(p => p.OrderServices)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_Order_Service_Employee");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderServices)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Order_Service_Order");

            entity.HasOne(d => d.Service).WithMany(p => p.OrderServices)
                .HasForeignKey(d => d.ServiceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Order_Service_Service");
        });

        modelBuilder.Entity<OrderProduct>(entity =>
        {
            entity.HasKey(e => new { e.OrderId, e.ProductId }).HasName("PK_Order_Product");

            entity.ToTable("Order_Product");

            entity.Property(e => e.ProductQuantity).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 2)");


            entity.HasOne(d => d.Order).WithMany(p => p.OrderProducts)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Order_Product_Order");

            entity.HasOne(d => d.Product).WithMany(p => p.OrderProducts)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Order_Product_Product");
        });

        modelBuilder.Entity<PaymentSummary>(entity =>
        {
            entity.HasKey(e => new { e.PaymentId, e.OrderId }).HasName("PK__Payment___C3905BCF5B134B98");

            entity.ToTable("Payment_Summary");

            entity.Property(e => e.PaymentId).ValueGeneratedOnAdd();
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalCash).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DiscountedPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalPOS)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TotalPOS");

            entity.HasOne(d => d.Order).WithMany(p => p.PaymentSummaries)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Payment_Summary_Order");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__Product__B40CC6CDADEDCEB1");

            entity.ToTable("Product");

            entity.HasOne(d => d.Supplier).WithMany(p => p.Products)
                .HasForeignKey(d => d.SupplierId)
                .HasConstraintName("FK_Product_Subject");
        });

        modelBuilder.Entity<Service>(entity =>
        {
            entity.HasKey(e => e.ServiceId).HasName("PK__Service__C51BB00A37E209CE");

            entity.ToTable("Service");

            entity.Property(e => e.ServiceCode).HasMaxLength(100);
            entity.Property(e => e.ServiceMaximumPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ServiceMinimumPrice).HasColumnType("decimal(18, 2)");


            entity.HasOne(d => d.Category).WithMany(p => p.Services)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_Service_Category");

            entity.HasMany(d => d.Employees).WithMany(p => p.Services)
                .UsingEntity<Dictionary<string, object>>(
                    "EmployeeService",
                    r => r.HasOne<Employee>().WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Employee_Service_Employee"),
                    l => l.HasOne<Service>().WithMany()
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Employee_Service_Service"),
                    j =>
                    {
                        j.HasKey("ServiceId", "EmployeeId");
                        j.ToTable("Employee_Service");
                    });
        });

        modelBuilder.Entity<Stock>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__Stock__B40CC6CDF7B15FC9");

            entity.ToTable("Stock");

            entity.Property(e => e.ProductId).ValueGeneratedNever();
            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 6)");

            entity.HasOne(d => d.Product).WithOne(p => p.Stock)
                .HasForeignKey<Stock>(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Stock_Product");
        });

        modelBuilder.Entity<Subject>(entity =>
        {
            entity.HasKey(e => e.SubjectId).HasName("PK__Subject__AC1BA3A885CEB9A3");

            entity.ToTable("Subject");

            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(20);
            entity.Property(e => e.RegistrationDate).HasColumnType("datetime");
            entity.Property(e => e.SubjectLastName).HasMaxLength(255);
            entity.Property(e => e.SubjectName).HasMaxLength(255);
        });

        modelBuilder.Entity<Login>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Login");

            entity.ToTable("Login");

            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Username).HasMaxLength(50);
            entity.Property(e => e.Surname).HasMaxLength(50);
            entity.Property(e => e.Role).HasMaxLength(50);
        });


        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PK_Category");

            entity.ToTable("Category");

            entity.Property(e => e.CategoryName).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
