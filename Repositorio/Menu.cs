using system;
namespace facturacionAPP
{
    class program
    {
        static void main(string[] args)
        {
            console.writeline("sistema de facturacion");
           
            //datos del cliente
            string nombreCliente = "juan perez";
            string direccionCliente = "123 calle principal";

            // datos del producto
            string nombreProducto = "producto A"
            double PrecioProducto= 19.99;
            int cantidaProducto= 2;

            // calculo del total
            double total = PrecioProducto * cantidaProducto;

            // imprimir factura 
            console.writeline ("\nfactura");
            console.writeline ("cliente:" + nombreCliente);
            console.writeline ("direccion:"direccionCliente);
             console.writeline ("producto: " + nombreProducto);
             cosole.writeline ("precio por unidad: $" + PrecioProducto);
             console.writeline("cantidad:"  + cantidaProducto);
             console.writeline("total: $" + total);
             
        
        }
    }
}
