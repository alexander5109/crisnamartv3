namespace Crisnamart.Domain;

public static class PrototipoContenido {
	public static ProductDetailsModel GetProductDetailsModelEjemplo() => new() {
		Id = 100,
		Title = "Galletas Napolitanke - Crisnamart",
		Category = "Golosinas",
		Description = "Galletas Napolitanke sabor avellana. Producto clásico para kioscos y comedores. Ideal para ventas al por mayor y reposición rápida en tu comercio.",
		Price = 18m,
		OldPrice = 24m,
		Rating = 4.5,
		RatingCount = 30,
		Badge = "Oferta",
		ImageUrls = [
			"images/products/product-single-img-1.jpg",
			"images/products/product-single-img-2.jpg",
			"images/products/product-single-img-3.jpg",
			"images/products/product-single-img-4.jpg"
		],
		ProductCode = "CRS-NA-001",
		Availability = "Disponible",
		Type = "Comestible",
		ShippingInfo = "Entrega en 24-48 hs dentro de CABA y Gran Buenos Aires",
		Link = "#!"
	};

	public static List<ProductCardModel> GetProductCardModelEjemplos() => [
		new ProductCardModel {
			Id = 11,
			Title = "Café Tostado Molido",
			Category = "Bazar - Bebidas",
			ImageUrl = "images/products/product-img-11.jpg",
			Price = 13m,
			OldPrice = 18m,
			Rating = 4.5,
			RatingCount = 120,
			Badge = "Más vendido",
			Link = "#!",
			DealEndsAt = new DateTime(2028, 10, 10)
		},
		new ProductCardModel {
			Id = 12,
			Title = "Conserva de Tomate Triturado",
			Category = "Bazar - Conservas",
			ImageUrl = "images/products/product-img-12.jpg",
			Price = 13m,
			OldPrice = 18m,
			Rating = 4.5,
			RatingCount = 89,
			Badge = null,
			Link = "#!",
			DealEndsAt = new DateTime(2028, 12, 9)
		},
		new ProductCardModel {
			Id = 13,
			Title = "Ananá Dorado (Golden Pineapple)",
			Category = "Bazar - Frutas",
			ImageUrl = "images/products/product-img-13.jpg",
			Price = 13m,
			OldPrice = 18m,
			Rating = 4.5,
			RatingCount = 47,
			Badge = "Fresco",
			Link = "#!",
			DealEndsAt = new DateTime(2028, 11, 11)
		}
	];

	public static PromoBannerModel GetPromoBannerModelEjemplo() => new() {
		Title = "Promoción Mayorista Crisnamart",
		Description = "Descuentos especiales en lotes seleccionados. Ideal para abastecer kioscos y casas de regalos.",
		ImageUrl = "images/banner/banner-deal.jpg",
		ButtonText = "Ver ofertas",
		Link = "#!"
	};


	public static List<PromocionModel> GetPromocionModelEjemplos() => [
		new PromocionModel {
			Titulo = "Merca y Falopa",
			Descuento = 30,
			ImagenUrl = "images/banner/grocery-banner.png",
			Link = "#!",
			TextoBoton = "Encargar ahora!"
		},
		new PromocionModel {
			Titulo = "Faso",
			Descuento = 25,
			ImagenUrl = "images/banner/grocery-banner-2.jpg",
			Link = "#!",
			TextoBoton = "Hace tu pedido ya!"
		}
	];

	public static List<LocalProduct> GetLocalProductEjemplos() => [
		new LocalProduct { Id = 1, Title = "Haldiram's Sev Bhujia", Category = "Snack & Munchies", ImageUrl = "images/products/product-img-1.jpg", Price = 18, OldPrice = 24, Rating = 4.5, RatingCount = 149, Badge = "Sale" },
		new LocalProduct { Id = 2, Title = "NutriChoice Digestive", Category = "Bakery & Biscuits", ImageUrl = "images/products/product-img-2.jpg", OldPrice = 24, Price = 24, Rating = 4.5, RatingCount = 25, Badge = "14%" },
		new LocalProduct { Id = 3, Title = "Cadbury 5 Star Chocolate", Category = "Bakery & Biscuits", ImageUrl = "images/products/product-img-3.jpg", Price = 32, OldPrice = 35, Rating = 5, RatingCount = 469, Badge = "" },
		new LocalProduct { Id = 4, Title = "Onion Flavour Potato", Category = "Snack & Munchies", ImageUrl = "images/products/product-img-4.jpg", Price = 3, OldPrice = 5, Rating = 3.5, RatingCount = 456, Badge = "Hot" },
		new LocalProduct { Id = 5, Title = "Salted Instant Popcorn", Category = "Instant Food", ImageUrl = "images/products/product-img-5.jpg", Price = 13, OldPrice = 18, Rating = 4.5, RatingCount = 39, Badge = "" }
	];




	public static List<SlidePromocionalModel> GetSlidePromocionalModelEjemplos() => [
		new SlidePromocionalModel {
			ImagenUrl = "images/slider/slide-1.jpg",
			Subtitulo = "Opening Sale Discount 50%",
			TituloHtml = "SuperMarket<br/>For Fresh Grocery",
			Descripcion = "Introduced a new model for online grocery shopping and convenient home delivery.",
			TextoBoton = "Shop Now",
			Link = "#!"
		},
		new SlidePromocionalModel {
			ImagenUrl = "images/slider/slider-2.jpg",
			Subtitulo = "Free Shipping - orders over $100",
			TituloHtml = "Free Shipping on<br/>orders over <span class='text-green-600'>$100</span>",
			Descripcion = "Free Shipping to First-Time Customers Only, after promotions and discounts are applied.",
			TextoBoton = "Shop Now",
			Link = "#!"
		}
	];

	public static List<CategoriaModel> GetCategoriaModelEjemplos() => [
		new CategoriaModel { Id = "1001", Nombre = "Artículos de Cocina", ImagenUrl = "images/category/category-dairy-bread-eggs.jpg", Link = "#!" },
		new CategoriaModel { Id = "1002", Nombre = "Vajilla y Cubiertos", ImagenUrl = "images/category/category-snack-munchies.jpg", Link = "#!" },
		new CategoriaModel { Id = "1003", Nombre = "Pavas, Cafeteras y Teteras", ImagenUrl = "images/category/category-bakery-biscuits.jpg", Link = "#!" },
		new CategoriaModel { Id = "1004", Nombre = "Hogar y Organización", ImagenUrl = "images/category/category-instant-food.jpg", Link = "#!" },
		new CategoriaModel { Id = "1005", Nombre = "Decoración y Ambientación", ImagenUrl = "images/category/category-tea-coffee-drinks.jpg", Link = "#!" },
		new CategoriaModel { Id = "1006", Nombre = "Jardín y Camping", ImagenUrl = "images/category/category-atta-rice-dal.jpg", Link = "#!" },
		new CategoriaModel { Id = "1007", Nombre = "Mascotas y Cuidado", ImagenUrl = "images/category/category-baby-care.jpg", Link = "#!" },
		new CategoriaModel { Id = "1008", Nombre = "Carpinteria", ImagenUrl = "images/category/category-chicken-meat-fish.jpg", Link = "#!" },
		new CategoriaModel { Id = "1009", Nombre = "Limpieza", ImagenUrl = "images/category/category-cleaning-essentials.jpg", Link = "#!" },
		new CategoriaModel { Id = "1000", Nombre = "Animalitos", ImagenUrl = "images/category/category-pet-care.jpg", Link = "#!" }
	];

	public static List<CategoriaModel> GetCategoriaModelDestacadasEjemplos() =>
		[.. GetCategoriaModelEjemplos()
		.Where(x => new[] { "1001", "1002", "1003", "1004", "1005", "1006"}
		.Contains(x.Id))];

	public static List<PropuestaValor> GetPropuestaValorEjemplos() => [
		new PropuestaValor{
			Icono = "images/icons/clock.svg",
			Titulo = "Entrega rápida y confiable",
			Descripcion = "Entregamos tus productos en tiempo récord dentro de la zona, sin intermediarios ni demoras innecesarias."
		},new PropuestaValor{
			Icono = "images/icons/gift.svg",
			Titulo = "Ofertas pensadas para vos",
			Descripcion = "Precios justos y promociones semanales en productos de consumo cotidiano, para que siempre ahorres."
		}, new PropuestaValor{
			Icono = "images/icons/package.svg",
			Titulo = "Productos frescos y seleccionados",
			Descripcion = "Cada artículo es elegido por nuestro equipo garantizando calidad y frescura, como si compraras vos mismo."
		}, new PropuestaValor{
			Icono = "images/icons/refresh-cw.svg",
			Titulo = "Atención cercana y resolutiva",
			Descripcion = "Ante cualquier inconveniente, resolvemos tu pedido con rapidez y empatía. Queremos que vuelvas a elegirnos."
		}
	];
}