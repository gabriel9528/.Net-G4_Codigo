using EjercicioFinal2Polimorfismo;

class Program
{
    static void Main(string[] args)
    {
        List<DocumentoFiscal> documentos = new List<DocumentoFiscal>
            {
                new Factura("F001", DateTime.Now, 1000, "Venta de productos"),
                new NotaCredito("NC001", DateTime.Now, 500, 50),
                new NotaDebito("ND001", DateTime.Now, 200, 20)
            };

        foreach (DocumentoFiscal documento in documentos)
        {
            Console.WriteLine($"Documento: {documento.Numero}, Fecha: {documento.Fecha.ToShortDateString()}, Total Calculado: {documento.CalcularTotal()}");
        }
    }
}