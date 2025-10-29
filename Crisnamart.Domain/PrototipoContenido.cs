namespace Crisnamart.Domain;

public class PrototipoContenido {
	// -------------------------------- -----------------------  --------------------------------  //
	// -------------------------------- Product related samples  --------------------------------  //
	// -------------------------------- -----------------------  --------------------------------  //
	public static ProductDetailsModel GetProductDetailsModelEjemplo() => new() {
		Id = 100,
		Titulo = "Set de Vajilla Clásica - Crisnamart",
		Categoria = "Vajilla y Cubiertos",
		Descripcion = "Set de vajilla de acero inoxidable ideal para comercios y mayoristas. Resistente, fácil de limpiar y con diseño clásico para reposición en mostradores y locales.",
		Price = 180m,
		OldPrice = 240m,
		Rating = 4.5,
		RatingCount = 30,
		Badge = "Oferta",
		ImagePaths = [
			"images/products/product-single-img-1.jpg",
			"images/products/product-single-img-2.jpg",
			"images/products/product-single-img-3.jpg",
			"images/products/product-single-img-4.jpg"
		],
		ProductCode = "CRS-VJ-001",
		Availability = "Disponible",
		Type = "Vajilla",
		ShippingInfo = "Entrega en24-72 hs en zona metropolitana; envíos a todo el país según convenio con transportista.",
		Link = "#!"
	};

	public static List<ProductCardModel> GetProductCardModelEjemplos() => [
		new ProductCardModel {
			Id =11,
			Titulo = "Pack de Vasos de Vidrio",
			Categoria = "Bazar - Hogar",
			ImagePath = "images/products/product-img-11.jpg",
			Price =130m,
			OldPrice =180m,
			Rating =4.5,
			RatingCount =120,
			Badge = "Más vendido",
			Link = "#!",
			DealEndsAt = new DateTime(2028,10,10)
		},
		new ProductCardModel {
			Id =12,
			Titulo = "Organizador de Plástico (Caja10)",
			Categoria = "Bazar - Organización",
			ImagePath = "images/products/product-img-12.jpg",
			Price =95m,
			OldPrice =120m,
			Rating =4.5,
			RatingCount =89,
			Badge = null,
			Link = "#!",
			DealEndsAt = new DateTime(2028,12,9)
		},
		new ProductCardModel {
			Id =13,
			Titulo = "Lámpara de Mesa - Pie Metálico",
			Categoria = "Bazar - Iluminación",
			ImagePath = "images/products/product-img-13.jpg",
			Price =130m,
			OldPrice =180m,
			Rating =4.5,
			RatingCount =47,
			Badge = "Nuevo",
			Link = "#!",
			DealEndsAt = new DateTime(2028,11,11)
		}
	];

	public static List<LocalProduct> GetLocalProductEjemplos() => [
		new LocalProduct { Id =1, Titulo = "Juego de Cucharas de Acero (12u)", Categoria = "Bazar - Cocina", ImagePath = "images/products/product-img-1.jpg", Price =180, OldPrice =240, Rating =4.5, RatingCount =149, Badge = "Oferta" },
		new LocalProduct { Id =2, Titulo = "Set de Tazas Cerámicas (6u)", Categoria = "Bazar - Hogar", ImagePath = "images/products/product-img-2.jpg", OldPrice =240, Price =240, Rating =4.5, RatingCount =25, Badge = "14%" },
		new LocalProduct { Id =3, Titulo = "Porta Velas Decorativo", Categoria = "Bazar - Decoración", ImagePath = "images/products/product-img-3.jpg", Price =320, OldPrice =350, Rating =5, RatingCount =469, Badge = "" },
		new LocalProduct { Id =4, Titulo = "Pala para Cocina - Metal", Categoria = "Bazar - Cocina", ImagePath = "images/products/product-img-4.jpg", Price =30, OldPrice =50, Rating =3.5, RatingCount =456, Badge = "Popular" },
		new LocalProduct { Id =5, Titulo = "Palangana Plástica Grande", Categoria = "Bazar - Organización", ImagePath = "images/products/product-img-5.jpg", Price =130, OldPrice =180, Rating =4.5, RatingCount =39, Badge = "" }
	];




	// -------------------------------- -----------------------  --------------------------------  //
	// -------------------------------- Product related samples  --------------------------------  //
	// -------------------------------- -----------------------  --------------------------------  //
	
	public static PromoBannerModel GetPromoBannerModelEjemplo() => new() {
		Titulo = "Promoción Mayorista - Lotes Seleccionados",
		Descripcion = "Descuentos especiales por compra por mayor en artículos de bazar. Ideal para reposición de locales y distribuidores.",
		ImagePath = "images/banner/banner-deal.jpg",
		ButtonText = "Ver ofertas",
		Link = "#!"
	};

	public static List<PromocionModel> GetPromocionModelEjemplos() => [
		new PromocionModel {
			Titulo = "Stock Mayorista",
			Descuento =30,
			ImagePath = "images/banner/grocery-banner.png",
			Link = "#!",
			TextoBoton = "Encargar ahora"
		},
		new PromocionModel {
			Titulo = "Liquidación de Temporada",
			Descuento =25,
			ImagePath = "images/banner/grocery-banner-2.jpg",
			Link = "#!",
			TextoBoton = "Ver precios"
		}
	];

	public static List<SlidePromocionalModel> GetSlidePromocionalModelEjemplos() => [
		new SlidePromocionalModel {
			ImagePath = "images/slider/slide-1.jpg",
			Subtitulo = "Apertura: Descuentos por volumen",
			TituloHtml = "Bazar Mayorista<br/>Calidad y Precio",
			Descripcion = "Amplio stock de artículos de bazar para mayoristas y comercios. Compras al por mayor con precios especiales.",
			TextoBoton = "Ver productos",
			Link = "#!"
		},
		new SlidePromocionalModel {
			ImagePath = "images/slider/slider-2.jpg",
			Subtitulo = "Envío gratuito por compras superiores",
			TituloHtml = "Envíos especiales<br/>para pedidos mayores",
			Descripcion = "Coordinamos envíos y entregas para distribuidores y comercios. Consultá condiciones y zonas de cobertura.",
			TextoBoton = "Consultar envíos",
			Link = "#!"
		}
	];

	public static List<CategoriaModel> GetCategoriaModelEjemplos() => [
		new CategoriaModel { Id = "1001", Titulo = "Artículos de Cocina", ImagePath = "images/category/category-dairy-bread-eggs.jpg", Link = "#!" },
		new CategoriaModel { Id = "1002", Titulo = "Vajilla y Cubiertos", ImagePath = "images/category/category-snack-munchies.jpg", Link = "#!" },
		new CategoriaModel { Id = "1003", Titulo = "Pequeños Electrodomésticos", ImagePath = "images/category/category-bakery-biscuits.jpg", Link = "#!" },
		new CategoriaModel { Id = "1004", Titulo = "Hogar y Organización", ImagePath = "images/category/category-instant-food.jpg", Link = "#!" },
		new CategoriaModel { Id = "1005", Titulo = "Decoración y Ambientación", ImagePath = "images/category/category-tea-coffee-drinks.jpg", Link = "#!" },
		new CategoriaModel { Id = "1006", Titulo = "Jardín y Camping", ImagePath = "images/category/category-atta-rice-dal.jpg", Link = "#!" },
		new CategoriaModel { Id = "1007", Titulo = "Mascotas y Cuidado", ImagePath = "images/category/category-baby-care.jpg", Link = "#!" },
		new CategoriaModel { Id = "1008", Titulo = "Carpintería", ImagePath = "images/category/category-chicken-meat-fish.jpg", Link = "#!" },
		new CategoriaModel { Id = "1009", Titulo = "Limpieza", ImagePath = "images/category/category-cleaning-essentials.jpg", Link = "#!" },
		new CategoriaModel { Id = "1000", Titulo = "Artículos Infantiles", ImagePath = "images/category/category-pet-care.jpg", Link = "#!" }
	];

	public static List<CategoriaModel> GetCategoriaModelDestacadasEjemplos() => [
		.. GetCategoriaModelEjemplos()
		.Where(x => new[] { "1001", "1002", "1003", "1004", "1005", "1006"}
		.Contains(x.Id))
	];

	public static List<PropuestaValor> GetPropuestaValorEjemplos() => [
		new PropuestaValor{
			Icono = "images/icons/clock.svg",
			Titulo = "Entrega rápida y confiable",
			Descripcion = "Entregamos los pedidos mayoristas en tiempo acordado dentro de la zona, con seguimiento directo."
		},new PropuestaValor{
			Icono = "images/icons/gift.svg",
			Titulo = "Ofertas y precios por volumen",
			Descripcion = "Descuentos y condiciones especiales para compras por mayor según acuerdos comerciales."
		}, new PropuestaValor{
			Icono = "images/icons/package.svg",
			Titulo = "Stock variado y de calidad",
			Descripcion = "Selección de productos nacionales e importados pensada para comercios y distribuidores."
		}, new PropuestaValor{
			Icono = "images/icons/refresh-cw.svg",
			Titulo = "Atención personalizada",
			Descripcion = "Asesoramiento comercial directo y soluciones a medida para clientes mayoristas."
		}
	];

	public static List<FooterColumn> GetFooterColumnsEjemplos() => [
		new FooterColumn {
			Titulo = "Categorías",
			Enlaces = [
				new Enlace { Titulo = "Artículos de Cocina", Url = "#!" },
				new Enlace { Titulo = "Vajilla y Cubiertos", Url = "#!" },
				new Enlace { Titulo = "Pequeños Electrodomésticos", Url = "#!" },
				new Enlace { Titulo = "Hogar y Organización", Url = "#!" },
				new Enlace { Titulo = "Decoración", Url = "#!" }
			]
		},
		new FooterColumn {
			Titulo = "Información",
			Enlaces = [
				new Enlace { Titulo = "Quiénes somos", Url = "#!" },
				new Enlace { Titulo = "Contacto", Url = "#!" },
				new Enlace { Titulo = "Términos y condiciones", Url = "#!" },
				new Enlace { Titulo = "Política de privacidad", Url = "#!" }
			]
		},
		new FooterColumn {
			Titulo = "Clientes",
			Enlaces = [
				new Enlace { Titulo = "Cómo comprar", Url = "#!" },
				new Enlace { Titulo = "Formas de pago", Url = "#!" },
				new Enlace { Titulo = "Envíos y logística", Url = "#!" },
				new Enlace { Titulo = "Devoluciones", Url = "#!" }
			]
		},
		new FooterColumn {
			Titulo = "Programas",
			Enlaces = [
				new Enlace { Titulo = "Ofertas por volumen", Url = "#!" },
				new Enlace { Titulo = "Trabajá con nosotros", Url = "#!" },
				new Enlace { Titulo = "Novedades", Url = "#!" }
			]
		}
	];


	public static List<IconoConEnlace> GetMediosDePagoEjemplo() => new(){
		new IconoConEnlace { Titulo = "MercadoPago", ImagePath = "images/payment/mp_28.svg", Url = "#!"  },
		new IconoConEnlace { Titulo = "Visa", ImagePath = "images/payment/visa.svg", Url = "#!"  },
		new IconoConEnlace { Titulo = "Mastercard", ImagePath = "images/payment/mastercard.svg", Url = "#!"  },
		//new IconoConEnlace { Titulo = "PayPal", ImagePath = "images/payment/paypal.svg", Url = "#!"  },
	};

	public static List<IconoConEnlace> GetRedesSocialesEjemplo() => new(){
		new() { Titulo = "Facebook", ImagePath = "images/social/28x28/facebook.png", Url = "https://www.facebook.com/" },
		new() { Titulo = "X (Twitter)", ImagePath = "images/social/28x28/x.png", Url = "https://x.com/" },
		new() { Titulo = "Instagram", ImagePath = "images/social/28x28/instagram.png", Url = "https://www.instagram.com/" },
	};

	public static List<IconoConEnlace> GetMediosDeContactoEjemplo() => new(){
		new IconoConEnlace{ Titulo = "WhatsApp", ImagePath = "images/contact/whatsapp_28.png", Url = "https://wa.me/541173624473" },
		new IconoConEnlace{ Titulo = "Email", ImagePath = "images/contact/email_28.svg", Url = "mailto:contacto@crisnamart.com" }
	};

	public static FooterTrademark GetTrademarkEjemplo() => new() {
		Empresa = "Crisnamart",
		Copyright = "Todos los derechos reservados.",
		Creditos = "Plantilla Tailwind-eCommerce adaptada por Seling Alexander."
	};


}