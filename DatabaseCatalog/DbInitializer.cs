using DatabaseCatalog.Models;

namespace DatabaseCatalog
{
    public class DbInitializer
    {
        ApplicationContext _context;

        public DbInitializer(ApplicationContext context)
        {
            _context = context;
        }

        public void Initialize()
        {
            try
            {
                _context.Database.EnsureCreated();
                InitializeInitialData();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void InitializeInitialData()
        {
            if (_context.Orders.Any())
            {
                return;
            }

            InitializeMaterials();
            InitializeManagers();
            InitializeOrders();
        }

        private void InitializeMaterials()
        {
            List<Material> materials = new List<Material>
            {
                new Material { Name = "Бумага", Type = "А6", PaperSettings = "105 x 148", Date = DateTime.Now },
                new Material { Name = "Бумага", Type = "А5", PaperSettings = "148 x 210", Date = DateTime.Now },
                new Material { Name = "Бумага", Type = "А4", PaperSettings = "297 x 210", Date = DateTime.Now },
                new Material { Name = "Бумага", Type = "А3", PaperSettings = "297 x 420", Date = DateTime.Now },
                new Material { Name = "Бумага", Type = "А2", PaperSettings = "594 x 420", Date = DateTime.Now },
                new Material { Name = "Бумага", Type = "А1", PaperSettings = "594 x 841", Date = DateTime.Now }
            };

            _context.Materials.AddRange(materials);

            _context.SaveChanges();
        }

        private void InitializeManagers()
        {
            List<Manager> managerList = new List<Manager>
            {
                new Manager { Name = "Иван", Surname = "Иванов", Patronymic = "Иванович", Appointment = "Менеджер 1" },
                new Manager { Name = "Петр", Surname = "Петров", Patronymic = "Петрович", Appointment = "Менеджер 2" }
            };

            _context.Managers.AddRange(managerList);

            _context.SaveChanges();
        }

        private void InitializeOrders()
        {
            Material material = _context.Materials.First(x => x.Type == "А4");
            Manager manager = _context.Managers.First(x => x.Appointment == "Менеджер 1");

            List<Order> orders = new List<Order>
            {
                new Order { Name = "Заказ 1", Volume = 200, Date = DateTime.Now, ManagerId = manager.Id, MaterialId = material.Id },
            };

            _context.Orders.AddRange(orders);

            _context.SaveChanges();
        }
    }
}
