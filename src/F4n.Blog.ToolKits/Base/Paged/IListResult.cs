﻿using System;
using System.Collections.Generic;
using System.Text;

namespace F4n.Blog.ToolKits.Base.Paged
{
    public interface IListResult<T>
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        IReadOnlyList<T> Item { get; set; }
    }
}
