// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MultipleDropInfoNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from MultipleDropInfoNotify.proto</summary>
  public static partial class MultipleDropInfoNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for MultipleDropInfoNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MultipleDropInfoNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxNdWx0aXBsZURyb3BJbmZvTm90aWZ5LnByb3RvGhZNdWx0aXBsZURyb3BJ",
            "bmZvLnByb3RvGh9QbGF5ZXJSZXR1cm5NdWx0aURyb3BEYXRhLnByb3RvInYK",
            "Fk11bHRpcGxlRHJvcEluZm9Ob3RpZnkSLQoSbXVsdGlwbGVfZHJvcF9saXN0",
            "GAUgAygLMhEuTXVsdGlwbGVEcm9wSW5mbxItCglkcm9wX2xpc3QYDiADKAsy",
            "Gi5QbGF5ZXJSZXR1cm5NdWx0aURyb3BEYXRhQh6qAhtFZ2dMaW5rLkRhbmhl",
            "bmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.MultipleDropInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.PlayerReturnMultiDropDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.MultipleDropInfoNotify), global::EggLink.DanhengServer.Proto.MultipleDropInfoNotify.Parser, new[]{ "MultipleDropList", "DropList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class MultipleDropInfoNotify : pb::IMessage<MultipleDropInfoNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MultipleDropInfoNotify> _parser = new pb::MessageParser<MultipleDropInfoNotify>(() => new MultipleDropInfoNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MultipleDropInfoNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.MultipleDropInfoNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MultipleDropInfoNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MultipleDropInfoNotify(MultipleDropInfoNotify other) : this() {
      multipleDropList_ = other.multipleDropList_.Clone();
      dropList_ = other.dropList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MultipleDropInfoNotify Clone() {
      return new MultipleDropInfoNotify(this);
    }

    /// <summary>Field number for the "multiple_drop_list" field.</summary>
    public const int MultipleDropListFieldNumber = 5;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.MultipleDropInfo> _repeated_multipleDropList_codec
        = pb::FieldCodec.ForMessage(42, global::EggLink.DanhengServer.Proto.MultipleDropInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MultipleDropInfo> multipleDropList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MultipleDropInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.MultipleDropInfo> MultipleDropList {
      get { return multipleDropList_; }
    }

    /// <summary>Field number for the "drop_list" field.</summary>
    public const int DropListFieldNumber = 14;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.PlayerReturnMultiDropData> _repeated_dropList_codec
        = pb::FieldCodec.ForMessage(114, global::EggLink.DanhengServer.Proto.PlayerReturnMultiDropData.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.PlayerReturnMultiDropData> dropList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.PlayerReturnMultiDropData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.PlayerReturnMultiDropData> DropList {
      get { return dropList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MultipleDropInfoNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MultipleDropInfoNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!multipleDropList_.Equals(other.multipleDropList_)) return false;
      if(!dropList_.Equals(other.dropList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= multipleDropList_.GetHashCode();
      hash ^= dropList_.GetHashCode();
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
      multipleDropList_.WriteTo(output, _repeated_multipleDropList_codec);
      dropList_.WriteTo(output, _repeated_dropList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      multipleDropList_.WriteTo(ref output, _repeated_multipleDropList_codec);
      dropList_.WriteTo(ref output, _repeated_dropList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += multipleDropList_.CalculateSize(_repeated_multipleDropList_codec);
      size += dropList_.CalculateSize(_repeated_dropList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MultipleDropInfoNotify other) {
      if (other == null) {
        return;
      }
      multipleDropList_.Add(other.multipleDropList_);
      dropList_.Add(other.dropList_);
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
          case 42: {
            multipleDropList_.AddEntriesFrom(input, _repeated_multipleDropList_codec);
            break;
          }
          case 114: {
            dropList_.AddEntriesFrom(input, _repeated_dropList_codec);
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
          case 42: {
            multipleDropList_.AddEntriesFrom(ref input, _repeated_multipleDropList_codec);
            break;
          }
          case 114: {
            dropList_.AddEntriesFrom(ref input, _repeated_dropList_codec);
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
