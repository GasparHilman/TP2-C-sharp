using System;
using System.Collections.Generic;

namespace Space{

class Carrito
{
    public List<Producto> produCarrito = new List<Producto>();
    public List<int> cant = new List<int>();

    public void AgregarProductoC(Producto producto, int cantidad)
    {   
        int index =produCarrito.FindIndex(x => x.nombre == producto.nombre);
        if (index >= 0){
            produCarrito[index].stock -= cantidad;
            cant[index] += cantidad;
        }else{
        produCarrito.Add(producto);
        cant.Add(cantidad);
        producto.stock -= cantidad;
            }
    }

    public void EliminarProducto(String Sproducto)
    {
        int index =produCarrito.FindIndex(prod => prod.nombre == Sproducto);
        if (index >= 0)
        {
            produCarrito[index].stock += cant[index];
            produCarrito.RemoveAt(index);
            cant.RemoveAt(index);
        }
        else
        {
            Console.WriteLine("El producto no se encuentra en el carrito.");
        }
    }

    public double CalcularSubtotal()
    {
        double subtotal = 0;
        for (int i = 0; i < produCarrito.Count; i++)
        {
            subtotal += produCarrito[i].precioVenta * cant[i];
        }
        return subtotal;
    }

    public void MostrarCarrito()
    {   Console.WriteLine(".................................................");
        Console.WriteLine("                  --CARRITO--");
        for (int i = 0; i < produCarrito.Count; i++)
        {
            Console.WriteLine(produCarrito[i].nombre + "  | Cantidad: " + cant[i] + "| Precio unitario: " + produCarrito[i].precioVenta);
        }
        Console.WriteLine("\n Subtotal: " + CalcularSubtotal());
        Console.WriteLine(".................................................");
    }
}
}