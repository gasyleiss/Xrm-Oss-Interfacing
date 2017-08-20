﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xrm.Oss.Interfacing.Domain
{
    public interface IMessage
    {
		IScenario Scenario { get; set; }
		Guid? RecordId { get; set; }
		DateTime TimeStamp { get; set; }
		string CorrelationId { get; set; }
    }
}