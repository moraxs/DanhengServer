// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DisplayChallengeInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from DisplayChallengeInfo.proto</summary>
  public static partial class DisplayChallengeInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for DisplayChallengeInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DisplayChallengeInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpEaXNwbGF5Q2hhbGxlbmdlSW5mby5wcm90byJVChREaXNwbGF5Q2hhbGxl",
            "bmdlSW5mbxITCgtQQkhCRE5GT0FNQxgFIAEoDRITCgtMR0RQR0RKQktMRhgP",
            "IAEoDRITCgtGQk1HSkNIQU9OSBgEIAEoDUIeqgIbRWdnTGluay5EYW5oZW5n",
            "U2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.DisplayChallengeInfo), global::EggLink.DanhengServer.Proto.DisplayChallengeInfo.Parser, new[]{ "PBHBDNFOAMC", "LGDPGDJBKLF", "FBMGJCHAONH" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class DisplayChallengeInfo : pb::IMessage<DisplayChallengeInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DisplayChallengeInfo> _parser = new pb::MessageParser<DisplayChallengeInfo>(() => new DisplayChallengeInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DisplayChallengeInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.DisplayChallengeInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DisplayChallengeInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DisplayChallengeInfo(DisplayChallengeInfo other) : this() {
      pBHBDNFOAMC_ = other.pBHBDNFOAMC_;
      lGDPGDJBKLF_ = other.lGDPGDJBKLF_;
      fBMGJCHAONH_ = other.fBMGJCHAONH_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DisplayChallengeInfo Clone() {
      return new DisplayChallengeInfo(this);
    }

    /// <summary>Field number for the "PBHBDNFOAMC" field.</summary>
    public const int PBHBDNFOAMCFieldNumber = 5;
    private uint pBHBDNFOAMC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PBHBDNFOAMC {
      get { return pBHBDNFOAMC_; }
      set {
        pBHBDNFOAMC_ = value;
      }
    }

    /// <summary>Field number for the "LGDPGDJBKLF" field.</summary>
    public const int LGDPGDJBKLFFieldNumber = 15;
    private uint lGDPGDJBKLF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LGDPGDJBKLF {
      get { return lGDPGDJBKLF_; }
      set {
        lGDPGDJBKLF_ = value;
      }
    }

    /// <summary>Field number for the "FBMGJCHAONH" field.</summary>
    public const int FBMGJCHAONHFieldNumber = 4;
    private uint fBMGJCHAONH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FBMGJCHAONH {
      get { return fBMGJCHAONH_; }
      set {
        fBMGJCHAONH_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DisplayChallengeInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DisplayChallengeInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PBHBDNFOAMC != other.PBHBDNFOAMC) return false;
      if (LGDPGDJBKLF != other.LGDPGDJBKLF) return false;
      if (FBMGJCHAONH != other.FBMGJCHAONH) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (PBHBDNFOAMC != 0) hash ^= PBHBDNFOAMC.GetHashCode();
      if (LGDPGDJBKLF != 0) hash ^= LGDPGDJBKLF.GetHashCode();
      if (FBMGJCHAONH != 0) hash ^= FBMGJCHAONH.GetHashCode();
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
      if (FBMGJCHAONH != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(FBMGJCHAONH);
      }
      if (PBHBDNFOAMC != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(PBHBDNFOAMC);
      }
      if (LGDPGDJBKLF != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(LGDPGDJBKLF);
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
      if (FBMGJCHAONH != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(FBMGJCHAONH);
      }
      if (PBHBDNFOAMC != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(PBHBDNFOAMC);
      }
      if (LGDPGDJBKLF != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(LGDPGDJBKLF);
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
      if (PBHBDNFOAMC != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PBHBDNFOAMC);
      }
      if (LGDPGDJBKLF != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LGDPGDJBKLF);
      }
      if (FBMGJCHAONH != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FBMGJCHAONH);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DisplayChallengeInfo other) {
      if (other == null) {
        return;
      }
      if (other.PBHBDNFOAMC != 0) {
        PBHBDNFOAMC = other.PBHBDNFOAMC;
      }
      if (other.LGDPGDJBKLF != 0) {
        LGDPGDJBKLF = other.LGDPGDJBKLF;
      }
      if (other.FBMGJCHAONH != 0) {
        FBMGJCHAONH = other.FBMGJCHAONH;
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
          case 32: {
            FBMGJCHAONH = input.ReadUInt32();
            break;
          }
          case 40: {
            PBHBDNFOAMC = input.ReadUInt32();
            break;
          }
          case 120: {
            LGDPGDJBKLF = input.ReadUInt32();
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
          case 32: {
            FBMGJCHAONH = input.ReadUInt32();
            break;
          }
          case 40: {
            PBHBDNFOAMC = input.ReadUInt32();
            break;
          }
          case 120: {
            LGDPGDJBKLF = input.ReadUInt32();
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