#if USE_ILRT && USE_PDB
// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Runtime.InteropServices;

namespace Microsoft.Cci.Pdb {
  /// <summary />
  internal class PdbConstant {
    internal string name;
    internal uint token;
    internal object value;

    internal PdbConstant(string name, uint token, object value) {
      this.name = name;
      this.token = token;
      this.value = value;
    }

    internal PdbConstant(BitAccess bits) {
      bits.ReadUInt32(out this.token);
      byte tag1;
      bits.ReadUInt8(out tag1);
      byte tag2;
      bits.ReadUInt8(out tag2);
      if (tag2 == 0) {
        this.value = tag1;
      } else if (tag2 == 0x80) {
        switch (tag1) {
          case 0x00: //sbyte
            sbyte sb;
            bits.ReadInt8(out sb);
            this.value = sb;
            break;
          case 0x01: //short
            short s;
            bits.ReadInt16(out s);
            this.value = s;
            break;
          case 0x02: //ushort
            ushort us;
            bits.ReadUInt16(out us);
            this.value = us;
            break;
          case 0x03: //int
            int i;
            bits.ReadInt32(out i);
            this.value = i;
            break;
          case 0x04: //uint
            uint ui;
            bits.ReadUInt32(out ui);
            this.value = ui;
            break;
          case 0x05: //float
            this.value = bits.ReadFloat();
            break;
          case 0x06: //double
            this.value = bits.ReadDouble();
            break;
          case 0x09: //long
            long sl;
            bits.ReadInt64(out sl);
            this.value = sl;
            break;
          case 0x0a: //ulong
            ulong ul;
            bits.ReadUInt64(out ul);
            this.value = ul;
            break;
          case 0x10: //string
            string str;
            bits.ReadBString(out str);
            this.value = str;
            break;
          case 0x19: //decimal
            this.value = bits.ReadDecimal();
            break;
          default:
            //TODO: error
            break; 
        }
      } else {
        //TODO: error
      }
      bits.ReadCString(out name);
    }
  }
}

#endif