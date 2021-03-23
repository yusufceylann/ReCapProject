using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba Eklendi";
        public static string CarDeleted = "Araba silindi";
        public static string CarUpdated = "Araba başarıyla güncellendi.";
        public static string CarAddedInvalid = "Araba fiyatı 0'dan büyük ve araba açıklaması 2 karakterden fazla olmalıdır"; 
        public static string CarsListed = "Arabalar Listelendi";

        public static string BrandAdded = "Araba Markası Eklendi";
        public static string BrandDeleted = "Araba Markası Silindi";
        public static string BrandUpdated = "Araba Markası Güncellendi";
        public static string BrandAddedInvalid = "Marka İsminin Uzunluğunu 2 Karakterden Fazla Olmalı!";
        public static string BrandListed = "Araba Markaları Listelendi";

        public static string ColorAdded = "Renk Eklendi";
        public static string ColorDeleted = "Renk Silindi";
        public static string ColorUpdated = "Renk  Güncellendi";
        public static string ColorListed = "Araba Renklerı Listelendi";

        public static string CustomerAdded = "Müşteri Eklendi";
        public static string CustomerDeleted = "Müşteri Silindi";
        public static string CustomersListed = "Müşteriler Listelendi";
        public static string CustomerListed = "Müşteri Listelendi";
        public static string CustomerUpdated = "Müşteri Güncellendi";

        public static string UserAdded = "Kullanıcı Eklendi";
        public static string UserDeleted = "Kullanıcı Silindi";
        public static string UsersListed = "Kullanıcılar Listelendi";
        public static string UserUpdated = "Kullanıcı Güncellendi";

        public static string FailedRentalAdd = "Araba henüz teslim edilmediği için kiralayamazsınız";
        public static string RentalAdded = "Kiralama İşlemi Eklendi";
        public static string RentalDeleted = "Araç Kiralama İşlemi İptal Edildi;";
        public static string RentalUpdated = "Araç Kiralama İşlemi Güncellendi";
        public static string RentalsListed = "Araç Kiralama Bilgileri Listelendi";
        public static string RentalListed = "Kiralanan Araçlar Listelendi";
        public static string ReturnedRental = "Kiralanan Araç Teslim Edildi";

        public static string MaintenanceTime = "Sistem Bakımda";
    }
}
