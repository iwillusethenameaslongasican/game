//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: code/unity/TankGame/Assets/proto/friend.proto
namespace code.unity.TankGame.Assets.proto.friend
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"c2s_friend_list_request")]
  public partial class c2s_friend_list_request : global::ProtoBuf.IExtensible
  {
    public c2s_friend_list_request() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"s2c_friend_list_reply")]
  public partial class s2c_friend_list_reply : global::ProtoBuf.IExtensible
  {
    public s2c_friend_list_reply() {}
    
    private uint _num;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint num
    {
      get { return _num; }
      set { _num = value; }
    }
    private readonly global::System.Collections.Generic.List<friend_info> _infos = new global::System.Collections.Generic.List<friend_info>();
    [global::ProtoBuf.ProtoMember(2, Name=@"infos", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<friend_info> infos
    {
      get { return _infos; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"c2s_add_friend_request")]
  public partial class c2s_add_friend_request : global::ProtoBuf.IExtensible
  {
    public c2s_add_friend_request() {}
    
    private uint _id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint id
    {
      get { return _id; }
      set { _id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"s2c_add_friend_reply")]
  public partial class s2c_add_friend_reply : global::ProtoBuf.IExtensible
  {
    public s2c_add_friend_reply() {}
    
    private int _result;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int result
    {
      get { return _result; }
      set { _result = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"c2s_del_friend_request")]
  public partial class c2s_del_friend_request : global::ProtoBuf.IExtensible
  {
    public c2s_del_friend_request() {}
    
    private uint _id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint id
    {
      get { return _id; }
      set { _id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"s2c_del_friend_reply")]
  public partial class s2c_del_friend_reply : global::ProtoBuf.IExtensible
  {
    public s2c_del_friend_reply() {}
    
    private int _result;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int result
    {
      get { return _result; }
      set { _result = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"c2s_friend_info_request")]
  public partial class c2s_friend_info_request : global::ProtoBuf.IExtensible
  {
    public c2s_friend_info_request() {}
    
    private uint _id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint id
    {
      get { return _id; }
      set { _id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"s2c_friend_info_reply")]
  public partial class s2c_friend_info_reply : global::ProtoBuf.IExtensible
  {
    public s2c_friend_info_reply() {}
    
    private friend_info _info;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public friend_info info
    {
      get { return _info; }
      set { _info = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"friend_info")]
  public partial class friend_info : global::ProtoBuf.IExtensible
  {
    public friend_info() {}
    
    private uint _id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint id
    {
      get { return _id; }
      set { _id = value; }
    }
    private string _username;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"username", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string username
    {
      get { return _username; }
      set { _username = value; }
    }
    private uint _image;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"image", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint image
    {
      get { return _image; }
      set { _image = value; }
    }
    private uint _status;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"status", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint status
    {
      get { return _status; }
      set { _status = value; }
    }
    private uint _win;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"win", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint win
    {
      get { return _win; }
      set { _win = value; }
    }
    private uint _fail;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"fail", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint fail
    {
      get { return _fail; }
      set { _fail = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}