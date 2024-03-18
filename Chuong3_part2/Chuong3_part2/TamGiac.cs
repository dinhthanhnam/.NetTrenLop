using System;

public class TamGiac
{
    private double canhA; // Cạnh a
    private double canhB; // Cạnh b
    private double canhC; // Cạnh c

    public double CanhA
    {
        get { return canhA; }
        set { canhA = value; }
    }

    public double CanhB
    {
        get { return canhB; }
        set { canhB = value; }
    }

    public double CanhC
    {
        get { return canhC; }
        set { canhC = value; }
    }

    // Phương thức tạo không đối số
    public TamGiac()
    {
    }

    // Phương thức tạo với 3 tham số
    public TamGiac(double a, double b, double c)
    {
        CanhA = a;
        CanhB = b;
        CanhC = c;
    }

    // Phương thức nhập thông tin tam giác
    public virtual void Nhap()
    {
        Console.WriteLine("Nhap do dai 3 canh cua tam giac:");
        Console.Write("Canh a: ");
        CanhA = double.Parse(Console.ReadLine());
        Console.Write("Canh b: ");
        CanhB = double.Parse(Console.ReadLine());
        Console.Write("Canh c: ");
        CanhC = double.Parse(Console.ReadLine());
    }

    // Phương thức hiển thị thông tin tam giác
    public virtual void HienThi()
    {
        Console.WriteLine("Do dai 3 canh cua tam giac:");
        Console.WriteLine($"Canh a: {CanhA}");
        Console.WriteLine($"Canh b: {CanhB}");
        Console.WriteLine($"Canh c: {CanhC}");
    }

    // Phương thức tính diện tích tam giác
    public virtual double TinhDienTich()
    {
        double p = (CanhA + CanhB + CanhC) / 2;
        return Math.Sqrt(p * (p - CanhA) * (p - CanhB) * (p - CanhC));
    }
}

public class TuDien : TamGiac
{
    private double chieuCao; // Chiều cao của tam giác

    public double ChieuCao
    {
        get { return chieuCao; }
        set { chieuCao = value; }
    }

    public TuDien()
    {
    }
    // Phương thức tạo với 4 tham số (bao gồm cả 3 cạnh và chiều cao)
    public TuDien(double a, double b, double c, double h) : base(a, b, c)
    {
        ChieuCao = h;
    }

    // Ghi đè phương thức nhập thông tin tam giác tứ diện
    public override void Nhap()
    {
        base.Nhap(); // Gọi lại phương thức Nhap của lớp cha để nhập 3 cạnh
        Console.Write("Nhap chieu cao cua tu dien: ");
        ChieuCao = double.Parse(Console.ReadLine());
    }

    // Ghi đè phương thức hiển thị thông tin tam giác tứ diện
    public override void HienThi()
    {
        base.HienThi(); // Gọi lại phương thức HienThi của lớp cha để hiển thị 3 cạnh
        Console.WriteLine($"Chieu cao cua tu dien: {ChieuCao}");
    }

    // Phương thức tính thể tích tam giác tứ diện
    public double TinhTheTich()
    {
        return (1.0 / 3) * ChieuCao * base.TinhDienTich(); // Sử dụng diện tích đáy là diện tích tam giác
    }
}

class Program
{
    static void Main(string[] args)
    {
        TuDien tuDien = new TuDien(); // Khởi tạo một tam giác tứ diện với 3 cạnh và chiều cao
        tuDien.Nhap();
        tuDien.HienThi();
    }
}
