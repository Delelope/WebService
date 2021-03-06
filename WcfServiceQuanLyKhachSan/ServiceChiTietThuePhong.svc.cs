﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Collections;
using System.Data.Linq.SqlClient;

namespace WcfServiceQuanLyKhachSan
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceChiTietThuePhong" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceChiTietThuePhong.svc or ServiceChiTietThuePhong.svc.cs at the Solution Explorer and start debugging.
    public class ServiceChiTietThuePhong : IServiceChiTietThuePhong
    {
        HotelDataContext htDataContext = new HotelDataContext();
        public int CountListcttp()
        {
            var query = (from cttp in htDataContext.chitietthuephongs select cttp).Count();
            return query;
        }

        public IList<ChiTietThuePhongDTO> getListChiTietThuePhongAll()
        {
            var query = (from cttp in htDataContext.chitietthuephongs
                         orderby cttp.maphieuthue descending
                         select new ChiTietThuePhongDTO
                         {
                             Maphieuthue = cttp.maphieuthue,
                             Maphong = cttp.maphong,
                             Madichvu = cttp.madichvu,
                             Ngay = (DateTime)cttp.ngay,
                             Soluong = (int)cttp.soluong,
                         }).Distinct<ChiTietThuePhongDTO>();

            return query.ToList<ChiTietThuePhongDTO>();
        }

        public IList<ChiTietThuePhongDTO> getListChiTietThuePhongLMAll(int a)
        {
            var query = (from cttp in htDataContext.chitietthuephongs
                         orderby cttp.maphieuthue descending
                         select new ChiTietThuePhongDTO
                         {
                             Maphieuthue = cttp.maphieuthue,
                             Maphong = cttp.maphong,
                             Madichvu = cttp.madichvu,
                             Ngay = (DateTime)cttp.ngay,
                             Soluong = (int)cttp.soluong,
                         }).Distinct<ChiTietThuePhongDTO>();

            query = query.Skip(a).Take(ServiceLogin.limitList);
            return query.ToList<ChiTietThuePhongDTO>();
        }

        public IList<ChiTietThuePhongDTO> getChiTietThuePhongByID(string id)
        {
            var querry = (from cttp in htDataContext.chitietthuephongs
                          where cttp.maphieuthue == id
                          select new ChiTietThuePhongDTO
                          {
                              Maphieuthue = cttp.maphieuthue,
                              Maphong = cttp.maphong,
                              Madichvu = cttp.madichvu,
                              Ngay = (DateTime)cttp.ngay,
                              Soluong = (int)cttp.soluong,
                          }).Distinct<ChiTietThuePhongDTO>();
            return querry.ToList<ChiTietThuePhongDTO>();
        }

        public IList<ChiTietThuePhongDTO> getListChiTietThuePhongByName(string name)
        {
            var querry = (from cttp in htDataContext.chitietthuephongs
                          where cttp.maphong == name
                          select new ChiTietThuePhongDTO
                          {
                              Maphieuthue = cttp.maphieuthue,
                              Maphong = cttp.maphong,
                              Madichvu = cttp.madichvu,
                              Ngay = (DateTime)cttp.ngay,
                              Soluong = (int)cttp.soluong,
                          }).Distinct<ChiTietThuePhongDTO>();
            if (querry.Count() == 0)
            {
                return null;
            }
            else
            {
                return querry.ToList<ChiTietThuePhongDTO>();
            }
        }

        public IList<ChiTietThuePhongDTO> getLikeChiTietThuePhongByID(string id)
        {
            var querry = (from cttp in htDataContext.chitietthuephongs
                          where SqlMethods.Like(cttp.maphieuthue, "%" + id + "%")
                          select new ChiTietThuePhongDTO
                          {
                              Maphieuthue = cttp.maphieuthue,
                              Maphong = cttp.maphong,
                              Madichvu = cttp.madichvu,
                              Ngay = (DateTime)cttp.ngay,
                              Soluong = (int)cttp.soluong,
                          }).Distinct<ChiTietThuePhongDTO>();
            if (querry.Count() == 0)
            {
                return null;
            }
            else
            {
                return querry.ToList<ChiTietThuePhongDTO>();
            }
        }

        public IList<ChiTietThuePhongDTO> getListLikeChiTietThuePhongByName(string name)
        {
            var querry = (from cttp in htDataContext.chitietthuephongs
                          where SqlMethods.Like(cttp.maphong, "%" + name + "%")
                          select new ChiTietThuePhongDTO
                          {
                              Maphieuthue = cttp.maphieuthue,
                              Maphong = cttp.maphong,
                              Madichvu = cttp.madichvu,
                              Ngay = (DateTime)cttp.ngay,
                              Soluong = (int)cttp.soluong,
                          }).Distinct<ChiTietThuePhongDTO>();
            if (querry.Count() == 0)
            {
                return null;
            }
            else
            {
                return querry.ToList<ChiTietThuePhongDTO>();
            }
        }

        public int insertChiTietThuePhong(ChiTietThuePhongDTO cttpDTO)
        {
            try
            {
                chitietthuephong cttp = new chitietthuephong();
                cttp.maphieuthue = cttpDTO.Maphieuthue;
                cttp.maphong = cttpDTO.Maphong;
                cttp.ngay = (DateTime)cttpDTO.Ngay;
                cttp.madichvu = cttpDTO.Madichvu;
                cttp.soluong = (int)cttpDTO.Soluong;
                htDataContext.chitietthuephongs.InsertOnSubmit(cttp);
                htDataContext.SubmitChanges();
                return 1;
            }
            catch
            {

                return 0;
            }
        }

        public int deleteChiTietThuePhong(string IDChiTietThuePhong, string maphong, DateTime ngay, string madichvu)
        {
            try
            {
                var querry = (from cttp in htDataContext.chitietthuephongs
                              where cttp.maphieuthue == IDChiTietThuePhong && cttp.maphong == maphong &&
                              cttp.ngay == ngay && cttp.madichvu == madichvu
                              select cttp).FirstOrDefault<chitietthuephong>();
                htDataContext.chitietthuephongs.DeleteOnSubmit(querry);
                htDataContext.SubmitChanges();
                return 1;
            }
            catch
            {

                return 0;
            }
        }

        public int updateChiTietThuePhong(ChiTietThuePhongDTO cttpDTO)
        {
            try
            {
                var querry = (from cttp in htDataContext.chitietthuephongs
                              where cttp.maphieuthue == cttpDTO.Maphieuthue && cttp.maphong == cttpDTO.Maphong &&
                              cttp.ngay == cttpDTO.Ngay && cttp.madichvu == cttpDTO.Madichvu
                              select cttp).FirstOrDefault<chitietthuephong>();
                querry.soluong = cttpDTO.Soluong;
                htDataContext.SubmitChanges();
                return 1;
            }
            catch
            {

                return 0;
            }
        }
    }
}
