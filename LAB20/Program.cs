using LAB20;

ProductoFisico fisico = new ProductoFisico("P01", "Laptop", 30000, 2.5);
ProductoDigital digital = new ProductoDigital("P02", "Video", 500, 700);

Console.WriteLine(fisico.Describir());
Console.WriteLine(digital.Describir());