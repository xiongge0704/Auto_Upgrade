﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Upgrade.Models
{ 
    // 下拉框的选项
    class UpdateMethodList : List<string>
    {
        public UpdateMethodList()
        {
            this.Add("新增");
            this.Add("替换");
            this.Add("删除");
        }
    }
}
