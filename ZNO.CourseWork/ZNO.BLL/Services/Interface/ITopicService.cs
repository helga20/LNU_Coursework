﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZNO.DAL.Models;

namespace ZNO.BLL.Services.Interface
{
    public interface ITopicService
    {
        IEnumerable<TopicDto> GetAllTopics();
    }
}
