namespace ScreenTimeTracker.Models;

/// <summary>
/// Las claves de categoría se guardan en los JSON diarios y no deben cambiar;
/// aquí solo se traducen para mostrarlas en la interfaz.
/// </summary>
public static class CategoryNames
{
    public static string ToDisplay(string category) => category switch
    {
        "Juegos" => "Jeux",
        "Aplicaciones de Escritorio" => "Applications de bureau",
        "Navegación Web" or "Navegación Web (Edge)" => "Navigation Web",
        _ => category
    };
}
