// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChessRogueNousDiceUpdateNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ChessRogueNousDiceUpdateNotify.proto</summary>
  public static partial class ChessRogueNousDiceUpdateNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for ChessRogueNousDiceUpdateNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChessRogueNousDiceUpdateNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRDaGVzc1JvZ3VlTm91c0RpY2VVcGRhdGVOb3RpZnkucHJvdG8aEUNQRUVM",
            "TENKQ01ELnByb3RvIkMKHkNoZXNzUm9ndWVOb3VzRGljZVVwZGF0ZU5vdGlm",
            "eRIhCgtBSUVFRkJNRUNGTRgNIAEoCzIMLkNQRUVMTENKQ01EQh6qAhtFZ2dM",
            "aW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.CPEELLCJCMDReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ChessRogueNousDiceUpdateNotify), global::EggLink.DanhengServer.Proto.ChessRogueNousDiceUpdateNotify.Parser, new[]{ "AIEEFBMECFM" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ChessRogueNousDiceUpdateNotify : pb::IMessage<ChessRogueNousDiceUpdateNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChessRogueNousDiceUpdateNotify> _parser = new pb::MessageParser<ChessRogueNousDiceUpdateNotify>(() => new ChessRogueNousDiceUpdateNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChessRogueNousDiceUpdateNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ChessRogueNousDiceUpdateNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueNousDiceUpdateNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueNousDiceUpdateNotify(ChessRogueNousDiceUpdateNotify other) : this() {
      aIEEFBMECFM_ = other.aIEEFBMECFM_ != null ? other.aIEEFBMECFM_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueNousDiceUpdateNotify Clone() {
      return new ChessRogueNousDiceUpdateNotify(this);
    }

    /// <summary>Field number for the "AIEEFBMECFM" field.</summary>
    public const int AIEEFBMECFMFieldNumber = 13;
    private global::EggLink.DanhengServer.Proto.CPEELLCJCMD aIEEFBMECFM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.CPEELLCJCMD AIEEFBMECFM {
      get { return aIEEFBMECFM_; }
      set {
        aIEEFBMECFM_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChessRogueNousDiceUpdateNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChessRogueNousDiceUpdateNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(AIEEFBMECFM, other.AIEEFBMECFM)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (aIEEFBMECFM_ != null) hash ^= AIEEFBMECFM.GetHashCode();
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
      if (aIEEFBMECFM_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(AIEEFBMECFM);
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
      if (aIEEFBMECFM_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(AIEEFBMECFM);
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
      if (aIEEFBMECFM_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AIEEFBMECFM);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChessRogueNousDiceUpdateNotify other) {
      if (other == null) {
        return;
      }
      if (other.aIEEFBMECFM_ != null) {
        if (aIEEFBMECFM_ == null) {
          AIEEFBMECFM = new global::EggLink.DanhengServer.Proto.CPEELLCJCMD();
        }
        AIEEFBMECFM.MergeFrom(other.AIEEFBMECFM);
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
          case 106: {
            if (aIEEFBMECFM_ == null) {
              AIEEFBMECFM = new global::EggLink.DanhengServer.Proto.CPEELLCJCMD();
            }
            input.ReadMessage(AIEEFBMECFM);
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
          case 106: {
            if (aIEEFBMECFM_ == null) {
              AIEEFBMECFM = new global::EggLink.DanhengServer.Proto.CPEELLCJCMD();
            }
            input.ReadMessage(AIEEFBMECFM);
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
