using System;

namespace Space{
class Producto {
    public string nombre{get; private set;}
    private double costo;
    public double precioVenta;
    public int stock;

  public Producto(string nombre, double costo, int stock)
  {
      while (string.IsNullOrEmpty(nombre) || costo <= 0)
      {
          Console.WriteLine("Error: nombre y costo del producto son obligatorios.");
          Console.Write("Ingrese el nombre del producto: ");
          nombre = Console.ReadLine();
          Console.Write("Ingrese el costo del producto: ");
          double.TryParse(Console.ReadLine(), out costo);
      }

      this.nombre = nombre;
      this.costo = costo;
      this.precioVenta = costo * 1.3; 
      this.stock = stock;
  }
}
    


}