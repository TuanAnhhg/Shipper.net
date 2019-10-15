using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace BooksShopOnline.Models
{
    public class hangDatabaseInitializer : DropCreateDatabaseAlways<Context>
    {
        protected override void Seed(Context context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetBooks().ForEach(p => context.Books.Add(p));
        }
        private static List<Category> GetCategories()
        {
            var categories = new List<Category>
            {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "cần câu"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Máy câu"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Mồi câu cá"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "các phụ kiện khác"
                }
            };
            return categories;
        }
        private static List<hang> GetBooks()
        {
            var books = new List<hang> {
                new hang
                {
                    BookID = 1,
                    BookName = "CẦN MÁY XẾP CÂU LỤC DAIWA LIBERTY T30 4M2 - 4M5",
                    Description = "Độ dài:  4m2 , 4m5.",
                    ImagePath ="can-may-xep-liberty-club-surf-4m2-fimax-6.jpg",
                    UnitPrice =520,
                    CategoryID = 1
                    },
                new hang
                {
                    BookID = 2,
                    BookName = "MÁY NGANG ABU GARCIA REVO IKE CÂU LURE CAO CẤP BẠO LỰC - CÂU BIỂN PHIÊN BẢN GIỚI HẠN - MADE IN KOREA",
                    Description = "Revo4 IKE-LTay : tay trái",
                    ImagePath ="may-ngang-abu-revo-ike-fimax-16_1.jpg",
                    UnitPrice = 214,
                    CategoryID = 2
                },
                new hang
                {
                    BookID = 3,
                    BookName = "MỒI NHÁI GỖ CÂU CÁ LÓC - MỒI CÂU CÁ",
                    Description = "Chất liệu: Gỗ",
                    ImagePath ="074b5df067fe82a0dbef.jpg",
                    UnitPrice = 26.73f,
                    CategoryID = 2
                },
                new hang
                {
                    BookID = 4,
                    BookName = "LƯỠI CÂU CÁ ZD WORM317",
                    Description = "Chất Liệu: Kim Loại",
                    ImagePath ="luoi-zd-fimax-fm483.jpg",
                    UnitPrice = 23.79f,
                    CategoryID = 3
                },
                new hang
                {
                    BookID = 5,
                    BookName = "TÚI ĐỰNG PHỤ KIỆN ĐI CÂU CỠ LỚN NHIỀU MÀU",
                    Description = " Kích thước: 20x10x28",
                    ImagePath ="a1668cdbab064e581717.jpg",
                    UnitPrice = 16.04f,
                    CategoryID = 4
                },


            };
            return books;
        }
    }
}