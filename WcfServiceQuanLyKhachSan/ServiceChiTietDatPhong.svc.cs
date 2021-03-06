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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceChiTietDatPhong" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceChiTietDatPhong.svc or ServiceChiTietDatPhong.svc.cs at the Solution Explorer and start debugging.
    public class ServiceChiTietDatPhong : IServiceChiTietDatPhong
    {
        HotelDataContext htDataContext = new HotelDataContext();
        public int CountListctdp()
        {
            var query = (from ctdp in htDataContext.chitietdatphongs select ctdp).Count();
            return query;
        }

        public IList<ChiTietDatPhongDTO> getListChiTietDatPhongAll()
        {
            var query = (from ctdp in htDataContext.chitietdatphongs
                         orderby ctdp.maphieudat descending

                         select new ChiTietDatPhongDTO
                         {
                             Maphieudat = ctdp.maphieudat,
                             Maphong = ctdp.maphong,
                         }).Distinct<ChiTietDatPhongDTO>();
            return query.ToList<ChiTietDatPhongDTO>();
        }

        public IList<ChiTietDatPhongDTO> getListChiTietDatPhongLMAll(int a)
        {
            var query = (from ctdp in htDataContext.chitietdatphongs
                         orderby ctdp.maphieudat descending

                         select new ChiTietDatPhongDTO
                         {
                             Maphieudat = ctdp.maphieudat,
                             Maphong = ctdp.maphong,
                         }).Distinct<ChiTietDatPhongDTO>();

            query = query.Skip(a).Take(ServiceLogin.limitList);
            return query.ToList<ChiTietDatPhongDTO>();
        }

        public IList<ChiTietDatPhongDTO> getChiTietDatPhongByID(string id)
        {
            var querry = (from ctdp in htDataContext.chitietdatphongs
                          where ctdp.maphieudat == id
                          select new ChiTietDatPhongDTO
                          {
                              Maphieudat = ctdp.maphieudat,
                              Maphong = ctdp.maphong,
                          }).Distinct<ChiTietDatPhongDTO>();
            return querry.ToList<ChiTietDatPhongDTO>();
        }

        public IList<ChiTietDatPhongDTO> getListChiTietDatPhongByName(string name)
        {
            var querry = (from ctdp in htDataContext.chitietdatphongs
                          where ctdp.maphong == name
                          select new ChiTietDatPhongDTO
                          {
                              Maphieudat = ctdp.maphieudat,
                              Maphong = ctdp.maphong,
                          }).Distinct<ChiTietDatPhongDTO>();
            if (querry.Count() == 0)
            {
                return null;
            }
            else
            {
                return querry.ToList<ChiTietDatPhongDTO>();
            }
        }

        public IList<ChiTietDatPhongDTO> getLikeChiTietDatPhongByID(string id)
        {
            var querry = (from ctdp in htDataContext.chitietdatphongs
                          where SqlMethods.Like(ctdp.maphieudat, "%" + id + "%")
                          select new ChiTietDatPhongDTO
                          {
                              Maphieudat = ctdp.maphieudat,
                              Maphong = ctdp.maphong,
                          }).Distinct<ChiTietDatPhongDTO>();
            if (querry.Count() == 0)
            {
                return null;
            }
            else
            {
                return querry.ToList<ChiTietDatPhongDTO>();
            }
        }

        public IList<ChiTietDatPhongDTO> getListLikeChiTietDatPhongByName(string name)
        {
            var querry = (from ctdp in htDataContext.chitietdatphongs
                          where SqlMethods.Like(ctdp.maphong, "%" + name + "%")
                          select new ChiTietDatPhongDTO
                          {
                              Maphieudat = ctdp.maphieudat,
                              Maphong = ctdp.maphong,
                          }).Distinct<ChiTietDatPhongDTO>();
            if (querry.Count() == 0)
            {
                return null;
            }
            else
            {
                return querry.ToList<ChiTietDatPhongDTO>();
            }
        }

        public int insertChiTietDatPhong(ChiTietDatPhongDTO ctdpDTO)
        {
            try
            {
                chitietdatphong ctdp = new chitietdatphong();
                ctdp.maphieudat = ctdpDTO.Maphieudat;
                ctdp.maphong = ctdpDTO.Maphong;
                htDataContext.chitietdatphongs.InsertOnSubmit(ctdp);
                htDataContext.SubmitChanges();
                return 1;
            }
            catch
            {

                return 0;
            }
        }

        public int deleteChiTietDatPhong(string IDChiTietDatPhong)
        {
            try
            {
                IEnumerable<chitietdatphong> querry = from ctdp in htDataContext.chitietdatphongs
                                                      where ctdp.maphieudat == IDChiTietDatPhong
                                                      select ctdp;
                foreach (chitietdatphong ct in querry)
                {
                    htDataContext.chitietdatphongs.DeleteOnSubmit(ct);
                }
                htDataContext.SubmitChanges();
                return 1;
            }
            catch
            {

                return 0;
            }
        }

        public int updateChiTietDatPhong(ChiTietDatPhongDTO ctdpDTO)
        {
            try
            {
                var querry = (from ctdp in htDataContext.chitietdatphongs
                              where ctdp.maphieudat == ctdpDTO.Maphieudat
                              select ctdp).FirstOrDefault<chitietdatphong>();
                querry.maphieudat = ctdpDTO.Maphieudat;
                querry.maphong = ctdpDTO.Maphong;
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
