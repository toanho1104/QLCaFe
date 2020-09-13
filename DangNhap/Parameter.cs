﻿using System.Data;

namespace QuanLyQuanCafeApp.Models
{
    public class Parameter
    {
        public string Name { get; set; }
        public object Value { get; set; }
        public DbType DbType { get; set; }
        public ParameterDirection Direction { get; set; }
    }
}
