#if USE_ILRT && USE_PDB
// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace Microsoft.Cci.Pdb {
  internal struct DbiSecCon {
    internal DbiSecCon(BitAccess bits) {
      bits.ReadInt16(out section);
      bits.ReadInt16(out pad1);
      bits.ReadInt32(out offset);
      bits.ReadInt32(out size);
      bits.ReadUInt32(out flags);
      bits.ReadInt16(out module);
      bits.ReadInt16(out pad2);
      bits.ReadUInt32(out dataCrc);
      bits.ReadUInt32(out relocCrc);
      //if (pad1 != 0 || pad2 != 0) {
      //  throw new PdbException("Invalid DBI section. "+
      //                                 "(pad1={0}, pad2={1})",
      //                         pad1, pad2);
      //}
    }

    internal short section;                    // 0..1
    internal short pad1;                       // 2..3
    internal int offset;                     // 4..7
    internal int size;                       // 8..11
    internal uint flags;                      // 12..15
    internal short module;                     // 16..17
    internal short pad2;                       // 18..19
    internal uint dataCrc;                    // 20..23
    internal uint relocCrc;                   // 24..27
  }
}

#endif