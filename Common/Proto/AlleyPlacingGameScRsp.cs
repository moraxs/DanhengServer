// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AlleyPlacingGameScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from AlleyPlacingGameScRsp.proto</summary>
  public static partial class AlleyPlacingGameScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for AlleyPlacingGameScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AlleyPlacingGameScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtBbGxleVBsYWNpbmdHYW1lU2NSc3AucHJvdG8iuAEKFUFsbGV5UGxhY2lu",
            "Z0dhbWVTY1JzcBIQCghldmVudF9pZBgJIAEoDRITCgtGRkVPRExIREtISRgP",
            "IAEoDRIPCgdyZXRjb2RlGAQgASgNEhMKC0JLTUlBUExKUEZMGA0gASgNEhMK",
            "C0lEQURDSEJFSUJCGAUgASgNEhMKC0JFTkVEREJCTEFCGAogASgNEhMKC0tK",
            "RE5HUENDSUhJGAMgASgNEhMKC01BQktLTENFR0NFGA4gASgNQh6qAhtFZ2dM",
            "aW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.AlleyPlacingGameScRsp), global::EggLink.DanhengServer.Proto.AlleyPlacingGameScRsp.Parser, new[]{ "EventId", "FFEODLHDKHI", "Retcode", "BKMIAPLJPFL", "IDADCHBEIBB", "BENEDDBBLAB", "KJDNGPCCIHI", "MABKKLCEGCE" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class AlleyPlacingGameScRsp : pb::IMessage<AlleyPlacingGameScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AlleyPlacingGameScRsp> _parser = new pb::MessageParser<AlleyPlacingGameScRsp>(() => new AlleyPlacingGameScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AlleyPlacingGameScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.AlleyPlacingGameScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AlleyPlacingGameScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AlleyPlacingGameScRsp(AlleyPlacingGameScRsp other) : this() {
      eventId_ = other.eventId_;
      fFEODLHDKHI_ = other.fFEODLHDKHI_;
      retcode_ = other.retcode_;
      bKMIAPLJPFL_ = other.bKMIAPLJPFL_;
      iDADCHBEIBB_ = other.iDADCHBEIBB_;
      bENEDDBBLAB_ = other.bENEDDBBLAB_;
      kJDNGPCCIHI_ = other.kJDNGPCCIHI_;
      mABKKLCEGCE_ = other.mABKKLCEGCE_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AlleyPlacingGameScRsp Clone() {
      return new AlleyPlacingGameScRsp(this);
    }

    /// <summary>Field number for the "event_id" field.</summary>
    public const int EventIdFieldNumber = 9;
    private uint eventId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EventId {
      get { return eventId_; }
      set {
        eventId_ = value;
      }
    }

    /// <summary>Field number for the "FFEODLHDKHI" field.</summary>
    public const int FFEODLHDKHIFieldNumber = 15;
    private uint fFEODLHDKHI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FFEODLHDKHI {
      get { return fFEODLHDKHI_; }
      set {
        fFEODLHDKHI_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 4;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "BKMIAPLJPFL" field.</summary>
    public const int BKMIAPLJPFLFieldNumber = 13;
    private uint bKMIAPLJPFL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BKMIAPLJPFL {
      get { return bKMIAPLJPFL_; }
      set {
        bKMIAPLJPFL_ = value;
      }
    }

    /// <summary>Field number for the "IDADCHBEIBB" field.</summary>
    public const int IDADCHBEIBBFieldNumber = 5;
    private uint iDADCHBEIBB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint IDADCHBEIBB {
      get { return iDADCHBEIBB_; }
      set {
        iDADCHBEIBB_ = value;
      }
    }

    /// <summary>Field number for the "BENEDDBBLAB" field.</summary>
    public const int BENEDDBBLABFieldNumber = 10;
    private uint bENEDDBBLAB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BENEDDBBLAB {
      get { return bENEDDBBLAB_; }
      set {
        bENEDDBBLAB_ = value;
      }
    }

    /// <summary>Field number for the "KJDNGPCCIHI" field.</summary>
    public const int KJDNGPCCIHIFieldNumber = 3;
    private uint kJDNGPCCIHI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint KJDNGPCCIHI {
      get { return kJDNGPCCIHI_; }
      set {
        kJDNGPCCIHI_ = value;
      }
    }

    /// <summary>Field number for the "MABKKLCEGCE" field.</summary>
    public const int MABKKLCEGCEFieldNumber = 14;
    private uint mABKKLCEGCE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MABKKLCEGCE {
      get { return mABKKLCEGCE_; }
      set {
        mABKKLCEGCE_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AlleyPlacingGameScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AlleyPlacingGameScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EventId != other.EventId) return false;
      if (FFEODLHDKHI != other.FFEODLHDKHI) return false;
      if (Retcode != other.Retcode) return false;
      if (BKMIAPLJPFL != other.BKMIAPLJPFL) return false;
      if (IDADCHBEIBB != other.IDADCHBEIBB) return false;
      if (BENEDDBBLAB != other.BENEDDBBLAB) return false;
      if (KJDNGPCCIHI != other.KJDNGPCCIHI) return false;
      if (MABKKLCEGCE != other.MABKKLCEGCE) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (EventId != 0) hash ^= EventId.GetHashCode();
      if (FFEODLHDKHI != 0) hash ^= FFEODLHDKHI.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (BKMIAPLJPFL != 0) hash ^= BKMIAPLJPFL.GetHashCode();
      if (IDADCHBEIBB != 0) hash ^= IDADCHBEIBB.GetHashCode();
      if (BENEDDBBLAB != 0) hash ^= BENEDDBBLAB.GetHashCode();
      if (KJDNGPCCIHI != 0) hash ^= KJDNGPCCIHI.GetHashCode();
      if (MABKKLCEGCE != 0) hash ^= MABKKLCEGCE.GetHashCode();
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
      if (KJDNGPCCIHI != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(KJDNGPCCIHI);
      }
      if (Retcode != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Retcode);
      }
      if (IDADCHBEIBB != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(IDADCHBEIBB);
      }
      if (EventId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(EventId);
      }
      if (BENEDDBBLAB != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(BENEDDBBLAB);
      }
      if (BKMIAPLJPFL != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(BKMIAPLJPFL);
      }
      if (MABKKLCEGCE != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(MABKKLCEGCE);
      }
      if (FFEODLHDKHI != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(FFEODLHDKHI);
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
      if (KJDNGPCCIHI != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(KJDNGPCCIHI);
      }
      if (Retcode != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Retcode);
      }
      if (IDADCHBEIBB != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(IDADCHBEIBB);
      }
      if (EventId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(EventId);
      }
      if (BENEDDBBLAB != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(BENEDDBBLAB);
      }
      if (BKMIAPLJPFL != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(BKMIAPLJPFL);
      }
      if (MABKKLCEGCE != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(MABKKLCEGCE);
      }
      if (FFEODLHDKHI != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(FFEODLHDKHI);
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
      if (EventId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EventId);
      }
      if (FFEODLHDKHI != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FFEODLHDKHI);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (BKMIAPLJPFL != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BKMIAPLJPFL);
      }
      if (IDADCHBEIBB != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(IDADCHBEIBB);
      }
      if (BENEDDBBLAB != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BENEDDBBLAB);
      }
      if (KJDNGPCCIHI != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KJDNGPCCIHI);
      }
      if (MABKKLCEGCE != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MABKKLCEGCE);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AlleyPlacingGameScRsp other) {
      if (other == null) {
        return;
      }
      if (other.EventId != 0) {
        EventId = other.EventId;
      }
      if (other.FFEODLHDKHI != 0) {
        FFEODLHDKHI = other.FFEODLHDKHI;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.BKMIAPLJPFL != 0) {
        BKMIAPLJPFL = other.BKMIAPLJPFL;
      }
      if (other.IDADCHBEIBB != 0) {
        IDADCHBEIBB = other.IDADCHBEIBB;
      }
      if (other.BENEDDBBLAB != 0) {
        BENEDDBBLAB = other.BENEDDBBLAB;
      }
      if (other.KJDNGPCCIHI != 0) {
        KJDNGPCCIHI = other.KJDNGPCCIHI;
      }
      if (other.MABKKLCEGCE != 0) {
        MABKKLCEGCE = other.MABKKLCEGCE;
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
            KJDNGPCCIHI = input.ReadUInt32();
            break;
          }
          case 32: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 40: {
            IDADCHBEIBB = input.ReadUInt32();
            break;
          }
          case 72: {
            EventId = input.ReadUInt32();
            break;
          }
          case 80: {
            BENEDDBBLAB = input.ReadUInt32();
            break;
          }
          case 104: {
            BKMIAPLJPFL = input.ReadUInt32();
            break;
          }
          case 112: {
            MABKKLCEGCE = input.ReadUInt32();
            break;
          }
          case 120: {
            FFEODLHDKHI = input.ReadUInt32();
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
            KJDNGPCCIHI = input.ReadUInt32();
            break;
          }
          case 32: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 40: {
            IDADCHBEIBB = input.ReadUInt32();
            break;
          }
          case 72: {
            EventId = input.ReadUInt32();
            break;
          }
          case 80: {
            BENEDDBBLAB = input.ReadUInt32();
            break;
          }
          case 104: {
            BKMIAPLJPFL = input.ReadUInt32();
            break;
          }
          case 112: {
            MABKKLCEGCE = input.ReadUInt32();
            break;
          }
          case 120: {
            FFEODLHDKHI = input.ReadUInt32();
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