using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    internal class MuonTra
    {
        private string maMuon;
        private string maThe;
        private string maSach;
        private string soLuong;
        private string ngayMuon;
        private string ngayTra; 
       

        public string MaMuon { get => maMuon; set => maMuon = value; }
        public string MaThe { get => maThe; set => maThe = value; }
        public string MaSach { get => maSach; set => maSach = value; }
        public string SoLuong { get => soLuong; set => soLuong = value; }
        public string NgayMuon { get => ngayMuon; set => ngayMuon = value; }
        public string NgayTra { get => ngayTra; set => ngayTra = value; }

        public MuonTra(string maMuon, string maThe, string tenSach, string soLuong, string ngayMuon, string ngayTra)
        {
            this.maMuon = maMuon;
            this.maThe = maThe;
            this.maSach = tenSach;
            this.soLuong = soLuong;
            this.ngayMuon = ngayMuon;
            this.ngayTra = ngayTra;
        }
       

    }
}
