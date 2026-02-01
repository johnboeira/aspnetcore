using eCommerce.WebApi.Contracts.Product;

namespace eCommerce.WebApi.Infra;

public class ProductRepository
{
    private static List<ProductResponse> _products = new List<ProductResponse>()
    {
        new ProductResponse(new Guid("11111111-2222-3333-4444-555555555555"), "Notebook Gamer", 8500.00m),
        new ProductResponse(Guid.NewGuid(), "Notebook Ultrafino", 6200.00m),
        new ProductResponse(Guid.NewGuid(), "Notebook 2 em 1", 5500.00m),
        new ProductResponse(Guid.NewGuid(), "Smartphone Android", 2800.00m),
        new ProductResponse(Guid.NewGuid(), "iPhone 15", 7200.00m),
        new ProductResponse(Guid.NewGuid(), "Tablet Android", 1800.00m),
        new ProductResponse(Guid.NewGuid(), "iPad Air", 4500.00m),
        new ProductResponse(Guid.NewGuid(), "Kindle Paperwhite", 650.00m),
        new ProductResponse(Guid.NewGuid(), "Monitor 24'' Full HD", 800.00m),
        new ProductResponse(Guid.NewGuid(), "Monitor 32'' 4K", 2200.00m),

        new ProductResponse(Guid.NewGuid(), "Teclado Mecânico RGB", 480.00m),
        new ProductResponse(Guid.NewGuid(), "Teclado sem fio", 220.00m),
        new ProductResponse(Guid.NewGuid(), "Mouse Gamer RGB", 320.00m),
        new ProductResponse(Guid.NewGuid(), "Mouse sem fio", 180.00m),
        new ProductResponse(Guid.NewGuid(), "Headset Gamer", 600.00m),
        new ProductResponse(Guid.NewGuid(), "Fone Bluetooth", 300.00m),
        new ProductResponse(Guid.NewGuid(), "Caixa de Som Inteligente", 550.00m),
        new ProductResponse(Guid.NewGuid(), "Soundbar", 1200.00m),
        new ProductResponse(Guid.NewGuid(), "Microfone USB", 350.00m),
        new ProductResponse(Guid.NewGuid(), "Webcam Full HD", 280.00m),

        new ProductResponse(Guid.NewGuid(), "SSD NVMe 1TB", 750.00m),
        new ProductResponse(Guid.NewGuid(), "SSD SATA 512GB", 350.00m),
        new ProductResponse(Guid.NewGuid(), "HD Externo 2TB", 500.00m),
        new ProductResponse(Guid.NewGuid(), "Placa de Vídeo RTX 4070", 4200.00m),
        new ProductResponse(Guid.NewGuid(), "Placa de Vídeo RTX 4090", 12000.00m),
        new ProductResponse(Guid.NewGuid(), "Placa-Mãe ATX", 900.00m),
        new ProductResponse(Guid.NewGuid(), "Processador Intel i9", 3500.00m),
        new ProductResponse(Guid.NewGuid(), "Processador Ryzen 9", 3200.00m),
        new ProductResponse(Guid.NewGuid(), "Memória RAM 16GB", 400.00m),
        new ProductResponse(Guid.NewGuid(), "Memória RAM 32GB", 780.00m),

        new ProductResponse(Guid.NewGuid(), "Fonte 750W Modular", 600.00m),
        new ProductResponse(Guid.NewGuid(), "Gabinete Gamer RGB", 750.00m),
        new ProductResponse(Guid.NewGuid(), "Water Cooler 240mm", 850.00m),
        new ProductResponse(Guid.NewGuid(), "Cooler de CPU", 250.00m),
        new ProductResponse(Guid.NewGuid(), "Roteador Wi-Fi 6", 700.00m),
        new ProductResponse(Guid.NewGuid(), "Switch Gigabit 8 Portas", 320.00m),
        new ProductResponse(Guid.NewGuid(), "HDMI Cable 2m", 60.00m),
        new ProductResponse(Guid.NewGuid(), "Carregador Portátil 20.000mAh", 220.00m),
        new ProductResponse(Guid.NewGuid(), "Estabilizador 1000VA", 480.00m),
        new ProductResponse(Guid.NewGuid(), "Nobreak 1500VA", 950.00m),

        new ProductResponse(Guid.NewGuid(), "Drone 4K", 5800.00m),
        new ProductResponse(Guid.NewGuid(), "Drone Profissional", 12500.00m),
        new ProductResponse(Guid.NewGuid(), "Câmera DSLR", 5200.00m),
        new ProductResponse(Guid.NewGuid(), "Câmera Mirrorless", 6800.00m),
        new ProductResponse(Guid.NewGuid(), "GoPro Hero", 2500.00m),
        new ProductResponse(Guid.NewGuid(), "Smartwatch", 1200.00m),
        new ProductResponse(Guid.NewGuid(), "Óculos de Realidade Virtual", 3500.00m),
        new ProductResponse(Guid.NewGuid(), "Console PlayStation 5", 4200.00m),
        new ProductResponse(Guid.NewGuid(), "Console Xbox Series X", 3900.00m),
        new ProductResponse(Guid.NewGuid(), "Nintendo Switch OLED", 2800.00m),
    };

    public async Task<ProductResponse> GetByIdAsync(Guid id)
    {
        await Task.Delay(600); // simulando I/O (Banco)
        return _products.SingleOrDefault(p => p.Id == id)!;
    }

    public async Task<IEnumerable<ProductResponse>> GetAllAsync()
    {
        await Task.Delay(700); // simulando I/O (Banco)
        return _products;
    }

    public async Task<ProductResponse> CreateAsync(ProductCreateRequest product)
    {
        await Task.Delay(700); // simulando I/O (Banco)
        var newProduct = new ProductResponse(Guid.NewGuid(), product.Name, product.Price);

        _products.Add(newProduct);

        return newProduct;
    }

    internal async Task<bool> DeleteAsync(ProductResponse productToDelete)
    {
        await Task.Delay(700); // simulando I/O (Banco)
        return _products.Remove(productToDelete);
    }
}