//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: code/unity/TankGame/Assets/proto/room.proto
namespace code.unity.TankGame.Assets.proto.room
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"c2s_get_achieve_request")]
  public partial class c2s_get_achieve_request : global::ProtoBuf.IExtensible
  {
    public c2s_get_achieve_request() {}
    
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
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"s2c_get_achieve_reply")]
  public partial class s2c_get_achieve_reply : global::ProtoBuf.IExtensible
  {
    public s2c_get_achieve_reply() {}
    
    private uint _id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint id
    {
      get { return _id; }
      set { _id = value; }
    }
    private uint _win;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"win", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint win
    {
      get { return _win; }
      set { _win = value; }
    }
    private uint _fail;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"fail", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint fail
    {
      get { return _fail; }
      set { _fail = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"c2s_get_room_list_request")]
  public partial class c2s_get_room_list_request : global::ProtoBuf.IExtensible
  {
    public c2s_get_room_list_request() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"s2c_get_room_list_reply")]
  public partial class s2c_get_room_list_reply : global::ProtoBuf.IExtensible
  {
    public s2c_get_room_list_reply() {}
    
    private uint _num;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint num
    {
      get { return _num; }
      set { _num = value; }
    }
    private readonly global::System.Collections.Generic.List<room_info> _rooms = new global::System.Collections.Generic.List<room_info>();
    [global::ProtoBuf.ProtoMember(2, Name=@"rooms", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<room_info> rooms
    {
      get { return _rooms; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"c2s_create_room_request")]
  public partial class c2s_create_room_request : global::ProtoBuf.IExtensible
  {
    public c2s_create_room_request() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"s2c_create_room_reply")]
  public partial class s2c_create_room_reply : global::ProtoBuf.IExtensible
  {
    public s2c_create_room_reply() {}
    
    private int _ret;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ret", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ret
    {
      get { return _ret; }
      set { _ret = value; }
    }
    private uint _room_id;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"room_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint room_id
    {
      get { return _room_id; }
      set { _room_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"c2s_enter_room_request")]
  public partial class c2s_enter_room_request : global::ProtoBuf.IExtensible
  {
    public c2s_enter_room_request() {}
    
    private int _room_id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"room_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int room_id
    {
      get { return _room_id; }
      set { _room_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"s2c_enter_room_reply")]
  public partial class s2c_enter_room_reply : global::ProtoBuf.IExtensible
  {
    public s2c_enter_room_reply() {}
    
    private int _ret;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ret", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ret
    {
      get { return _ret; }
      set { _ret = value; }
    }
    private uint _room_id;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"room_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint room_id
    {
      get { return _room_id; }
      set { _room_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"c2s_get_room_info_request")]
  public partial class c2s_get_room_info_request : global::ProtoBuf.IExtensible
  {
    public c2s_get_room_info_request() {}
    
    private uint _room_id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"room_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint room_id
    {
      get { return _room_id; }
      set { _room_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"s2c_get_room_info_reply")]
  public partial class s2c_get_room_info_reply : global::ProtoBuf.IExtensible
  {
    public s2c_get_room_info_reply() {}
    
    private uint _num;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint num
    {
      get { return _num; }
      set { _num = value; }
    }
    private readonly global::System.Collections.Generic.List<role_info> _roles = new global::System.Collections.Generic.List<role_info>();
    [global::ProtoBuf.ProtoMember(2, Name=@"roles", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<role_info> roles
    {
      get { return _roles; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"c2s_leave_room_request")]
  public partial class c2s_leave_room_request : global::ProtoBuf.IExtensible
  {
    public c2s_leave_room_request() {}
    
    private uint _room_id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"room_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint room_id
    {
      get { return _room_id; }
      set { _room_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"s2c_leave_room_reply")]
  public partial class s2c_leave_room_reply : global::ProtoBuf.IExtensible
  {
    public s2c_leave_room_reply() {}
    
    private int _ret;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ret", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ret
    {
      get { return _ret; }
      set { _ret = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"room_info")]
  public partial class room_info : global::ProtoBuf.IExtensible
  {
    public room_info() {}
    
    private uint _room_id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"room_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint room_id
    {
      get { return _room_id; }
      set { _room_id = value; }
    }
    private uint _num;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint num
    {
      get { return _num; }
      set { _num = value; }
    }
    private int _status;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"status", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int status
    {
      get { return _status; }
      set { _status = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"role_info")]
  public partial class role_info : global::ProtoBuf.IExtensible
  {
    public role_info() {}
    
    private uint _id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint id
    {
      get { return _id; }
      set { _id = value; }
    }
    private int _team;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"team", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int team
    {
      get { return _team; }
      set { _team = value; }
    }
    private uint _win;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"win", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint win
    {
      get { return _win; }
      set { _win = value; }
    }
    private uint _fail;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"fail", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint fail
    {
      get { return _fail; }
      set { _fail = value; }
    }
    private int _is_owner;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"is_owner", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int is_owner
    {
      get { return _is_owner; }
      set { _is_owner = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}