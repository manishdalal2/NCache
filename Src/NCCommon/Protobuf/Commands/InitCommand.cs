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

// Generated from: InitCommand.proto
// Note: requires additional types generated from: ProductVersion.proto
// Note: requires additional types generated from: ClientInfo.proto
namespace Alachisoft.NCache.Common.Protobuf
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"InitCommand")]
  public partial class InitCommand : global::ProtoBuf.IExtensible
  {
    public InitCommand() {}
    

    private string _cacheId = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"cacheId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string cacheId
    {
      get { return _cacheId; }
      set { _cacheId = value; }
    }

    private long _requestId = default(long);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"requestId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long requestId
    {
      get { return _requestId; }
      set { _requestId = value; }
    }

    private string _clientId = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"clientId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string clientId
    {
      get { return _clientId; }
      set { _clientId = value; }
    }

    private string _licenceCode = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"licenceCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string licenceCode
    {
      get { return _licenceCode; }
      set { _licenceCode = value; }
    }

    private string _licenceInfo = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"licenceInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string licenceInfo
    {
      get { return _licenceInfo; }
      set { _licenceInfo = value; }
    }

    private bool _isDotnetClient = default(bool);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"isDotnetClient", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool isDotnetClient
    {
      get { return _isDotnetClient; }
      set { _isDotnetClient = value; }
    }

    private string _clientEditionId = "";
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"clientEditionId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string clientEditionId
    {
      get { return _clientEditionId; }
      set { _clientEditionId = value; }
    }

    private int _clientVersion = default(int);
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"clientVersion", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int clientVersion
    {
      get { return _clientVersion; }
      set { _clientVersion = value; }
    }

    private string _clientIP = "";
    [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"clientIP", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string clientIP
    {
      get { return _clientIP; }
      set { _clientIP = value; }
    }

    private bool _isAzureClient = default(bool);
    [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"isAzureClient", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool isAzureClient
    {
      get { return _isAzureClient; }
      set { _isAzureClient = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.ProductVersion _productVersion = null;
    [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"productVersion", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.ProductVersion productVersion
    {
      get { return _productVersion; }
      set { _productVersion = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.ClientInfo _clientInfo = null;
    [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"clientInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.ClientInfo clientInfo
    {
      get { return _clientInfo; }
      set { _clientInfo = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}