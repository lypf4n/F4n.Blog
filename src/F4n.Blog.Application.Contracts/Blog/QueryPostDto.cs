﻿using System;
using System.Collections.Generic;
using System.Text;

namespace F4n.Blog.Application.Contracts.Blog
{
    public class QueryPostDto
    {
        /// <summary>
        /// 年份
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// Posts
        /// </summary>
        public IEnumerable<PostBriefDto> Posts { get; set; }
    }
}
