// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MonopolyGameCreateScNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from MonopolyGameCreateScNotify.proto</summary>
  public static partial class MonopolyGameCreateScNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for MonopolyGameCreateScNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MonopolyGameCreateScNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBNb25vcG9seUdhbWVDcmVhdGVTY05vdGlmeS5wcm90bxoRSEtQSFBNSUtK",
            "R00ucHJvdG8aEUhLSE9JRE1PTk9NLnByb3RvImIKGk1vbm9wb2x5R2FtZUNy",
            "ZWF0ZVNjTm90aWZ5EiEKC0hBS0VKTUVFTEZIGA0gASgLMgwuSEtIT0lETU9O",
            "T00SIQoLTEFPQUxPR0FQSEcYASABKAsyDC5IS1BIUE1JS0pHTUIeqgIbRWdn",
            "TGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.HKPHPMIKJGMReflection.Descriptor, global::EggLink.DanhengServer.Proto.HKHOIDMONOMReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.MonopolyGameCreateScNotify), global::EggLink.DanhengServer.Proto.MonopolyGameCreateScNotify.Parser, new[]{ "HAKEJMEELFH", "LAOALOGAPHG" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class MonopolyGameCreateScNotify : pb::IMessage<MonopolyGameCreateScNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MonopolyGameCreateScNotify> _parser = new pb::MessageParser<MonopolyGameCreateScNotify>(() => new MonopolyGameCreateScNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MonopolyGameCreateScNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.MonopolyGameCreateScNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MonopolyGameCreateScNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MonopolyGameCreateScNotify(MonopolyGameCreateScNotify other) : this() {
      hAKEJMEELFH_ = other.hAKEJMEELFH_ != null ? other.hAKEJMEELFH_.Clone() : null;
      lAOALOGAPHG_ = other.lAOALOGAPHG_ != null ? other.lAOALOGAPHG_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MonopolyGameCreateScNotify Clone() {
      return new MonopolyGameCreateScNotify(this);
    }

    /// <summary>Field number for the "HAKEJMEELFH" field.</summary>
    public const int HAKEJMEELFHFieldNumber = 13;
    private global::EggLink.DanhengServer.Proto.HKHOIDMONOM hAKEJMEELFH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.HKHOIDMONOM HAKEJMEELFH {
      get { return hAKEJMEELFH_; }
      set {
        hAKEJMEELFH_ = value;
      }
    }

    /// <summary>Field number for the "LAOALOGAPHG" field.</summary>
    public const int LAOALOGAPHGFieldNumber = 1;
    private global::EggLink.DanhengServer.Proto.HKPHPMIKJGM lAOALOGAPHG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.HKPHPMIKJGM LAOALOGAPHG {
      get { return lAOALOGAPHG_; }
      set {
        lAOALOGAPHG_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MonopolyGameCreateScNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MonopolyGameCreateScNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(HAKEJMEELFH, other.HAKEJMEELFH)) return false;
      if (!object.Equals(LAOALOGAPHG, other.LAOALOGAPHG)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (hAKEJMEELFH_ != null) hash ^= HAKEJMEELFH.GetHashCode();
      if (lAOALOGAPHG_ != null) hash ^= LAOALOGAPHG.GetHashCode();
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
      if (lAOALOGAPHG_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(LAOALOGAPHG);
      }
      if (hAKEJMEELFH_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(HAKEJMEELFH);
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
      if (lAOALOGAPHG_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(LAOALOGAPHG);
      }
      if (hAKEJMEELFH_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(HAKEJMEELFH);
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
      if (hAKEJMEELFH_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(HAKEJMEELFH);
      }
      if (lAOALOGAPHG_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LAOALOGAPHG);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MonopolyGameCreateScNotify other) {
      if (other == null) {
        return;
      }
      if (other.hAKEJMEELFH_ != null) {
        if (hAKEJMEELFH_ == null) {
          HAKEJMEELFH = new global::EggLink.DanhengServer.Proto.HKHOIDMONOM();
        }
        HAKEJMEELFH.MergeFrom(other.HAKEJMEELFH);
      }
      if (other.lAOALOGAPHG_ != null) {
        if (lAOALOGAPHG_ == null) {
          LAOALOGAPHG = new global::EggLink.DanhengServer.Proto.HKPHPMIKJGM();
        }
        LAOALOGAPHG.MergeFrom(other.LAOALOGAPHG);
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
          case 10: {
            if (lAOALOGAPHG_ == null) {
              LAOALOGAPHG = new global::EggLink.DanhengServer.Proto.HKPHPMIKJGM();
            }
            input.ReadMessage(LAOALOGAPHG);
            break;
          }
          case 106: {
            if (hAKEJMEELFH_ == null) {
              HAKEJMEELFH = new global::EggLink.DanhengServer.Proto.HKHOIDMONOM();
            }
            input.ReadMessage(HAKEJMEELFH);
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
          case 10: {
            if (lAOALOGAPHG_ == null) {
              LAOALOGAPHG = new global::EggLink.DanhengServer.Proto.HKPHPMIKJGM();
            }
            input.ReadMessage(LAOALOGAPHG);
            break;
          }
          case 106: {
            if (hAKEJMEELFH_ == null) {
              HAKEJMEELFH = new global::EggLink.DanhengServer.Proto.HKHOIDMONOM();
            }
            input.ReadMessage(HAKEJMEELFH);
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