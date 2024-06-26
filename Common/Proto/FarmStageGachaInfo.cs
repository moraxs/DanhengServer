// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FarmStageGachaInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from FarmStageGachaInfo.proto</summary>
  public static partial class FarmStageGachaInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for FarmStageGachaInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FarmStageGachaInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhGYXJtU3RhZ2VHYWNoYUluZm8ucHJvdG8iTAoSRmFybVN0YWdlR2FjaGFJ",
            "bmZvEhIKCmJlZ2luX3RpbWUYByABKAMSEAoIZ2FjaGFfaWQYDyABKA0SEAoI",
            "ZW5kX3RpbWUYAyABKANCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90",
            "b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.FarmStageGachaInfo), global::EggLink.DanhengServer.Proto.FarmStageGachaInfo.Parser, new[]{ "BeginTime", "GachaId", "EndTime" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class FarmStageGachaInfo : pb::IMessage<FarmStageGachaInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FarmStageGachaInfo> _parser = new pb::MessageParser<FarmStageGachaInfo>(() => new FarmStageGachaInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FarmStageGachaInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.FarmStageGachaInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FarmStageGachaInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FarmStageGachaInfo(FarmStageGachaInfo other) : this() {
      beginTime_ = other.beginTime_;
      gachaId_ = other.gachaId_;
      endTime_ = other.endTime_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FarmStageGachaInfo Clone() {
      return new FarmStageGachaInfo(this);
    }

    /// <summary>Field number for the "begin_time" field.</summary>
    public const int BeginTimeFieldNumber = 7;
    private long beginTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long BeginTime {
      get { return beginTime_; }
      set {
        beginTime_ = value;
      }
    }

    /// <summary>Field number for the "gacha_id" field.</summary>
    public const int GachaIdFieldNumber = 15;
    private uint gachaId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GachaId {
      get { return gachaId_; }
      set {
        gachaId_ = value;
      }
    }

    /// <summary>Field number for the "end_time" field.</summary>
    public const int EndTimeFieldNumber = 3;
    private long endTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long EndTime {
      get { return endTime_; }
      set {
        endTime_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FarmStageGachaInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FarmStageGachaInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BeginTime != other.BeginTime) return false;
      if (GachaId != other.GachaId) return false;
      if (EndTime != other.EndTime) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (BeginTime != 0L) hash ^= BeginTime.GetHashCode();
      if (GachaId != 0) hash ^= GachaId.GetHashCode();
      if (EndTime != 0L) hash ^= EndTime.GetHashCode();
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
      if (EndTime != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(EndTime);
      }
      if (BeginTime != 0L) {
        output.WriteRawTag(56);
        output.WriteInt64(BeginTime);
      }
      if (GachaId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(GachaId);
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
      if (EndTime != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(EndTime);
      }
      if (BeginTime != 0L) {
        output.WriteRawTag(56);
        output.WriteInt64(BeginTime);
      }
      if (GachaId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(GachaId);
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
      if (BeginTime != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(BeginTime);
      }
      if (GachaId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GachaId);
      }
      if (EndTime != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(EndTime);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FarmStageGachaInfo other) {
      if (other == null) {
        return;
      }
      if (other.BeginTime != 0L) {
        BeginTime = other.BeginTime;
      }
      if (other.GachaId != 0) {
        GachaId = other.GachaId;
      }
      if (other.EndTime != 0L) {
        EndTime = other.EndTime;
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
          case 24: {
            EndTime = input.ReadInt64();
            break;
          }
          case 56: {
            BeginTime = input.ReadInt64();
            break;
          }
          case 120: {
            GachaId = input.ReadUInt32();
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
          case 24: {
            EndTime = input.ReadInt64();
            break;
          }
          case 56: {
            BeginTime = input.ReadInt64();
            break;
          }
          case 120: {
            GachaId = input.ReadUInt32();
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
