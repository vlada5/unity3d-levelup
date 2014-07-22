/// Copyright (C) 2012-2014 Soomla Inc.
///
/// Licensed under the Apache License, Version 2.0 (the "License");
/// you may not use this file except in compliance with the License.
/// You may obtain a copy of the License at
///
///      http://www.apache.org/licenses/LICENSE-2.0
///
/// Unless required by applicable law or agreed to in writing, software
/// distributed under the License is distributed on an "AS IS" BASIS,
/// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
/// See the License for the specific language governing permissions and
/// limitations under the License.using System;

using System;
using System.Collections.Generic;

using Soomla.Store;

namespace Soomla.Levelup
{
	public class BalanceMission : Mission
	{

		public BalanceMission(string id, string name, string associatedItemId, int desiredBalance)
			: base(id, name, typeof(BalanceGate), new object[] { associatedItemId, desiredBalance })
		{
		}
		
		public BalanceMission(string id, string name, List<Reward> rewards, string associatedItemId, int desiredBalance)
			: base(id, name, rewards, typeof(BalanceGate), new object[] { associatedItemId, desiredBalance })
		{
		}
		
		public BalanceMission(JSONObject jsonMission)
			: base(jsonMission)
		{
		}

	}
}

