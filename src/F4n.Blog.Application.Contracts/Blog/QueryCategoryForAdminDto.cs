﻿using System;
using System.Collections.Generic;
using System.Text;

namespace F4n.Blog.Application.Contracts.Blog
{
    public class QueryCategoryForAdminDto : QueryCategoryDto
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int Id { get; set; }
    }
}
