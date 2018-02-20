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
// limitations under the License

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: EventId.proto
// Note: requires additional types generated from: EventCacheItem.proto
namespace Alachisoft.NCache.Common.Protobuf
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"EventId")]
  public partial class EventId : global::ProtoBuf.IExtensible
  {
    public EventId() {}
    

    private string _eventUniqueId = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"eventUniqueId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string eventUniqueId
    {
      get { return _eventUniqueId; }
      set { _eventUniqueId = value; }
    }

    private long _operationCounter = default(long);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"operationCounter", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long operationCounter
    {
      get { return _operationCounter; }
      set { _operationCounter = value; }
    }

    private int _eventCounter = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"eventCounter", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int eventCounter
    {
      get { return _eventCounter; }
      set { _eventCounter = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.EventCacheItem _item = null;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"item", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.EventCacheItem item
    {
      get { return _item; }
      set { _item = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.EventCacheItem _oldItem = null;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"oldItem", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.EventCacheItem oldItem
    {
      get { return _oldItem; }
      set { _oldItem = value; }
    }

    private int _removeReason = default(int);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"removeReason", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int removeReason
    {
      get { return _removeReason; }
      set { _removeReason = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}