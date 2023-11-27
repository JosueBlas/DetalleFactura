public class DetalleFactura
{
    public int IdDetalleFactura{ get; set; }

    public int IdFactura{ get; set; }
    public Factura Factura{ get; set; }

    public int IdProducto{ get; set; }
    public Producto Producto{ get; set; }

    public int CantidadProducto{ get; set; }
    public decimal SubTotal{ get; set; }
    public decimal Descuento{ get; set; }
    public decimal Impuesto{ get; set; }
}
