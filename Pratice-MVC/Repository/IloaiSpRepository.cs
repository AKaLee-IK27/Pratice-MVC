﻿using Practive_MVC.Models;
namespace Practive_MVC.Repository
{
    public interface IloaiSpRepository
    {
        TLoaiSp Add(TLoaiSp loaiSp);
        TLoaiSp Update(TLoaiSp loaiSp);
        TLoaiSp Delete(String maloaiSp);
        TLoaiSp GetLoaiSp(String maloaiSp);
        IEnumerable<TLoaiSp> GetAllLoaiSp();


    }
}
