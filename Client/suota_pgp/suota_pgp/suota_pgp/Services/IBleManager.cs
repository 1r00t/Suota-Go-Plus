﻿using suota_pgp.Model;

namespace suota_pgp.Services
{
    public interface IBleManager
    {
        KeyBlobPair GetKeyBlob();
    }
}