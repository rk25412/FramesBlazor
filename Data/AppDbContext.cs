namespace FramesBlazor.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<AdminFramesIn> AdminFramesIns { get; set; } = default!;
    public DbSet<AdminPayment> AdminPayments { get; set; } = default!;
    public DbSet<AdminBill> AdminBills { get; set; } = default!;
    public DbSet<AdminBillFrameType> AdminBillFrameTypes { get; set; } = default!;
    public DbSet<Worker> Workers { get; set; } = default!;
    public DbSet<ItemType> ItemTypes { get; set; } = default!;
    public DbSet<WorkerFramesIn> WorkerFramesIns { get; set; } = default!;
    public DbSet<WorkerFramesOut> WorkerFramesOuts { get; set; } = default!;
    public DbSet<WorkerFramesOutNumber> WorkerFramesOutNumbers { get; set; } = default!;
    public DbSet<WorkerBill> WorkerBills { get; set; } = default!;
    public DbSet<WorkerBillFrameTypes> WorkerBillFrameTypes { get; set; } = default!;
    public DbSet<WorkerPayment> WorkerPayments { get; set; } = default!;
    public DbSet<AdminFramesOut> AdminFramesOuts { get; set; } = default!;
    public DbSet<AdminFramesOutNumber> AdminFramesOutNumbers { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Entity<ItemType>()
            .HasData(
                new ItemType(1, "Item1", 17, 12.5m),
                new ItemType(2, "Item2", 9, 7.5m),
                new ItemType(3, "Item3", 13, 9)
            );

        modelBuilder
            .Entity<Worker>()
            .HasData(
                new Worker(1, "Logan"),
                new Worker(2, "Jean"),
                new Worker(3, "Scott"),
                new Worker(4, "Kitty"),
                new Worker(5, "Storm")
            );

        var rnd = new Random();
        DateTime dateTime = DateTime.Today;

        modelBuilder.Entity<AdminFramesIn>()
            .HasData(
                new AdminFramesIn(1, rnd.Next(50, 100), new DateTime(dateTime.Year, dateTime.Month, rnd.Next(1, DateTime.Today.Day), rnd.Next(9, 17), rnd.Next(1, 59), 0)),
                new AdminFramesIn(2, rnd.Next(50, 100), new DateTime(dateTime.Year, dateTime.Month, rnd.Next(1, DateTime.Today.Day), rnd.Next(9, 17), rnd.Next(1, 59), 0)),
                new AdminFramesIn(3, rnd.Next(50, 100), new DateTime(dateTime.Year, dateTime.Month, rnd.Next(1, DateTime.Today.Day), rnd.Next(9, 17), rnd.Next(1, 59), 0)),
                new AdminFramesIn(4, rnd.Next(50, 100), new DateTime(dateTime.Year, dateTime.Month, rnd.Next(1, DateTime.Today.Day), rnd.Next(9, 17), rnd.Next(1, 59), 0)),
                new AdminFramesIn(5, rnd.Next(50, 100), new DateTime(dateTime.Year, dateTime.Month, rnd.Next(1, DateTime.Today.Day), rnd.Next(9, 17), rnd.Next(1, 59), 0)),
                new AdminFramesIn(6, rnd.Next(50, 100), new DateTime(dateTime.Year, dateTime.Month, rnd.Next(1, DateTime.Today.Day), rnd.Next(9, 17), rnd.Next(1, 59), 0)),
                new AdminFramesIn(7, rnd.Next(50, 100), new DateTime(dateTime.Year, dateTime.Month, rnd.Next(1, DateTime.Today.Day), rnd.Next(9, 17), rnd.Next(1, 59), 0)),
                new AdminFramesIn(8, rnd.Next(50, 100), new DateTime(dateTime.Year, dateTime.Month, rnd.Next(1, DateTime.Today.Day), rnd.Next(9, 17), rnd.Next(1, 59), 0)),
                new AdminFramesIn(9, rnd.Next(50, 100), new DateTime(dateTime.Year, dateTime.Month, rnd.Next(1, DateTime.Today.Day), rnd.Next(9, 17), rnd.Next(1, 59), 0)),
                new AdminFramesIn(10, rnd.Next(50, 100), new DateTime(dateTime.Year, dateTime.Month, rnd.Next(1, DateTime.Today.Day), rnd.Next(9, 17), rnd.Next(1, 59), 0))
            );
    }
}
