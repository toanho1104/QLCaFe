﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafeApp.Models
{
    public class Ban
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TrangThai { get; set; }
        public Ban() { }

        public Ban(int _id, string _name, string _trangthai)
        {
            Id = _id;
            Name = _name;
            TrangThai = _trangthai;
        }
    }
}
