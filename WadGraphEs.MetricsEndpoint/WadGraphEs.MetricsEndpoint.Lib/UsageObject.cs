﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WadGraphEs.MetricsEndpoint.Lib {
    public class UsageObject {
        public string GraphiteCounterName { get; set; }
        public string Timestamp { get; set; }
        public double Value { get; set; }

       
    }
}
