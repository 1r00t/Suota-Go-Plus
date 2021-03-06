﻿using suota_pgp.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace suota_pgp.Services
{
    public interface IFileManager
    {
        byte Crc { get; }

        int FileSize { get; }

        int NumOfBlocks { get; }

        byte[] Patch { get; }

        byte[] Header { get; }

        List<byte[]> GetChunks(int blockIndex);

        List<byte[]> GetHeaderChunks();

        Task<List<PatchFile>> GetFirmwareFileNames();

        void LoadFirmware(string fileName);
        
        void Save(GoPlus device);
    }
}
