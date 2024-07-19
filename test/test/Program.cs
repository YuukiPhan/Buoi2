using System;

namespace TinhTongGiaTriDonHang
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Nhập số lượng sản phẩm
                Console.Write("nhap so luong san pham: ");
                int soLuong = int.Parse(Console.ReadLine());

                // Kiểm tra số lượng sản phẩm phải lớn hơn 3
                if (soLuong <= 3)
                {
                    throw new Exception("so luong san pham phai lon hon 3.");
                }

                // Nhập giá mỗi sản phẩm
                Console.Write("nhap gia san pham: ");
                double giaMoiSanPham = double.Parse(Console.ReadLine());

                // Kiểm tra giá mỗi sản phẩm phải lớn hơn 2000
                if (giaMoiSanPham <= 2000)
                {
                    throw new Exception("gia san pham phai lon hon 2000.");
                }

                // Tính tổng giá trị đơn hàng
                double tongGiaTri = soLuong * giaMoiSanPham;

                // Hiển thị kết quả
                Console.WriteLine("tong gia tri la : " + tongGiaTri);
            }
            catch (Exception ex)
            {
                Console.WriteLine("loi: " + ex.Message);
            }
        }
    }
}
