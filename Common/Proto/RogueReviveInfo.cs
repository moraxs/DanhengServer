// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueReviveInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueReviveInfo.proto</summary>
  public static partial class RogueReviveInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueReviveInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueReviveInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVSb2d1ZVJldml2ZUluZm8ucHJvdG8aEkl0ZW1Db3N0RGF0YS5wcm90byJ0",
            "Cg9Sb2d1ZVJldml2ZUluZm8SEwoLSUhDQUtGRkxMUFAYCiABKA0SEwoLTUJI",
            "RUtGQU9ORUIYBiADKA0SIgoLTE1MRUFFUExBUE4YDCABKAsyDS5JdGVtQ29z",
            "dERhdGESEwoLTElFUERIRk1GQ0cYASABKA1CHqoCG0VnZ0xpbmsuRGFuaGVu",
            "Z1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ItemCostDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueReviveInfo), global::EggLink.DanhengServer.Proto.RogueReviveInfo.Parser, new[]{ "IHCAKFFLLPP", "MBHEKFAONEB", "LMLEAEPLAPN", "LIEPDHFMFCG" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueReviveInfo : pb::IMessage<RogueReviveInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueReviveInfo> _parser = new pb::MessageParser<RogueReviveInfo>(() => new RogueReviveInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueReviveInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueReviveInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueReviveInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueReviveInfo(RogueReviveInfo other) : this() {
      iHCAKFFLLPP_ = other.iHCAKFFLLPP_;
      mBHEKFAONEB_ = other.mBHEKFAONEB_.Clone();
      lMLEAEPLAPN_ = other.lMLEAEPLAPN_ != null ? other.lMLEAEPLAPN_.Clone() : null;
      lIEPDHFMFCG_ = other.lIEPDHFMFCG_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueReviveInfo Clone() {
      return new RogueReviveInfo(this);
    }

    /// <summary>Field number for the "IHCAKFFLLPP" field.</summary>
    public const int IHCAKFFLLPPFieldNumber = 10;
    private uint iHCAKFFLLPP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint IHCAKFFLLPP {
      get { return iHCAKFFLLPP_; }
      set {
        iHCAKFFLLPP_ = value;
      }
    }

    /// <summary>Field number for the "MBHEKFAONEB" field.</summary>
    public const int MBHEKFAONEBFieldNumber = 6;
    private static readonly pb::FieldCodec<uint> _repeated_mBHEKFAONEB_codec
        = pb::FieldCodec.ForUInt32(50);
    private readonly pbc::RepeatedField<uint> mBHEKFAONEB_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> MBHEKFAONEB {
      get { return mBHEKFAONEB_; }
    }

    /// <summary>Field number for the "LMLEAEPLAPN" field.</summary>
    public const int LMLEAEPLAPNFieldNumber = 12;
    private global::EggLink.DanhengServer.Proto.ItemCostData lMLEAEPLAPN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemCostData LMLEAEPLAPN {
      get { return lMLEAEPLAPN_; }
      set {
        lMLEAEPLAPN_ = value;
      }
    }

    /// <summary>Field number for the "LIEPDHFMFCG" field.</summary>
    public const int LIEPDHFMFCGFieldNumber = 1;
    private uint lIEPDHFMFCG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LIEPDHFMFCG {
      get { return lIEPDHFMFCG_; }
      set {
        lIEPDHFMFCG_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueReviveInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueReviveInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IHCAKFFLLPP != other.IHCAKFFLLPP) return false;
      if(!mBHEKFAONEB_.Equals(other.mBHEKFAONEB_)) return false;
      if (!object.Equals(LMLEAEPLAPN, other.LMLEAEPLAPN)) return false;
      if (LIEPDHFMFCG != other.LIEPDHFMFCG) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IHCAKFFLLPP != 0) hash ^= IHCAKFFLLPP.GetHashCode();
      hash ^= mBHEKFAONEB_.GetHashCode();
      if (lMLEAEPLAPN_ != null) hash ^= LMLEAEPLAPN.GetHashCode();
      if (LIEPDHFMFCG != 0) hash ^= LIEPDHFMFCG.GetHashCode();
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
      if (LIEPDHFMFCG != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(LIEPDHFMFCG);
      }
      mBHEKFAONEB_.WriteTo(output, _repeated_mBHEKFAONEB_codec);
      if (IHCAKFFLLPP != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(IHCAKFFLLPP);
      }
      if (lMLEAEPLAPN_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(LMLEAEPLAPN);
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
      if (LIEPDHFMFCG != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(LIEPDHFMFCG);
      }
      mBHEKFAONEB_.WriteTo(ref output, _repeated_mBHEKFAONEB_codec);
      if (IHCAKFFLLPP != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(IHCAKFFLLPP);
      }
      if (lMLEAEPLAPN_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(LMLEAEPLAPN);
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
      if (IHCAKFFLLPP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(IHCAKFFLLPP);
      }
      size += mBHEKFAONEB_.CalculateSize(_repeated_mBHEKFAONEB_codec);
      if (lMLEAEPLAPN_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LMLEAEPLAPN);
      }
      if (LIEPDHFMFCG != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LIEPDHFMFCG);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueReviveInfo other) {
      if (other == null) {
        return;
      }
      if (other.IHCAKFFLLPP != 0) {
        IHCAKFFLLPP = other.IHCAKFFLLPP;
      }
      mBHEKFAONEB_.Add(other.mBHEKFAONEB_);
      if (other.lMLEAEPLAPN_ != null) {
        if (lMLEAEPLAPN_ == null) {
          LMLEAEPLAPN = new global::EggLink.DanhengServer.Proto.ItemCostData();
        }
        LMLEAEPLAPN.MergeFrom(other.LMLEAEPLAPN);
      }
      if (other.LIEPDHFMFCG != 0) {
        LIEPDHFMFCG = other.LIEPDHFMFCG;
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
          case 8: {
            LIEPDHFMFCG = input.ReadUInt32();
            break;
          }
          case 50:
          case 48: {
            mBHEKFAONEB_.AddEntriesFrom(input, _repeated_mBHEKFAONEB_codec);
            break;
          }
          case 80: {
            IHCAKFFLLPP = input.ReadUInt32();
            break;
          }
          case 98: {
            if (lMLEAEPLAPN_ == null) {
              LMLEAEPLAPN = new global::EggLink.DanhengServer.Proto.ItemCostData();
            }
            input.ReadMessage(LMLEAEPLAPN);
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
          case 8: {
            LIEPDHFMFCG = input.ReadUInt32();
            break;
          }
          case 50:
          case 48: {
            mBHEKFAONEB_.AddEntriesFrom(ref input, _repeated_mBHEKFAONEB_codec);
            break;
          }
          case 80: {
            IHCAKFFLLPP = input.ReadUInt32();
            break;
          }
          case 98: {
            if (lMLEAEPLAPN_ == null) {
              LMLEAEPLAPN = new global::EggLink.DanhengServer.Proto.ItemCostData();
            }
            input.ReadMessage(LMLEAEPLAPN);
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
