// Copyright (c) 2018 Alachisoft
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//    http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using Alachisoft.NCache.Runtime;
using Alachisoft.NCache.Runtime.Serialization;
using Alachisoft.NCache.Runtime.Serialization.IO;

namespace Alachisoft.NCache.Caching.EvictionPolicies
{
    /// <summary>
    /// Implements the eviction hint for Priority based eviction strategy.
    /// </summary>
    [Serializable]
    public class PriorityEvictionHint : EvictionHint, ICompactSerializable
    {

        new internal static int InMemorySize = 24;

        static PriorityEvictionHint() 
        {
            InMemorySize = Common.MemoryUtil.GetInMemoryInstanceSize(EvictionHint.InMemorySize + Common.MemoryUtil.NetEnumSize);
        }

        /// <summary>The actual priority value contained within this object.</summary>
        private CacheItemPriority		_priority;

        /// <summary>Get and set the priority</summary>
        public CacheItemPriority Priority
        {
            get { return _priority; }
            set { _priority = value; }
        }


        /// <summary>
        /// Constructor.
        /// </summary>
        public PriorityEvictionHint()
        {
            _hintType = EvictionHintType.PriorityEvictionHint;
            _priority  = CacheItemPriority.Normal;
        }


        /// <summary>
        /// Overloaded Constructor
        /// Based on Priority Value
        /// </summary>
        /// <param name="priority"></param>
        public PriorityEvictionHint(CacheItemPriority priority)
        {
            _hintType = EvictionHintType.PriorityEvictionHint;
            _priority = priority;
        }


        /// <summary>
        /// Return if hint is to be changed on Update
        /// </summary>
        public override bool IsVariant
        {
            get { return false; }
        }


        /// <summary>
        /// Update hint if required
        /// </summary>
        /// <returns></returns>
        public override bool Update() 
        {
            return false;
        }

        #region	/                 --- ICompactSerializable ---           /

        void ICompactSerializable.Deserialize(CompactReader reader)
        {
            base.Deserialize(reader);
            _priority = (CacheItemPriority)Enum.ToObject(typeof(CacheItemPriority), reader.ReadInt16());
        }

        void ICompactSerializable.Serialize(CompactWriter writer)
        {
            base.Serialize(writer);
            writer.Write(Convert.ToInt16(_priority));
        }

        #endregion       
    }
}