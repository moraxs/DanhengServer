// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FinishChessRogueSubStoryScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from FinishChessRogueSubStoryScRsp.proto</summary>
  public static partial class FinishChessRogueSubStoryScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for FinishChessRogueSubStoryScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FinishChessRogueSubStoryScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNGaW5pc2hDaGVzc1JvZ3VlU3ViU3RvcnlTY1JzcC5wcm90byKEAQodRmlu",
            "aXNoQ2hlc3NSb2d1ZVN1YlN0b3J5U2NSc3ASDwoHcmV0Y29kZRgFIAEoDRIT",
            "CgtHS0FJT0dOQ0RORRgNIAEoDRITCgtIQ0hNT0hIS01GUBgHIAEoDRITCgtI",
            "RUlFT0ZITUFDQRgDIAEoDRITCgtPR0FET0RLR0xOTBgGIAEoDUIeqgIbRWdn",
            "TGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.FinishChessRogueSubStoryScRsp), global::EggLink.DanhengServer.Proto.FinishChessRogueSubStoryScRsp.Parser, new[]{ "Retcode", "GKAIOGNCDNE", "HCHMOHHKMFP", "HEIEOFHMACA", "OGADODKGLNL" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class FinishChessRogueSubStoryScRsp : pb::IMessage<FinishChessRogueSubStoryScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FinishChessRogueSubStoryScRsp> _parser = new pb::MessageParser<FinishChessRogueSubStoryScRsp>(() => new FinishChessRogueSubStoryScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FinishChessRogueSubStoryScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.FinishChessRogueSubStoryScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FinishChessRogueSubStoryScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FinishChessRogueSubStoryScRsp(FinishChessRogueSubStoryScRsp other) : this() {
      retcode_ = other.retcode_;
      gKAIOGNCDNE_ = other.gKAIOGNCDNE_;
      hCHMOHHKMFP_ = other.hCHMOHHKMFP_;
      hEIEOFHMACA_ = other.hEIEOFHMACA_;
      oGADODKGLNL_ = other.oGADODKGLNL_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FinishChessRogueSubStoryScRsp Clone() {
      return new FinishChessRogueSubStoryScRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 5;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "GKAIOGNCDNE" field.</summary>
    public const int GKAIOGNCDNEFieldNumber = 13;
    private uint gKAIOGNCDNE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GKAIOGNCDNE {
      get { return gKAIOGNCDNE_; }
      set {
        gKAIOGNCDNE_ = value;
      }
    }

    /// <summary>Field number for the "HCHMOHHKMFP" field.</summary>
    public const int HCHMOHHKMFPFieldNumber = 7;
    private uint hCHMOHHKMFP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HCHMOHHKMFP {
      get { return hCHMOHHKMFP_; }
      set {
        hCHMOHHKMFP_ = value;
      }
    }

    /// <summary>Field number for the "HEIEOFHMACA" field.</summary>
    public const int HEIEOFHMACAFieldNumber = 3;
    private uint hEIEOFHMACA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HEIEOFHMACA {
      get { return hEIEOFHMACA_; }
      set {
        hEIEOFHMACA_ = value;
      }
    }

    /// <summary>Field number for the "OGADODKGLNL" field.</summary>
    public const int OGADODKGLNLFieldNumber = 6;
    private uint oGADODKGLNL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OGADODKGLNL {
      get { return oGADODKGLNL_; }
      set {
        oGADODKGLNL_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FinishChessRogueSubStoryScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FinishChessRogueSubStoryScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if (GKAIOGNCDNE != other.GKAIOGNCDNE) return false;
      if (HCHMOHHKMFP != other.HCHMOHHKMFP) return false;
      if (HEIEOFHMACA != other.HEIEOFHMACA) return false;
      if (OGADODKGLNL != other.OGADODKGLNL) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (GKAIOGNCDNE != 0) hash ^= GKAIOGNCDNE.GetHashCode();
      if (HCHMOHHKMFP != 0) hash ^= HCHMOHHKMFP.GetHashCode();
      if (HEIEOFHMACA != 0) hash ^= HEIEOFHMACA.GetHashCode();
      if (OGADODKGLNL != 0) hash ^= OGADODKGLNL.GetHashCode();
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
      if (HEIEOFHMACA != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(HEIEOFHMACA);
      }
      if (Retcode != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Retcode);
      }
      if (OGADODKGLNL != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(OGADODKGLNL);
      }
      if (HCHMOHHKMFP != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(HCHMOHHKMFP);
      }
      if (GKAIOGNCDNE != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(GKAIOGNCDNE);
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
      if (HEIEOFHMACA != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(HEIEOFHMACA);
      }
      if (Retcode != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Retcode);
      }
      if (OGADODKGLNL != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(OGADODKGLNL);
      }
      if (HCHMOHHKMFP != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(HCHMOHHKMFP);
      }
      if (GKAIOGNCDNE != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(GKAIOGNCDNE);
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
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (GKAIOGNCDNE != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GKAIOGNCDNE);
      }
      if (HCHMOHHKMFP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HCHMOHHKMFP);
      }
      if (HEIEOFHMACA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HEIEOFHMACA);
      }
      if (OGADODKGLNL != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OGADODKGLNL);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FinishChessRogueSubStoryScRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.GKAIOGNCDNE != 0) {
        GKAIOGNCDNE = other.GKAIOGNCDNE;
      }
      if (other.HCHMOHHKMFP != 0) {
        HCHMOHHKMFP = other.HCHMOHHKMFP;
      }
      if (other.HEIEOFHMACA != 0) {
        HEIEOFHMACA = other.HEIEOFHMACA;
      }
      if (other.OGADODKGLNL != 0) {
        OGADODKGLNL = other.OGADODKGLNL;
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
            HEIEOFHMACA = input.ReadUInt32();
            break;
          }
          case 40: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 48: {
            OGADODKGLNL = input.ReadUInt32();
            break;
          }
          case 56: {
            HCHMOHHKMFP = input.ReadUInt32();
            break;
          }
          case 104: {
            GKAIOGNCDNE = input.ReadUInt32();
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
            HEIEOFHMACA = input.ReadUInt32();
            break;
          }
          case 40: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 48: {
            OGADODKGLNL = input.ReadUInt32();
            break;
          }
          case 56: {
            HCHMOHHKMFP = input.ReadUInt32();
            break;
          }
          case 104: {
            GKAIOGNCDNE = input.ReadUInt32();
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
