using eCommerce.Domain.Features.Products;

namespace eCommerce.WebApi.Infra.Data;

public class ProductRepository
{
    private static List<Product> _products = new List<Product>()
    {
        new Product(new Guid("11111111-2222-3333-4444-555555555555"), "Notebook Gamer", 8500.00m),
        new Product(Guid.NewGuid(), "Notebook Ultrafino", 6200.00m),
        new Product(Guid.NewGuid(), "Notebook 2 em 1", 5500.00m),
        new Product(Guid.NewGuid(), "Smartphone Android", 2800.00m),
        new Product(Guid.NewGuid(), "iPhone 15", 7200.00m),
        new Product(Guid.NewGuid(), "Tablet Android", 1800.00m),
        new Product(Guid.NewGuid(), "iPad Air", 4500.00m),
        new Product(Guid.NewGuid(), "Kindle Paperwhite", 650.00m),
        new Product(Guid.NewGuid(), "Monitor 24'' Full HD", 800.00m),
        new Product(Guid.NewGuid(), "Monitor 32'' 4K", 2200.00m),

        new Product(Guid.NewGuid(), "Teclado Mecânico RGB", 480.00m),
        new Product(Guid.NewGuid(), "Teclado sem fio", 220.00m),
        new Product(Guid.NewGuid(), "Mouse Gamer RGB", 320.00m),
        new Product(Guid.NewGuid(), "Mouse sem fio", 180.00m),
        new Product(Guid.NewGuid(), "Headset Gamer", 600.00m),
        new Product(Guid.NewGuid(), "Fone Bluetooth", 300.00m),
        new Product(Guid.NewGuid(), "Caixa de Som Inteligente", 550.00m),
        new Product(Guid.NewGuid(), "Soundbar", 1200.00m),
        new Product(Guid.NewGuid(), "Microfone USB", 350.00m),
        new Product(Guid.NewGuid(), "Webcam Full HD", 280.00m),

        new Product(Guid.NewGuid(), "SSD NVMe 1TB", 750.00m),
        new Product(Guid.NewGuid(), "SSD SATA 512GB", 350.00m),
        new Product(Guid.NewGuid(), "HD Externo 2TB", 500.00m),
        new Product(Guid.NewGuid(), "Placa de Vídeo RTX 4070", 4200.00m),
        new Product(Guid.NewGuid(), "Placa de Vídeo RTX 4090", 12000.00m),
        new Product(Guid.NewGuid(), "Placa-Mãe ATX", 900.00m),
        new Product(Guid.NewGuid(), "Processador Intel i9", 3500.00m),
        new Product(Guid.NewGuid(), "Processador Ryzen 9", 3200.00m),
        new Product(Guid.NewGuid(), "Memória RAM 16GB", 400.00m),
        new Product(Guid.NewGuid(), "Memória RAM 32GB", 780.00m),

        new Product(Guid.NewGuid(), "Fonte 750W Modular", 600.00m),
        new Product(Guid.NewGuid(), "Gabinete Gamer RGB", 750.00m),
        new Product(Guid.NewGuid(), "Water Cooler 240mm", 850.00m),
        new Product(Guid.NewGuid(), "Cooler de CPU", 250.00m),
        new Product(Guid.NewGuid(), "Roteador Wi-Fi 6", 700.00m),
        new Product(Guid.NewGuid(), "Switch Gigabit 8 Portas", 320.00m),
        new Product(Guid.NewGuid(), "HDMI Cable 2m", 60.00m),
        new Product(Guid.NewGuid(), "Carregador Portátil 20.000mAh", 220.00m),
        new Product(Guid.NewGuid(), "Estabilizador 1000VA", 480.00m),
        new Product(Guid.NewGuid(), "Nobreak 1500VA", 950.00m),

        new Product(Guid.NewGuid(), "Drone 4K", 5800.00m),
        new Product(Guid.NewGuid(), "Drone Profissional", 12500.00m),
        new Product(Guid.NewGuid(), "Câmera DSLR", 5200.00m),
        new Product(Guid.NewGuid(), "Câmera Mirrorless", 6800.00m),
        new Product(Guid.NewGuid(), "GoPro Hero", 2500.00m),
        new Product(Guid.NewGuid(), "Smartwatch", 1200.00m),
        new Product(Guid.NewGuid(), "Óculos de Realidade Virtual", 3500.00m),
        new Product(Guid.NewGuid(), "Console PlayStation 5", 4200.00m),
        new Product(Guid.NewGuid(), "Console Xbox Series X", 3900.00m),
        new Product(Guid.NewGuid(), "Nintendo Switch OLED", 2800.00m),
    };

    public async Task<Product> GetByIdAsync(Guid id)
    {
        await Task.Delay(600); // simulate I/O (db)
        return _products.SingleOrDefault(p => p.Id == id)!;
    }

    public async Task<IEnumerable<Product>> GetAllAsync()
    {
        await Task.Delay(700); // simulate I/O (db)
        return _products;
    }

    public async Task<Product> CreateAsync(Product product)
    {
        await Task.Delay(700); // simulate I/O (db)
        var newProduct = new Product(Guid.NewGuid(), product.Name, product.Price);

        _products.Add(newProduct);

        return newProduct;
    }

    internal async Task<bool> DeleteAsync(Product productToDelete)
    {
        await Task.Delay(700); // simulate I/O (db)
        return _products.Remove(productToDelete);
    }
}