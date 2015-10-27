﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.Linq.SqlClient;
using System.Collections;

namespace WcfServiceQuanLyKhachSan
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceDichVu" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceDichVu.svc or ServiceDichVu.svc.cs at the Solution Explorer and start debugging.
    public class ServiceDichVu : IServiceDichVu
    {
        HotelDataContext htDataContext = new HotelDataContext();
        public int CountListdv()
        {
            var query = (from dv in htDataContext.dichvus select dv).Distinct().Count();
            return query;
        }
        //Lấy danh sách tất cả các dịch vụ 
        public IList<DichVuDTO> getListDichVuAll()
        {
            var query = (from dv in htDataContext.dichvus
                         orderby dv.madichvu descending
                         select new DichVuDTO
                         {
                             Madichvu = dv.madichvu,
                             Tendichvu = dv.tendichvu,
                             Donvitinh = dv.donvitinh,
                             Gia = (decimal)dv.gia,
                         }).Distinct<DichVuDTO>();

            return query.ToList<DichVuDTO>();
        }
        //Lấy danh sách tất cả các dịch vụ mỗi lần lấy 10 phần tử
        public IList<DichVuDTO> getListDichVuLMAll(int a)
        {
            var query = (from dv in htDataContext.dichvus
                         orderby dv.madichvu descending
                         select new DichVuDTO
                         {
                             Madichvu = dv.madichvu,
                             Tendichvu = dv.tendichvu,
                             Donvitinh = dv.donvitinh,
                             Gia = (decimal)dv.gia,
                         }).Distinct<DichVuDTO>();

            query = query.Skip(a).Take(ServiceLogin.limitList);
            return query.ToList<DichVuDTO>();
        }
        //Danh sách các dịch vụ có mã dịch vụ được nhập vào
        public DichVuDTO getDichVuByID(string id)
        {
            var querry = (from dv in htDataContext.dichvus
                          where dv.madichvu == id
                          select new DichVuDTO
                          {
                              Madichvu = dv.madichvu,
                              Tendichvu = dv.tendichvu,
                              Donvitinh = dv.donvitinh,
                              Gia = (decimal)dv.gia,
                          }).Distinct<DichVuDTO>();
            if (querry.Count() == 0)
            {
                return null;
            }
            else
            {
                return querry.Single<DichVuDTO>();
            }
        }
        //Lấy danh sách tất cả các dịch vụ có tên được nhập vào
        public IList<DichVuDTO> getListDichVuByName(string name)
        {
            var querry = (from dv in htDataContext.dichvus
                          where dv.tendichvu == name
                          select new DichVuDTO
                          {
                              Madichvu = dv.madichvu,
                              Tendichvu = dv.tendichvu,
                              Donvitinh = dv.donvitinh,
                              Gia = (decimal)dv.gia,
                          }).Distinct<DichVuDTO>();
            if (querry.Count() == 0)
            {
                return null;
            }
            else
            {
                return querry.ToList<DichVuDTO>();
            }
        }
        //Danh sách gần đúng các dịch vụ có mã dịch vụ được nhập vào
        public IList<DichVuDTO> getLikeDichVuByID(string id)
        {
            var querry = (from dv in htDataContext.dichvus
                          where SqlMethods.Like(dv.madichvu, "%" + id + "%")
                          select new DichVuDTO
                          {
                              Madichvu = dv.madichvu,
                              Tendichvu = dv.tendichvu,
                              Donvitinh = dv.donvitinh,
                              Gia = (decimal)dv.gia,
                          }).Distinct<DichVuDTO>();
            if (querry.Count() == 0)
            {
                return null;
            }
            else
            {
                return querry.ToList<DichVuDTO>();
            }
        }
        //Lấy danh sách gần đúng tất cả các dịch vụ có tên được nhập vào
        public IList<DichVuDTO> getListLikeDichVuByName(string name)
        {
            var querry = (from dv in htDataContext.dichvus
                          where SqlMethods.Like(dv.tendichvu, "%" + name + "%")
                          select new DichVuDTO
                          {
                              Madichvu = dv.madichvu,
                              Tendichvu = dv.tendichvu,
                              Donvitinh = dv.donvitinh,
                              Gia = (decimal)dv.gia,
                          }).Distinct<DichVuDTO>();
            if (querry.Count() == 0)
            {
                return null;
            }
            else
            {
                return querry.ToList<DichVuDTO>();
            }
        }
        //Thêm dịch vụ
        public int insertDichVu(DichVuDTO dvDTO)
        {
            try
            {
                dichvu dv = new dichvu();
                dv.madichvu = dvDTO.Madichvu;
                dv.tendichvu = dvDTO.Tendichvu;
                dv.donvitinh = dvDTO.Donvitinh;
                dv.gia = (decimal)dvDTO.Gia;
                htDataContext.dichvus.InsertOnSubmit(dv);
                htDataContext.SubmitChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        //Xóa dịch vụ
        public int deleteDichVu(string IDDV)
        {
            try
            {
                var querry = (from dv in htDataContext.dichvus
                              where dv.madichvu == IDDV
                              select dv).FirstOrDefault<dichvu>();
                htDataContext.dichvus.DeleteOnSubmit(querry);
                htDataContext.SubmitChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        //Sửa dịch vụ
        public int updateDichVu(DichVuDTO dvDTO)
        {
            try
            {
                var querry = (from dv in htDataContext.dichvus
                              where dv.madichvu == dvDTO.Madichvu
                              select dv).FirstOrDefault<dichvu>();
                querry.tendichvu = dvDTO.Tendichvu;
                querry.donvitinh = dvDTO.Donvitinh;
                querry.gia = (decimal)dvDTO.Gia;
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
