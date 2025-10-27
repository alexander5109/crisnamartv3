namespace Crisnamart.Domain;

public static class PrototipoContenido {

	public static List<PromocionModel> ObtenerPromociones() => [
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

	public static List<SlidePromocionalModel> ObtenerSlidesPromocionales() => [
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

	public static List<CategoriaModel> TodasLasCategorias => [
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

	public static List<CategoriaModel> CategoriasDestacadas =>
		[.. TodasLasCategorias
		.Where(x => new[] { "1001", "1002", "1003", "1004", "1005", "1006"}
		.Contains(x.Id))];

	public static List<PropuestaValor> PropuestasDeValor => [
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