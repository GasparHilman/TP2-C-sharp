using System;
using System.Collections.Generic;

namespace Space{
  
class Tienda{
private List<Producto> productos = new List<Producto>();
private double DineroCaja;
  
  public Tienda(int dinero){
    this.DineroCaja = dinero;
  }
  
  public void AgregarProducto(string nombre, double costo, int stock){
    
    int index = productos.FindIndex(p => p.nombre == nombre);
    if (index >= 0){
      productos[index].stock += stock;
      productos[index].precioVenta = costo * 1.3;
    }else{
    Producto producto = new Producto(nombre, costo, stock);
    productos.Add(producto);
      }
  }
  
  public void EliminarProducto(){
    Console.WriteLine("Lista de productos:");
    for(int i = 0; i < productos.Count; i++){
      Console.WriteLine(i+1 + ". " + productos[i].nombre);
    }
    Console.WriteLine("Numero del producto que desea borrar: ");
    string borrar = Console.ReadLine();
    int index = int.Parse(borrar)-1;
     
    productos.Remove(productos[index]);
    
  }
  
  public void MostrarProductos(Carrito carrito){
    int index = 1;
    productos.ForEach(prod => Console.WriteLine(index++ +" "+ prod.nombre + " Stock: " + prod.stock + " Precio: " + prod.precioVenta));
    for(int y=0;y==0;){
    Console.WriteLine("¿Que producto desea agregar al carrito?");
    int producto = int.Parse(Console.ReadLine());
    try{
    Producto x = productos[producto-1];
    for (int z=0;z==0;){
    Console.WriteLine("¿Cuantos desea agregar?");
    int cantidad = int.Parse(Console.ReadLine());
      if (cantidad > 0){
      if(x.stock >= cantidad){
        carrito.AgregarProductoC(x, cantidad);
        z++;
      }else{
        Console.WriteLine("No hay suficiente stock de "+ x.nombre);
       }
      }else{
        z++;
      }
      y++;
     }}
      catch( Exception){
        Console.WriteLine("No existe el producto");
      }
      }
    
  }

  public void Cobrar(Carrito carrito){
    double total = carrito.CalcularSubtotal();
    for(int y=0;y==0;){
      Console.WriteLine("Ingrese el monto con el que va a pagar: ");
      int dinero = int.Parse(Console.ReadLine());
    if(dinero >= total){
      Console.Clear();
      Console.WriteLine("Compra realizada con exito!");
      Console.WriteLine("El cambio es de: "+ (dinero-total));
      Console.WriteLine("El dinero en caja es de: "+ (DineroCaja+total) + "\n");
      DineroCaja += total;
      carrito.produCarrito.Clear();
      carrito.cant.Clear();
      y++;
    }else{
      Console.WriteLine("El dinero ingresado es insuficiente");
    }}
    
  }
  }}
 