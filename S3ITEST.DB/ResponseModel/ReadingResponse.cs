﻿using System;
using System.Collections.Generic;
using System.Text;

namespace S3ITEST.DB.ResponseModel
{
    public class ReadingResponse
    {
        public string BuildingName { get; set; }
        public string ObjectName { get; set; }
        public string DataFieldName { get; set; }
        public List<Int64> Timestamp { get; set; }
        public List<decimal> Value { get; set; }
    }
}
