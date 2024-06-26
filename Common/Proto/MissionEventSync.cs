// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MissionEventSync.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from MissionEventSync.proto</summary>
  public static partial class MissionEventSyncReflection {

    #region Descriptor
    /// <summary>File descriptor for MissionEventSync.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MissionEventSyncReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZNaXNzaW9uRXZlbnRTeW5jLnByb3RvGg1NaXNzaW9uLnByb3RvImIKEE1p",
            "c3Npb25FdmVudFN5bmMSJAoSbWlzc2lvbl9ldmVudF9saXN0GAggAygLMggu",
            "TWlzc2lvbhITCgtHS1BDR0lIR0RCQRgHIAMoDRITCgtCTERGSkNCSEhJQRgE",
            "IAMoDUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.MissionReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.MissionEventSync), global::EggLink.DanhengServer.Proto.MissionEventSync.Parser, new[]{ "MissionEventList", "GKPCGIHGDBA", "BLDFJCBHHIA" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class MissionEventSync : pb::IMessage<MissionEventSync>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MissionEventSync> _parser = new pb::MessageParser<MissionEventSync>(() => new MissionEventSync());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MissionEventSync> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.MissionEventSyncReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MissionEventSync() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MissionEventSync(MissionEventSync other) : this() {
      missionEventList_ = other.missionEventList_.Clone();
      gKPCGIHGDBA_ = other.gKPCGIHGDBA_.Clone();
      bLDFJCBHHIA_ = other.bLDFJCBHHIA_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MissionEventSync Clone() {
      return new MissionEventSync(this);
    }

    /// <summary>Field number for the "mission_event_list" field.</summary>
    public const int MissionEventListFieldNumber = 8;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.Mission> _repeated_missionEventList_codec
        = pb::FieldCodec.ForMessage(66, global::EggLink.DanhengServer.Proto.Mission.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Mission> missionEventList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Mission>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Mission> MissionEventList {
      get { return missionEventList_; }
    }

    /// <summary>Field number for the "GKPCGIHGDBA" field.</summary>
    public const int GKPCGIHGDBAFieldNumber = 7;
    private static readonly pb::FieldCodec<uint> _repeated_gKPCGIHGDBA_codec
        = pb::FieldCodec.ForUInt32(58);
    private readonly pbc::RepeatedField<uint> gKPCGIHGDBA_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> GKPCGIHGDBA {
      get { return gKPCGIHGDBA_; }
    }

    /// <summary>Field number for the "BLDFJCBHHIA" field.</summary>
    public const int BLDFJCBHHIAFieldNumber = 4;
    private static readonly pb::FieldCodec<uint> _repeated_bLDFJCBHHIA_codec
        = pb::FieldCodec.ForUInt32(34);
    private readonly pbc::RepeatedField<uint> bLDFJCBHHIA_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> BLDFJCBHHIA {
      get { return bLDFJCBHHIA_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MissionEventSync);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MissionEventSync other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!missionEventList_.Equals(other.missionEventList_)) return false;
      if(!gKPCGIHGDBA_.Equals(other.gKPCGIHGDBA_)) return false;
      if(!bLDFJCBHHIA_.Equals(other.bLDFJCBHHIA_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= missionEventList_.GetHashCode();
      hash ^= gKPCGIHGDBA_.GetHashCode();
      hash ^= bLDFJCBHHIA_.GetHashCode();
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
      bLDFJCBHHIA_.WriteTo(output, _repeated_bLDFJCBHHIA_codec);
      gKPCGIHGDBA_.WriteTo(output, _repeated_gKPCGIHGDBA_codec);
      missionEventList_.WriteTo(output, _repeated_missionEventList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      bLDFJCBHHIA_.WriteTo(ref output, _repeated_bLDFJCBHHIA_codec);
      gKPCGIHGDBA_.WriteTo(ref output, _repeated_gKPCGIHGDBA_codec);
      missionEventList_.WriteTo(ref output, _repeated_missionEventList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += missionEventList_.CalculateSize(_repeated_missionEventList_codec);
      size += gKPCGIHGDBA_.CalculateSize(_repeated_gKPCGIHGDBA_codec);
      size += bLDFJCBHHIA_.CalculateSize(_repeated_bLDFJCBHHIA_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MissionEventSync other) {
      if (other == null) {
        return;
      }
      missionEventList_.Add(other.missionEventList_);
      gKPCGIHGDBA_.Add(other.gKPCGIHGDBA_);
      bLDFJCBHHIA_.Add(other.bLDFJCBHHIA_);
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
          case 34:
          case 32: {
            bLDFJCBHHIA_.AddEntriesFrom(input, _repeated_bLDFJCBHHIA_codec);
            break;
          }
          case 58:
          case 56: {
            gKPCGIHGDBA_.AddEntriesFrom(input, _repeated_gKPCGIHGDBA_codec);
            break;
          }
          case 66: {
            missionEventList_.AddEntriesFrom(input, _repeated_missionEventList_codec);
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
          case 34:
          case 32: {
            bLDFJCBHHIA_.AddEntriesFrom(ref input, _repeated_bLDFJCBHHIA_codec);
            break;
          }
          case 58:
          case 56: {
            gKPCGIHGDBA_.AddEntriesFrom(ref input, _repeated_gKPCGIHGDBA_codec);
            break;
          }
          case 66: {
            missionEventList_.AddEntriesFrom(ref input, _repeated_missionEventList_codec);
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
