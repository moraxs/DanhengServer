// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: IPKNDGIPCGA.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from IPKNDGIPCGA.proto</summary>
  public static partial class IPKNDGIPCGAReflection {

    #region Descriptor
    /// <summary>File descriptor for IPKNDGIPCGA.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static IPKNDGIPCGAReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFJUEtOREdJUENHQS5wcm90bxoRTE1CT0NPSUpIRk4ucHJvdG8iWgoLSVBL",
            "TkRHSVBDR0ESIQoLTERPQ0RESExJQ0sYDiABKA4yDC5MTUJPQ09JSkhGThIT",
            "CgtJRU1LR0hDTUxQShgGIAEoDRITCgtESUpQTUdNRklGQRgHIAEoDUIeqgIb",
            "RWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.LMBOCOIJHFNReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.IPKNDGIPCGA), global::EggLink.DanhengServer.Proto.IPKNDGIPCGA.Parser, new[]{ "LDOCDDHLICK", "IEMKGHCMLPJ", "DIJPMGMFIFA" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class IPKNDGIPCGA : pb::IMessage<IPKNDGIPCGA>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<IPKNDGIPCGA> _parser = new pb::MessageParser<IPKNDGIPCGA>(() => new IPKNDGIPCGA());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<IPKNDGIPCGA> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.IPKNDGIPCGAReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public IPKNDGIPCGA() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public IPKNDGIPCGA(IPKNDGIPCGA other) : this() {
      lDOCDDHLICK_ = other.lDOCDDHLICK_;
      iEMKGHCMLPJ_ = other.iEMKGHCMLPJ_;
      dIJPMGMFIFA_ = other.dIJPMGMFIFA_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public IPKNDGIPCGA Clone() {
      return new IPKNDGIPCGA(this);
    }

    /// <summary>Field number for the "LDOCDDHLICK" field.</summary>
    public const int LDOCDDHLICKFieldNumber = 14;
    private global::EggLink.DanhengServer.Proto.LMBOCOIJHFN lDOCDDHLICK_ = global::EggLink.DanhengServer.Proto.LMBOCOIJHFN.RogueModifierContentDefinite;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.LMBOCOIJHFN LDOCDDHLICK {
      get { return lDOCDDHLICK_; }
      set {
        lDOCDDHLICK_ = value;
      }
    }

    /// <summary>Field number for the "IEMKGHCMLPJ" field.</summary>
    public const int IEMKGHCMLPJFieldNumber = 6;
    private uint iEMKGHCMLPJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint IEMKGHCMLPJ {
      get { return iEMKGHCMLPJ_; }
      set {
        iEMKGHCMLPJ_ = value;
      }
    }

    /// <summary>Field number for the "DIJPMGMFIFA" field.</summary>
    public const int DIJPMGMFIFAFieldNumber = 7;
    private uint dIJPMGMFIFA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DIJPMGMFIFA {
      get { return dIJPMGMFIFA_; }
      set {
        dIJPMGMFIFA_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as IPKNDGIPCGA);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(IPKNDGIPCGA other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (LDOCDDHLICK != other.LDOCDDHLICK) return false;
      if (IEMKGHCMLPJ != other.IEMKGHCMLPJ) return false;
      if (DIJPMGMFIFA != other.DIJPMGMFIFA) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (LDOCDDHLICK != global::EggLink.DanhengServer.Proto.LMBOCOIJHFN.RogueModifierContentDefinite) hash ^= LDOCDDHLICK.GetHashCode();
      if (IEMKGHCMLPJ != 0) hash ^= IEMKGHCMLPJ.GetHashCode();
      if (DIJPMGMFIFA != 0) hash ^= DIJPMGMFIFA.GetHashCode();
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
      if (IEMKGHCMLPJ != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(IEMKGHCMLPJ);
      }
      if (DIJPMGMFIFA != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(DIJPMGMFIFA);
      }
      if (LDOCDDHLICK != global::EggLink.DanhengServer.Proto.LMBOCOIJHFN.RogueModifierContentDefinite) {
        output.WriteRawTag(112);
        output.WriteEnum((int) LDOCDDHLICK);
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
      if (IEMKGHCMLPJ != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(IEMKGHCMLPJ);
      }
      if (DIJPMGMFIFA != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(DIJPMGMFIFA);
      }
      if (LDOCDDHLICK != global::EggLink.DanhengServer.Proto.LMBOCOIJHFN.RogueModifierContentDefinite) {
        output.WriteRawTag(112);
        output.WriteEnum((int) LDOCDDHLICK);
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
      if (LDOCDDHLICK != global::EggLink.DanhengServer.Proto.LMBOCOIJHFN.RogueModifierContentDefinite) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) LDOCDDHLICK);
      }
      if (IEMKGHCMLPJ != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(IEMKGHCMLPJ);
      }
      if (DIJPMGMFIFA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DIJPMGMFIFA);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(IPKNDGIPCGA other) {
      if (other == null) {
        return;
      }
      if (other.LDOCDDHLICK != global::EggLink.DanhengServer.Proto.LMBOCOIJHFN.RogueModifierContentDefinite) {
        LDOCDDHLICK = other.LDOCDDHLICK;
      }
      if (other.IEMKGHCMLPJ != 0) {
        IEMKGHCMLPJ = other.IEMKGHCMLPJ;
      }
      if (other.DIJPMGMFIFA != 0) {
        DIJPMGMFIFA = other.DIJPMGMFIFA;
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
          case 48: {
            IEMKGHCMLPJ = input.ReadUInt32();
            break;
          }
          case 56: {
            DIJPMGMFIFA = input.ReadUInt32();
            break;
          }
          case 112: {
            LDOCDDHLICK = (global::EggLink.DanhengServer.Proto.LMBOCOIJHFN) input.ReadEnum();
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
          case 48: {
            IEMKGHCMLPJ = input.ReadUInt32();
            break;
          }
          case 56: {
            DIJPMGMFIFA = input.ReadUInt32();
            break;
          }
          case 112: {
            LDOCDDHLICK = (global::EggLink.DanhengServer.Proto.LMBOCOIJHFN) input.ReadEnum();
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
