// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SpringRecoverSingleAvatarCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from SpringRecoverSingleAvatarCsReq.proto</summary>
  public static partial class SpringRecoverSingleAvatarCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for SpringRecoverSingleAvatarCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SpringRecoverSingleAvatarCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRTcHJpbmdSZWNvdmVyU2luZ2xlQXZhdGFyQ3NSZXEucHJvdG8aEEF2YXRh",
            "clR5cGUucHJvdG8ioAEKHlNwcmluZ1JlY292ZXJTaW5nbGVBdmF0YXJDc1Jl",
            "cRIQCghwbGFuZV9pZBgFIAEoDRIWCg5wcm9wX2VudGl0eV9pZBgIIAEoDRIU",
            "CgxyZWNvdmVyX2Z1bGwYDiABKAgSIAoLYXZhdGFyX3R5cGUYDCABKA4yCy5B",
            "dmF0YXJUeXBlEhAKCGZsb29yX2lkGAIgASgNEgoKAmlkGAMgASgNQh6qAhtF",
            "Z2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.AvatarTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.SpringRecoverSingleAvatarCsReq), global::EggLink.DanhengServer.Proto.SpringRecoverSingleAvatarCsReq.Parser, new[]{ "PlaneId", "PropEntityId", "RecoverFull", "AvatarType", "FloorId", "Id" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SpringRecoverSingleAvatarCsReq : pb::IMessage<SpringRecoverSingleAvatarCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SpringRecoverSingleAvatarCsReq> _parser = new pb::MessageParser<SpringRecoverSingleAvatarCsReq>(() => new SpringRecoverSingleAvatarCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SpringRecoverSingleAvatarCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.SpringRecoverSingleAvatarCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SpringRecoverSingleAvatarCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SpringRecoverSingleAvatarCsReq(SpringRecoverSingleAvatarCsReq other) : this() {
      planeId_ = other.planeId_;
      propEntityId_ = other.propEntityId_;
      recoverFull_ = other.recoverFull_;
      avatarType_ = other.avatarType_;
      floorId_ = other.floorId_;
      id_ = other.id_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SpringRecoverSingleAvatarCsReq Clone() {
      return new SpringRecoverSingleAvatarCsReq(this);
    }

    /// <summary>Field number for the "plane_id" field.</summary>
    public const int PlaneIdFieldNumber = 5;
    private uint planeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PlaneId {
      get { return planeId_; }
      set {
        planeId_ = value;
      }
    }

    /// <summary>Field number for the "prop_entity_id" field.</summary>
    public const int PropEntityIdFieldNumber = 8;
    private uint propEntityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PropEntityId {
      get { return propEntityId_; }
      set {
        propEntityId_ = value;
      }
    }

    /// <summary>Field number for the "recover_full" field.</summary>
    public const int RecoverFullFieldNumber = 14;
    private bool recoverFull_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool RecoverFull {
      get { return recoverFull_; }
      set {
        recoverFull_ = value;
      }
    }

    /// <summary>Field number for the "avatar_type" field.</summary>
    public const int AvatarTypeFieldNumber = 12;
    private global::EggLink.DanhengServer.Proto.AvatarType avatarType_ = global::EggLink.DanhengServer.Proto.AvatarType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.AvatarType AvatarType {
      get { return avatarType_; }
      set {
        avatarType_ = value;
      }
    }

    /// <summary>Field number for the "floor_id" field.</summary>
    public const int FloorIdFieldNumber = 2;
    private uint floorId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FloorId {
      get { return floorId_; }
      set {
        floorId_ = value;
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 3;
    private uint id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SpringRecoverSingleAvatarCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SpringRecoverSingleAvatarCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PlaneId != other.PlaneId) return false;
      if (PropEntityId != other.PropEntityId) return false;
      if (RecoverFull != other.RecoverFull) return false;
      if (AvatarType != other.AvatarType) return false;
      if (FloorId != other.FloorId) return false;
      if (Id != other.Id) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (PlaneId != 0) hash ^= PlaneId.GetHashCode();
      if (PropEntityId != 0) hash ^= PropEntityId.GetHashCode();
      if (RecoverFull != false) hash ^= RecoverFull.GetHashCode();
      if (AvatarType != global::EggLink.DanhengServer.Proto.AvatarType.None) hash ^= AvatarType.GetHashCode();
      if (FloorId != 0) hash ^= FloorId.GetHashCode();
      if (Id != 0) hash ^= Id.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (FloorId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(FloorId);
      }
      if (Id != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Id);
      }
      if (PlaneId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(PlaneId);
      }
      if (PropEntityId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(PropEntityId);
      }
      if (AvatarType != global::EggLink.DanhengServer.Proto.AvatarType.None) {
        output.WriteRawTag(96);
        output.WriteEnum((int) AvatarType);
      }
      if (RecoverFull != false) {
        output.WriteRawTag(112);
        output.WriteBool(RecoverFull);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (FloorId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(FloorId);
      }
      if (Id != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Id);
      }
      if (PlaneId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(PlaneId);
      }
      if (PropEntityId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(PropEntityId);
      }
      if (AvatarType != global::EggLink.DanhengServer.Proto.AvatarType.None) {
        output.WriteRawTag(96);
        output.WriteEnum((int) AvatarType);
      }
      if (RecoverFull != false) {
        output.WriteRawTag(112);
        output.WriteBool(RecoverFull);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (PlaneId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PlaneId);
      }
      if (PropEntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PropEntityId);
      }
      if (RecoverFull != false) {
        size += 1 + 1;
      }
      if (AvatarType != global::EggLink.DanhengServer.Proto.AvatarType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) AvatarType);
      }
      if (FloorId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FloorId);
      }
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Id);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SpringRecoverSingleAvatarCsReq other) {
      if (other == null) {
        return;
      }
      if (other.PlaneId != 0) {
        PlaneId = other.PlaneId;
      }
      if (other.PropEntityId != 0) {
        PropEntityId = other.PropEntityId;
      }
      if (other.RecoverFull != false) {
        RecoverFull = other.RecoverFull;
      }
      if (other.AvatarType != global::EggLink.DanhengServer.Proto.AvatarType.None) {
        AvatarType = other.AvatarType;
      }
      if (other.FloorId != 0) {
        FloorId = other.FloorId;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 16: {
            FloorId = input.ReadUInt32();
            break;
          }
          case 24: {
            Id = input.ReadUInt32();
            break;
          }
          case 40: {
            PlaneId = input.ReadUInt32();
            break;
          }
          case 64: {
            PropEntityId = input.ReadUInt32();
            break;
          }
          case 96: {
            AvatarType = (global::EggLink.DanhengServer.Proto.AvatarType) input.ReadEnum();
            break;
          }
          case 112: {
            RecoverFull = input.ReadBool();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 16: {
            FloorId = input.ReadUInt32();
            break;
          }
          case 24: {
            Id = input.ReadUInt32();
            break;
          }
          case 40: {
            PlaneId = input.ReadUInt32();
            break;
          }
          case 64: {
            PropEntityId = input.ReadUInt32();
            break;
          }
          case 96: {
            AvatarType = (global::EggLink.DanhengServer.Proto.AvatarType) input.ReadEnum();
            break;
          }
          case 112: {
            RecoverFull = input.ReadBool();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
