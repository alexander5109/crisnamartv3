using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crisnamart.Domain;
public class PromocionModel {

	public string Titulo { get; set; } = string.Empty;
	public int Descuento { get; set; }
	public string ImagenUrl { get; set; } = string.Empty;
	public string Link { get; set; } = "#!";
	public string TextoBoton { get; set; } = "Shop Now";
}
public class SlidePromocionalModel {
	public string ImagenUrl { get; set; } = string.Empty;
	public string Subtitulo { get; set; } = string.Empty;
	public string TituloHtml { get; set; } = string.Empty; // allows <br/> or <span> tags
	public string Descripcion { get; set; } = string.Empty;
	public string TextoBoton { get; set; } = "Shop Now";
	public string Link { get; set; } = "#!";
	public string ClasesInternas { get; set; } = "lg:py-32 p-12 lg:pl-12 xl:w-2/5 md:w-3/5";
}
public class CategoriaDestacadaModel {
	public string Nombre { get; set; } = string.Empty;
	public string ImagenUrl { get; set; } = string.Empty;
	public string Link { get; set; } = "#!";
}