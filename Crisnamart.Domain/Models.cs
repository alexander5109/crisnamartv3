namespace Crisnamart.Domain;

public record PromocionModel {
	public required string Titulo { get; init; }
	public required	int Descuento { get; init; }
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