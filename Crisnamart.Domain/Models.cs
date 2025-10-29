namespace Crisnamart.Domain;


// -------------------------------- -----------------------  --------------------------------  //
// -------------------------------- Product related models   --------------------------------  //
// -------------------------------- -----------------------  --------------------------------  //
public record LocalProduct {
	public required int Id { get; init; }
	public required string Titulo { get; init; }
	public required string Categoria { get; init; }
	public required decimal Price { get; init; }
	public required decimal? OldPrice { get; init; }
	
	public required string ImageUrl { get; init; }
	public required double Rating { get; init; }
	public required int RatingCount { get; init; }
	public required string? Badge { get; init; }
}

public record ProductDetailsModel {
	public required int Id { get; init; }
	public required string Titulo { get; init; }
	public string? Categoria { get; init; }
	public required decimal Price { get; init; }
	public decimal? OldPrice { get; init; }
	
	public required List<string> ImageUrls { get; init; }
	public required string Description { get; init; }
	public double Rating { get; init; }
	public int RatingCount { get; init; }
	public string? Badge { get; init; }
	public required string ProductCode { get; init; }
	public string Availability { get; init; } = "En stock";
	public string Type { get; init; } = "";
	public string ShippingInfo { get; init; } = "";
	public string? Link { get; init; }
}

public record ProductCardModel {
	public required int Id { get; init; }
	public required string Titulo { get; init; }
	public string? Categoria { get; init; }
	public required decimal Price { get; init; }
	public decimal? OldPrice { get; init; }
	
	public required string ImageUrl { get; init; }
	public double Rating { get; init; }
	public int RatingCount { get; init; }
	public string? Badge { get; init; }
	public string? Link { get; init; }
	public DateTime? DealEndsAt { get; init; }
}




// -------------------------------- -----------------------  --------------------------------  //
// --------------------------------   Home related models    --------------------------------  //
// -------------------------------- -----------------------  --------------------------------  //

public record PromocionModel {
	public required string Titulo { get; init; }
	public required int Descuento { get; init; }
	public required string ImagenUrl { get; init; }
	public required string Link { get; init; }
	public required string TextoBoton { get; init; }
}

public record SlidePromocionalModel {
	public required string ImagenUrl { get; init; }
	public required string Subtitulo { get; init; }
	public required string TituloHtml { get; init; }
	public required string Descripcion { get; init; }
	public required string TextoBoton { get; init; }
	public required string Link { get; init; }
}

public record PropuestaValor {
	public required string Icono { get; init; }
	public required string Titulo { get; init; }
	public required string Descripcion { get; init; }
}

public record CategoriaModel {
	public required string Id { get; init; }
	public required string Nombre { get; init; }
	public required string ImagenUrl { get; init; }
	public required string Link { get; init; }
}

public record PromoBannerModel {
	public required string Titulo { get; init; }
	public required string Description { get; init; }
	public required string ImageUrl { get; init; }
	public required string ButtonText { get; init; }
	public string? Link { get; init; }
}

public record Enlace {
	public required string Nombre { get; init; }
	public required string Url { get; init; }
}

public record FooterColumn {
	public required string Titulo { get; init; }
	public required List<Enlace> Enlaces { get; init; }
}

public record FooterTrademark {
	public string Empresa { get; set; } = string.Empty;
	public string Copyright { get; set; } = string.Empty;
	public string Creditos { get; set; } = string.Empty;
}

public record FooterLink {
	public string Nombre { get; set; } = string.Empty;
	public string Url { get; set; } = "#";
}

public record MedioDePago {
	public string Nombre { get; set; } = string.Empty;
	public string ImagePath { get; set; } = string.Empty;
	public string Url { get; set; } = "#";
}

public record RedSocial {
	public string Nombre { get; set; } = string.Empty;
	public string ImagePath { get; set; } = string.Empty;
	public string Url { get; set; } = "#";
}

public record MedioDeContacto {
	public string Nombre { get; set; } = string.Empty;
	public string ImagePath { get; set; } = string.Empty;
	public string Url { get; set; } = "#";
}