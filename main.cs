using System; 

namespace Space{

class Program {
  
  public static void Main (string[] args) {
    
    Tienda tienda = new Tienda(10000);
    tienda.AgregarProducto("Ravioles",200,20);
    Carrito carrito = new Carrito();
    bool salir = false; 
    while (!salir)
    {
        Console.WriteLine("Menú de la Tienda:");
        Console.WriteLine("1. Agregar producto");
        Console.WriteLine("2. Eliminar producto");
        Console.WriteLine("3. Mostrar listado de productos y Comprar");
        Console.WriteLine("4. Mostrar carrito");
        Console.WriteLine("5. Eliminar producto del carrito");
        Console.WriteLine("6. Cobrar importe total de la compra");
        Console.WriteLine("7. Salir");
        Console.Write("Seleccione una opción: ");


        switch (Console.ReadLine())
        {
            case "1":
              Console.Clear();
              Console.WriteLine("Agregar Producto:");
              Console.Write("Nombre: ");
              string name = Console.ReadLine();
              Console.Write("Costo: ");
              double cost = double.Parse(Console.ReadLine());
              Console.Write("Stock: ");
              int stock = int.Parse(Console.ReadLine());
              tienda.AgregarProducto(name, cost, stock);
              Console.Clear();
              break;

            case "2":
            Console.Clear();
            tienda.EliminarProducto();
            Console.Clear();
                break;
            case "3":
            Console.Clear();
            tienda.MostrarProductos(carrito);
            Console.Clear();
                break;
            case "4":
            Console.Clear();
            carrito.MostrarCarrito();
                break;
            case "5":
            Console.Clear();
            carrito.MostrarCarrito();
            Console.WriteLine("Nombre del producto que desea borrar del carrito: ");
            string rem = Console.ReadLine();
            carrito.EliminarProducto(rem);
                break;
            case "6":
            Console.Clear();
            carrito.MostrarCarrito();
            tienda.Cobrar(carrito);
            break;
            case "7":
            salir = true;
            break;
            default:
                Console.WriteLine("Opción no válida. Presione cualquier tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
                break;
        }
    }
    
    
  }
}
  }