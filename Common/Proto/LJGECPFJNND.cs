// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: LJGECPFJNND.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from LJGECPFJNND.proto</summary>
  public static partial class LJGECPFJNNDReflection {

    #region Descriptor
    /// <summary>File descriptor for LJGECPFJNND.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LJGECPFJNNDReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFMSkdFQ1BGSk5ORC5wcm90bxoRQ0xCTkZIREZHR0sucHJvdG8iWgoLTEpH",
            "RUNQRkpOTkQSIQoLSktGTEpES0pJRkoYAiADKAsyDC5DTEJORkhERkdHSxIT",
            "CgtQREFCUENCR0hPThgHIAEoCBITCgtMQ0pHUEpNSk1GRxgEIAEoDUIeqgIb",
            "RWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.CLBNFHDFGGKReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.LJGECPFJNND), global::EggLink.DanhengServer.Proto.LJGECPFJNND.Parser, new[]{ "JKFLJDKJIFJ", "PDABPCBGHON", "LCJGPJMJMFG" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class LJGECPFJNND : pb::IMessage<LJGECPFJNND>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LJGECPFJNND> _parser = new pb::MessageParser<LJGECPFJNND>(() => new LJGECPFJNND());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<LJGECPFJNND> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.LJGECPFJNNDReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LJGECPFJNND() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LJGECPFJNND(LJGECPFJNND other) : this() {
      jKFLJDKJIFJ_ = other.jKFLJDKJIFJ_.Clone();
      pDABPCBGHON_ = other.pDABPCBGHON_;
      lCJGPJMJMFG_ = other.lCJGPJMJMFG_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LJGECPFJNND Clone() {
      return new LJGECPFJNND(this);
    }

    /// <summary>Field number for the "JKFLJDKJIFJ" field.</summary>
    public const int JKFLJDKJIFJFieldNumber = 2;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.CLBNFHDFGGK> _repeated_jKFLJDKJIFJ_codec
        = pb::FieldCodec.ForMessage(18, global::EggLink.DanhengServer.Proto.CLBNFHDFGGK.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.CLBNFHDFGGK> jKFLJDKJIFJ_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.CLBNFHDFGGK>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.CLBNFHDFGGK> JKFLJDKJIFJ {
      get { return jKFLJDKJIFJ_; }
    }

    /// <summary>Field number for the "PDABPCBGHON" field.</summary>
    public const int PDABPCBGHONFieldNumber = 7;
    private bool pDABPCBGHON_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool PDABPCBGHON {
      get { return pDABPCBGHON_; }
      set {
        pDABPCBGHON_ = value;
      }
    }

    /// <summary>Field number for the "LCJGPJMJMFG" field.</summary>
    public const int LCJGPJMJMFGFieldNumber = 4;
    private uint lCJGPJMJMFG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LCJGPJMJMFG {
      get { return lCJGPJMJMFG_; }
      set {
        lCJGPJMJMFG_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as LJGECPFJNND);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(LJGECPFJNND other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!jKFLJDKJIFJ_.Equals(other.jKFLJDKJIFJ_)) return false;
      if (PDABPCBGHON != other.PDABPCBGHON) return false;
      if (LCJGPJMJMFG != other.LCJGPJMJMFG) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= jKFLJDKJIFJ_.GetHashCode();
      if (PDABPCBGHON != false) hash ^= PDABPCBGHON.GetHashCode();
      if (LCJGPJMJMFG != 0) hash ^= LCJGPJMJMFG.GetHashCode();
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
      jKFLJDKJIFJ_.WriteTo(output, _repeated_jKFLJDKJIFJ_codec);
      if (LCJGPJMJMFG != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(LCJGPJMJMFG);
      }
      if (PDABPCBGHON != false) {
        output.WriteRawTag(56);
        output.WriteBool(PDABPCBGHON);
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
      jKFLJDKJIFJ_.WriteTo(ref output, _repeated_jKFLJDKJIFJ_codec);
      if (LCJGPJMJMFG != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(LCJGPJMJMFG);
      }
      if (PDABPCBGHON != false) {
        output.WriteRawTag(56);
        output.WriteBool(PDABPCBGHON);
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
      size += jKFLJDKJIFJ_.CalculateSize(_repeated_jKFLJDKJIFJ_codec);
      if (PDABPCBGHON != false) {
        size += 1 + 1;
      }
      if (LCJGPJMJMFG != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LCJGPJMJMFG);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(LJGECPFJNND other) {
      if (other == null) {
        return;
      }
      jKFLJDKJIFJ_.Add(other.jKFLJDKJIFJ_);
      if (other.PDABPCBGHON != false) {
        PDABPCBGHON = other.PDABPCBGHON;
      }
      if (other.LCJGPJMJMFG != 0) {
        LCJGPJMJMFG = other.LCJGPJMJMFG;
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
          case 18: {
            jKFLJDKJIFJ_.AddEntriesFrom(input, _repeated_jKFLJDKJIFJ_codec);
            break;
          }
          case 32: {
            LCJGPJMJMFG = input.ReadUInt32();
            break;
          }
          case 56: {
            PDABPCBGHON = input.ReadBool();
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
          case 18: {
            jKFLJDKJIFJ_.AddEntriesFrom(ref input, _repeated_jKFLJDKJIFJ_codec);
            break;
          }
          case 32: {
            LCJGPJMJMFG = input.ReadUInt32();
            break;
          }
          case 56: {
            PDABPCBGHON = input.ReadBool();
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
