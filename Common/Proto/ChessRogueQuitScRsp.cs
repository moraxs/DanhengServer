// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChessRogueQuitScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ChessRogueQuitScRsp.proto</summary>
  public static partial class ChessRogueQuitScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for ChessRogueQuitScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChessRogueQuitScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlDaGVzc1JvZ3VlUXVpdFNjUnNwLnByb3RvGhFBSUtBS0FBTURPTi5wcm90",
            "bxoRQVBDS09CS0RHRkcucHJvdG8aEUNOSEdKRExBRUhMLnByb3RvGhFBTk5O",
            "Sk9MTkRIRS5wcm90bxoRSUdES09MTkFGS1AucHJvdG8aEUVFUEdITEZOREtK",
            "LnByb3RvGhFKUERIT05QSUNJRC5wcm90bxoRS09HSkpNQkVEREUucHJvdG8i",
            "wgIKE0NoZXNzUm9ndWVRdWl0U2NSc3ASJAoOcm9ndWVfZ2V0X2luZm8YDiAB",
            "KAsyDC5JR0RLT0xOQUZLUBIlCg9yb2d1ZV9nYW1lX2luZm8YCyABKAsyDC5B",
            "Tk5OSk9MTkRIRRIaCgRpbmZvGAcgASgLMgwuRUVQR0hMRk5ES0oSIQoLQU5O",
            "TkJISkRNUE0YBSABKAsyDC5KUERIT05QSUNJRBIhCgtBRkRLUEZMQkZKSRgM",
            "IAEoCzIMLkFJS0FLQUFNRE9OEiUKD3JvZ3VlX2Flb25faW5mbxgGIAEoCzIM",
            "LkFQQ0tPQktER0ZHEg8KB3JldGNvZGUYCiABKA0SIQoLQ0dFQktPRkJLSk8Y",
            "DSABKAsyDC5LT0dKSk1CRURERRIhCgtQQkhPSk5MS0tPTBgDIAEoCzIMLkNO",
            "SEdKRExBRUhMQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.AIKAKAAMDONReflection.Descriptor, global::EggLink.DanhengServer.Proto.APCKOBKDGFGReflection.Descriptor, global::EggLink.DanhengServer.Proto.CNHGJDLAEHLReflection.Descriptor, global::EggLink.DanhengServer.Proto.ANNNJOLNDHEReflection.Descriptor, global::EggLink.DanhengServer.Proto.IGDKOLNAFKPReflection.Descriptor, global::EggLink.DanhengServer.Proto.EEPGHLFNDKJReflection.Descriptor, global::EggLink.DanhengServer.Proto.JPDHONPICIDReflection.Descriptor, global::EggLink.DanhengServer.Proto.KOGJJMBEDDEReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ChessRogueQuitScRsp), global::EggLink.DanhengServer.Proto.ChessRogueQuitScRsp.Parser, new[]{ "RogueGetInfo", "RogueGameInfo", "Info", "ANNNBHJDMPM", "AFDKPFLBFJI", "RogueAeonInfo", "Retcode", "CGEBKOFBKJO", "PBHOJNLKKOL" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ChessRogueQuitScRsp : pb::IMessage<ChessRogueQuitScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChessRogueQuitScRsp> _parser = new pb::MessageParser<ChessRogueQuitScRsp>(() => new ChessRogueQuitScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChessRogueQuitScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ChessRogueQuitScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueQuitScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueQuitScRsp(ChessRogueQuitScRsp other) : this() {
      rogueGetInfo_ = other.rogueGetInfo_ != null ? other.rogueGetInfo_.Clone() : null;
      rogueGameInfo_ = other.rogueGameInfo_ != null ? other.rogueGameInfo_.Clone() : null;
      info_ = other.info_ != null ? other.info_.Clone() : null;
      aNNNBHJDMPM_ = other.aNNNBHJDMPM_ != null ? other.aNNNBHJDMPM_.Clone() : null;
      aFDKPFLBFJI_ = other.aFDKPFLBFJI_ != null ? other.aFDKPFLBFJI_.Clone() : null;
      rogueAeonInfo_ = other.rogueAeonInfo_ != null ? other.rogueAeonInfo_.Clone() : null;
      retcode_ = other.retcode_;
      cGEBKOFBKJO_ = other.cGEBKOFBKJO_ != null ? other.cGEBKOFBKJO_.Clone() : null;
      pBHOJNLKKOL_ = other.pBHOJNLKKOL_ != null ? other.pBHOJNLKKOL_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueQuitScRsp Clone() {
      return new ChessRogueQuitScRsp(this);
    }

    /// <summary>Field number for the "rogue_get_info" field.</summary>
    public const int RogueGetInfoFieldNumber = 14;
    private global::EggLink.DanhengServer.Proto.IGDKOLNAFKP rogueGetInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.IGDKOLNAFKP RogueGetInfo {
      get { return rogueGetInfo_; }
      set {
        rogueGetInfo_ = value;
      }
    }

    /// <summary>Field number for the "rogue_game_info" field.</summary>
    public const int RogueGameInfoFieldNumber = 11;
    private global::EggLink.DanhengServer.Proto.ANNNJOLNDHE rogueGameInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ANNNJOLNDHE RogueGameInfo {
      get { return rogueGameInfo_; }
      set {
        rogueGameInfo_ = value;
      }
    }

    /// <summary>Field number for the "info" field.</summary>
    public const int InfoFieldNumber = 7;
    private global::EggLink.DanhengServer.Proto.EEPGHLFNDKJ info_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.EEPGHLFNDKJ Info {
      get { return info_; }
      set {
        info_ = value;
      }
    }

    /// <summary>Field number for the "ANNNBHJDMPM" field.</summary>
    public const int ANNNBHJDMPMFieldNumber = 5;
    private global::EggLink.DanhengServer.Proto.JPDHONPICID aNNNBHJDMPM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.JPDHONPICID ANNNBHJDMPM {
      get { return aNNNBHJDMPM_; }
      set {
        aNNNBHJDMPM_ = value;
      }
    }

    /// <summary>Field number for the "AFDKPFLBFJI" field.</summary>
    public const int AFDKPFLBFJIFieldNumber = 12;
    private global::EggLink.DanhengServer.Proto.AIKAKAAMDON aFDKPFLBFJI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.AIKAKAAMDON AFDKPFLBFJI {
      get { return aFDKPFLBFJI_; }
      set {
        aFDKPFLBFJI_ = value;
      }
    }

    /// <summary>Field number for the "rogue_aeon_info" field.</summary>
    public const int RogueAeonInfoFieldNumber = 6;
    private global::EggLink.DanhengServer.Proto.APCKOBKDGFG rogueAeonInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.APCKOBKDGFG RogueAeonInfo {
      get { return rogueAeonInfo_; }
      set {
        rogueAeonInfo_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 10;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "CGEBKOFBKJO" field.</summary>
    public const int CGEBKOFBKJOFieldNumber = 13;
    private global::EggLink.DanhengServer.Proto.KOGJJMBEDDE cGEBKOFBKJO_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.KOGJJMBEDDE CGEBKOFBKJO {
      get { return cGEBKOFBKJO_; }
      set {
        cGEBKOFBKJO_ = value;
      }
    }

    /// <summary>Field number for the "PBHOJNLKKOL" field.</summary>
    public const int PBHOJNLKKOLFieldNumber = 3;
    private global::EggLink.DanhengServer.Proto.CNHGJDLAEHL pBHOJNLKKOL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.CNHGJDLAEHL PBHOJNLKKOL {
      get { return pBHOJNLKKOL_; }
      set {
        pBHOJNLKKOL_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChessRogueQuitScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChessRogueQuitScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(RogueGetInfo, other.RogueGetInfo)) return false;
      if (!object.Equals(RogueGameInfo, other.RogueGameInfo)) return false;
      if (!object.Equals(Info, other.Info)) return false;
      if (!object.Equals(ANNNBHJDMPM, other.ANNNBHJDMPM)) return false;
      if (!object.Equals(AFDKPFLBFJI, other.AFDKPFLBFJI)) return false;
      if (!object.Equals(RogueAeonInfo, other.RogueAeonInfo)) return false;
      if (Retcode != other.Retcode) return false;
      if (!object.Equals(CGEBKOFBKJO, other.CGEBKOFBKJO)) return false;
      if (!object.Equals(PBHOJNLKKOL, other.PBHOJNLKKOL)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (rogueGetInfo_ != null) hash ^= RogueGetInfo.GetHashCode();
      if (rogueGameInfo_ != null) hash ^= RogueGameInfo.GetHashCode();
      if (info_ != null) hash ^= Info.GetHashCode();
      if (aNNNBHJDMPM_ != null) hash ^= ANNNBHJDMPM.GetHashCode();
      if (aFDKPFLBFJI_ != null) hash ^= AFDKPFLBFJI.GetHashCode();
      if (rogueAeonInfo_ != null) hash ^= RogueAeonInfo.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (cGEBKOFBKJO_ != null) hash ^= CGEBKOFBKJO.GetHashCode();
      if (pBHOJNLKKOL_ != null) hash ^= PBHOJNLKKOL.GetHashCode();
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
      if (pBHOJNLKKOL_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(PBHOJNLKKOL);
      }
      if (aNNNBHJDMPM_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(ANNNBHJDMPM);
      }
      if (rogueAeonInfo_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(RogueAeonInfo);
      }
      if (info_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(Info);
      }
      if (Retcode != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Retcode);
      }
      if (rogueGameInfo_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(RogueGameInfo);
      }
      if (aFDKPFLBFJI_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(AFDKPFLBFJI);
      }
      if (cGEBKOFBKJO_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(CGEBKOFBKJO);
      }
      if (rogueGetInfo_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(RogueGetInfo);
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
      if (pBHOJNLKKOL_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(PBHOJNLKKOL);
      }
      if (aNNNBHJDMPM_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(ANNNBHJDMPM);
      }
      if (rogueAeonInfo_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(RogueAeonInfo);
      }
      if (info_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(Info);
      }
      if (Retcode != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Retcode);
      }
      if (rogueGameInfo_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(RogueGameInfo);
      }
      if (aFDKPFLBFJI_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(AFDKPFLBFJI);
      }
      if (cGEBKOFBKJO_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(CGEBKOFBKJO);
      }
      if (rogueGetInfo_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(RogueGetInfo);
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
      if (rogueGetInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueGetInfo);
      }
      if (rogueGameInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueGameInfo);
      }
      if (info_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Info);
      }
      if (aNNNBHJDMPM_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ANNNBHJDMPM);
      }
      if (aFDKPFLBFJI_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AFDKPFLBFJI);
      }
      if (rogueAeonInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueAeonInfo);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (cGEBKOFBKJO_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CGEBKOFBKJO);
      }
      if (pBHOJNLKKOL_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PBHOJNLKKOL);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChessRogueQuitScRsp other) {
      if (other == null) {
        return;
      }
      if (other.rogueGetInfo_ != null) {
        if (rogueGetInfo_ == null) {
          RogueGetInfo = new global::EggLink.DanhengServer.Proto.IGDKOLNAFKP();
        }
        RogueGetInfo.MergeFrom(other.RogueGetInfo);
      }
      if (other.rogueGameInfo_ != null) {
        if (rogueGameInfo_ == null) {
          RogueGameInfo = new global::EggLink.DanhengServer.Proto.ANNNJOLNDHE();
        }
        RogueGameInfo.MergeFrom(other.RogueGameInfo);
      }
      if (other.info_ != null) {
        if (info_ == null) {
          Info = new global::EggLink.DanhengServer.Proto.EEPGHLFNDKJ();
        }
        Info.MergeFrom(other.Info);
      }
      if (other.aNNNBHJDMPM_ != null) {
        if (aNNNBHJDMPM_ == null) {
          ANNNBHJDMPM = new global::EggLink.DanhengServer.Proto.JPDHONPICID();
        }
        ANNNBHJDMPM.MergeFrom(other.ANNNBHJDMPM);
      }
      if (other.aFDKPFLBFJI_ != null) {
        if (aFDKPFLBFJI_ == null) {
          AFDKPFLBFJI = new global::EggLink.DanhengServer.Proto.AIKAKAAMDON();
        }
        AFDKPFLBFJI.MergeFrom(other.AFDKPFLBFJI);
      }
      if (other.rogueAeonInfo_ != null) {
        if (rogueAeonInfo_ == null) {
          RogueAeonInfo = new global::EggLink.DanhengServer.Proto.APCKOBKDGFG();
        }
        RogueAeonInfo.MergeFrom(other.RogueAeonInfo);
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.cGEBKOFBKJO_ != null) {
        if (cGEBKOFBKJO_ == null) {
          CGEBKOFBKJO = new global::EggLink.DanhengServer.Proto.KOGJJMBEDDE();
        }
        CGEBKOFBKJO.MergeFrom(other.CGEBKOFBKJO);
      }
      if (other.pBHOJNLKKOL_ != null) {
        if (pBHOJNLKKOL_ == null) {
          PBHOJNLKKOL = new global::EggLink.DanhengServer.Proto.CNHGJDLAEHL();
        }
        PBHOJNLKKOL.MergeFrom(other.PBHOJNLKKOL);
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
          case 26: {
            if (pBHOJNLKKOL_ == null) {
              PBHOJNLKKOL = new global::EggLink.DanhengServer.Proto.CNHGJDLAEHL();
            }
            input.ReadMessage(PBHOJNLKKOL);
            break;
          }
          case 42: {
            if (aNNNBHJDMPM_ == null) {
              ANNNBHJDMPM = new global::EggLink.DanhengServer.Proto.JPDHONPICID();
            }
            input.ReadMessage(ANNNBHJDMPM);
            break;
          }
          case 50: {
            if (rogueAeonInfo_ == null) {
              RogueAeonInfo = new global::EggLink.DanhengServer.Proto.APCKOBKDGFG();
            }
            input.ReadMessage(RogueAeonInfo);
            break;
          }
          case 58: {
            if (info_ == null) {
              Info = new global::EggLink.DanhengServer.Proto.EEPGHLFNDKJ();
            }
            input.ReadMessage(Info);
            break;
          }
          case 80: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 90: {
            if (rogueGameInfo_ == null) {
              RogueGameInfo = new global::EggLink.DanhengServer.Proto.ANNNJOLNDHE();
            }
            input.ReadMessage(RogueGameInfo);
            break;
          }
          case 98: {
            if (aFDKPFLBFJI_ == null) {
              AFDKPFLBFJI = new global::EggLink.DanhengServer.Proto.AIKAKAAMDON();
            }
            input.ReadMessage(AFDKPFLBFJI);
            break;
          }
          case 106: {
            if (cGEBKOFBKJO_ == null) {
              CGEBKOFBKJO = new global::EggLink.DanhengServer.Proto.KOGJJMBEDDE();
            }
            input.ReadMessage(CGEBKOFBKJO);
            break;
          }
          case 114: {
            if (rogueGetInfo_ == null) {
              RogueGetInfo = new global::EggLink.DanhengServer.Proto.IGDKOLNAFKP();
            }
            input.ReadMessage(RogueGetInfo);
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
          case 26: {
            if (pBHOJNLKKOL_ == null) {
              PBHOJNLKKOL = new global::EggLink.DanhengServer.Proto.CNHGJDLAEHL();
            }
            input.ReadMessage(PBHOJNLKKOL);
            break;
          }
          case 42: {
            if (aNNNBHJDMPM_ == null) {
              ANNNBHJDMPM = new global::EggLink.DanhengServer.Proto.JPDHONPICID();
            }
            input.ReadMessage(ANNNBHJDMPM);
            break;
          }
          case 50: {
            if (rogueAeonInfo_ == null) {
              RogueAeonInfo = new global::EggLink.DanhengServer.Proto.APCKOBKDGFG();
            }
            input.ReadMessage(RogueAeonInfo);
            break;
          }
          case 58: {
            if (info_ == null) {
              Info = new global::EggLink.DanhengServer.Proto.EEPGHLFNDKJ();
            }
            input.ReadMessage(Info);
            break;
          }
          case 80: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 90: {
            if (rogueGameInfo_ == null) {
              RogueGameInfo = new global::EggLink.DanhengServer.Proto.ANNNJOLNDHE();
            }
            input.ReadMessage(RogueGameInfo);
            break;
          }
          case 98: {
            if (aFDKPFLBFJI_ == null) {
              AFDKPFLBFJI = new global::EggLink.DanhengServer.Proto.AIKAKAAMDON();
            }
            input.ReadMessage(AFDKPFLBFJI);
            break;
          }
          case 106: {
            if (cGEBKOFBKJO_ == null) {
              CGEBKOFBKJO = new global::EggLink.DanhengServer.Proto.KOGJJMBEDDE();
            }
            input.ReadMessage(CGEBKOFBKJO);
            break;
          }
          case 114: {
            if (rogueGetInfo_ == null) {
              RogueGetInfo = new global::EggLink.DanhengServer.Proto.IGDKOLNAFKP();
            }
            input.ReadMessage(RogueGetInfo);
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
