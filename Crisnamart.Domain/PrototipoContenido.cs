namespace Crisnamart.Domain;

public class PrototipoContenido {
	public static ProductDetailsModel GetProductDetailsModelEjemplo() => new() {
		Id = 100,
		Title = "Set de Vajilla Clásica - Crisnamart",
		Category = "Vajilla y Cubiertos",
		Description = "Set de vajilla de acero inoxidable ideal para comercios y mayoristas. Resistente, fácil de limpiar y con diseño clásico para reposición en mostradores y locales.",
		Price = 180m,
		OldPrice = 240m,
		Rating = 4.5,
		RatingCount = 30,
		Badge = "Oferta",
		ImageUrls = [
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

	public static PromoBannerModel GetPromoBannerModelEjemplo() => new() {
		Title = "Promoción Mayorista - Lotes Seleccionados",
		Description = "Descuentos especiales por compra por mayor en artículos de bazar. Ideal para reposición de locales y distribuidores.",
		ImageUrl = "images/banner/banner-deal.jpg",
		ButtonText = "Ver ofertas",
		Link = "#!"
	};


	public static List<PromocionModel> GetPromocionModelEjemplos() => [
		new PromocionModel {
			Titulo = "Stock Mayorista",
			Descuento =30,
			ImagenUrl = "images/banner/grocery-banner.png",
			Link = "#!",
			TextoBoton = "Encargar ahora"
		},
		new PromocionModel {
			Titulo = "Liquidación de Temporada",
			Descuento =25,
			ImagenUrl = "images/banner/grocery-banner-2.jpg",
			Link = "#!",
			TextoBoton = "Ver precios"
		}
	];




	public static List<ProductCardModel> GetProductCardModelEjemplos() => [
		new ProductCardModel {
			Id =11,
			Title = "Pack de Vasos de Vidrio",
			Category = "Bazar - Hogar",
			ImageUrl = "images/products/product-img-11.jpg",
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
			Title = "Organizador de Plástico (Caja10)",
			Category = "Bazar - Organización",
			ImageUrl = "images/products/product-img-12.jpg",
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
			Title = "Lámpara de Mesa - Pie Metálico",
			Category = "Bazar - Iluminación",
			ImageUrl = "images/products/product-img-13.jpg",
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
		new LocalProduct { Id =1, Title = "Juego de Cucharas de Acero (12u)", Category = "Bazar - Cocina", ImageUrl = "images/products/product-img-1.jpg", Price =180, OldPrice =240, Rating =4.5, RatingCount =149, Badge = "Oferta" },
		new LocalProduct { Id =2, Title = "Set de Tazas Cerámicas (6u)", Category = "Bazar - Hogar", ImageUrl = "images/products/product-img-2.jpg", OldPrice =240, Price =240, Rating =4.5, RatingCount =25, Badge = "14%" },
		new LocalProduct { Id =3, Title = "Porta Velas Decorativo", Category = "Bazar - Decoración", ImageUrl = "images/products/product-img-3.jpg", Price =320, OldPrice =350, Rating =5, RatingCount =469, Badge = "" },
		new LocalProduct { Id =4, Title = "Pala para Cocina - Metal", Category = "Bazar - Cocina", ImageUrl = "images/products/product-img-4.jpg", Price =30, OldPrice =50, Rating =3.5, RatingCount =456, Badge = "Popular" },
		new LocalProduct { Id =5, Title = "Palangana Plástica Grande", Category = "Bazar - Organización", ImageUrl = "images/products/product-img-5.jpg", Price =130, OldPrice =180, Rating =4.5, RatingCount =39, Badge = "" }
	];



	public static List<SlidePromocionalModel> GetSlidePromocionalModelEjemplos() => [
		new SlidePromocionalModel {
			ImagenUrl = "images/slider/slide-1.jpg",
			Subtitulo = "Apertura: Descuentos por volumen",
			TituloHtml = "Bazar Mayorista<br/>Calidad y Precio",
			Descripcion = "Amplio stock de artículos de bazar para mayoristas y comercios. Compras al por mayor con precios especiales.",
			TextoBoton = "Ver productos",
			Link = "#!"
		},
		new SlidePromocionalModel {
			ImagenUrl = "images/slider/slider-2.jpg",
			Subtitulo = "Envío gratuito por compras superiores",
			TituloHtml = "Envíos especiales<br/>para pedidos mayores",
			Descripcion = "Coordinamos envíos y entregas para distribuidores y comercios. Consultá condiciones y zonas de cobertura.",
			TextoBoton = "Consultar envíos",
			Link = "#!"
		}
	];

	public static List<CategoriaModel> GetCategoriaModelEjemplos() => [
		new CategoriaModel { Id = "1001", Nombre = "Artículos de Cocina", ImagenUrl = "images/category/category-dairy-bread-eggs.jpg", Link = "#!" },
		new CategoriaModel { Id = "1002", Nombre = "Vajilla y Cubiertos", ImagenUrl = "images/category/category-snack-munchies.jpg", Link = "#!" },
		new CategoriaModel { Id = "1003", Nombre = "Pequeños Electrodomésticos", ImagenUrl = "images/category/category-bakery-biscuits.jpg", Link = "#!" },
		new CategoriaModel { Id = "1004", Nombre = "Hogar y Organización", ImagenUrl = "images/category/category-instant-food.jpg", Link = "#!" },
		new CategoriaModel { Id = "1005", Nombre = "Decoración y Ambientación", ImagenUrl = "images/category/category-tea-coffee-drinks.jpg", Link = "#!" },
		new CategoriaModel { Id = "1006", Nombre = "Jardín y Camping", ImagenUrl = "images/category/category-atta-rice-dal.jpg", Link = "#!" },
		new CategoriaModel { Id = "1007", Nombre = "Mascotas y Cuidado", ImagenUrl = "images/category/category-baby-care.jpg", Link = "#!" },
		new CategoriaModel { Id = "1008", Nombre = "Carpintería", ImagenUrl = "images/category/category-chicken-meat-fish.jpg", Link = "#!" },
		new CategoriaModel { Id = "1009", Nombre = "Limpieza", ImagenUrl = "images/category/category-cleaning-essentials.jpg", Link = "#!" },
		new CategoriaModel { Id = "1000", Nombre = "Artículos Infantiles", ImagenUrl = "images/category/category-pet-care.jpg", Link = "#!" }
	];

	public static List<CategoriaModel> GetCategoriaModelDestacadasEjemplos() =>
		[.. GetCategoriaModelEjemplos()
		.Where(x => new[] { "1001", "1002", "1003", "1004", "1005", "1006"}
		.Contains(x.Id))];

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
				new Enlace { Nombre = "Artículos de Cocina", Url = "#!" },
				new Enlace { Nombre = "Vajilla y Cubiertos", Url = "#!" },
				new Enlace { Nombre = "Pequeños Electrodomésticos", Url = "#!" },
				new Enlace { Nombre = "Hogar y Organización", Url = "#!" },
				new Enlace { Nombre = "Decoración", Url = "#!" }
			]
		},
		new FooterColumn {
			Titulo = "Información",
			Enlaces = [
				new Enlace { Nombre = "Quiénes somos", Url = "#!" },
				new Enlace { Nombre = "Contacto", Url = "#!" },
				new Enlace { Nombre = "Términos y condiciones", Url = "#!" },
				new Enlace { Nombre = "Política de privacidad", Url = "#!" }
			]
		},
		new FooterColumn {
			Titulo = "Clientes",
			Enlaces = [
				new Enlace { Nombre = "Cómo comprar", Url = "#!" },
				new Enlace { Nombre = "Formas de pago", Url = "#!" },
				new Enlace { Nombre = "Envíos y logística", Url = "#!" },
				new Enlace { Nombre = "Devoluciones", Url = "#!" }
			]
		},
		new FooterColumn {
			Titulo = "Programas",
			Enlaces = [
				new Enlace { Nombre = "Ofertas por volumen", Url = "#!" },
				new Enlace { Nombre = "Trabajá con nosotros", Url = "#!" },
				new Enlace { Nombre = "Novedades", Url = "#!" }
			]
		}
	];




	public static List<MedioDePago> GetMediosDePagoEjemplo() => new(){
		new MedioDePago { Nombre = "MercadoPago", ImagePath = "images/payment/mp_28.svg", Url = "#!"  },
		new MedioDePago { Nombre = "Visa", ImagePath = "images/payment/visa.svg", Url = "#!"  },
		new MedioDePago { Nombre = "Mastercard", ImagePath = "images/payment/mastercard.svg", Url = "#!"  },
		//new MedioDePago { Nombre = "PayPal", ImagePath = "images/payment/paypal.svg", Url = "#!"  },
	};

	public static List<RedSocial> GetRedesSocialesEjemplo() => new(){
		new() { Nombre = "Facebook", ImagePath = "images/social/28x28/facebook.png", Url = "https://www.facebook.com/" },
		new() { Nombre = "X (Twitter)", ImagePath = "images/social/28x28/x.png", Url = "https://x.com/" },
		new() { Nombre = "Instagram", ImagePath = "images/social/28x28/instagram.png", Url = "https://www.instagram.com/" },
	};

	public static List<MedioDeContacto> GetMediosDeContactoEjemplo() => new(){
		new MedioDeContacto{ Nombre = "WhatsApp", ImagePath = "images/contact/whatsapp_28.png", Url = "https://wa.me/541173624473" },
		new MedioDeContacto{ Nombre = "Email", ImagePath = "images/contact/email_28.svg", Url = "mailto:contacto@crisnamart.com" }
	};

	public static FooterTrademark GetTrademarkEjemplo() => new() {
		Empresa = "Crisnamart",
		TextoLegal = "Todos los derechos reservados.<br/>Plantilla Tailwind-eCommerce adaptada por Seling Alexander."
	};


}