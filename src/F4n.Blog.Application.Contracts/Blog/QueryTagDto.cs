﻿using System;
using System.Collections.Generic;
using System.Text;

namespace F4n.Blog.Application.Contracts.Blog
{
    public class QueryTagDto : TagDto
    {
        /// <summary>
        /// 总数
        /// </summary>
        public int Count { get; set; }
    }
}
